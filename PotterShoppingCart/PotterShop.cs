using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShop
    {
        public int CalculateFee(List<Book> books)
        {
            switch (books.Count.ToString())
            {
                case "1":
                    return 100 * books.Count;
                case "2":
                    return 100 * (int)(books.Count*0.95);
                default:
                    return 0;
            }
            
        }
    }
}
