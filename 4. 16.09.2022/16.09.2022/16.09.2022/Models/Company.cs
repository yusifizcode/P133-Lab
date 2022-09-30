using System;
using System.Collections.Generic;
using System.Text;

namespace _16._09._2022.Models
{
    internal class Company
    {
        string _name;
        public string Name { get =>_name; set 
            {
                if(!String.IsNullOrEmpty(value))
                {
                    if (char.IsUpper(value[0]))
                    {
                        for (int i = 0; i < value.Length; i++)
                        {
                            if(!(char.IsWhiteSpace(value[i]) || char.IsDigit(value[i]) || char.IsLetter(value[i])))
                            {
                                Console.WriteLine("Company name must be contain letter, digit or white space!");
                                return;
                            }    
                        }
                        _name = value;

                    }
                    else
                    {
                        Console.WriteLine("Company name first letter must upper case!");
                    }
                }
                else
                {
                    Console.WriteLine("Company name is required!");
                }
            } }
        public int EmployeeLimit;
        public Employee[] Employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            if(EmployeeLimit > Employees.Length)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
            else
            {
                Console.WriteLine("Limit ashilib!!");
            }
        }

        public Employee[] GetEmployees() => Employees;
    }
}
