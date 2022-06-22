using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_1_
{
    public class Trainee : Employee     //наслідує властивості працівника
    {
        public override string GetWorkerInfo()
        {
            Console.WriteLine("Стажер");
            return Name;
        }
    }
}
