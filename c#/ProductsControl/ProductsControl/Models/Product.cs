using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsControl.Models
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int inventory { get; set; }
        public double price { get; set; }
    }
}
