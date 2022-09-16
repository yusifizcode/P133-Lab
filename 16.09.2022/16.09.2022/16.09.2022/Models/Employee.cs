using System;
using System.Collections.Generic;
using System.Text;

namespace _16._09._2022.Models
{
    internal class Employee
    {
        static int _no;
        public int No;
        public string FullName;
        public double Salary;
        public string Position;

        static Employee()
        {
            _no = 0;
        }

        public Employee()
        {
            _no++;
            No = _no;
        }
    }
}
