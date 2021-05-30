using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Dog : Animal, IDomesticated
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor. Good puppy :) ");
        }
        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }
        public override void Sing()
        {
            Console.WriteLine("Hoooowl!");
        }



        public void Fetch(String thing)
        {
            Console.WriteLine($"Oh boy. Here is your {thing}. Let's do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's suppertime, the very best time of the day!");
        }
    }
}
