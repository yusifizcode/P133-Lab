using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    abstract class Product
    {
        public string Name;
        public double Price;

        public abstract void GetInfo();
    }
}
