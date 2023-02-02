using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BusBiletCoreApplication.ViewComponents
{
    public class SliderComponentView:ViewComponent
    {
        SliderManager SliderManager = new SliderManager(new EfSliderRepository());

        public IViewComponentResult Invoke() {
            var list=SliderManager.SliderListele();
            return View(list);

        }
    }
}
