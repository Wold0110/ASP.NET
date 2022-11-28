using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaCucc.Pages
{
    public class UjPizzaModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            int id = int.Parse(Request.Form["id"]);
            string name = Request.Form["name"];
            PizzaRendeloLib.Pizza array = new();
            array.PizzaHozzaad(name, id);
            //PizzaRendeloLib.Pizza local = new(id, name);
        }
    }
}
