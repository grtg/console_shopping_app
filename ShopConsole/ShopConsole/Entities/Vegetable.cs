using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole.Entities
{
    public class Vegetable : Item
    {
        public double Fiber { get; set; }
        public override string? ToString()
        {
            return $"{Name} with {Fiber} g of fibers";
        }
    }
}
