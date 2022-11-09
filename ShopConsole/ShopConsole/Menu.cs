using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ShopConsole.Entities;
using ShopConsole.Repositories;

namespace ShopConsole
{
    internal class Menu
    {
        int moneyValue;

        public void InitiateMenu()
        {
            Console.WriteLine("How much money do you have? Please enter the amount:");
            string money = Console.ReadLine();

            bool success = int.TryParse(money, out moneyValue);
            while (!success)
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine("Please enter the amount:");
                money = Console.ReadLine();
                success = int.TryParse(money, out moneyValue);
            }
            Console.WriteLine($"You have EUR {moneyValue}");
            Console.WriteLine("Press [Enter] to continue...");
            Console.ReadLine();

            bool isAlive = true;
            while (isAlive)
            {
                if (moneyValue > 0)
                {
                    Console.WriteLine("1. Print Drinks");
                    Console.WriteLine("2. Print Meats");
                    Console.WriteLine("3. Print Sweets");
                    Console.WriteLine("4. Print Vegetables");
                    Console.WriteLine("5. Buy Sweet");
                    Console.WriteLine("6. Buy Meat");
                    Console.WriteLine("7. Buy Drink");
                    Console.WriteLine("8. Buy Vegetable");
                    Console.WriteLine("9. Print cart");
                    Console.WriteLine("10. Confirm your purchase");
                    Console.WriteLine("11. Exit");
                }
                else
                {
                    Console.WriteLine("Oops,not enough money to buy new items! You can see the list only.");
                    Console.WriteLine("1. Print Drinks");
                    Console.WriteLine("2. Print Meats");
                    Console.WriteLine("3. Print Sweets");
                    Console.WriteLine("4. Print Vegetables");
                    Console.WriteLine("9. Print cart");
                    Console.WriteLine("10. Confirm your purchase");
                    Console.WriteLine("11. Exit");

                }
                var input = GetSelection();
                switch (input)
                {
                    case 0:
                        continue;
                    case 1:
                        PrintDrinks();
                        break;
                    case 2:
                        PrintMeats();
                        break;
                    case 3:
                        PrintSweets();
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
                        ShoppingCart.PrintCost();
                        break;
                    case 10:
                        ConfirmPurchase();
                        break;
                    case 11:
                        Console.WriteLine("Thank you for visiting our shop!");
                        System.Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("This is not valid choice!");
                        break;
                }

            }

        }
        public void BuyDrink()
        {
            var selectedDrink = GetSelection();
            var drink = DrinkRepository.Drinks[selectedDrink - 1];
            if (drink is null || moneyValue < 0 || drink.Price > moneyValue)
            {
                Console.WriteLine($"Drink with index {selectedDrink - 1} does not exist OR you do not have enough money.");
                return;
            }
            else
            {
                ShoppingCart.AddItem(drink);
                decimal availableMoney = moneyValue - drink.Price;
                Console.WriteLine("You selected: " + drink);
                Console.WriteLine($"You have EUR {availableMoney} left");
                decimal availableMoney1 = availableMoney;
                moneyValue = (int)availableMoney1;
            }
        }

        public void BuyMeat()
        {
            var selectedMeat = GetSelection();
            var meat = MeatRepository.Meats[selectedMeat - 2];
            if (meat is null || moneyValue < 0 || meat.Price > moneyValue)
            {
                Console.WriteLine($"Meat with index {selectedMeat - 2} does not exist or you do not have enough money");
                return;
            }
            else
            {
                ShoppingCart.AddItem(meat);
                decimal availableMoney = moneyValue - meat.Price;
                Console.WriteLine("You selected: " + meat.ToString());
                Console.WriteLine($"You have EUR {availableMoney} left");
                decimal availableMoney1 = availableMoney;
                moneyValue = (int)availableMoney1;
            }

        }

        public void BuySweet()
        {
            var selectedSweet = GetSelection();
            var sweet = SweetRepository.Sweets[selectedSweet - 3];
            if (sweet is null || moneyValue < 0 || sweet.Price > moneyValue)
            {
                Console.WriteLine($"Sweet with index {selectedSweet - 3} does not exist or you do not have enough money.");
                return;
            }
            else
            {
                ShoppingCart.AddItem(sweet);
                decimal availableMoney = moneyValue - sweet.Price;
                Console.WriteLine("You selected: " + sweet);
                Console.WriteLine($"You have EUR {availableMoney} left");
                decimal availableMoney1 = availableMoney;
                moneyValue = (int)availableMoney1;
            }

        }
        public void BuyVegetable()
        {
            var selectedVegetable = GetSelection();
            var vegetable = VegetableRepository.Vegetables[selectedVegetable - 4];
            if (vegetable is null || moneyValue < 0 || vegetable.Price > moneyValue)
            {
                Console.WriteLine($"Vegetable with index {selectedVegetable - 4} does not exist or you do not have enough money.");
                return;
            }
            else
            {
                ShoppingCart.AddItem(vegetable);
                decimal availableMoney = moneyValue - vegetable.Price;
                Console.WriteLine("You selected: " + vegetable);
                Console.WriteLine($"You have EUR {availableMoney} left");
                decimal availableMoney1 = availableMoney;
                moneyValue = (int)availableMoney1;
            }
        }
        public void ConfirmPurchase()
        {
            Console.WriteLine("Your order confirmed");
            Console.WriteLine("*****************************************************");
            ShoppingCart.PrintCart();
            ShoppingCart.PrintCost();
            ShoppingCart.DeleteCartItems();
            Console.WriteLine("Your order was successfuly completed. Thank you for visiting our shop!");
            Console.WriteLine("******************************************************");
        }
        public void PrintSweets()
        {
            foreach (Sweet sweet in SweetRepository.Sweets)
            {
                Console.WriteLine(sweet);
                Console.WriteLine("******************************************************");
            }
        }

        public void PrintMeats()
        {
            foreach (Meat meat in MeatRepository.Meats)
            {
                Console.WriteLine(meat);
                Console.WriteLine("******************************************************");
            }
        }

        public void PrintDrinks()
        {
            foreach (Drink drink in DrinkRepository.Drinks)
            {
                Console.WriteLine(drink);
                Console.WriteLine("******************************************************");
            }
        }

        public void PrintVegetables()
        {
            foreach (Vegetable vegetable in VegetableRepository.Vegetables)
            {
                Console.WriteLine(vegetable);
                Console.WriteLine("******************************************************");
            }
        }
        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("Wrong format.");
            return 0;

        }
    }

}

   
  

