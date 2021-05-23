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
                //Console.WriteLine($"You selected {action}");

                switch (action)
                {
                    // add cars to inventory
                    case 1:
                        Console.WriteLine("\n#### You chose to add a car to the inventory ####");

                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0.0m;
                        string carColor = "";
                        //bool carCondition = false;
                        int carYear = 0;


                        Console.WriteLine("\nWhat is the car make? Toyota, Honda, Ford, etc...");
                        carMake = Console.ReadLine();

                        Console.WriteLine("\nWhat is the car model? Corolla, Civic, Mustang, etc...");
                        carModel = Console.ReadLine();

                        // console coding challenge
                        Console.WriteLine("\nWhat is the color of the car?");
                        carColor = Console.ReadLine();


                        Console.WriteLine("\nWhat year is the car? ");
                        while (!int.TryParse(Console.ReadLine(), out carYear))
                        {
                            Console.WriteLine("\nPlease select a correct number: ");
                        }

                        Console.WriteLine("\nWhat is the car price?");
                        //carPrice = int.Parse(Console.ReadLine());
                        while (!decimal.TryParse(Console.ReadLine(), out carPrice))
                        {
                            Console.WriteLine("\nPlease select a correct number: ");
                           
                        }



                        // add car to the inventory list
                        
                        Car newCar = new Car(carMake, carModel, carPrice, carColor, carYear);
                        s.CarList.Add(newCar);
                        Console.WriteLine("\nThe following car was added to the inventory.\n");
                        printInventory(s);

                        break;

                    // add cars to shopping cart
                    case 2:
                        Console.WriteLine("####  You chose to add a car to the shopping cart #### \n");

                        Console.WriteLine("\nWhich car would you like to buy?");
                        // display inventory available for purchase
                        printInventory(s);
                     
                        int carChosen;

                        while (!int.TryParse(Console.ReadLine(), out carChosen))
                        {
                            Console.WriteLine("\nPlease select a correct number: ");
                            printInventory(s);
                        }
                        s.ShoppingList.Add(s.CarList[carChosen]);

    



                        printShoppingCart(s);

                        break;

                    case 3:
                        Console.WriteLine("####  You chose to buy the following cars #### \n");
                        printShoppingCart(s);

                        Console.WriteLine($"The total cost of your purchase is : {s.Checkout()}");
                        Console.WriteLine("Thanks for shopping with us!");
                      


                        break;
                    default:
                        break;
                }
                action = chooseAction();
            
            }

            
        }

        // print  items in shopping cart
        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("cars chosen to buy");
            
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine($"Car #:{i} {s.ShoppingList[i]}");

            }
        }

        // print car inventory
        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine($"Car #:{i} {s.CarList[i]}");

            }
        }

        // main menu
        // will require a valid number input
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

            return choice;
           
        }

      
    }
}
