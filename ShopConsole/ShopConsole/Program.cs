using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using ShopConsole;
using ShopConsole.Entities;
using ShopConsole.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        var sweetRepository = new SweetRepository();
        var meatRepository = new MeatRepository();
        var drinkRepository = new DrinkRepository();
        var vegetableRepository = new VegetableRepository();

        var menu = new Menu();
        menu.InitiateMenu();
    }
}