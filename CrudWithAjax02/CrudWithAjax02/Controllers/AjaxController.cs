using CrudWithAjax02.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudWithAjax02.Controllers
{
    public class AjaxController : Controller
    {
        private readonly AjaxCrudContext _context;

        public AjaxController(AjaxCrudContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult AllEmploye()
        {
            var data = _context.Employees.ToList();

            return new JsonResult(data);
        }

        public JsonResult SaveEmploye(Employee employee)
        {
            Employee emp = new Employee()
            {
                Name = employee.Name,
                State = employee.State,
                City = employee.City,
                Salary = employee.Salary,
            };
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return new JsonResult(emp);
        }
    }
}
