using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
using BusinessLayer.Validaitons;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class GuzergahOtobusController : Controller
    {
        GuzergahOtobusManager controller = new GuzergahOtobusManager(new EfGuzergahOtobusRepository());
        GuzergahOtobusValidator validator;
        public IActionResult Index()
        {
            var guzergahOtobusler = controller.guzergahOtobusListele();
            return View(guzergahOtobusler);
        }

        public ActionResult Sil(int id)
        {
            GuzergahOtobus guzergahOtobus = controller.guzergahOtobusGetById(id);
            guzergahOtobus.guzergahOtobusSilindi = true;
            controller.guzergahOtobusGuncelle(guzergahOtobus);
            return RedirectToAction("listele");
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(GuzergahOtobus guzergahOtobus)
        {
            validator = new GuzergahOtobusValidator();
            var result = validator.Validate(guzergahOtobus);

            if (result.IsValid)
            {
                controller.guzergahOtobusEkle(guzergahOtobus);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            GuzergahOtobus guzergahOtobus = controller.guzergahOtobusGetById(id);
            return View(guzergahOtobus);
        }

        [HttpPost]
        public IActionResult Guncelle(GuzergahOtobus guzergahOtobus)
        {
            controller.guzergahOtobusGuncelle(guzergahOtobus);
            return RedirectToAction("Index");
        }

    }
}

