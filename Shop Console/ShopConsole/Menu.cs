using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopConsole.Entities;
using ShopConsole.Repositories;

namespace ShopConsole
{
    internal class Menu
    {
        public void InitiateMenu()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. Print Sweets");
                Console.WriteLine("2. Print Meats");
                Console.WriteLine("3. Print Drinks");
                Console.WriteLine("4. Print Vegetables");
                Console.WriteLine("5. Buy Sweet");
                Console.WriteLine("6. Buy Meat");
                Console.WriteLine("7. Buy Drink");
                Console.WriteLine("8. Buy Vegetable");
                Console.WriteLine("9. Print cart");
                var input = GetSelection();
                switch (input)
                {
                    case 0:
                        continue;
                    case 1:
                        PrintSweets();
                        break;
                    case 2:
                        PrintMeats();
                        break;
                    case 3:
                        PrintDrinks();
                        break;
                    case 4:
                        PrintVegetables();
                        break;
                    case 5:
                        BuySweet();
                        break;
                    case 6:
                        BuyMeat();
                        break;
                    case 7:
                        BuyDrink();
                        break;
                    case 8:
                        BuyVegetable();
                        break;
                    case 9:
                        ShoppingCart.PrintCart();
                        break;
                }
            }
        }

        public void BuySweet()
        {
            var selectedSweet = GetSelection();
            var sweet = SweetRepository.Sweets[selectedSweet - 1];
            if (sweet is null)
            {
                Console.WriteLine($"Sweet with index {selectedSweet - 1} does not exist");
                return;
            }
            ShoppingCart.AddItem(sweet.ToString());
        }

        public void BuyMeat()
        {
            var selectedMeat = GetSelection();
            var meat = MeatRepository.Meats[selectedMeat - 2];
            if (meat is null)
            {
                Console.WriteLine($"Meat with index {selectedMeat - 2} does not exist");
                return;
            }
            ShoppingCart.AddItem(meat.ToString());
        }

        public void BuyDrink()
        {
            var selectedDrink = GetSelection();
            var drink = DrinkRepository.Drinks[selectedDrink - 3];
            if (drink is null)
            {
                Console.WriteLine($"Drink with index {selectedDrink - 3} does not exist");
                return;
            }
            ShoppingCart.AddItem(drink.ToString());
        }
        public void BuyVegetable()
        {
            var selectedVegetable = GetSelection();
            var vegetable = VegetableRepository.Vegetables[selectedVegetable - 4];
            if (vegetable is null)
            {
                Console.WriteLine($"Vegetable with index {selectedVegetable - 4} does not exist");
                return;
            }
            ShoppingCart.AddItem(vegetable.ToString());
        }
        public void PrintSweets()
        {
            foreach (Sweet sweet in SweetRepository.Sweets)
            {
                Console.WriteLine(sweet);
            }
        }

        public void PrintMeats()
        {
            foreach (Meat meat in MeatRepository.Meats)
            {
                Console.WriteLine(meat);
            }
        }

        public void PrintDrinks()
        {
            foreach (Drink drink in DrinkRepository.Drinks)
            {
                Console.WriteLine(drink);
            }
        }

        public void PrintVegetables()
        {
            foreach (Vegetable vegetable in VegetableRepository.Vegetables)
            {
                Console.WriteLine(vegetable);
            }
        }

        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("Wrong format");
            return 0;
        }
    }
}
