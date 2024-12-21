using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(cs);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand();
            _command.Connection = _connection;
            _command.CommandText = "SELECT * FROM Users Where Email = @Email AND Password = @Pass";
            _command.Parameters.AddWithValue("@Email" , EmailTextBox.Text);
            _command.Parameters.AddWithValue("@Pass", PassTextBox.Text);
            _connection.Open();
            SqlDataReader dr = _command.ExecuteReader();
            if (dr.Read())
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('SignUp successful !!')</script>");
                Session["email"] = EmailTextBox.Text;
                Session["password"] = PassTextBox.Text;
                Response.Redirect("Webform3.aspx");
            }
            _connection.Close();
        }
    }
}