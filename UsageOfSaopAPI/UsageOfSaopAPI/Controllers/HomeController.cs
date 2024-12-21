using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsageOfSaopAPI.localhost;

namespace UsageOfSaopAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GetDepartments();
            return View();
        }

        public List<Department> GetDepartments()
        {
            List<Department> result = new List<Department>();

            Service1 service1 = new Service1();
            var dept = service1.GetDepartments().ToList();
            foreach (var department in dept)
            {
                Department D = department;
                //D.DepartmentName
                //D.DepartmentId
                //D.Status
                result.Add(D);
            }

            return ViewBag.DList = result;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}