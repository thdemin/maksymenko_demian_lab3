using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_1_
{
    public abstract class Employee
    {
        public string Name { get; set; }         

        public abstract string GetWorkerInfo();

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return GetWorkerInfo();
        }
    }

}
