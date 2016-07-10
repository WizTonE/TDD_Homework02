using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShopTests
    {
        private List<Book> Books { get; set; }

        [TestMethod()]
        public void Buy_One_Book_for_Series1_expected_Fee_is_100()
        {
            //arrange
            var expected = 100;
            var target = new PotterShop();
            Books = new List<Book> {
                new Book {Series = 1 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
        [TestMethod()]
        public void Buy_One_Book_for_Series1_and_2_expected_Fee_is_190()
        {
            //arrange
            var expected = 190;
            var target = new PotterShop();
            Books = new List<Book> {
                new Book {Series = 1 },
                new Book {Series = 2 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void Buy_One_Book_for_Series1_and_2_and_3_expected_Fee_is_270()
        {
            //arrange
            var expected = 270;
            var target = new PotterShop();
            Books = new List<Book> {
                new Book {Series = 1 },
                new Book {Series = 2 },
                new Book {Series = 3 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void Buy_One_Book_for_Series1_and_2_and_3_and_4_expected_Fee_is_320()
        {
            //arrange
            var expected = 320;
            var target = new PotterShop();
            Books = new List<Book> {
                new Book {Series = 1 },
                new Book {Series = 2 },
                new Book {Series = 3 },
                new Book {Series = 4 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

    }

    
}