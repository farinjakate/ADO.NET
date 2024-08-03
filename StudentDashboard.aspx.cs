using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONetWebApplication
{
    public partial class StudentDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["MYADONETDB"].ConnectionString;

            SqlConnection con=new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("select * from student",con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            gvStudents.DataSource = reader;
            gvStudents.DataBind();

            con.Close();



                
        }

    }
}