using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class Book
    {
        public int Series { get; set; }
        public int Cost { get; set; }
        public Book()
        {
            Cost = 100;
        }
    }
}
