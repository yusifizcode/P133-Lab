using _16._09._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _16._09._2022.Models
{
    public class User : IAccount
    {

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        static string _password;
        public string FullName;
        public string Email;
        public string Password { get => _password; set 
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Shifre yanslishdir!");
                }
            } }



        public bool PasswordChecker(string password)
        {
            bool checkDigit = false;
            bool checkUpper = false;
            bool checkLower = false;

            if(password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if(char.IsLower(password[i]))
                        checkLower = true;
                    if(char.IsUpper(password[i]))
                        checkUpper = true;
                    if(char.IsDigit(password[i]))
                        checkDigit = true;
                }

                if(checkDigit && checkUpper && checkLower)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Email: {Email}\nFullname: {FullName}\n Password: {Password}");
        }
    }
}
