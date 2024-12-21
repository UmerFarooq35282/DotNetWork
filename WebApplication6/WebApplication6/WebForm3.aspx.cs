using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["email"] != null)
            {
                Response.Write($"Welcome to my site Mr/Mrs {Session["email"].ToString()}");
            }
            else
            {
                Response.Redirect("WebForm2.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}