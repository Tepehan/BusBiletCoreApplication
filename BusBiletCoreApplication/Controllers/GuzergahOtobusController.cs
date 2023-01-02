using BusBiletCoreApplication.Models;
using BusBiletCoreApplication.Validaitons;
using BusinessLayer;
using BusinessLayer.Validaitons;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BusBiletCoreApplication.Controllers
{
    public class GuzergahOtobusController : Controller
    {
        GuzergahOtobusManager guzergahOtobusManager = new GuzergahOtobusManager(new EfGuzergahOtobusRepository());
        GuzergahManager guzergahManager=new GuzergahManager(new EfGuzergahRepository());
        OtobusManager otobusManager = new OtobusManager(new EfOtobusRepository());
        GuzergahOtobusValidator validator;
        public IActionResult Index()
        {
            var guzergahOtobusler = guzergahOtobusManager.guzergahOtobusListele();
            return View(guzergahOtobusler);
        }

        public IActionResult Sil(int id)
        {
            GuzergahOtobus guzergahOtobus = guzergahOtobusManager.guzergahOtobusGetById(id);
            guzergahOtobus.guzergahOtobusSilindi = true;
            guzergahOtobusManager.guzergahOtobusGuncelle(guzergahOtobus);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            SeferGuzergahModel seferGuzergahModel = new SeferGuzergahModel();
            seferGuzergahModel.guzergahModel = guzergahManager.GuzergahListele();
            seferGuzergahModel.otobusModel = otobusManager.otobusListele();
            seferGuzergahModel.guzergahOtobusModel = new GuzergahOtobus() ;
            return View(seferGuzergahModel);
        }

        [HttpPost]
        public IActionResult Ekle(GuzergahOtobus guzergahOtobus)
        {
            guzergahOtobusManager.guzergahOtobusEkle(guzergahOtobus);
            return RedirectToAction("Index");
            //validator = new GuzergahOtobusValidator();
            //var result = validator.Validate(guzergahOtobus);

            //if (result.IsValid)
            //{

            //}
            //else
            //{
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            //    }

            //    return View();
            //}
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            GuzergahOtobus guzergahOtobus = guzergahOtobusManager.guzergahOtobusGetById(id);
          
            SeferGuzergahModel seferGuzergahModel = new SeferGuzergahModel();
            seferGuzergahModel.guzergahModel = guzergahManager.GuzergahListele();
            seferGuzergahModel.guzergahOtobusModel = guzergahOtobus;
            seferGuzergahModel.otobusModel = otobusManager.otobusListele();
            return View(seferGuzergahModel);
        }

        [HttpPost]
        public IActionResult Guncelle(GuzergahOtobus guzergahOtobus)
        {
           
            guzergahOtobusManager.guzergahOtobusGuncelle(guzergahOtobus);
            return RedirectToAction("Index");
        }

    }
}

