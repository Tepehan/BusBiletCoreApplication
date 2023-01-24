using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace BusBiletCoreApplication.Controllers
{
    public class SliderController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public SliderController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        SliderManager sm = new SliderManager(new EfSliderRepository());
        public IActionResult Index()
        {
           
            return View(sm.SliderListele());
        }
        [HttpGet]
        public IActionResult Ekle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Slider slider)
        {
            slider.resimUrl= FileUpload(slider);
            sm.sliderEkle(slider);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult guncelle(int id)
        {  
            return View(sm.sliderGetirById(id));
        }
        [HttpPost]
        public IActionResult guncelle(Slider slider)
        {
           
            slider.resimUrl = FileUpload(slider);
            sm.sliderGuncelle(slider);
            return RedirectToAction("Index");
        }

        private string  FileUpload(Slider slider)
        {
            string uniquefileName = "";
            if (slider.imgFile != null)
            {
                 uniquefileName = Guid.NewGuid().ToString() + "_" + slider.imgFile.FileName;
                string uploadfolder = Path.Combine(webHostEnvironment.WebRootPath,"sliderimages");
                string filePath = Path.Combine(uploadfolder,uniquefileName);
               

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                     slider.imgFile.CopyTo(stream);
                }
            }
            return uniquefileName;
        }
    }
}
