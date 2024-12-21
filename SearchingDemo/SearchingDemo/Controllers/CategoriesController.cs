using Microsoft.AspNetCore.Mvc;
using SearchingDemo.Models;

namespace SearchingDemo.Controllers
{
    public class CategoriesController : Controller
    {
        ProjectContext _context;
        public CategoriesController(ProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Categories.ToList();
            return View(data);
        }

        [HttpPost]

        public JsonResult AddCategory(Category cat)
        {
            _context.Categories.Add(cat);
            _context.SaveChanges();
            return new JsonResult("Added Success");
        }

        public IActionResult EditCategory(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var data = _context.Categories.Find(id);
            if(data == null)
            {
                return NotFound();
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult EditCategory(int id ,Category cat)
        {
            if (id != cat.Categoryid) return NotFound();

            _context.Categories.Update(cat);
            _context.SaveChanges();
            return RedirectToAction("Index" , "Categories");
        }
    }
}
