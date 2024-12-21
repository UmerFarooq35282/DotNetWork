using CrudWithAjax.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudWithAjax.Controllers
{
    public class AjaxController : Controller
    {
        ContextClass _context;

        public AjaxController(ContextClass context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult EmployeeList()
        {
            var data = _context.employees.ToList();
            return new JsonResult(data);
        }

        [HttpPost]

        public JsonResult AddEmployee(Employees employe)
        {
            Employees emp = new Employees()
            {
                Name = employe.Name,
                State = employe.State,
                City = employe.City,
                Salary = employe.Salary,
            };
            _context.employees.Add(emp);
            _context.SaveChanges();
            return new JsonResult(emp);
        }
    }
}
