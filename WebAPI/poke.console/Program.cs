using poke.data;
using poke.data.model;

CSVreader reader = new();
List<PokemonData> pokemons = reader.ParseCSV("C:\\Users\\SESA646228\\source\\repos\\WebAPI\\poke.data\\data\\pokedex.csv");

Console.WriteLine(pokemons.Count+" db van");