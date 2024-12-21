using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;
using WebAPISaopBase.Models;
using System.Data;

namespace WebAPISaopBase
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PracticeAPI" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PracticeAPI.svc or PracticeAPI.svc.cs at the Solution Explorer and start debugging.
    public class PracticeAPI : IPracticeAPI
    {
        public void DoWork()
        {
        }

        public List<Department> GetDeparments()
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
                department.Rating = Convert.ToInt32(reader["Rating"]);
                department.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);

                list.Add(department);
            }

            return list;
        }

        public List<Department> GetDeparmentById(int id)
        {
            List<Department> list = new List<Department>();
            string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ToString();
            SqlConnection aConnection = new SqlConnection(ConnectionString);

            aConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Departments WHERE DepartmentId = @id";
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Department department = new Department();
                department.DepartmentName = reader["DepartmentName"].ToString();
                department.ArabicName = reader["ArabicName"].ToString();
                department.Status = reader["Status"].ToString();
                department.Rating = Convert.ToInt32(reader["Rating"]);
                department.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);

                list.Add(department);
            }

            return list;
        }

        public List<Department> GetTopDepartments(int id, int rating)
        {
            throw new NotImplementedException();
        }
    }
}
