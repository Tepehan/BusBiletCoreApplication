using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
   
    public class FirmaController : Controller
    {
        FirmaManager fm = new FirmaManager(new EfFirmaRepository());
    
        public IActionResult Index()
        {
            var firmalar = fm.firmaListele();
            return View(firmalar);
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
