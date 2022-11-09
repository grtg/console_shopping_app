using ShopConsole.Entities;

namespace ShopConsole
{
    internal class CsvService
    {
        private string SweetsPath = "Sweets.csv";
        private string MeatsPath = "Meats.csv";
        private string DrinksPath = "Drinks.csv";
        private string VegetablesPath = "Vegetables.csv";
        public List<Sweet> ReadSweets()
        {
            string mainDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string text = File.ReadAllText(Path.Combine(mainDir,SweetsPath));

            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            

            var sweets = new List<Sweet>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] itemDataArray = lines[i].Split(',');
                var sweet = new Sweet
                {
                    Name = itemDataArray[0],
                    Price = Convert.ToDecimal(itemDataArray[1]),
                    Barcode = itemDataArray[2],
                    Weight = Convert.ToDouble(itemDataArray[3]),
                    Sugar = Convert.ToDouble(itemDataArray[4])
                };

                sweets.Add(sweet);
            }

            return sweets;
        }

        public List<Meat> ReadMeats()
        {
            string mainDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string text = File.ReadAllText(Path.Combine(mainDir, MeatsPath));

            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var meats = new List<Meat>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] itemDataArray = lines[i].Split(',');
                var meat = new Meat
                {
                    Name = itemDataArray[0],
                    Price = Convert.ToDecimal(itemDataArray[1]),
                    Barcode = itemDataArray[2],
                    Weight = Convert.ToDouble(itemDataArray[3]),
                    Protein = Convert.ToDouble(itemDataArray[4])
                };

                meats.Add(meat);
            }

            return meats;
        }
        public List<Drink> ReadDrinks()
        {
            string mainDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string text = File.ReadAllText(Path.Combine(mainDir, DrinksPath));

            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var drinks = new List<Drink>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] itemDataArray = lines[i].Split(',');
                var drink = new Drink
                {
                    Name = itemDataArray[0],
                    Price = Convert.ToDecimal(itemDataArray[1]),
                    Barcode = itemDataArray[2],
                    Weight = Convert.ToDouble(itemDataArray[3]),
                    Litre = Convert.ToDouble(itemDataArray[4])
                };

                drinks.Add(drink);
            }

            return drinks;
        }
        public List<Vegetable> ReadVegetables()
        {
            string mainDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string text = File.ReadAllText(Path.Combine(mainDir, VegetablesPath));

            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var vegetables = new List<Vegetable>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] itemDataArray = lines[i].Split(',');
                var vegetable = new Vegetable
                {
                    Name = itemDataArray[0],
                    Price = Convert.ToDecimal(itemDataArray[1]),
                    Barcode = itemDataArray[2],
                    Weight = Convert.ToDouble(itemDataArray[3]),
                    Fiber = Convert.ToDouble(itemDataArray[4])
                };

                vegetables.Add(vegetable);
            }

            return vegetables;
        }

    }
}