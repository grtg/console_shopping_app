using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole
{
    internal class ShoppingCart
    {
        private static List<string> Items = new();

        public static void AddItem(string item)
        {
            Items.Add(item);
        }

        public static void PrintCart()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}