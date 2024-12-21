using AjaxLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxLearning.Controllers
{
    public class EmployeesController : Controller
    {
        ProjectContext _context;

        public EmployeesController(ProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public JsonResult CreateEmp(Employe emp)
        {
            Employe employee = new Employe()
            {
                EmployeName = emp.EmployeName,
                EmpCity = emp.EmpCity,
                EmpCountry = emp.EmpCountry,
                EmpPhone = emp.EmpPhone,
                EmpImage = emp.EmpImage,
            };
            _context.employes.Add(employee);
            _context.SaveChanges();
            return new JsonResult(employee);
        }
        [HttpGet]
        public JsonResult GetEmployees()
        {
            var data = _context.employes.ToList();
            return Json(data);
        }

        public JsonResult DeleteEmployees(int id)
        {
            var data = _context.employes.Find(id);
            if(data != null)
            {
                _context.employes.Remove(data);
                _context.SaveChanges();
            }
            return new JsonResult("Data Deleted Successfully");
        }
    }
}
