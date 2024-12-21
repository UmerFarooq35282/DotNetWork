using FirstProjectCozaStore.DAL;
using FirstProjectCozaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectCozaStore.Controllers
{
    public class HomeController : Controller
    {

        DataAccesLayer _dal = new DataAccesLayer(); 
        public ActionResult Index()
        {
            var prdts = _dal.GetCategories().Take(3);

            //Product p = new Product();
            //p.ProductImage
            //p.ProductName
            //p.Description
            //p.Price

            Category cat = new Category();

            //cat.CategoryImage
            //cat.CategoryName
            //cat.Description


            ViewBag.Prd = prdts;
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