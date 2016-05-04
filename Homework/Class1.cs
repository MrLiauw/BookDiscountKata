using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    public class Cart
    {
        public double CalculatePrice(List<Book> bookIdList, int pricePerBook)
        {
            int distinctIdCount = bookIdList.GroupBy(b => b.id).Count();
            double price = distinctIdCount * pricePerBook * GetDiscountRate(distinctIdCount);
            return price + (bookIdList.Count - distinctIdCount) * pricePerBook;
        }

        private double GetDiscountRate(int distinctIdCount)
        {
            switch (distinctIdCount)
            {
                case 1:
                    return 1;
                case 2:
                    return 0.95;
                case 3:
                    return 0.9;
                case 4:
                    return 0.8;
                case 5:
                    return 0.75;
                default:
                    return 1;
            }
        }
    }

    public class Book
    {
        public int id;
    }
}
