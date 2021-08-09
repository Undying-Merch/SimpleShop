using System;
using System.Collections.Generic;

namespace SimpleShopModels
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string customerName { get; set; }

        public List<Order> Orders { get; set; }

        //Constructor, takes name
        public Customer(string name)
        {
            customerName = name;
        }

        //Cunstrocter overload, takes ID and name
        public Customer(int id, string name)
        {
            CustomerId = id;
            customerName = name;
        }
    }
}
