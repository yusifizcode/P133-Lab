using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    class Journal:Product
    {
        public string CompanyName;

        public override void GetInfo()
        {
            Console.WriteLine($"Company Name: {CompanyName}");
        }
    }
}
