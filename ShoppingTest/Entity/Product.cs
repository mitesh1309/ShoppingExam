using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTest.Entity
{
    public class Product
    {
        private string sku;
        private string name;
        private decimal price;
        public Product(string sku, string name, decimal price)
        {
            this.sku = sku;
            this.name = name;
            this.price = price;
        }
        public decimal getPrice()
        {
            return price;
        }
    }

}
