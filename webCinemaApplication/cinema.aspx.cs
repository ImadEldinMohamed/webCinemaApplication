using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCinemaApplication
{
    public partial class cinema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["prova"] != null)
            {

               string nome = Request.Cookies["prova"]["username"];
                bentornato.InnerHtml = $"Bentornato {nome}";



            }




            }

        protected void Button1_Click(object sender, EventArgs e)


             
        {

         

             
           

            }
        }
    }
}