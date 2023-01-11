using BusBiletCoreApplication.Models;
using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
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
        GuzergahOtobusManager guzergahOtobusManager = new GuzergahOtobusManager(new EfGuzergahOtobusRepository());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciRepository());
        public IActionResult Index()
        {
            var guzergahOtobusKullaniciler = gokm.BiletListele();
            return View(guzergahOtobusKullaniciler);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            BiletSeferGuzergahKullaniciModel biletSeferGuzergahKullaniciModel = new BiletSeferGuzergahKullaniciModel();
            biletSeferGuzergahKullaniciModel.seferModel = guzergahOtobusManager.guzergahOtobusListele();
            biletSeferGuzergahKullaniciModel.kullaniciModel = kullaniciManager.KullaniciListele();
            biletSeferGuzergahKullaniciModel.biletModel = new GuzergahOtobusKullanici();
            return View(biletSeferGuzergahKullaniciModel);
        }

        [HttpPost]
        public IActionResult Ekle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {

            //gokm.BiletEkle(guzergahOtobusKullanici);
            //return RedirectToAction("index");
            GuzergahOtobusKullaniciValidator gokValidator = new GuzergahOtobusKullaniciValidator();
            var result = gokValidator.Validate(guzergahOtobusKullanici);
            if (result.IsValid)
            {
                gokm.BiletEkle(guzergahOtobusKullanici);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                BiletSeferGuzergahKullaniciModel biletSeferGuzergahKullaniciModel = new BiletSeferGuzergahKullaniciModel();
                biletSeferGuzergahKullaniciModel.seferModel = guzergahOtobusManager.guzergahOtobusListele();
                biletSeferGuzergahKullaniciModel.kullaniciModel = kullaniciManager.KullaniciListele();
                biletSeferGuzergahKullaniciModel.biletModel = guzergahOtobusKullanici;
                return View(biletSeferGuzergahKullaniciModel);
            }
        }
        public IActionResult Sil(int id)
        {
            GuzergahOtobusKullanici guzergahOtobusKullanici = gokm.BiletGetById(id);
            guzergahOtobusKullanici.silindi = true;
            gokm.BiletGuncelle(guzergahOtobusKullanici);
            return RedirectToAction("Index");
        }
        public IActionResult Guncelle(int id)
        {
            GuzergahOtobusKullanici guzergahOtobusKullanici = gokm.BiletGetById(id);
            return View(guzergahOtobusKullanici);
        }
        [HttpPost]
        public IActionResult Guncelle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {

            GuzergahOtobusKullaniciValidator gokValidator = new GuzergahOtobusKullaniciValidator();
            var result = gokValidator.Validate(guzergahOtobusKullanici);
            if (result.IsValid)
            {
                gokm.BiletGuncelle(guzergahOtobusKullanici);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(guzergahOtobusKullanici);
            }

        }
    }
}
