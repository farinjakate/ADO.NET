using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO.NETWebApp
{
    // ye code behind file hai
    // ****Trainer List humko tabuler formate me batani hai.*****
    // browser me table jo dikhenga usko hum apne hisab se design kr sakte hai
    //right click on code behind file go on view designer click on tables upper right corners arrow go on auto formate 
    //humne sabse pehle ASP ke TrainerDashboard.aspx(1st page) me toolbox me se Gridview and label tags drag and drop karke liye isase Trainer List tabuler
    //format me dikhengi browser me


    public partial class TrainerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
              string cs = "server=.\\sqlexpress;database=MYADONETDB;integrated security=true;";

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("select * from trainer",con);

            con.Open(); 
                            
           SqlDataReader reader= cmd.ExecuteReader();

            gvTrainers.DataSource = reader;  //gvTrainers Id hai, TrainerDashboard.aspx page se liye
            gvTrainers.DataBind();

            lblMessage. Text = "Trainers Loaded From Database";

            con.Close();
           
        }
    }
}