using poke.data.model;
using System.Text;

namespace poke.data
{
    public class CSVreader
    {
        private List<PokemonData> pokemons;

        public CSVreader()
        {
            pokemons = new List<PokemonData>();
        }
        public List<PokemonData> ParseCSV(string pokedexPath)
        {
            pokemons.Clear();
            
            using(StreamReader reader = new StreamReader(pokedexPath, Encoding.Default)){
                string header = reader.ReadLine();

                while(!reader.EndOfStream)
                {
                    string[] lineParts = reader.ReadLine().Split(',');
                    PokemonData p = new PokemonData();

                    int id = 0;
                    int.TryParse(lineParts[0], out id);
                    p.Id = id;

                    p.Name = lineParts[2];
                    p.Image = lineParts[3];
                    p.Type = lineParts[4];
                    p.SubType = lineParts[5];
                    p.Height = lineParts[6];
                    p.Weight = lineParts[7];

                    int nextEv = 0;
                    int.TryParse(lineParts[19], out nextEv);
                    p.NextEvolution = nextEv;

                    pokemons.Add(p);
                }
            }
            return pokemons;
        }
    }
}