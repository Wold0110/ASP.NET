using Microsoft.AspNetCore.Mvc;
using Vegyes.Models;

namespace Vegyes.Controllers
{
    public class DiagController : Controller
    {
        public IActionResult Index()
        {
            KategoriaModel km = new();
            return View(km);
        }

        [HttpPost]
        public IActionResult Kirajzol()
        {
            string kat = Request.Form["kategoriak"];
            Adatok data = new();
            Dictionary<string, int> koltesek = new Dictionary<string, int>();
            foreach(Kiadasok x in data.Kiadasoks.Where(x => x.Mire.TrimEnd() == kat))
            {
                if (koltesek.ContainsKey(x.Ki)) koltesek[x.Ki] += int.Parse(x.Mennyit);
                else koltesek.Add(x.Ki, int.Parse(x.Mennyit));
            }
            return View(koltesek);
        }
    }
}
