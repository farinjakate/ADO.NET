using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    //low level module
    //iske uper depend ho raha hai
   public class TrainerDB: ITrainerDB
   {
        // communicating with Database

        //crud methods  for trainer table

        public void Insert()
        {
           
            Console.WriteLine("Trainer Created successfully");

            Console.ReadLine();

        }

   }
}
