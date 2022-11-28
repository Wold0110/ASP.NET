using Pokedex.Models;
using System.Text.Json;

namespace Pokedex.Services
{
    public static class PokemonReader
    {
        public static List<Pokemon> ReadPokemonFromURL(string url)
        {
            string apiResponse = new HttpClient().GetStringAsync(url).Result;
            return JsonSerializer.Deserialize<List<Pokemon>>(apiResponse);
        }
    }
}
