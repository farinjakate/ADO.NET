
//using Ado.net in Dot Net Core Application

// See https://aka.ms/new-console-template for more information

using ADONetCoreAppp;
using Microsoft.Data.SqlClient;
using System.Numerics;

Console.WriteLine("***All Trainers***");



/////    comment kiye huye code ko copy karke  AllTrainers() method me paste kiya hai       ////


//List<Trainer> trainers = new List<Trainer>();//Trainer ki List Banaye

//string connectionString = "server=.\\sqlexpress;database=MYADONETDB;integrated security=true;encrypt=false;";
////so here we have to do some changes in .net core encrypt=false;

//SqlConnection con = new SqlConnection(connectionString);

//SqlCommand cmd = new SqlCommand("select * from Trainer", con); //select * from Trainer ye ek  inline(adoc)query hai
//con.Open();
//SqlDataReader reader = cmd.ExecuteReader();

//if (reader.HasRows) // HasRows check krta hai Rows hai kya
//{
//    while (reader.Read())
//    {
//        Trainer t = new Trainer() //object Initializer syntax
//        {
//            Id = (int)reader["Id"],
//            Name = reader["Name"].ToString(),
//            City = reader["City"].ToString(),
//            Experience = (int)reader["Experience"]
//        };
//        trainers.Add(t);//Trainer List yaha Pr Add Kiye
//    }
//}
//else
//{
//    trainers = null;
//}

//con.Close();









TrainerDB db = new TrainerDB();
var trainers = db.AllTrainers();

foreach (var item in trainers)
{
    Console.WriteLine($"Id:{item.Id} Name:{item.Name}  city:{item.City} Experience:{item.Experience}");
}

Console.WriteLine("Create A New Trainer");
Console.WriteLine("Please enter name");
string name = Console.ReadLine();
Console.WriteLine("Please enter city");
string city = Console.ReadLine();
Console.WriteLine("Please enter experience");
int experience =int.Parse(Console.ReadLine());

Trainer t = new Trainer() { Name = name, City = city, Experience = experience };

int rn;
if(db.CreateTrainer(t,out rn))
{
    Console.WriteLine($"Trainer Inserted successfully.Trainer Id is {rn}");

}
else
{
    Console.WriteLine("Failed to insert new trainer");

}


Console.WriteLine("\nEnter trainer id to delete");
int id = int.Parse(Console.ReadLine());

bool status = db.DeleteTrainer(id);
if(status)
{
    Console.WriteLine($"Trainer with id {id} Deleted successfully,");
}
else
{
    Console.WriteLine($"Trainer with Id {id} Delete failed.");
}




Console.ReadLine();
Console.WriteLine("Hello, World!");



