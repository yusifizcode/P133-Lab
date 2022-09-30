using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model = "s500";

            Car car = new Car();

            car.BrandName = "Mercedes";
            car.Price = 40000;
            car.Model = "s400";
            car.Color = "blue";

            Console.WriteLine(car.Model);
            Car car2 = new Car("Model x");
        }
    }
}
