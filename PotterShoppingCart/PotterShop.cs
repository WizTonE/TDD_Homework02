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
                    return (int)(100 * books.Count * 0.95);
                case "3":
                    return (int)(100 * books.Count * 0.9);
                case "4":
                    return (int)(100 * books.Count * 0.8);
                default:
                    return 0;
            }
            
        }
    }
}
