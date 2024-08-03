using Birthday_Messanger_Scheduler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Messanger_Scheduler
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string WhatsAppMessage { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public DateTime MessageSendDate { get; set; }
        public DateTime EmailSendDate { get; set; }

    }

    public class Friendship
    {

        public List<Friend> GetFriendsWithTodayBirthday() // here we can write any method name
        {
            string connectionString = "Server=.\\sqlexpress;database=MYADONETDB;integrated security=true;";

            List<Friend> friends = new List<Friend>();

            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();               
                                                   
                                                                                                    
               string query = "SELECT * FROM Friendship  WHERE MONTH(DateOfBirth) = MONTH(GETDATE()) AND DAY(DateOfBirth) = DAY(GETDATE())";

                //string query = "SELECT * FROM Friendship";
                    
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Friend friend = new Friend
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        Mobile = reader["Mobile"].ToString(),
                        Email = reader["Email"].ToString(),
                        WhatsAppMessage = reader["WhatsAppMessage"].ToString()
                    };
                    friends.Add(friend);
                }
            }
            return friends;
        }
    }
}


