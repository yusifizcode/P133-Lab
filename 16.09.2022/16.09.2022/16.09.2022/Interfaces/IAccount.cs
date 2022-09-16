using System;
using System.Collections.Generic;
using System.Text;

namespace _16._09._2022.Interfaces
{
    internal interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
