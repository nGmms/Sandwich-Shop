using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    class SandwichIngredients
    {
        public SandwichIngredients()
        {

        }
        public SandwichIngredients(string name, double price)
        {
            Name = name;
            Price = price;
           

        }

        public string Name { get; set; }
        public double Price { get; set; }
        
    }
}
