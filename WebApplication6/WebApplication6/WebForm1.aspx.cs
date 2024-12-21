using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(cs);
        }

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            
            _command = new SqlCommand();
            _command.Connection = _connection;
            _command.CommandText = "Insert into Users(UserName , Email , Password , CPassword) Values (@user , @Email , @Password , @CPassword)";
            _command.Parameters.AddWithValue("@user" , UserTextBox.Text);
            _command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
            _command.Parameters.AddWithValue("@Password", PassTextBox.Text);
            _command.Parameters.AddWithValue("@CPassword", CPassTextBox.Text);
            _connection.Open();
            int id = _command.ExecuteNonQuery();
            if (id == 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('SignUp successful !!')</script>");
                Session["email"] = EmailTextBox.Text;
                Session["password"] = PassTextBox.Text;
                Response.Redirect("WebForm2.aspx");
            }
            _connection.Close();
        }
    }
}