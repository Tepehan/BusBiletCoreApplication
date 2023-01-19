using BusBiletCoreApplication.PagedList;
using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using X.PagedList;

namespace BusBiletCoreApplication.Controllers
{
    
    public class FirmaController : Controller
    {
        FirmaManager fm = new FirmaManager(new EfFirmaRepository());
        
        public IActionResult Index(int page = 1)
        {
            int pageSize = 2;
            Context c = new Context();
            Pager pager;
            
            //var firmalar = fm.firmaListele().ToPagedList(page, pageSize);
            var itemCounts = c.firmalar.ToList().Count;
             pager= new Pager(pageSize,itemCounts,page);
            var data = c.firmalar.Skip((page - 1) * pageSize).Take(pageSize).ToList() ;
            ViewBag.pager=pager; 
            ViewBag.actionName = "Index";
            ViewBag.contrName = "Firma";
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
    
        public IActionResult sil(int id)
        {
            Firma firma=fm.firmaGetirById(id);
            firma.silindi = true;
            fm.firmaGuncelle(firma);
            return RedirectToAction("Index");
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
    }
}
