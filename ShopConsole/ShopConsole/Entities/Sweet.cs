using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole.Entities
{
    internal class Sweet : Item
    {
        public double Sugar { get; set; }
        public override string? ToString()
        {
            return $"{Name} with {Sugar} g of sugar";
        }
    }
}
