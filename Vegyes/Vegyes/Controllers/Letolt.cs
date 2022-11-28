using Microsoft.AspNetCore.Mvc;
using System.Text;
using Vegyes.Models;

namespace Vegyes.Controllers
{
    public class Letolt : Controller
    {
        public FileResult Index()
        {
            Adatok data = new();
            StringBuilder txtString=new();
            foreach(var x in data.Kiadasoks)
            {
                txtString.Append(x+"\r\n");
            }
            return File(Encoding.UTF8.GetBytes(txtString.ToString()),"application/txt","download.txt");
        }
    }
}
