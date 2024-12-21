using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AdminPanel.Controllers
{
    public class UserLoginsController : Controller
    {
        private readonly ProjectDbContext _context;

        public UserLoginsController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PanelUsers Pn)
        {
            var x = from a in _context.PanelUsers.Where(m=> m.Email.Equals(Pn.Email))
                    select a;
            if (x.Any())
            {
                TempData["Email_Error"] = "Email Already Exists";
            }
            else
            {
                _context.PanelUsers.Add(Pn);
                _context.SaveChanges();
                return RedirectToAction("SignIn" , "UserLogins");
            }
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(PanelUsers Pn)
        {
            var x = from a in _context.PanelUsers.Where(m=> m.Email.Equals(Pn.Email) && m.Password.Equals(Pn.Password))
                    select a;
            if (x.Any())
            {
                var m = x;
                HttpContext.Session.SetString("Email" , $"{Pn.Email}");
                return RedirectToAction("Index" , "Home");
            }
            else
            {
                TempData["Login_Error"] = "Email or Password Incorrect";
            }
            return View();
        }
    }
}
