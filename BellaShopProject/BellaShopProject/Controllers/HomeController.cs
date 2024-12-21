using BellaShopProject.DALRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BellaShopProject.Controllers
{
    public class HomeController : Controller
    {
        DataAccessLayer _dal = new DataAccessLayer();
        public ActionResult Index()
        {
            _dal.GetProducts();
            return View();
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