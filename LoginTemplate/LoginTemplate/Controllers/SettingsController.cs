using LoginTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{
    public class SettingsController : Controller
    {
        ProjectDbContext _context;
        public SettingsController(ProjectDbContext context) 
        {
            _context = context;
        }

        public IActionResult Index(string? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var result = _context.Users.FirstOrDefault( m => m.Email  == id);
            if(result == null)
            {
                return NotFound(id);
            }
            return View(result);
        }
    }
}
