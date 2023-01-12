using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.Controllers
{
    public class SliderController : Controller
    {
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
            sm.sliderGuncelle(slider);
            return RedirectToAction("Index");
        }
      
        // public async Task<IActionResult>  FileUpload(IFormFile formFile)
        //{
        //    if (formFile!=null)
        //    {
        //        var extent = Path.GetExtension(formFile.FileName);
        //        var randomName = ($"{Guid.NewGuid()}{extent}");
        //        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);
                
        //        using(var stream=new FileStream(path, FileMode.Create))
        //        {
        //            await formFile.CopyToAsync(stream);
        //        }
        //    }
        //    return View();
        //}
    }
}
