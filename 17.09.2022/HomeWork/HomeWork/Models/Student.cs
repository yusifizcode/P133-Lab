using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    class Student
    {
        public Student(string fullname, string groupNo,byte age)
        {
            FullName = fullname;
            GroupNo = groupNo;
            Age = age;
        }

        static string _fullName;
        public string FullName { get=>_fullName; set 
            {
                while (!CheckFullName(value))
                {
                    Console.WriteLine("Duzgun fullname edin!");
                    value = Console.ReadLine();
                }
                _fullName = value;
            } }

        static string _groupNo;
        public string GroupNo { get=>_groupNo; set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Duzgun group no edin!");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            } }
        public byte Age;

        public bool CheckGroupNo(string groupNo)
        {
            int count = 0;
            if(!string.IsNullOrEmpty(groupNo) && groupNo.Length == 4 && char.IsUpper(groupNo[0]))
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (char.IsDigit(groupNo[i]))
                    {
                        count++;
                    }
                }

                if (count == 3)
                    return true;
                return false;
            }
            return false;
        }


        public bool CheckFullName(string fullName)
        {
            string newFullName = fullName.Trim();
            string[] strArr = newFullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            newFullName = string.Join(' ', strArr);

            int count = 0;

            if(!string.IsNullOrEmpty(fullName) && char.IsUpper(fullName[0]) && char.IsLower(fullName[fullName.Length - 1]) && newFullName.Length == fullName.Length)
            {
                for (int i = 1; i < fullName.Length; i++)
                {
                    if(char.IsLower(fullName[i]) || (fullName[i] == ' ' && char.IsUpper(fullName[i + 1])))
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
    }
}
