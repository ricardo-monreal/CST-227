using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the CST-227 Car store.");

            Store s = new Store();
            int action = chooseAction();

            while (action !=0)
            {
                Console.WriteLine($"You selected {action}");

                switch (action)
                {
                    case 1:
                        Console.WriteLine("YOu chose to add a car to the inventory");

                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0.0m;

                        Console.WriteLine("What is the car make? Toyota, Honda, Ford, etc...");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? Corolla, Civic, Mustang, etc...");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);

                        break;


                    default:
                        break;
                }
                action = chooseAction();
            }

            //Car c = new Car("Honda", "Civic", 21000);
            //Car d = new Car("Toyota", "Corolla", 19000);

            //Console.WriteLine($"Car C is as follows: {c.Make}, {c.Model}, ${c.Price}");
            //Console.WriteLine($"Car d is as follows: {d.Make}, {d.Model}, ${d.Price}");

            //Store s = new Store();

            //s.ShoppingList.Add(c);
            //s.ShoppingList.Add(d);

            //decimal total = s.Checkout();

            //Console.WriteLine($"Store value is ${total}");

            //Console.ReadLine();
        }

        private static void printInventory(Store s)
        {
            foreach (Car c in s.CarList)
            {
                //Console.WriteLine($"Car: {c.Make}, {c.Model}, {c.Price}");
                Console.WriteLine($"Car: {c}");

            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action: (0) to quit, (1) to add a new car to the inventory, (2) add car to shopping cart, (3) to checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
