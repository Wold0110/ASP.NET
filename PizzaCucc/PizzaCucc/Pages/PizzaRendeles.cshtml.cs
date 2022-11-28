using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaCucc.Pages
{
    public class PizzaRendelesModel : PageModel
    {
        public string Megrendelo { get; set; }
        public void OnGet()
        {
            Megrendelo = HttpContext.Session.GetString("felhasz");
        }
    }
}
