using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class Order
    {
        public Cart Cart { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime DateTime { get; private set; }
        public float TotalPrice  { get;private set; }
        public Order(Cart cart,Customer customer)
        {
            this.Cart = cart;
            this.Customer = customer;
            this.DateTime=DateTime.Now;
        }

    }
}
