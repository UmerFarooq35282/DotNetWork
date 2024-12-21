using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class CategoriesController : Controller
    {
        ProjectDbContext _context;

        public CategoriesController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.categories.ToList());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if (category == null) return NotFound();

            if(ModelState.IsValid)
            {
                _context.categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index" , "Categories");
            }
            return View(category);
        }

        public IActionResult EditCategory(int? id) 
        {
            if (id == null) return NotFound();
            
            var category = _context.categories.FirstOrDefault(m => m.CategoryId == id);
            
            return View(category);
        }
        [HttpPost]

        public IActionResult EditCategory(int id , Category category)
        {
            return View();
        }
    }
}
