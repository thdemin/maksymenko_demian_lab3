using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_1_
{
    public class Engineer : PaidWorker    //наслідує властивості оплачуваного працівника
    {
        public Engineer(int salary) : base(salary)
        {
        }

        public override string GetWorkerInfo()
        {
            Console.WriteLine("Iнженер");
            return Name + " " + Salary;
        }
    }


}

