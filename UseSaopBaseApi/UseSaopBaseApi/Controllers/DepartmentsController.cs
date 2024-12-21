using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UseSaopBaseApi.localhost;

namespace UseSaopBaseApi.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            Departs();
            return View();
        }

        public void Departs()
        {
            
        }
    }
}