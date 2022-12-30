using BusinessLayer;
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
        
    }
}
