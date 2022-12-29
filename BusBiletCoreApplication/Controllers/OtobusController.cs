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
    }
}
