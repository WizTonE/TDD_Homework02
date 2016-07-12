using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShop
    {
        private Dictionary<int, double> DiscountList = new Dictionary<int, double>//同系列每本一本時的書本數量與折扣
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
            var DuplicateList = OrderList.GroupBy(grp => grp.Series).SelectMany(x => x.Skip(1)).ToList();//取得重複的書集合
            if (DuplicateList.Count() > 0)//如果尚有重複的書, 則再次取得重複的書集合
            {
                Fee += CalculateFee(DuplicateList);
            }

            var SeriesGroupList = OrderList.GroupBy(grp => grp.Series).SelectMany(x => x.Take(1)).ToList();//取得系列中每本一本的書集合
            Fee += (int)(SeriesGroupList.Count() * SeriesGroupList.FirstOrDefault().Cost * DiscountList[SeriesGroupList.Count()]);//計算同系列每本一本時的價錢
            return Fee;
        }

    }
}
