using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    class Book:Product
    {
        public string Author;
        public string Genre;

        public override void GetInfo()
        {
            Console.WriteLine($"Author: {Author}  Genre: {Genre}");
        }
    }
}
