using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Bird : Animal, IFly
    {
        public Bird()
        {
            // must declare a body
        }

        public void Flap()
        {
            Console.WriteLine("Flapping my wings takes me soaring!!");
        }

        public void Glide()
        {
            Console.WriteLine("Birds glide when scanning for prey");
        }
    }
}
