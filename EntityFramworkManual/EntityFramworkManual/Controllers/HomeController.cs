using EntityFramworkManual.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFramworkManual.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext _context;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(StudentDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var std = _context.Students.ToList();
            return View(std);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            if(ModelState.IsValid)
            {
                _context.Students.Add(std);
                _context.SaveChanges();
                TempData["Created_success"] = "Created Successfully";
                return RedirectToAction("Index" , "Home");
            }
            
            return View(std);
        }
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var std = _context.Students.FirstOrDefault(x => x.Id == id);
            if(std == null)
            {
                return NotFound();
            }
            return View(std);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var std = _context.Students.Find(id);
            if (std == null)
            {
                return NotFound();
            }
            return View(std);
        }
        [HttpPost]
        public IActionResult Edit(int id , Student std)
        {
            if (id != std.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                _context.Update(std);
                _context.SaveChanges();
                TempData["Updated_success"] = "Updated Successfully";
                return RedirectToAction("Index" , "Home");
            }
            return View(std);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var std = _context.Students.Find(id);
            if (std == null)
            {
                return NotFound();
            }
            return View(std);
        }
        [HttpPost , ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var stdDelete = _context.Students.Find(id);
            if(stdDelete != null)
            {
                _context.Students.Remove(stdDelete);
            }
            _context.SaveChanges();
            TempData["Deleted_success"] = "Deleted Successfully";
            return RedirectToAction("Index" , "Home");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
