using BusinessLayer;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class FirmaController : Controller
    {
        FirmaManager fm = new FirmaManager(new EfFirmaRepository());
        public IActionResult Index()
        {
            var firmalar = fm.firmaListele();
            return View(firmalar);
        }
        [HttpGet]
        public IActionResult Ekle() {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Firma firma)
        {
            fm.firmaEkle(firma);
            return RedirectToAction("Index");
        }
    
        public IActionResult sil(int id)
        {
            Firma firma=fm.firmaGetirById(id);
            firma.silindi = true;
            fm.firmaGuncelle(firma);
            return RedirectToAction("Index");
        }
        public IActionResult guncelle(int id)
        {
            Firma firma = fm.firmaGetirById(id);
         
            return View(firma);
        }
        [HttpPost]
        public IActionResult guncelle(Firma firma)
        {
            fm.firmaGuncelle(firma);
            return RedirectToAction("Index");
        }
    }
}
