using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExclServicess.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            getService();
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

        public List<Service> getService()
        {
            List<Service> srvcList = new List<Service>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ExcellOnServiceConnectionString"].ToString();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Services";
            SqlDataReader re = cmd.ExecuteReader();

            
            while (re.Read())
            {
                Service service = new Service();
                service.ServiceName = re["ServiceName"].ToString();
                service.ServiceDescription = re["ServiceDescription"].ToString();
                service.MainServiceImg = re["MainServiceImg"].ToString();
                service.ServiceCode = re["ServiceCode"].ToString();
                service.ServiceCharges = int.Parse(re["ServiceCharges"].ToString());

                srvcList.Add(service);
            }
            return ViewBag.SrcList = srvcList;
        }
    }
}