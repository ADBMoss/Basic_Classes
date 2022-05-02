using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            var car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2008;

            Console.WriteLine($"Your car is a {car1.Year} {car1.Make} {car1.Model}");




        }
    }
}
