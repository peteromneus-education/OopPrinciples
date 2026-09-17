using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrinciples
{
    // Car inherits from Vehicle class
    internal class Car : Vehicle
    {
        public string Model { get; private set; }

        public Car(string brand, string model)
            : base(brand)
        {
            Model = model;
        }

        public void PrintCarInfo()
        {
            PrintInfo();
            Console.WriteLine($"Model: {Model}");
        }
    }
}
