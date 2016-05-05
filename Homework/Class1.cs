using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    public class Cart
    {
        public double CalculatePrice(List<Book> bookIdList, int pricePerBook)
        {
            var distinctIdCount = bookIdList.GroupBy(b => b.id).Count();
            var priceOfDifferentBooks = GetTotalPriceOfDifferentBooks(pricePerBook, distinctIdCount);
            return priceOfDifferentBooks + GetPriceOfDuplicatedBooks(bookIdList, pricePerBook, distinctIdCount);
        }

        private static int GetPriceOfDuplicatedBooks(List<Book> bookIdList, int pricePerBook, int distinctIdCount)
        {
            return (bookIdList.Count - distinctIdCount) * pricePerBook;
        }

        private double GetTotalPriceOfDifferentBooks(int pricePerBook, int distinctIdCount)
        {
            return distinctIdCount * pricePerBook * GetDiscountRate(distinctIdCount);
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
