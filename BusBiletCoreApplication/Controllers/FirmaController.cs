using BusinessLayer;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class FirmaController : Controller
    { 
        FirmaManager fm=new FirmaManager(new EfFirmaRepository());
        public IActionResult Index()
        {
            var firmalar=fm.firmaListele();
            return View(firmalar);
        }
    }
}
