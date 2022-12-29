using BusinessLayer;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class GuzergahOtobusController : Controller
    {
        GuzergahOtobusManager gom = new GuzergahOtobusManager(new EfGuzergahOtobusRepository());
        public IActionResult Index()
        {
            var guzergahOtobusler = gom.guzergahOtobusListele();
            return View(guzergahOtobusler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(GuzergahOtobus guzergahOtobus)
        {
            gom.guzergahOtobusEkle(guzergahOtobus);
            return RedirectToAction("Index");
        }
    }
}
