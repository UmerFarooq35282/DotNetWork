using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThirdSemesterProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            getServices();
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

        public ActionResult Products(int? id)
        {
            getSubServices(id);
            return View();
        }
        public ActionResult ProductDetail(int? id)
        {
            getProductDetail(id);
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
                service.ServiceId = int.Parse(re["ServiceId"].ToString());
                serviceList.Add(service);
            }
            return ViewBag.SrvListItem = serviceList;
        }

        public List<SubService> getSubServices(int? id)
        {
            List<SubService> serviceList = new List<SubService>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ExcellOnServiceConnectionString"].ToString();

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SubServices WHERE ServiceId = '"+id+"'";
            SqlDataReader re = cmd.ExecuteReader();
            while (re.Read())
            {
                SubService service = new SubService();
                service.SubServiceName = re["SubServiceName"].ToString();
                service.SubServiceDescription = re["SubServiceDescription"].ToString();
                service.SubServiceCode = re["SubServiceCode"].ToString();
                service.ServiceImage = re["ServiceImage"].ToString();
                service.SubServiceCharges = int.Parse(re["SubServiceCharges"].ToString());
                service.SubServiceId = int.Parse(re["SubServiceId"].ToString());
                service.ServiceId = int.Parse(re["ServiceId"].ToString());
                serviceList.Add(service);
            }
            return ViewBag.SbSrvListItem = serviceList;
        }
        public void getProductDetail(int? id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ExcellOnServiceConnectionString"].ToString();

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SubServices WHERE SubServiceId = '" + id + "'";
            SqlDataReader re = cmd.ExecuteReader();

            re.Read();

            SubService service = new SubService();
            if (re.HasRows)
            {
                service.SubServiceName = re["SubServiceName"].ToString();
                service.SubServiceDescription = re["SubServiceDescription"].ToString();
                service.SubServiceCode = re["SubServiceCode"].ToString();
                service.ServiceImage = re["ServiceImage"].ToString();
                service.SubServiceCharges = int.Parse(re["SubServiceCharges"].ToString());
                service.SubServiceId = int.Parse(re["SubServiceId"].ToString());
                service.ServiceId = int.Parse(re["ServiceId"].ToString());
            }
            ViewBag.ProductDetail = service;
        }
    }
}