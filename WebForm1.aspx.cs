using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            user us = new user();
            us.Username = TextBox1.Text;
            us.password = TextBox2.Text;
            Session["user"] = us.Username;
            if(us.Username!="lokeshwari" && us.password!="23111")
            {
                Response.Write("Check ur user name or password");

            }
            else
            {
                Response.Write("Check ur user name or password");

                Response.Redirect("~/WebForm2.aspx");

            }
        }
    }
}