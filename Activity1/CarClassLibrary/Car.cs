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
        // Console application coding challenge properties
        public string Color { get; set; }
        //public bool isNew { get; set; }
        public int Year { get; set;  }


        // constructor with default values
        public Car()
        {
            Make = "Not set";
            Model = "Not set";
            Price = 0.00m;
            // challenge properties
            Color = "Not set";
            //isNew = false;
            Year = 1900;
        }

        // constructor with 3 parameters
        public Car(string a, string b, decimal c, string d, int e)
        {
            Make = a;
            Model = b;
            Price = c;
            Color = d;
            Year = e;

        }

        override public string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Color: {Color}, Year: {Year}, Price: ${Price}";
        }
    }
}
