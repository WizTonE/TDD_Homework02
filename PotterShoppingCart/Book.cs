using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class Book
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public Book()
        {
            Cost = 100;
        }
    }
}
