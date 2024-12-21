using LoginTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{
    public class LoginsController : Controller
    {
        ProjectDbContext _context;

         
        public LoginsController(ProjectDbContext context)
        {
            _context = context;
        }
        public string user = "";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginUser l)
        {
            var x = from a in _context.Users.Where(m=> m.Email.Equals(l.Email) && m.Password.Equals(l.Password)) 
                    select a;
            if (x.Any())
            {
                TempData["Success"] = "Login Successfully";
                TempData["User"] = l.Email;
                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["Error"] = "Invalid Email Or Password";
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(LoginUser l)
        {
            var x = from a in _context.Users.Where(m=> m.Email.Equals(l.Email))
                    select a;
            if(x.Any())
            {
                TempData["Error"] = "Email Already Exists";
            }
            else
            {
                
                _context.Users.Add(l);
                _context.SaveChanges();
                TempData["Success"] = "User Register Successfully";
                return RedirectToAction("Index" , "Logins");
            }
            return View(l);
        }
    }
}
