using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SearchingDemo.Models;

namespace SearchingDemo.Controllers
{
    public class ProductsController : Controller
    {
        ProjectContext _context;
        IWebHostEnvironment _environment;
        
        public ProductsController(ProjectContext context , IWebHostEnvironment enviroment)
        {
            _context = context;
            _environment = enviroment;
        }
        
        public IActionResult Index()
        {
            var data = _context.Products.Include(p => p.Category).ToList();
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Categoryid" , "CategoryName");
            return View(data);
        }

        public JsonResult SearchProduct(string val)
        {
            
            return Json(new { val });
        }
        public IActionResult AddProduct()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Categoryid", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product , IFormFile img) 
        {
            if(img != null) 
            {
                var path = _environment.WebRootPath;
                var filepath = "ProductImages/" + img.FileName;
                var fullPath = Path.Combine(path, filepath);
                using(var fs = new FileStream(fullPath , FileMode.Create))
                {
                    img.CopyTo(fs);
                    product.Image = img.FileName;
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    return RedirectToAction("Index" , "Products");
                }
            }
            return View();
        }

        public IActionResult ProDetail(int? id)
        {
            var pro = _context.Products.FirstOrDefault(m=>m.Id == id);
            return View(pro);
        }
        public ActionResult EditProduct(int? id)
        {
            if (id == null) return NotFound();

            var data = _context.Products.Find(id);
            if(data == null) return NotFound();

            return View(data);
        }
    }
}
