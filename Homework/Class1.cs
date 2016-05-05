using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    public class Cart
    {
        public double CalculatePrice(List<Book> bookIdList, int pricePerBook)
        {
            var uniqueBooksCount = bookIdList.GroupBy(b => b.id).Count();
            var priceOfUniqueBooks = GetTotalPriceOfUniqueBooks(pricePerBook, uniqueBooksCount);
            return priceOfUniqueBooks + GetTotalPriceOfDuplicatedBooks(bookIdList, pricePerBook, uniqueBooksCount);
        }

        private static int GetTotalPriceOfDuplicatedBooks(List<Book> bookIdList, int pricePerBook, int uniqueBooksCount)
        {
            return (bookIdList.Count - uniqueBooksCount) * pricePerBook;
        }

        private double GetTotalPriceOfUniqueBooks(int pricePerBook, int uniqueBooksCount)
        {
            return uniqueBooksCount * pricePerBook * GetDiscountRate(uniqueBooksCount);
        }

        private double GetDiscountRate(int uniqueBooksCount)
        {
            switch (uniqueBooksCount)
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
