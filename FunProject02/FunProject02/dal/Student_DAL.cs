using FunProject02.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;

namespace FunProject02.dal
{
    public class Student_DAL
    {
        SqlConnection _connection;
        SqlCommand _command;

        public IConfigurationRoot Configration { get;  set; }

        public string GetConnectionString()
        {
            var biulder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configration = biulder.Build();
            return Configration.GetConnectionString("DefaultConnection");
        }

        public List<Student> GetAllStudents()
        {
            List<Student> studentslist = new List<Student>();
            using(_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[sp_get_all_student]";
                _connection.Open();
                SqlDataReader dr = _command.ExecuteReader();
                while (dr.Read())
                {
                    Student student = new Student();
                    student.id = Convert.ToInt32(dr["id"]);
                    student.SName = dr["SName"].ToString();
                    student.FName = dr["FName"].ToString();
                    student.SClass = dr["SClass"].ToString();
                    student.SAddress = dr["SAddress"].ToString();
                    studentslist.Add(student);
                }
                return studentslist;
            }
        } 

        public bool Insert(Student student)
        {
            int id = 0;
            using(_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[sp_insert_std]";
                _command.Parameters.AddWithValue("@SName", student.SName);
                _command.Parameters.AddWithValue("@FName", student.FName);
                _command.Parameters.AddWithValue("@Gender", student.Gender);
                _command.Parameters.AddWithValue("@SClass", student.SClass);
                _command.Parameters.AddWithValue("@SAddress", student.SAddress);
                _connection.Open();
                id = _command.ExecuteNonQuery();
                _connection.Close();
            }
            return id > 0 ? true : false;
        }
    }
}
