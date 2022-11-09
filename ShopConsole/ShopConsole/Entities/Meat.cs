using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole.Entities
{
    public class Meat : Item
    {
        public double Protein { get; set; }
        public override string? ToString()
        {
            return $"{Name} with {Protein} g of proteins which costs EUR {Price}";
        }
    }
}
