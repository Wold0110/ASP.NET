namespace Pokedex.Models
{
    public class Pokemon
    {
        public int id            { get; set; }
        public string name          { get; set; }
        public string image         { get; set; }
        public string type          { get; set; }
        public string subType       { get; set; }
        public string height        { get; set; }
        public string weight        { get; set; }
        public int nextEvolution { get; set; }
    }
}
