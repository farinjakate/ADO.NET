using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    //high level module
    //jo depend ho raha hai
    public class TrainerBL
    {  //Business Logic

        private ITrainerDB _db;

        //using Constructor
        public TrainerBL(ITrainerDB db)
        {
            _db = db; //declaration
                      //constructor ke parameter ke through private field ke through interface ki
                      //dependency liya hai
        }

        //using Property
        //public ITrainerDB Dependency
        //{
        //    set
        //    {
        //        _db = value;
        //    }
        //}


        //using Method
        //public void SetDependency(ITrainerDB db)
        //{
        //    _db = db;
        //}




        public void Insert()
        {
            //TrainerDB db= new TrainerDB();
            //db.Insert();

            _db.Insert();
        }

    }
}
