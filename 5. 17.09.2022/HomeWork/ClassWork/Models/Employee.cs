using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    class Employee:Person
    {
        public Employee(string name,string surName,byte age,double salaryOfHour,int workingHour)
        {
            Name = name;
            SurName = surName;
            Age = age;
            SalaryOfHour = salaryOfHour;
            WorkingHour = workingHour;
        }

        public double SalaryOfHour { get; set; }
        public int WorkingHour { get; set; }

        public void CalculateSalary() 
        {
            if(Age >= 18)
            {
                if(WorkingHour / 30 <= 8)
                {
                    if(WorkingHour* SalaryOfHour >= 250)
                    {
                        Console.WriteLine($"Maash: {WorkingHour * SalaryOfHour}");
                    }
                    else
                    {
                        Console.WriteLine("Maash 250den asagi ola bilmez!");
                    }
                }
                else
                {
                    Console.WriteLine("Gunluk ish saati 8 saatdan cox ola bilmez!");
                }
            }
            else
            {
                Console.WriteLine("Ishcinin yashi minimum 18 olmalidir!");
            }
        }
    }
}
