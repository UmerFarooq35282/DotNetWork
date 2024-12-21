using CrudWithMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudWithMvc.Controllers
{
    public class CategoriesController : Controller
    {
        ProjectDbContext _dbContext;

        public CategoriesController(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.categories.ToList());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if (category == null) return NotFound();

            
            _dbContext.categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index" , "Categories");
            
        }

        public IActionResult EditCategory(int? id)
        {
            if(id == null) return NotFound();
            var cat = _dbContext.categories.FirstOrDefault(m=>m.CategoryId == id);
            return View(cat);
        }
        [HttpPost]
        public IActionResult EditCategory(int id , Category category)
        {
            if(id != category.CategoryId) return NotFound();

            _dbContext.categories.Update(category);
            _dbContext.SaveChanges();

            return RedirectToAction("Index" , "Categories");
        }

        public IActionResult CategoryDetails(int? id)
        {
            if (id == null) return NotFound();
            var cat = _dbContext.categories.FirstOrDefault(m => m.CategoryId == id);
            return View(cat);
        }
        public IActionResult DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            var cat = _dbContext.categories.FirstOrDefault(m => m.CategoryId == id);
            if(cat != null)
            {
                _dbContext.categories.Remove(cat);
                _dbContext.SaveChanges();
                return RedirectToAction("Index" , "Categories");
            }
            return View();
        }

        //[HttpPost]
        //public IActionResult ConfirmDelete(int id)
        //{   
        //    var cat = _dbContext.categories.Find(id);
        //    if(cat != null)
        //    {
        //        _dbContext.categories.Remove(cat);
        //        _dbContext.SaveChanges();
        //        return RedirectToAction("Index", "Categories");
        //    }
        //    return View(cat);

            
        //}
    }
}
