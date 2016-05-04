using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Cart
    {
        public int CalculatePrice(List<Book> bookIdList, int pricePerBook)
        {
            var price = 0;
            int distinctIdCount = bookIdList.GroupBy(b => b.id).Count();
            if (distinctIdCount == 1)
            {
                price = 100;
            }
            if (distinctIdCount == 2)
            {
                price = 190;
            }
            if (distinctIdCount == 3)
            {
                price = 270;
            }
            if (distinctIdCount == 4)
            {
                price = 320;
            }
            if (distinctIdCount == 5)
            {
                price = 375;
            }
            return price + (bookIdList.Count - distinctIdCount) * 100;
        }
    }

    public class Book
    {
        public int id;
    }
}
