using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShop
    {
        public int CalculateFee<T>(List<T> books)
        {
            return 100 * books.Count;
        }
    }
}
