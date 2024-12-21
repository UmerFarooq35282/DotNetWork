using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

using System.Configuration;
using System.Web.Services;
using SoapBaseAPI.Models;

namespace SoapBaseAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }

        public List<Department> GetDepartments()
        {
            List<Department> list = new List<Department>();
            string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ToString();
            SqlConnection aConnection = new SqlConnection(ConnectionString);

            aConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Departments";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Department department = new Department();
                department.DepartmentName = reader["DepartmentName"].ToString();
                department.ArabicName = reader["ArabicName"].ToString();
                department.Status = reader["Status"].ToString();

                list.Add(department);
            }

            return list;
        }
    }
}
