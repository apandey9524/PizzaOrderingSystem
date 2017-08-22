using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class Cart
    {
        public List<Pizza> PizzasInCart { get; private set; }
        public void AddToCart(Pizza pizza)
        {
            PizzasInCart.Add(pizza);
        }
        public void RemoveFromCart(Pizza pizza)
        {
            PizzasInCart.Remove(pizza);
        }
        public string ViewCart()
        {
            string cartDetails=string.Empty;
            foreach(var pizza in PizzasInCart)
            {
                cartDetails=pizza.ViewPizzaDetails();
            }
            return cartDetails;
        }
    }
}
