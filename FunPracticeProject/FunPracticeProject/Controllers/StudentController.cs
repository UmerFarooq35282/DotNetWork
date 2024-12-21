using FunPracticeProject.dal;
using FunPracticeProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FunPracticeProject.Controllers
{
    public class StudentController : Controller
    {
        Student_DAL _dal;

        public StudentController(Student_DAL dal)
        {
            _dal = dal;
        }
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            try
            {
                students = _dal.GetAll();
            }
            catch ( Exception ex)
            {

                TempData["ErrorMessage"] = ex.Message;
            }
            return View(students);
        }
    }
}
