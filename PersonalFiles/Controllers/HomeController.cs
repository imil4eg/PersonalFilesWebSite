using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalFiles.Models;

namespace PersonalFiles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            LoginViewModel model = new LoginViewModel();
            return Redirect("~/Views/Authorization/Login.cshtml");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View("~/Views/Authorization/Login.cshtml");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View("~/Views/Security/Register.cshtml");
        }

        public IActionResult Privacy()
        {
        
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
