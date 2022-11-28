using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Pokedex.Services;
using System.Diagnostics;

namespace Pokedex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Pokemon> pokeList = new List<Pokemon>();
        private readonly string apiEndPoint = "http://localhost:5066/pokemon/getallpokemons";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            pokeList = PokemonReader.ReadPokemonFromURL(apiEndPoint);
        }

        public IActionResult Index()
        {
            return View(pokeList);
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