using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {

            ViewData["Message"] = "This is the message from About Controller";
            var viewModel = new Orders
            {
                Name = "Umer Farooq",
                Description = "Wrist Watch for men",
                Address = "Street 19 Sec E Manzoor Colon Karachi"
            };
            return View(viewModel);
        }
    }
}
