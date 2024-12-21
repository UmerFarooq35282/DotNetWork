using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
