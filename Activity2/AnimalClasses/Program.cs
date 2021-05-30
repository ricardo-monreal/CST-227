using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            //Animal beast = new Animal();

            //beast.Talk();
            //beast.Greet();
            //beast.Talk();

            Dog pluto = new Dog();

            pluto.Talk();
            pluto.Greet();
            pluto.Sing();
            pluto.Fetch("bone");
            pluto.FeedMe();
            pluto.TouchMe();


            Robin red = new Robin();

            red.Talk();
            red.Greet();
            red.Sing();
            //red.Feth("Worm");
            //red.Feedme();
            //red.TouchMe();


            Bird eagle = new Bird();

            eagle.Glide();
            eagle.Flap();
            eagle.Talk();

            Fish salmon = new Fish();

            salmon.Swim();
            salmon.Upstream("Salmon");


            Console.ReadLine();
        }
    }
}
