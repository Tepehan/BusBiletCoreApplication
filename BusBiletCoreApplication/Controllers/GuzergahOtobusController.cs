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
            GuzergahOtobusValidator guzergahValidator = new GuzergahOtobusValidator();
            var result = guzergahValidator.Validate(guzergahOtobus);
            if (result.IsValid)
            {
                guzergahOtobusManager.guzergahOtobusEkle(guzergahOtobus);
                return RedirectToAction("Index");

            }
            else
            {
                SeferGuzergahModel seferGuzergahModel = new SeferGuzergahModel();
                seferGuzergahModel.guzergahModel = guzergahManager.GuzergahListele();
                seferGuzergahModel.otobusModel = otobusManager.otobusListele();
                seferGuzergahModel.guzergahOtobusModel = new GuzergahOtobus();
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(seferGuzergahModel);
            }              
    
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
            GuzergahOtobusValidator guzergahValidator = new GuzergahOtobusValidator();
            var result = guzergahValidator.Validate(guzergahOtobus);
            if (result.IsValid)
            {
                guzergahOtobusManager.guzergahOtobusGuncelle(guzergahOtobus);
                return RedirectToAction("Index");

            }
            else
            {
                SeferGuzergahModel seferGuzergahModel = new SeferGuzergahModel();
                seferGuzergahModel.guzergahModel = guzergahManager.GuzergahListele();
                seferGuzergahModel.guzergahOtobusModel = guzergahOtobus;
                seferGuzergahModel.otobusModel = otobusManager.otobusListele();
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(seferGuzergahModel);
            }

           
        }

    }
}

