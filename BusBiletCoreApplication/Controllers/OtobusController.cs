using BusinessLayer;
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
            om.otobusEkle(otobus);
            return RedirectToAction("Index");
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
            om.otobusGuncelle(otobus);
            return RedirectToAction("Index");
        }
    }
}
