using Microsoft.AspNetCore.Mvc;
using poke.data.model;
using poke.logic;

namespace poke.webapi.Controllers
{
    [ApiController]
    [Route("Pokemon")]
    public class PokemonControler : Controller
    {
        private readonly DataHandler dataHandler;

        [HttpGet]
        [Route("getallpokemons")]
        public IEnumerable<PokemonData> Get()
        {
            return dataHandler.GetAllPokemons();
        }
        [HttpGet]
        [Route("getpokemonbyid/{id}/")]
        public PokemonData GetPokemonById(int id)
        {
            return dataHandler.GetAllPokemons().Where(x => x.Id == id).First();
        }

        public PokemonControler()
        {
            dataHandler = new();
        }
    }
}
