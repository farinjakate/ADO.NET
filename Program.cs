using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
namespace dependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.//     TrainerBL bl = new TrainerBL(new TrainerDB());

            //TrainerBL bl = new TrainerBL();
            //bl.Dependency = new TrainerDB();

            //TrainerBL bl = new TrainerBL();
            //bl.SetDependency(new TrainerDB());

            //TrainerBL bl = new TrainerBL(new TrainerOracleDB());
            //bl.Insert();

            var container=new UnityContainer();
            //register

            container.RegisterType<ITrainerDB, TrainerDB >();


            //resolve
            TrainerBL bl = container.Resolve<TrainerBL>();
            bl.Insert();
                

            Console.ReadLine();
        }
    }
}
