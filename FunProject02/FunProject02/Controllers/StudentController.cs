using FunProject02.dal;
using FunProject02.Models;
using Microsoft.AspNetCore.Mvc;

namespace FunProject02.Controllers
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
                students = _dal.GetAllStudents();
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
            }
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                TempData["errorMessage"] = "Model Data is invalid";
            }
            bool result = _dal.Insert(student);
            if(!result)
            {
                TempData["errorMessage"] = "Unable to save data";
                return View();
            }
            TempData["sucessMessage"] = "Record Saved Successfully";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id , Student student)
        {
            
            return View();
        }
    }
}
