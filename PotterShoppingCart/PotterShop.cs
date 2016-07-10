using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShop
    {
        internal Dictionary<int, double> DiscountList = new Dictionary<int, double>
        {
            {0,0 },
            {1,1 },
            {2,0.95 },
            {3,0.9 },
            {4,0.8 },
            {5,0.75 }
        };
        

        public int CalculateFee(List<Book> OrderList)
        {
            var Fee = 0;

            
            return Fee;
        }
    }
}
