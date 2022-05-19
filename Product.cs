using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginApp
{
    internal class Product
    {

        public int price { get; set; }
        public string name { get; set; }

        public int product_id { get; set; }

        public string category { get; set; }

        public Product(int Product_id, string Name,string Category,int Price)
        {
            price = Price;
            name = Name;
            product_id = Product_id;
            category = Category;
        }

    }
}
