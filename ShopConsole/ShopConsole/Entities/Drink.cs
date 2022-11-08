using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole.Entities
{
    public class Drink : Item
    {
        public double Litre { get; set; }
        public override string? ToString()
        {
            return $"{Name} in a bottle of {Litre} l";
        }
    }
}
