using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        // inventory list
        public List<Car> CarList { get; set; }

        // Shopping cart list
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            //initialize lists
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;
            foreach (var c in ShoppingList)
            {
                totalCost = totalCost + c.Price;
            }

            ShoppingList.Clear();
            return totalCost;
        }
    }
}
