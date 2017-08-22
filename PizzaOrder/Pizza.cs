using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class Pizza
    {
        public string crust { get; private set; }
        public List<string> toppings { get;private set; }
        public float price { get; private set; }
        public string ViewPizzaDetails()
        {
            //TODO:return pizza by looping in toppings along with price of each individual element as well as subtotal
            return string.Empty;
        }
    }
}
