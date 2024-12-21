using FunPracticeProject.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FunPracticeProject.dal
{
    public class Student_DAL
    {
        SqlConnection _coneection = null;
        SqlCommand _command = null;

        public IConfigurationRoot Configration { get; set; }

        private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configration = builder.Build();
            return Configration.GetConnectionString("DefaultConnection");
        }

        public List<Student> GetAll()
        {
            List<Student> list = new List<Student>();
            using (_coneection = new SqlConnection(GetConnectionString()))
            {
                _command = _coneection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[sp_get_all_student]";
                _coneection.Open();

                SqlDataReader dr = _command.ExecuteReader();
                while (dr.Read())
                {
                    Student student = new Student();
                    student.id = Convert.ToInt32(dr["id"]);
                    student.SName = dr["SName"].ToString();
                    student.FName = dr["FName"].ToString();
                    student.SClass = dr["SClass"].ToString();
                    student.SAddress = dr["SAddress"].ToString();
                    list.Add(student);
                }
                return list;
            }
        }
    }
}
