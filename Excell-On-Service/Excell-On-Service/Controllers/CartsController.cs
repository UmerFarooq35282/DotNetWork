using Microsoft.AspNetCore.Mvc;

namespace Excell_On_Service.Controllers
{
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
