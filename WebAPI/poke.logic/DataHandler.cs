using poke.data;
using poke.data.model;

namespace poke.logic
{
    public class DataHandler
    {
        private List<PokemonData> pokemons;

        public List<PokemonData> GetAllPokemons()
        {
            CSVreader r = new();
            return r.ParseCSV("C:\\Users\\SESA646228\\source\\repos\\WebAPI\\poke.data\\data\\pokedex.csv");
        }

    }
}