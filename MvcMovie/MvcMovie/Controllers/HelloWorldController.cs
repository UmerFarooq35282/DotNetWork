using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string message , int numtimes)
        {
            ViewData["Message"] = $"Hello {message}";
            ViewData["NumTimes"] = numtimes;
            return View();
        }
    }
}
