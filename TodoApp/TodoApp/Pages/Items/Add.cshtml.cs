using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoApp.Model;

namespace TodoApp.Pages.Items
{
    public class AddModel : PageModel
    {
        public class Input
        {
            public string title { get; set; }
            public string desc { get; set; }
        }

        [BindProperty]
        public Input FormInput { get; set; }

        public void OnGet()
        {}

        public void OnPost()
        {
            TodoItem.list.Add(new(FormInput.title, FormInput.desc));
        }
    }
}
