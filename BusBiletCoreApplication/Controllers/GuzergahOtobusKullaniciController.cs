using BusBiletCoreApplication.Validaitons;
using BusinessLayer.Concrete;
using BusinessLayer.Validaitons;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class GuzergahOtobusKullaniciController : Controller
    {
        GuzergahOtobusKullaniciManager gokm = new GuzergahOtobusKullaniciManager(new EfGuzergahOtobusKullaniciRepository());
        public IActionResult Index()
        {
            var guzergahOtobusKullaniciler = gokm.guzergahOtobusKullaniciListele();
            return View(guzergahOtobusKullaniciler);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Ekle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {
            GuzergahOtobusKullaniciValidator gokValidator = new GuzergahOtobusKullaniciValidator();
            var result = gokValidator.Validate(guzergahOtobusKullanici);
            if (result.IsValid)
            {
                gokm.GuzergahOtobusKullaniciEkle(guzergahOtobusKullanici);
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

        public IActionResult Guncelle(int id)
        {
            GuzergahOtobusKullanici guzergahOtobusKullanici = gokm.guzergahOtobusKullaniciGetById(id);
            return View();
        }
        [HttpPost]
        public IActionResult Guncelle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {

            gokm.GuzergahOtobusKullaniciGuncelle(guzergahOtobusKullanici);
            return RedirectToAction("Index");
        }
    }
}
