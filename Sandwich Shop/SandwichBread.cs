using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    public class SandwichBread
    {
        public SandwichBread()
        {

        }
       public SandwichBread(string name, double price, int maxIngredients)
        {
            Name = name;
            Price = price;
            MaxIngredients = maxIngredients;
            
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public double MaxIngredients { get; set; }


    }

}
