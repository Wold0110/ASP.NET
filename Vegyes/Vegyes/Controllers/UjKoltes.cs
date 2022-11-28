using Microsoft.AspNetCore.Mvc;
using Vegyes.Models;

namespace Vegyes.Controllers
{
    public class UjKoltes : Controller
    {
        public IActionResult Index()
        {
            KategoriaModel km = new();
            return View(km);
        }
        public IActionResult Feltoltes()
        {
            string mennyit = Request.Form["osszeg"];
            string ki = Request.Form["ki"];
            string kat = Request.Form["kategoriak"];
            Adatok data = new();
            Kiadasok k = new();
            k.Ki = ki;
            k.Mire = kat;
            k.Mennyit = mennyit;
            data.Kiadasoks.Add(k);
            data.SaveChanges();

            return View();
        }
    }
}
