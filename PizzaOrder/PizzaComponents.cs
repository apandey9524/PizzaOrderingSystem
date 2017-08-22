using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class PizzaComponents
    {
        public static Dictionary<string, float> Toppings = new Dictionary<string, float>()
            {
                {"CheeseOverload",30 },
                {"Olives",40 },
                {"Alapinos",40 },
            };

        public static Dictionary<string, float> Crusts = new Dictionary<string, float>()
            {
                {"FreshPan",30 },
                {"CheeseBurst",40 },
            };
        //TODO: Add methods that can be used by admin only to add pizza components
    }
}
