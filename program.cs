using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Demos");

            //TrainerDB db = new TrainerDB();
            //List<Trainer> trainers = db.AllTrainers();

            //List<Trainer> trainers;
            //List<Student> students;
            //db.AllTrainers(out trainers, out students);

            //Console.WriteLine("*** ALL TRAINERS FROM DATABASE ***");

            //foreach (var t in trainers)
            //{
            //    Console.WriteLine($"Id:{t.Id} Name: {t.Name} City:{t.City} Experience:{t.Experience}");
            //}

            //Console.WriteLine("*** ALL STUDENTS FROM DATABASE ***");


            //foreach (var s in students)
            //{
            //    Console.WriteLine($"Roll Number :{s.RollNumber} Name:{s.Name} City:{s.Gender} Trainer Id:{s.TrainerId}");
            //}


            //Console.WriteLine("Please enter trainer id to search");
            //int trainerId = int.Parse(Console.ReadLine());

            //Trainer trainer = db.GetTrainerById(trainerId);

            //if (trainer != null)
            //{
            //    Console.WriteLine($"Id:{trainer.Id} Name:{trainer.Name} City:{trainer.City} Experience:{trainer.Experience}");

            //}
            //else
            //{
            //    Console.WriteLine($"Trainer not found for Id {trainerId}");
            //}

            #region SQL Injection Attack

            //Console.WriteLine("Please enter a roll number to search student");
            //string rollnumber = Console.ReadLine();

            //string connectionString =
            //   "server=.\\sqlexpress;database=MYADONETDB;integrated security=true;";


            //SqlConnection con = new SqlConnection(connectionString);

            ////  string query = $"select * from student where RollNumber = {rollnumber}";

            ////parameterized query
            //string query = $"select * from student where RollNumber = @RollNumber";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@RollNumber", rollnumber);


            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        Student s = new Student()
            //        {
            //            RollNumber = (int)reader["RollNumber"],
            //            Name = reader["Name"].ToString(),
            //            Gender = reader["Gender"].ToString(),
            //            TrainerId = (int)reader["TrainerId"]
            //        };

            //        Console.WriteLine($"Roll Number :{s.RollNumber} Name :{s.Name} Gender:{s.Gender} TrainerId:{s.TrainerId}");
            //        break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Student not found for roll number {rollnumber}");
            //}

            //con.Close();

            #endregion SQL Injection Attack



            #region creating trainer

            //Console.WriteLine("Create a new trainer");
            //Console.WriteLine("Please enter trainer name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter trainer city");
            //string city = Console.ReadLine();
            //Console.WriteLine("Please enter trainer experience");
            //int experience = Convert.ToInt32(Console.ReadLine());

            //Trainer t = new Trainer()
            //{
            //    Name = name,
            //    City = city,
            //    Experience = experience
            //};
            //TrainerDB db = new TrainerDB();

            //int rollNumber = 0;
            //bool status = db.CreateTrainer(t, out rollNumber);

            //if (status)
            //{
            //    Console.WriteLine($"Trainer created successfully. Id is {rollNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Trainer creation failed");
            //}

            #endregion creating trainer


            #region Updating trainer

            //Console.WriteLine("Please enter trainer id");
            //int id = int.Parse(Console.ReadLine());

            //TrainerDB db1 = new TrainerDB();
            //Trainer trainer = db1.GetTrainerById(id);

            //Console.WriteLine($"Existing Trainer : Id : {trainer.Id} " +
            //    $"Name : {trainer.Name} City : {trainer.City} Experience : {trainer.Experience}");

            //string choice = "";
            //do
            //{
            //    Console.WriteLine("Please enter property name to update"); //hum ne jo Trainer class me jo property diye hai wo
            //    string name = Console.ReadLine();

            //    Console.WriteLine($"Please enter new value for {name}"); //updated value
            //    string newValue = Console.ReadLine();

            //    switch (name.ToUpper()) 
            //    {
            //        case "NAME":
            //            trainer.Name = newValue;
            //            break;
            //        case "CITY":
            //            trainer.City = newValue;
            //            break;
            //        case "EXPERIENCE":
            //            trainer.Experience = int.Parse(newValue);
            //            break;
            //        default:
            //            Console.WriteLine("INVALID PROPERTY NAME");
            //            break;
            //    }

            //    Console.WriteLine("Do you want to continue?");
            //    choice = Console.ReadLine().ToUpper();
            //} while (choice == "Y" || choice == "YES");// here we can take inpute anything Y or YES 

            //bool status = db.UpdateTrainer(trainer);
            //if (status)
            //{
            //    Console.WriteLine("Trainer details updated successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Trainer update failed.");
            //}

            #endregion Updating trainer


            #region Deleting a trainer


            //Console.WriteLine("Please enter trainer id to delete");
            //int id = int.Parse(Console.ReadLine());

            //TrainerDB db1 = new TrainerDB();
            //bool status = db1.DeleteTrainer(id);

            //if (status)
            //{
            //    Console.WriteLine($"Trainer with id {id} is deleted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine($"Unable to delete trainer with id {id}");
            //}

            #endregion Deleting a trainer

            Console.WriteLine($"Data copy Started @{DateTime.Now}..");

            TrainerDB db = new TrainerDB();
            bool status =db.BulkDataCopy();

            if (status)
            {
                Console.WriteLine($"Data Copy successfully Completed @{DateTime.Now}..");
            }
            else
            {
                Console.WriteLine($"Data Copy Stopped Due to Error @{DateTime.Now}..");
            }

            Console.ReadLine();
        }
    }
}

