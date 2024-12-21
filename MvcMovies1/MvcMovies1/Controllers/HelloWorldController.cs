using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string name = "" , int numtimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Welcome {name} , NumTimes is: {numtimes}");
        }
    }
}
