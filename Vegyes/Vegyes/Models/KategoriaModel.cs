namespace Vegyes.Models
{
    public class KategoriaModel
    {
        public List<string> KatNevek { get; set; }
        public KategoriaModel() {
            KatNevek = File.ReadAllLines("KategoriaConfig.txt").ToList();
        }
    }
}
