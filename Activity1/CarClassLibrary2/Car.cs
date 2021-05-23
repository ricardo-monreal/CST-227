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
        // GUI application coding challenge properties
        public string Color { get; set; }
        public int Year { get; set;  }


        // constructor with default values
        public Car()
        {
            Make = "Not set";
            Model = "Not set";
            Color = "Not set";
            Year = 1900;
            Price = 0.00m;
            // challenge properties
            
        }

        // constructor with 3 parameters
        //public Car(string a, string b, decimal c, string d, int e)
        public Car(string a, string b, string c, int d, decimal e )
        {
            Make = a;
            Model = b;
            Color = c;
            Year = d;
            Price = e;
           

        }

        override public string ToString()
        {
            //return $"Make: {Make}, Model: {Model}, Color: {Color}, Year: {Year}, Price: ${Price}";
            return $"{Make} - {Model} - {Color} - {Year} - ${Price}";
        }
    }
}
