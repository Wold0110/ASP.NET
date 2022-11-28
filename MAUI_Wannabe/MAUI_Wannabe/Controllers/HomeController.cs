using MAUI_Wannabe.Data;
using MAUI_Wannabe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MAUI_Wannabe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyDBContext __db_context;
        public HomeController(ILogger<HomeController> logger,MyDBContext myDB)
        {
            _logger = logger;
            __db_context = myDB;
        }

        public IActionResult Index()
        {
            var x = __db_context.players.Select(x => x);
            if(x.Any())
                return View(x);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPlayer(Player p)
        {
            if(p != null)
            {
                __db_context.players.Add(p);
                __db_context.SaveChanges();

                return Ok("Sikeresen regisztráltál!");
            }
            return Ok("Üres felhasználó.");
        }
        [HttpPost]
        public IActionResult DelPlayer(Player p)
        {
            if (p != null)
            {
                __db_context.players.Where(x => (p.email == x.email && p.password == x.password))
                    .ToList().ForEach(x => __db_context.players.Remove(x));
                __db_context.SaveChanges();

                return Ok("Sikeresen törölted");
            }
            return Ok("Sikertelen törölted a felhasználód.");
        }
        public IActionResult NewPW(Player p)
        {
            if (p != null)
            {
                __db_context.players.Where(x => p.email == x.email)
                    .ToList().ForEach(x => x.password = p.password);
                __db_context.SaveChanges();

                return Ok("Sikeresen megváltoztattad");
            }
            return Ok("Nem történt változás");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}