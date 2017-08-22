using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class Customer
    {
        public string NameOfCustomer { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address address { get; private set; }

        public void SetCustomerName(string name)
        {
            NameOfCustomer = name;
        }
        public void SetCustomerPhoneNumber(string phoneNumber)
        {
            PhoneNumber=phoneNumber;
        }
        public void SetCustomerAddress()
        {
            //TODO: take individual validation methods
        }
    }
}
