using BusinessLayer;
using BusinessLayer.Validaitons;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class GuzergahController : Controller
    {
        GuzergahManager gm = new GuzergahManager(new EfGuzergahRepository());
        public ActionResult Listele()
        {
            var guzergahlar = gm.GuzergahListele();
            return View(guzergahlar);
        }
       public ActionResult Sil(int id)
        {
            Guzergah guzergah=gm.GuzergahGetirById(id);
            guzergah.silindi = true;
            gm.GuzergahGuncelle(guzergah);
            return RedirectToAction("listele");
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Guzergah guzergah)
        {
            GuzergahValidator guzergahValidator = new GuzergahValidator();
            var result = guzergahValidator.Validate(guzergah);
            if (result.IsValid)
            {
                gm.GuzergahEkle(guzergah);
                return RedirectToAction("Listele");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(guzergah);
            }
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            Guzergah guzergah = gm.GuzergahGetirById(id);

            return View(guzergah);
        }
        [HttpPost]
        public IActionResult Guncelle(Guzergah guzergah)
        {
            GuzergahValidator guzergahValidator = new GuzergahValidator();
            var result = guzergahValidator.Validate(guzergah);
            if (result.IsValid)
            {
                gm.GuzergahGuncelle(guzergah);
                return RedirectToAction("Listele");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(guzergah);
            }

           
        }

    }
}
