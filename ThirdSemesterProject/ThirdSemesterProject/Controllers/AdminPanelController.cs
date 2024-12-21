using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThirdSemesterProject.Controllers
{
    public class AdminPanelController : Controller
    {
        // GET: AdminPanel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            getServices();
            return View();

        }

        public ActionResult SubServices()
        {
            getSubServices();
            return View();

        }

        public List<Service> getServices()
        {
            List<Service> serviceList = new List<Service>();
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
                service.ServiceCode = re["ServiceCode"].ToString();
                service.MainServiceImg = re["MainServiceImg"].ToString();
                service.ServiceCharges = int.Parse(re["ServiceCharges"].ToString());
                serviceList.Add(service);
            }
            return ViewBag.SrvListItem = serviceList;
        }

        public List<SubService> getSubServices()
        {
            List<SubService> serviceList = new List<SubService>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ExcellOnServiceConnectionString"].ToString();

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SubServices";
            SqlDataReader re = cmd.ExecuteReader();
            while (re.Read())
            {
                SubService service = new SubService();
                service.SubServiceName = re["SubServiceName"].ToString();
                service.SubServiceDescription = re["SubServiceDescription"].ToString();
                service.SubServiceCode = re["SubServiceCode"].ToString();
                service.ServiceImage = re["ServiceImage"].ToString();
                service.SubServiceCharges = int.Parse(re["SubServiceCharges"].ToString());
                service.ServiceId = int.Parse(re["ServiceId"].ToString());
                serviceList.Add(service);
            }
            return ViewBag.SbSrvListItem = serviceList;
        }
    }
}