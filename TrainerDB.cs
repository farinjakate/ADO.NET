using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetCoreAppp
{
    // ye dot net core Application ka code hai isme srif ek hi change hai encrypted=false;
    public class TrainerDB
    {
        public List<Trainer> AllTrainers()//Trainer table ka pura data copy kiye hai.
        {
            List<Trainer> trainers = new List<Trainer>();//Trainer ki List Banaye

            string connectionString = "server=.\\sqlexpress;database=MYADONETDB;integrated security=true;encrypt=false;";
            //so here we have to do some changes in .net core encrypt=false;

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Trainer", con); //select * from Trainer ye ek  inline(adoc)query hai
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) // HasRows check krta hai Rows hai kya
            {
                while (reader.Read())
                {
                    Trainer t = new Trainer() //object Initializer syntax
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        City = reader["City"].ToString(),
                        Experience = (int)reader["Experience"]
                    };
                    trainers.Add(t);//Trainer List yaha Pr Add Kiye
                }
            }
            else
            {
                trainers = null;
            }
            con.Close();

            return trainers;
        }

        public bool DeleteTrainer(int id)
        {
            string connextionString =
                    "server=.\\sqlexpress;database=MYADONETDB;integrated security=true;encrypt=false;";

            //string connextionString =
            //  ConfigurationManager.ConnectionStrings["ADONETDB"].ConnectionString;

            // [] bracket in connectionstring name which is written in App.config file.

            SqlConnection con = new SqlConnection(connextionString);

            SqlCommand cmd = new SqlCommand("uspDeleteTrainer", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);


            SqlParameter status = new SqlParameter()
            {
                ParameterName = "@Status",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Output,
            };

            cmd.Parameters.Add(status);

            con.Open();

            cmd.ExecuteNonQuery();//ExecuteNonQuery command class hai, use for prepared & execute command

            con.Close();

            return (bool)status.Value;
        }

        public bool CreateTrainer(Trainer trainer, out int rollNumber)
        {
            string connectionString =
                "server=.\\sqlexpress;database=MYADONETDB;integrated security=true;encrypt=false;";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("uspCreateTrainer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", trainer.Name);
            cmd.Parameters.AddWithValue("@City", trainer.City);
            cmd.Parameters.AddWithValue("@Experience", trainer.Experience);

            SqlParameter rn = new SqlParameter()
            {
                ParameterName = "@RollNumber",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(rn);

            SqlParameter status = new SqlParameter()
            {
                ParameterName = "@Status",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(status);

            con.Open();

            cmd.ExecuteNonQuery();

            rollNumber = (int)rn.Value;
            con.Close();
            return (bool)status.Value;
           
        }

       

    }
}
