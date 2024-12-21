using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BellaShopProject.DALRepo
{
    public class DataAccessLayer : IDataAccessLayer
    {

        SqlConnection conn;
        SqlCommand cmd;

        string ConnetionStr = ConfigurationManager.ConnectionStrings["Cs"].ToString();
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCat(int catId)
        {
            List<Product> products = new List<Product>();
            using (conn = new SqlConnection(ConnetionStr))
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Products WHERE CategoryID = @id";
                cmd.Parameters.AddWithValue("id", catId);
                SqlDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    Product prod = new Product();
                    prod.ProductName = re["ProductName"].ToString();
                    prod.Description = re["Description"].ToString();
                    prod.ProductImage = re["ProductImage"].ToString();
                    prod.Price = Convert.ToDecimal(re["Price"]);
                    prod.ProductID = Convert.ToInt32(re["ProductID"]);
                    prod.CategoryID = Convert.ToInt32(re["CategoryID"]);
                    prod.Stock = Convert.ToInt32(re["Stock"]);
                    products.Add(prod);
                }
            }
            return products;
        }

        public Product GetProductById(int id)
        {
            Product prod = new Product();
            using (conn = new SqlConnection(ConnetionStr))
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Products WHERE ProducId = @id";
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    prod.ProductName = re["ProductName"].ToString();
                    prod.Description = re["Description"].ToString();
                    prod.ProductImage = re["ProductImage"].ToString();
                    prod.Price = Convert.ToDecimal(re["Price"]);
                    prod.ProductID = Convert.ToInt32(re["ProductID"]);
                    prod.CategoryID = Convert.ToInt32(re["CategoryID"]);
                    prod.Stock = Convert.ToInt32(re["Stock"]);
                }
            }
            return prod;
        }

        public List<Product> GetProducts(string pro, int catId, int page)
        {
            List<Product> products = new List<Product>();
            using(conn = new SqlConnection(ConnetionStr))
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllProducts";
                SqlDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    Product prod = new Product();
                    prod.ProductName = re["ProductName"].ToString();
                    prod.Description = re["Description"].ToString();
                    prod.ProductImage = re["ProductImage"].ToString();
                    prod.Price = Convert.ToDecimal(re["Price"]);
                    prod.ProductID = Convert.ToInt32(re["ProductID"]);
                    prod.CategoryID = Convert.ToInt32(re["CategoryID"]);
                    prod.Stock = Convert.ToInt32(re["Stock"]);
                    products.Add(prod);
                }
            }
            return products;
        }
    }
}