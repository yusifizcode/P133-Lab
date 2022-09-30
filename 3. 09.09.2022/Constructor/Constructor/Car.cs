using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    partial class Car
    {
        public Car(string model, string color = "red")
        {
           this.Model = model;
            Color = color;
            Console.WriteLine("car yaradildi");
        }

        public Car()
        {

        }

        public Car(string model, string brandName,double price):this(model)
        {
            BrandName = brandName;
            Price = price;
        }

        public string Model;
        public string Color;
        public string BrandName;
        public double Price;


    }
}
