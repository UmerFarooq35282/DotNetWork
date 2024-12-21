using Microsoft.AspNetCore.Mvc;
using MvcLoginPage.Models;

namespace MvcLoginPage.Controllers
{
    public class LoginsController : Controller
    {

        private readonly LoginDbContext _dbContext;

        public LoginsController(LoginDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserLogin login)
        {
            var x = from a in _dbContext.Users.Where(m=>m.Email == login.Email)
                    select a;
            var y = from a in _dbContext.Users.Where(m => m.Password == login.Password)
                    select a;
            if(x.Any() && y.Any())
            {
                return RedirectToAction("Index" , "Home");
            }else if (!x.Any())
            {
                TempData["Email_Error"] = " Incorrect Email ";
            }else if (!y.Any())
            {
                TempData["Pass_Error"] = " Incorrect Password ";
            }
            else
            {
                TempData["Both_Error"] = " Email & Password Both Are Incorrect ";
            }
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(UserLogin login)
        {
            var x = from a in _dbContext.Users.Where(m=> m.Email == login.Email)
                    select a;
            if(ModelState.IsValid)
            {
                if(x.Any())
                {
                    TempData["Insert_Error"] = "Email Already Exists";
                }
                else
                {
                    _dbContext.Users.Add(login);
                    _dbContext.SaveChanges();
                    TempData["Insert_Seccuss"] = "User signup successfully";
                    return RedirectToAction("Index", "Logins");
                }
            }
            return View(login);
        }
    }
}
