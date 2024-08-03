using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONetWebApplication
{
    public partial class CreateStudent : System.Web.UI.Page
    {   
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTrainers();
            }       
        }
        private void LoadTrainers()
        {

            string connectionstring = ConfigurationManager.ConnectionStrings["MYADONETDB"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("select * from trainer", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            ddlTrainers.DataValueField = "Id";
            ddlTrainers.DataTextField = "Name";


            ddlTrainers.DataSource = reader;
            ddlTrainers.DataBind();



            ddlTrainers.Items.Insert(0, new ListItem() { Value = "-1", Text = "-- select Trainer --" });


            con.Close();

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                // string Gender=txtGender.Text;

                IEnumerable<ListItem> items = rblGender.Items.Cast<ListItem>();
                string gender = items.FirstOrDefault(i => i.Selected == true)?.Value;
                // string trainerId = ddlTrainers.Text;
                int trainerId = int.Parse(ddlTrainers.SelectedValue);

                //ado.net code to insert student in database

                string connectionstring = ConfigurationManager.ConnectionStrings["MYADONETDB"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionstring);

                string cmdText = $"insert into student values('{name}','{gender}',{trainerId})";

                SqlCommand cmd = new SqlCommand(cmdText, con);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Redirect("StudentDashboard.aspx");
                }
                else
                {
                    lblMessage.Text = "Error in creating student";
                }
            }
            catch
            {
                lblMessage.Text = "Error in creating student";
            }
        }        
    }
}       