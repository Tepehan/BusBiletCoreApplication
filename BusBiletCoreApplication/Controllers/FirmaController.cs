using BusBiletCoreApplication.PagedList;
using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace BusBiletCoreApplication.Controllers
{
    
    public class FirmaController : Controller
    {
        FirmaManager fm = new FirmaManager(new EfFirmaRepository());
        
        public IActionResult Index(int page = 1,string searchText="")
        {

            TempData["page"] = page;
            int pageSize = 2;
            Context c = new Context();
            Pager pager;
            List<Firma> data;
            var itemCounts=0;
            if (searchText != "" && searchText != null)
            {

                data = c.firmalar.Where(firma => firma.firmaAd.Contains(searchText)).Skip(( - 1) * pageSize).Take(pageSize).ToList();
                itemCounts = c.firmalar.Where(firma => firma.firmaAd.Contains(searchText)).ToList().Count;
            }
            else {
                 data = c.firmalar.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                itemCounts = c.firmalar.ToList().Count;
            }
            //var firmalar = fm.firmaListele().ToPagedList(page, pageSize);
            
             pager= new Pager(pageSize,itemCounts,page);
           
            ViewBag.pager=pager; 
            ViewBag.actionName = "Index";
            ViewBag.contrName = "Firma";
            ViewBag.searchText = searchText;
            return View(data);

        }
       
        [HttpGet]
        public IActionResult Ekle() {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Firma firma)
        {
           FirmaValidator firmaValidator= new FirmaValidator(); 
            var result = firmaValidator.Validate(firma);
            if (result.IsValid)
            {
                fm.firmaEkle(firma);
                return RedirectToAction("Index");
               
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
          
        }
        public JsonResult deneme(int id)
        {
            Firma firma = fm.firmaGetirById(id);
           var jsonRes=JsonConvert.SerializeObject(firma);
            return Json(jsonRes);
        }
        public IActionResult sil(int id)
        {
            Firma firma=fm.firmaGetirById(id);
            firma.silindi = true;
            fm.firmaGuncelle(firma);
            int page = (int)TempData["page"];
            return RedirectToAction("Index", new { page, searchText = "" });
        }
        public IActionResult guncelle(int id)
        {
            Firma firma = fm.firmaGetirById(id);
         
            return View(firma);
        }
        [HttpPost]
        public IActionResult guncelle(Firma firma)
        {
            FirmaValidator firmaValidator = new FirmaValidator();
            var result = firmaValidator.Validate(firma);
            if (result.IsValid)
            {
                fm.firmaGuncelle(firma);
                int page = (int)TempData["page"];
                return RedirectToAction("Index", new { page, searchText = "" });

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }
    }
}
