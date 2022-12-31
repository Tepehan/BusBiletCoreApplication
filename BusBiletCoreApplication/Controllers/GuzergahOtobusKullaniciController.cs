using BusinessLayer.Concrete;
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
            return RedirectToAction("Index");
        }
       
    }
}
