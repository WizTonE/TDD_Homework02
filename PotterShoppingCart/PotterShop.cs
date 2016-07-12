using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShop
    {
        internal Dictionary<int, double> discountList = new Dictionary<int, double>
        {
            {0,0 },
            {1,1 },
            {2,0.95 },
            {3,0.9 },
            {4,0.8 },
            {5,0.75 }
        };

        public int CalculateFee(List<Book> books)
        {
            return (int)(100 * books.Count * discountList[books.Count]);
        }
    }
}
