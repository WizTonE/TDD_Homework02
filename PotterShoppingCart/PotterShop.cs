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
            var GroupList = OrderList
                .Select((b, i) => new { index = i, value = b.Name, cost = b.Cost })
                .GroupBy(grp => grp.value)
                .Select(grp => new
                {
                    Name = grp.Select(v => v.value).FirstOrDefault(),
                    Count = grp.Select(i => i.index).Count(),
                    Cost = grp.Select(i => i.cost).FirstOrDefault()
                }).ToList();

            GroupList.ForEach(x => { Fee = (int)(x.Cost * DiscountList[x.Count > 1 ? x.Count - 1 : 0]); });

            Fee += (int)(GroupList.Count() * 100 * DiscountList[GroupList.Count]);

            return Fee;
        }
    }
}
