using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONetWebApplication
{
    public partial class Home : System.Web.UI.Page
    {
        // // page level event
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtAspx.Text = "ASPX Textbox";
            //txtHTML.Value = "HTML Textbox";

            if (IsPostBack)
            {
                Response.Write("POST REQUEST : Page_Load <br/>");
            }
            else
            {
                Response.Write("GET REQUEST:Page_Load <br/>");
            }
        }
        protected void Page_init(object sender, EventArgs e)
        {
            Response.Write("Page_init <br/>");

        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender <br/>");

        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            Response.Write("BtnLoad_Click <br/>");

        }

    }
}