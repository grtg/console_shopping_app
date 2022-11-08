using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopConsole.Entities;

namespace ShopConsole.Repositories
{
    internal class SweetRepository
    {
        private CsvService Service = new CsvService();
        public static List<Sweet> Sweets { get; set; }

        public SweetRepository()
        {
            Sweets = Service.ReadSweets();
        }
    }
}
