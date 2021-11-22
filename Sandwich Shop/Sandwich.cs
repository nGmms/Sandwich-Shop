using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    class Sandwich
    {
        public Sandwich()
        {

        }
        public SandwichBread Bread { get; set; }
        
        public List<SandwichIngredients> Ingredients { get; set; } = new List<SandwichIngredients>();

        public override string ToString()
        {
            string text = "";

            text = Bread.Name + " ";

            foreach (var entry in Ingredients)
                text += entry.Name + ",";

            var price = "$ " + GetPrice().ToString("N2");

            return price + " " + text;
        }
        internal double GetPrice()
        {
            
            double price = 0;
            price += Bread.Price;
            
            //todo
            return price;
        }
    }
}
