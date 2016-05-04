using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Homework.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CalculatePrice_1_Book_Should_Return_100()
        {
            //arrange
            var target = new Cart();
            var bookList = new List<Book>(){new Book(){id=1}};
            var pricePerBook = 100;

            var expected = 100;

            //act
            var actual = target.CalculatePrice(bookList, pricePerBook);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePrice_2_Same_Book_Should_Return_200()
        {
            //arrange
            var target = new Cart();
            var bookList = new List<Book>() { 
                new Book() { id = 1}, 
                new Book() { id = 1} 
            };
            var pricePerBook = 100;

            var expected = 200;

            //act
            var actual = target.CalculatePrice(bookList, pricePerBook);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePrice_Book1_Book2_Should_Return_190()
        {
            //arrange
            var target = new Cart();
            var bookList = new List<Book>() { 
                new Book() { id = 1}, 
                new Book() { id = 2} 
            };
            var pricePerBook = 100;

            var expected = 190;

            //act
            var actual = target.CalculatePrice(bookList, pricePerBook);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePrice_3_SameBook_Should_Return_300()
        {
            //arrange
            var target = new Cart();
            var bookList = new List<Book>() { 
                new Book() { id = 1}, 
                new Book() { id = 1},
                new Book() { id = 1}
            };
            var pricePerBook = 100;

            var expected = 300;

            //act
            var actual = target.CalculatePrice(bookList, pricePerBook);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePrice_2_Book1_1_Book2_Should_Return_290()
        {
            //arrange
            var target = new Cart();
            var bookList = new List<Book>() { 
                new Book() { id = 1}, 
                new Book() { id = 1},
                new Book() { id = 2}
            };
            var pricePerBook = 100;

            var expected = 290;

            //act
            var actual = target.CalculatePrice(bookList, pricePerBook);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePrice_Book1_Book2_Book3_Should_Return_270()
        {
            //arrange
            var target = new Cart();
            var bookList = new List<Book>() { 
                new Book() { id = 1}, 
                new Book() { id = 2},
                new Book() { id = 3}
            };
            var pricePerBook = 100;

            var expected = 270;

            //act
            var actual = target.CalculatePrice(bookList, pricePerBook);

            Assert.AreEqual(expected, actual);
        }
    }
}
