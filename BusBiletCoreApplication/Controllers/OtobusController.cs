using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
using BusinessLayer.Validaitons;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
	public class OtobusController : Controller
	{
		OtobusManager om = new OtobusManager(new EfOtobusRepository());
		public IActionResult Index()
		{
			var otobusler = om.otobusListele();
			return View(otobusler);
		}
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Otobus otobus)
        {
            OtobusValidator otobusValidator = new OtobusValidator();
            var result = otobusValidator.Validate(otobus);
            if (result.IsValid)
            {
                om.otobusEkle(otobus);
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
            Otobus otobus = om.otobusGetirById(id);
            otobus.otobusSilindi = true;
            om.otobusGuncelle(otobus);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult guncelle(int id)
        {
            Otobus otobus = om.otobusGetirById(id);
            return View(otobus);
        }
        [HttpPost]
        public IActionResult guncelle(Otobus otobus)
        {
            OtobusValidator otobusValidator = new OtobusValidator();
            var result = otobusValidator.Validate(otobus);
            if (result.IsValid)
            {
                om.otobusGuncelle(otobus);
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
