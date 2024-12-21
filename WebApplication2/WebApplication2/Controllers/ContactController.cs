using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is the message from Contact Controller";

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
