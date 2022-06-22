﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_1_
{
    public static class Office
    {
        public static List<Employee> Workers = new List<Employee>();   //створюємо список працівників

        public static void PrintAllWorkers()
        {
            foreach (var worker in Workers)
            {
                Console.WriteLine(worker.GetWorkerInfo());   //метод для отримання інфо про працівників
            }

            Console.WriteLine();
        }
    }
}
