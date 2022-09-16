using System;
using System.Collections.Generic;
using System.Text;

namespace _09._09._2022
{
    internal class Worker
    {
        public string Name;
        public string SurName;
        public byte Age;
        public double SalaryForHour;
        public int Hour;

        public Worker(string name, string surName,byte age,double salaryForHour)
        {
            Name = name;
            SurName = surName;
            Age = age;
            SalaryForHour = salaryForHour;
        }

        public double CalcSalary()
        {
            if (Age >= 18)
                return SalaryForHour * Hour;
            else
                return -1;
        }
    }
}
