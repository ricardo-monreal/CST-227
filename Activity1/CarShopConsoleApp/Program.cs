using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // show greeting
            Console.WriteLine("################ Welcome to the CST-227 Car store ################");
            
            Store s = new Store();
            // show main menu
            int action = chooseAction();

            // menu options
            while (action !=0)
            {
                Console.WriteLine($"You selected {action}");

                switch (action)
                {
                    // add cars to inventory
                    case 1:
                        Console.WriteLine("\nYou chose to add a car to the inventory");

                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0.0m;

                        Console.WriteLine("\nWhat is the car make? Toyota, Honda, Ford, etc...");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? Corolla, Civic, Mustang, etc...");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);

                        break;

                    // add cars to shopping cart
                    case 2:
                        Console.WriteLine("You chose to add a car to the shopping cart\n");
                        Console.WriteLine("Which car would you like to buy?");
                        // display inventory available for purchase
                        printInventory(s);

                        int carChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.CarList[carChosen]);

                        printShoppingCart(s);

                        break;

                    case 3:

                        printShoppingCart(s);

                        Console.WriteLine($"The total cost of your items is : {s.Checkout()}");


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

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("cars chosen to buy");
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                //Console.WriteLine($"Car: {c.Make}, {c.Model}, {c.Price}");
                Console.WriteLine($"Car #:{i} {s.ShoppingList[i]}");

            }
        }

        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
            {
                //Console.WriteLine($"Car: {c.Make}, {c.Model}, {c.Price}");
                Console.WriteLine($"Car #:{i} {s.CarList[i]}");

            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            bool isValid = false;

            do
            {
              Console.WriteLine("\nChoose an action:\n" +
                  
                  "\n(1) Add a car to inventory\n" +
                  "(2) Add a car to shopping cart\n" +
                  "(3) Checkout\n"+
                  "(0) Exit Application\n");

                isValid = int.TryParse(Console.ReadLine(), out choice)
                      && choice >= 0
                      && choice <= 3;

                    if (!isValid)
                    {
                        Console.WriteLine("Please enter the correct number");
                    }

            } while (!isValid);


            //string input = Console.ReadLine();

            //try
            //{
            //    choice = Int32.Parse(input);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine($"Unable to parse '{input}");

            //}

            //choice = int.Parse(Console.ReadLine());
            return choice;
           
        }
    }
}
