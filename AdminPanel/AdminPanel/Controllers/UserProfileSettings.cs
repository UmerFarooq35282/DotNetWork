using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class UserProfileSettings : Controller
    {
        ProjectDbContext _context;

        public UserProfileSettings(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string email)
        {
            if (email == null)
            {
                return NotFound();
            }
            var user = _context.PanelUsers.FirstOrDefault(m => m.Email == email);
            if(user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }
}
