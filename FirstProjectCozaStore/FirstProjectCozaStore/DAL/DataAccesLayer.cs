using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

using FirstProjectCozaStore.Models;

namespace FirstProjectCozaStore.DAL
{
    public class DataAccesLayer : IDataAccesLayer
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ToString();

        
        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllCategories";

                SqlDataReader re = cmd.ExecuteReader();

                while (re.Read())
                {
                    Category category = new Category();
                    category.CreatedDate = DateTime.Now;
                    category.CategoryName = re["CategoryName"].ToString();
                    category.Description = re["Description"].ToString();
                    category.CategoryID = Convert.ToInt32(re["CategoryID"]);
                    category.CategoryImage = re["CategoryImage"].ToString();
                    list.Add(category);
                }

            }
            return list;
        }

        public List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllProducts";

                SqlDataReader re = cmd.ExecuteReader();

                while (re.Read())
                {
                    Product product = new Product();
                    product.CreatedDate = DateTime.Now;
                    product.ProductName = re["ProductName"].ToString();
                    product.Description = re["Description"].ToString();
                    product.CategoryID = Convert.ToInt32(re["CategoryID"]);
                    product.ProductID = Convert.ToInt32(re["ProductID"]);
                    product.ProductImage = re["ProductImage"].ToString();
                    product.Stock = Convert.ToInt32(re["Stock"]);
                    product.Price = Convert.ToDecimal(re["Price"]);

                    list.Add(product);

                }

            }
            return list;
        }
    }
}