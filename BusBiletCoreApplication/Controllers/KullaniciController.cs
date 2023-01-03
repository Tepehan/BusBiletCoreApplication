using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class KullaniciController : Controller
    {
        KullaniciManager km = new KullaniciManager(new EfKullaniciRepository());

        public IActionResult Index()
        {
            var kullanicilar = km.KullaniciListele();
            return View(kullanicilar);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kullanici kullanici)
        {
            KullaniciValidator kullaniciValidator = new KullaniciValidator();
            var result = kullaniciValidator.Validate(kullanici);
            if (result.IsValid)
            {
                km.KullaniciEkle(kullanici);
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
            Kullanici kullanici = km.KullaniciGetirById(id);
            kullanici.silindi = true;
            km.KullaniciGuncelle(kullanici);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult guncelle(int id)
        {
            Kullanici kullanici = km.KullaniciGetirById(id);

            return View(kullanici);
        }
        [HttpPost]
        public IActionResult guncelle(Kullanici kullanici)
        {
            KullaniciValidator kullaniciValidator = new KullaniciValidator();
            var result = kullaniciValidator.Validate(kullanici);
            if (result.IsValid)
            {
                km.KullaniciGuncelle(kullanici);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(kullanici);
            }
            
        }
    }
}
