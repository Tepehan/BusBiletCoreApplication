using BusBiletCoreApplication.Models;
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
        FirmaManager fm=new FirmaManager(new EfFirmaRepository());
		public IActionResult Index()
		{
			var otobusler = om.otobusListele();
			return View(otobusler);
		}
        [HttpGet]
        public IActionResult Ekle()
        {
            OtobusFirmaModel model= new OtobusFirmaModel();
            model.firmaModal = fm.firmaListele();
            return View(model);
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
			OtobusFirmaModel model = new OtobusFirmaModel();
			model.firmaModal = fm.firmaListele();
            model.otobusModal = om.otobusGetirById(id);
			return View(model);
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
