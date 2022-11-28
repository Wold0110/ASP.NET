using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaCucc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string nev = Request.Query["user"];
            if (!String.IsNullOrEmpty(nev))
            {
                HttpContext.Session.SetString("felhasz", nev);
                Response.Cookies.Append("fel2",nev);
            }
        }
        public void OnPost()
        {
            string nev2 = Request.Form["user"];
        }
    }
}