using ClassWork.Models;
using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Employee employee = new Employee("asd","Asd",23,23,200);

            employee.CalculateSalary();
        }
    }
}
