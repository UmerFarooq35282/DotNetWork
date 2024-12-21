using Excell_On_Service.ContextFolder;
using Microsoft.AspNetCore.Mvc;

namespace Excell_On_Service.Controllers
{
    public class ContactSettingsController : Controller
    {
        private readonly ProjectDbContext _context;

        public ContactSettingsController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
