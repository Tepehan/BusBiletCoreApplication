using BusBiletCoreApplication.Models;
using BusinessLayer;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace BusBiletCoreApplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        Context c;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            c = new Context();
        }
       
        public IActionResult Index()
        {
            var menus = c.menuler.ToList();
            var mappedTree=mapListToTreview(menus);
            MenuSliderModel msmodel=new MenuSliderModel();
            SliderManager sm = new SliderManager(new EfSliderRepository());
            msmodel.menuModel= mappedTree;
            msmodel.sliderModel = sm.SliderListele();
            return View(msmodel);
         
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = 
            ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel 
            { 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            });
        }
        public IActionResult deneme()
        {
            return View();
        }
        private List<Menu> mapListToTreview(List<Menu> menus)
        { //Menü listesi dönen bir fonksiyon oluşturdum. Parametre olarak menü listesi yollanıyor.
            var altMenuler = new List<Menu>(); // alt menüler için bir menü liste oluşturdum.
            foreach (var menu in menus)
            { //parametre olarak alınan menü listesini foreach ile döndürüyorum.
                altMenuler.Add(new Menu
                { //dönülen listeyi oluşturdugum alt listeye ekledim.
                    menuId = menu.menuId,
                    parentId = menu.parentId,
                    name = menu.name,
                    children = menu.children.Count > 0 ? mapListToTreview(menu.children.ToList()) // childleri varsa tekrardan recursive ediyor. Fonksiyon tekrardan çalışıyor. Yoksada boş liste dönüyor.
                        : new List<Menu>()
                });
            }
            return altMenuler;
        }
      
    }
   
}
