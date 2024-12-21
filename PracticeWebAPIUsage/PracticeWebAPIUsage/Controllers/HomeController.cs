using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using PracticeWebAPIUsage.localhost;
namespace PracticeWebAPIUsage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GetAllDept();
            return View();
        }

        public List<Department> GetAllDept()
        {
            List<Department> list = new List<Department>();
            PracticeAPI practiceAPI = new PracticeAPI();
            var dept = practiceAPI.GetDeparments().ToList();
            foreach (var department in dept)
            {
                Department D = department;
                //D.DepartmentName
                //D.DepartmentId
                //D.Status
                //D.ArabicName
                list.Add(D);
            }

            return ViewBag.DList = list;
        }

        public List<Department> GetDepartById(int id)
        {
            List<Department> list = new List<Department>();

            bool initial = false;
            PracticeAPI practiceAPI= new PracticeAPI();

            var depart = practiceAPI.GetDeparments().FirstOrDefault(m => m.DepartmentId == id);
            //Department D = new Department();

            if (depart != null)
            {
                initial = true;
            }
            else
            {
                initial = false;
            }
            var dept = practiceAPI.GetDeparmentById(id, initial).ToList();
            if (dept != null)
            {
                foreach (var i in dept)
                {
                    Department De = i;
                    list.Add(De);
                }
            }
            return ViewBag.DList = list;
        }
        public ActionResult About(int id)
        {
            GetDepartById(id);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}