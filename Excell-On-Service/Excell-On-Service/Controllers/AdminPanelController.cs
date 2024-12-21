using Excell_On_Service.ContextFolder;
using Excell_On_Service.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace Excell_On_Service.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ProjectDbContext _context;

        public IWebHostEnvironment _enviroment;

        public AdminPanelController(ProjectDbContext context , IWebHostEnvironment enviroment)
        {
            _context = context;
            _enviroment = enviroment;
        }
        public IActionResult Index()
        {
            List<Service> ServiceList = _context.Services.ToList();
            TempData["Total_Services"] = ServiceList.Count;

            List<SubService> SubServiceList = _context.SubServices.ToList();
            TempData["Total_SubServices"] = SubServiceList.Count;

            var ReqEmployee = from a in _context.TblEmployee.Where(p => p.RoleEmploye == "Employee") select a;
            List<TblEmployee> ReqEmpList = ReqEmployee.ToList();
            TempData["Emp_Request"] = ReqEmpList.Count;

            var ReqAdmin = from a in _context.TblEmployee.Where(p => p.RoleEmploye == "Admin") select a;
            List<TblEmployee> ReqAdminList = ReqAdmin.ToList();
            TempData["Admin_Req"] = ReqAdminList.Count;

            var Employees = from a in _context.TblEmployee.Where(p => p.RoleEmploye == "employees") select a;
            List<TblEmployee> EmployeeList = Employees.ToList();
            TempData["Total_Employees"] = EmployeeList.Count;

            var Clients = _context.TblClient.ToList();
            TempData["Total_Client"] = Clients.Count();

            var Admins = from a in _context.TblEmployee.Where(p=> p.RoleEmploye == "ActiveAdmin") select a;
            List<TblEmployee> AdminsList = Admins.ToList();
            TempData["Total_Admins"] = AdminsList.Count;

            List<Department> Departs = _context.Departments.ToList();
            TempData["Total-Department"] = Departs.Count;
            var list = _context.TblEmployee.Include(p=>p.Department).ToList();
            TempData["Total_Uses"] = list.Count();
            if(HttpContext.Session.GetString("Admin") == "ActiveAdmin")
            {
                return View(list);
            }
            else
            {
                return RedirectToAction("CreateEmp", "Employees");
            }
        }

        // ====>> Services & Products Work For Admin Panel Strat<<======
        public IActionResult Services() 
        {
            var items = _context.Services.ToList();
            return View(items);
        }

        public IActionResult CreateService()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service ser , IFormFile img)
        {
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    var imgPath = Path.Combine(_enviroment.WebRootPath, "MainServiceImage");
                    var fileName = Guid.NewGuid() + "_" + img.FileName;
                    var folderPath = Path.Combine(imgPath, fileName);
                    using (var fs = new FileStream(folderPath, FileMode.Create))
                    {
                        img.CopyTo(fs);
                        ser.MainServiceImg = fileName;
                        _context.Services.Add(ser);
                        _context.SaveChanges();
                        return RedirectToAction("Index", "AdminPanel");
                    }
                }
            }
            return View(ser);
        }

        public IActionResult UpdateServices(int? id)
        {
            if (id == null) return NotFound();
            var ser = _context.Services.FirstOrDefault(p => p.ServiceId == id);
            return View(ser);
        }

        [HttpPost]

        public IActionResult UpdateServices(int? id , Service ser , IFormFile img)
        {
            if (id != ser.ServiceId) return NotFound();

            if (img != null)
            {
                var imgPath = Path.Combine(_enviroment.WebRootPath, "MainServiceImage");
                var fileName = Guid.NewGuid() + "_" + img.FileName;
                var folderPath = Path.Combine(imgPath, fileName);
                using (var fs = new FileStream(folderPath, FileMode.Create))
                {
                    img.CopyTo(fs);
                    ser.MainServiceImg = fileName;
                    _context.Services.Update(ser);
                    _context.SaveChanges();
                    return RedirectToAction("Services", "AdminPanel");
                }
            }
            return View();
        }
        public IActionResult SubServices()
        {
            var items = _context.SubServices.Include(p=>p.Service).ToList();
            return View(items);
        }

        public IActionResult CreateSubService()
        {
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateSubService(SubService ser , IFormFile img)
        {
            if (img != null)
            {
                var imgPath = Path.Combine(_enviroment.WebRootPath, "SubServiceImages");
                var fileName = Guid.NewGuid() + "_" + img.FileName;
                var folderPath = Path.Combine(imgPath, fileName);
                using (var fs = new FileStream(folderPath, FileMode.Create))
                {
                    img.CopyTo(fs);
                    ser.ServiceImage = fileName;
                    _context.SubServices.Add(ser);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "AdminPanel");
                }
            }
            return View(ser);
        }

        public IActionResult UpdateSubServices(int? id)
        {
            if (id == null) return NotFound();
            var ser = _context.SubServices.FirstOrDefault(p => p.SubServiceId == id);
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName");
            return View(ser);
        }

        [HttpPost]

        public IActionResult UpdateSubServices(int? id, SubService ser, IFormFile img)
        {
            if (id != ser.SubServiceId) return NotFound();

            if (img != null)
            {
                var imgPath = Path.Combine(_enviroment.WebRootPath, "SubServiceImages");
                var fileName = Guid.NewGuid() + "_" + img.FileName;
                var folderPath = Path.Combine(imgPath, fileName);
                using (var fs = new FileStream(folderPath, FileMode.Create))
                {
                    img.CopyTo(fs);
                    ser.ServiceImage = fileName;
                    _context.SubServices.Update(ser);
                    _context.SaveChanges();
                    return RedirectToAction("Services", "AdminPanel");
                }
            }
            return View();
        }

        // ====>> Services & Products Work For Admin Panel End<<======

        // ====>> Employee Work For Admin Panel Start <<======
        public IActionResult GetEmployees()
        {
            var ReqEmployee = from a in _context.TblEmployee.Where(p => p.RoleEmploye == "employees") select a;
            List<TblEmployee> ReqEmpList = ReqEmployee.Include(p => p.Department).ToList();
            return View(ReqEmployee);
        }
        public IActionResult GetReqEmployees()
        {
            var ReqEmployee = from a in _context.TblEmployee.Where(p => p.RoleEmploye == "Employee") select a;
            List<TblEmployee> ReqEmpList = ReqEmployee.Include(p => p.Department).ToList();
            return View(ReqEmployee);
        }
        [ActionName("UpdateEmployee")]
        public IActionResult GetEmpById(int? id)
        {

            if (id == null) return NotFound();
            var emp = _context.TblEmployee.FirstOrDefault(p => p.Id == id);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "DepartmentName");
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName");
            return View(emp);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(int id , TblEmployee emp , IFormFile img)
        {
            if (img != null)
            {
                var imgPath = Path.Combine(_enviroment.WebRootPath, "EmployeeImages");
                var fileName = Guid.NewGuid() + "_" + img.FileName;
                var folderPath = Path.Combine(imgPath, fileName);
                using (var fs = new FileStream(folderPath, FileMode.Create))
                {
                    img.CopyTo(fs);
                    emp.Image = fileName;
                    _context.TblEmployee.Update(emp);
                    _context.SaveChanges();
                    return RedirectToAction("GetEmployees", "AdminPanel");
                }
            }
            return View();
        }
        public IActionResult DeleteById(int? id)
        {
            if (id == null) return NotFound();
            var emp = _context.TblEmployee.FirstOrDefault(p => p.Id == id);
            return View(emp);
        }

        public IActionResult UpdateEmp(int? id)
        {
            if(id == null) return NotFound();
            var emp = _context.TblEmployee.FirstOrDefault(p => p.Id == id);
            if(emp != null)
            {
                emp.RoleEmploye = "employees";
                _context.SaveChanges();
                return RedirectToAction("Index" , "AdminPanel");
            }

            return View(emp);
        }


        // ====>> Employee Work For Admin Panel End <<======


        // ====>> Client Work For Admin Panel Start <<======
        public IActionResult GetClient()
        {
            var ReqClient = _context.TblClient.ToList();
            return View(ReqClient);
        }
        public IActionResult UpdateClient(int? id)
        {
            if (id == null) return NotFound();
            var data = _context.TblClient.FirstOrDefault(p=>p.ClientId == id);
            if (data == null) return NotFound();
            return View(data);
        }
        [HttpPost]
        public IActionResult UpdateClient(int id , Client client , IFormFile img)
        {
            if (id != client.ClientId) return NotFound();
            if (img != null)
            {
                var imgPath = Path.Combine(_enviroment.WebRootPath, "ClientImage");
                var fileName = Guid.NewGuid() + "_" + img.FileName;
                var folderPath = Path.Combine(imgPath, fileName);
                using (var fs = new FileStream(folderPath, FileMode.Create))
                {
                    img.CopyTo(fs);
                    client.ClientPhoto = fileName;
                    _context.TblClient.Update(client);
                    _context.SaveChanges();
                    return RedirectToAction("GetClient", "AdminPanel");
                }
            }

            return View();
        }


        // ====>> Client Work For Admin Panel End <<======


        // ====>> Work For Admins Of Panel User Strat<<======
        public IActionResult AdminReq()
        {
            var AdminReqList = from a in _context.TblEmployee.Where(p=> p.RoleEmploye == "Admin") select a;
            List<TblEmployee> listAdmin = AdminReqList.Include(p=>p.Department).ToList();
            return View(listAdmin);
        }
        public IActionResult AdminApproval(int? id)
        {
            var data = _context.TblEmployee.FirstOrDefault(p=> p.Id == id);
            if(data != null)
            {
                data.RoleEmploye = "ActiveAdmin";
                _context.SaveChanges();
                return RedirectToAction("Index" , "AdminPanel");
            }
            return View();
        }

        public IActionResult GetAllAdmins()
        {
            var list = _context.TblEmployee.Where(p => p.RoleEmploye == "ActiveAdmin");
            return View(list);
        }

        // ====>> Work For Admins Of Panel User Strat<<======

        // ====>> Department Work For Admin Panel Strat<<======
        public IActionResult Departments()
        {

            return View(_context.Departments.ToList());
        }

        public IActionResult CreateDepart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDepart(Department dep)
        {
            if(dep == null) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Departments.Add(dep);
                _context.SaveChanges();
                return RedirectToAction("Index" , "AdminPanel");
            }
            return View();
        }
    }
}
