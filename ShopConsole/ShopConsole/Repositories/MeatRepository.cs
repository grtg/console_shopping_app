﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopConsole.Entities;

namespace ShopConsole.Repositories
{
    internal class MeatRepository
    {
        private CsvService Service = new CsvService();
        public static List<Meat> Meats;

        public MeatRepository()
        {
            Meats = Service.ReadMeats();
        }
    }
}
