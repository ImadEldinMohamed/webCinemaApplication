using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCinemaApplication
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == ConfigurationManager.AppSettings["username"] && TextBox3.Text == ConfigurationManager.AppSettings["password"])
            {
                Label1.Text = "dati corretti";
                HttpCookie cookie = new HttpCookie("prova");
                cookie.Values["username"] = TextBox1.Text;
                cookie.Values["password"]= TextBox3.Text;
                Response.Cookies.Add(cookie);
                Response.Redirect("cinema.aspx");

            }
            else
            {
                Label1.Text = "errore!";
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {

        }
    }
}