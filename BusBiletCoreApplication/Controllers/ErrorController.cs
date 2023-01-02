using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Abstractions;
using System.Collections.Generic;

namespace BusBiletCoreApplication.Controllers
{
	[Route("error")]
	public class ErrorController : Controller
	{
        [Route("/Error/HandleError/{code:int}")]
        public IActionResult HandleError(int code)
        {
            ViewData["ErrorMessage"] = $"Error occurred. The ErrorCode is: {code}";
            return View();
        }
    }
}
