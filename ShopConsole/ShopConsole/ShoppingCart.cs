using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole
{
    internal class ShoppingCart
    {
        private static List<Entities.Item> Items = new();

        public static void AddItem(Entities.Item item)
        {
            Items.Add(item);
        }

        public static void PrintCart()
        {
            foreach (var item in Items)
            {
                Console.WriteLine("Your list in the shopping cart: " + item);
            }
        }
        private static List<Entities.Item> Cost = new();
        public static void TotalCost(Entities.Item Price)
        {

            Cost.Add(Price);
        }

        public static void PrintCost()
        {
            double shoppingCartSum = 0;
            foreach (var price in Items)
            {
                shoppingCartSum = shoppingCartSum + Convert.ToDouble(price.Price);
            }
            Console.WriteLine("*****************************************************");
            Console.WriteLine($"Total cost: EUR {shoppingCartSum} ");
            Console.WriteLine("*****************************************************");

        }


        public static void DeleteCartItems()
        {
            Items.Clear();
        }
    }
}
