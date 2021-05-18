using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        // Car properties
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }


        // constructor with default values
        public Car()
        {
            Make = "Not set";
            Model = "Not set";
            Price = 0.00m;
        }

        // constructor with 3 parameters
        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }

        override public string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Price: ${Price}";
        }
    }
}
