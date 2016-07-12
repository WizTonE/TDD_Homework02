using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpectedObjects;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShopTests
    {
        private List<Book> Books { get; set; }

        [TestMethod()]
        public void Buy_Series1_and_expected_fee_is_100()
        {
            //arrange
            var expected = 100;
            var target = new PotterShop();
            Books = new List<Book>
            {
                new Book {Series = 1 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void Buy_Series1_Series2_and_expected_fee_is_190()
        {
            //arrange
            var expected = 190;
            var target = new PotterShop();
            Books = new List<Book>
            {
                new Book {Series = 1 },
                new Book {Series = 2 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void Buy_Series1_Series2_Series3_and_expected_fee_is_270()
        {
            //arrange
            var expected = 270;
            var target = new PotterShop();
            Books = new List<Book>
            {
                new Book {Series = 1 },
                new Book {Series = 2 },
                new Book {Series = 3 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }

    
}