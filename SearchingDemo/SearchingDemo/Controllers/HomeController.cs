using Microsoft.AspNetCore.Mvc;
using SearchingDemo.Models;
using System.Diagnostics;

namespace SearchingDemo.Controllers
{


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProjectContext _context;
        public HomeController(ILogger<HomeController> logger , ProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.Products.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
