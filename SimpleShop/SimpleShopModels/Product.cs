using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShopModels
{
    public class Product
    {
        public int ProductId { get; set; }

        public string productName { get; set; }

        public decimal productPrice { get; set; }

        //Constructor, enters name and price
        public Product(string name, decimal price)
        {
            productName = name;
            productPrice = price;
        }

        //Constructor overload, enters id, name and price
        public Product(int id, string name, decimal price)
        {
            ProductId = id;
            productName = name;
            productPrice = price;
        }
    }
}
