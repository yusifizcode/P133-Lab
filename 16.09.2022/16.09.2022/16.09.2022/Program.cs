using _16._09._2022.Models;
using System;

namespace _16._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Employee employee6 = new Employee();


            Console.WriteLine(employee5.No);

            Company company = new Company();

            company.EmployeeLimit = 3;


            employee1.FullName = "Yusif";
            employee2.FullName = "Abbas";
            employee3.FullName = "Hikmet";
            employee4.FullName = "filankes";

            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            company.AddEmployee(employee3);
            company.AddEmployee(employee4);



            foreach (var item in company.GetEmployees())
            {
                Console.WriteLine(item.FullName);
            }
            #endregion


            #region Task 2
            User user = new User("salam@gmail.com","Asda1ds12312");

            user.ShowInfo();
            #endregion
        }
    }
}
