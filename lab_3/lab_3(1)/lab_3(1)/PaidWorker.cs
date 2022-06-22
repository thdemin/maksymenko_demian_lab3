using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_1_
{
    public abstract class PaidWorker : Employee   //наслідує властивості працівника
    {
        public int Salary { get; private set; }

        public PaidWorker(int salary)
        {
            Salary = salary;                  //метод для отримання зарплатні
        }

        public void PayRise(int newSalary)
        {
            Console.WriteLine("Пiдвищення зарплатнi");

            if (newSalary <= Salary)
                throw new ArgumentException("нова зарплатня повинна бути вищою");   //метод для підвищення зарплатні

            Salary = newSalary;
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Salary);
        }

        public override string ToString()
        {
            return GetWorkerInfo();
        }
    }
}
