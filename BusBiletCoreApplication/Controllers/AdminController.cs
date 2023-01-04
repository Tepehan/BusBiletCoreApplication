using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using System.Linq;

namespace BusBiletCoreApplication.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IToastNotification _toastNotification;

        public AdminController(ILogger<AdminController> logger, IToastNotification toastNotification)
        {
            _logger = logger;
            _toastNotification = toastNotification;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Giris(Admin admin)
        {
            Context c=new Context();
            var result= c.adminler.Where(x=>x.adminEmail==admin.adminEmail&&x.adminPassword==admin.adminPassword).SingleOrDefault();
            if (result!=null) {
               
                return RedirectToAction("Index","Firma");
            }
            _toastNotification.AddErrorToastMessage("Kullanıcı adı veya password hatalı");
            TempData["init"] = 1;
            return RedirectToAction("Index");
        }
    }
}
