using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    public class TrainerOracleDB : ITrainerDB
    {
        public void Insert()
        {
            Console.WriteLine("Trainer Created Successfully in oracle DB");
        }
    }
}
