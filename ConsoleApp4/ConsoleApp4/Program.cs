using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            Console.ReadLine();
        }

        public static void Connection()
        {
            //string cs = "Data Source = DESKTOP-UNV1KV7; Initial Catalog = DbUmer; Integrated Security = true;";
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    Console.WriteLine("Enter Your Id");
                    string id = Console.ReadLine();
                    //Console.WriteLine("Enter Your Name");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("Enter Your Father Name");
                    //string fname = Console.ReadLine();
                    //Console.WriteLine("Enter Your Age");
                    //string age = Console.ReadLine();

                    // string query = "Update StudentInfo set SName = @name , FName = @fname , Age = @age where id = @id";
                    // string query = "Update StudentInfo set SName = @name , FName = @fname , Age = @age where id = @id";
                    string query = "delete from StudentInfo where id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    //cmd.Parameters.AddWithValue("name", name);
                    //cmd.Parameters.AddWithValue("fname", fname);
                    //cmd.Parameters.AddWithValue("age", age);
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    if(a > 0)
                    {
                        Console.WriteLine("Data Deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Data deletion failed..");
                    }
                    //string query = "spDetStudenData";
                    //SqlCommand cmd = new SqlCommand(query,conn);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //conn.Open();
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    Console.WriteLine($"Id : {dr["Id"]} Name : {dr["SName"]} Father Name : {dr["FName"]} Age : {dr["Age"]}");
                    //}
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
