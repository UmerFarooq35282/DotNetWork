using Microsoft.AspNetCore.Mvc;

namespace MvcMovies1.Controllers
{
    public class SecondTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name , int numtimes)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numtimes;
            return View();
        }
    }
}
