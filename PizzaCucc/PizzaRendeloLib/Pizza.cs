using System.Diagnostics;

namespace PizzaRendeloLib
{
    public class Pizza
    {
        private List<Pizza> pizzaList = new List<Pizza>();
        int id;
        string name;
        public Pizza(int id, string name)
        {
            this.id = id;this.name = name;
        }
        public Pizza() { }
        public void PizzaHozzaad(string name,int id)
        {
            pizzaList.Add(new(id,name));
        }

        public List<Pizza> PizzaLista()
        {
            pizzaList.Add(new(1, "Magyaros"));
            pizzaList.Add(new(2, "Hawaii"));
            pizzaList.Add(new(3, "Kemény legény"));
            return pizzaList;
        }
        public void Rendeles(int id, string user)
        {
            //SMS lenne itt
            //TODO: id -> pizza név
            Debug.WriteLine(user + " ordered a " + id+" id pizza "+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}