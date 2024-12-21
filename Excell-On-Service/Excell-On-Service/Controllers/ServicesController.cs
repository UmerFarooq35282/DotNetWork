using Excell_On_Service.ContextFolder;
using Excell_On_Service.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Excell_On_Service.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ProjectDbContext _context;

        public ServicesController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }

        public IActionResult GetSubServices(int? id)
        {
            if (id == null) return NotFound();
            var SbSer = _context.SubServices.Where(p => p.ServiceId == id).Include(p=>p.Service).ToList();
            var MnSer = _context.Services.FirstOrDefault(p => p.ServiceId == id);
            if(MnSer == null) return NotFound();
            TempData["Servive_Heading"] = MnSer.ServiceName.ToString();
            if (SbSer == null) return NotFound();
            return View(SbSer);
        }

        public IActionResult SubServicesDetail(int? id)
        {
            if (id == null) return NotFound();
            var data = _context.SubServices.FirstOrDefault(p=>p.SubServiceId == id);
            if (data == null) return NotFound();
            return View(data);
        }

        public IActionResult PaymentDetail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PaymentDetail(PymentDetail py)
        {
            if (py == null) return NotFound();
            
            
            if(py != null)
            {
                _context.PymentDetail.Add(py);
                _context.SaveChanges();
                HttpContext.Session.SetString("PaymentID", "Done");
                return RedirectToAction("Index", "Services");
            }
            
            return View(py);
        }
    }
}
