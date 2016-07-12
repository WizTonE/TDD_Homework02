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
            var fee = 0;
            var distinctBooks = books.GroupBy(x => x.Series).SelectMany(x => x.Take(1)).ToList();
            var duplicateBooks = books.GroupBy(x => x.Series).SelectMany(x => x.Skip(1)).ToList();
            if(duplicateBooks.Count > 0)
            {
                fee += CalculateFee(duplicateBooks);
            }
            
            fee += (int)(distinctBooks.FirstOrDefault().Cost
                * distinctBooks.Count * discountList[distinctBooks.Count]);
            return fee;
        }
    }
}
