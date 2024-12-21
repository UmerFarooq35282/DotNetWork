using Excell_On_Service.ContextFolder;
using Excell_On_Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Excell_On_Service.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ProjectDbContext _context;
        private readonly IWebHostEnvironment enviroment;

        public EmployeesController(ProjectDbContext context , IWebHostEnvironment enviroment)
        {
            _context = context;
            this.enviroment = enviroment;
        }
        public IActionResult Index()
        {
            var empList = _context.TblEmployee.Include(p => p.Department).ToList();
            return View(empList);
        }

        public IActionResult CreateEmp()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments , "DepartmentId", "DepartmentName");
            ViewData["ServiceId"] = new SelectList(_context.Services , "ServiceId", "ServiceName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmp(TblEmployee emp , IFormFile img)
        {
            var data = _context.TblEmployee.Where(p=>p.Email == emp.Email);
            if (data.Any())
            {
                TempData["Creating_Error"] = "Email Already Exists";
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (img != null)
                    {
                        var imgPath = Path.Combine(enviroment.WebRootPath, "EmployeeImages");
                        var fileName = Guid.NewGuid().ToString() + "_" + img.FileName;
                        var folderPath = Path.Combine(imgPath, fileName);
                        using (var fs = new FileStream(folderPath, FileMode.Create))
                        {
                            img.CopyTo(fs);
                            emp.Image = fileName;
                            emp.PhoneNumber = "pending";
                            _context.TblEmployee.Add(emp);
                            _context.SaveChanges();
                            return RedirectToAction("EmpLogin", "Employees");
                        }
                    }
                }
            }
            
            return View();
        }
        public IActionResult EmpLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmpLogin(TblEmployee emp)
        {
            if (emp == null) return NotFound();
           
            var data = from a in _context.TblEmployee.Where(p => p.Email == emp.Email && p.Password == emp.Password) select a;

            var emplist = _context.TblEmployee.FirstOrDefault(p=>p.Email == emp.Email);
            if(emplist != null)
            {
                
            }
            if (data.Any())
            {
                if (data.Any(p=>p.RoleEmploye == "ActiveAdmin"))
                {
                    HttpContext.Session.SetString("Admin" , "ActiveAdmin");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    HttpContext.Session.SetString("Employee", "employees");
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                TempData["Login_Error"] = "Email or password not Correct";
            }
            
            return View();
        }
    }
}
