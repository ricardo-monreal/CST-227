using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Fish : Animal, ISwim
    {
        public Fish()
        {

        }

        public void Swim()
        {
            Console.WriteLine("All fish swim");
        }

        public void Upstream(string name)
        {
            Console.WriteLine($"Some fish like {name} swim upstream to find breeding grouds");
            
        }

        public void Upstream()
        {
            Console.WriteLine("Fish can also swim upstream");
        }
    }
}
