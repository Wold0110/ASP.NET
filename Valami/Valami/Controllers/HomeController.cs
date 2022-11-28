using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Valami.Models;

namespace Valami.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IActionResult Dolog2()
        {
            string adat = HttpContext.Request.Form["user"];
            return View();
        }

        [HttpGet]
        public IActionResult Dolog3()
        {
            string adat = HttpContext.Request.Query["user"];
            return View();
        }
        
        public IActionResult Dolog(int ID)
        {
            ViewBag.Adat1 = ID;
            ViewBag.Adat2 = "Béla";
            ViewData.Add("Adat3", 333);
            ViewData.Add("Adat4", "Józsi");

            HomeModel model = new();

            return View(model);
        }
        public IActionResult Index()
        {
            return View();
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