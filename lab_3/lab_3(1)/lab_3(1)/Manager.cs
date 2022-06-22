﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_1_
{
    public class Manager : PaidWorker       //наслідує властивості оплачуваного працівника
    {
        public Manager(int salary) : base(salary)  
        {
        }

        public void Fire(Employee worker)
        {
            Console.WriteLine("Менеджер звiльнив:");    //метод для звільнення працівників
            Office.Workers.Remove(worker);
        }

        public override string GetWorkerInfo()
        {
            Console.WriteLine("Менеджер");
            return Name + " " + Salary ;
        }
    }

}

