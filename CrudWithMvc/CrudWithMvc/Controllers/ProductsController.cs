using CrudWithMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
namespace CrudWithMvc.Controllers
{
    public class ProductsController : Controller
    {
        ProjectDbContext _db;
        IWebHostEnvironment _environment;
        
        public ProductsController(ProjectDbContext db, IWebHostEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }
        public IActionResult Index()
        {
            var product = _db.products.Include(f => f.Category);
            return View(product.ToList());
        }

        public IActionResult CreateProduct()
        {
            ViewData["CategoryId"] = new SelectList(_db.categories , "CategoryId" , "CategoryName");
            return View();
        }
        [HttpPost]

        public IActionResult CreateProduct(Product product , IFormFile img)
        {
            if(product == null)
            {
                return NotFound();
            }
            string folderPath = Path.Combine(_environment.WebRootPath , "PImages");
            string fileName = Path.GetFileName(img.FileName);
            string path = Path.Combine(folderPath, fileName);
            //_db.products.Add(product);
            //_db.SaveChanges();
            return RedirectToAction("Index" , "Products");
        }

    }
}
