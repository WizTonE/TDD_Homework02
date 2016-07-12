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
        public void CalculateFeeTest()
        {
            //arrange
            var expected = 100;
            var target = new PotterShop();
            Books = new List<Book>
            {
                new Book {Series = 1 }
            };

            //act
            var actual = target.CalculateFee<Book>(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }

    public class Book
    {
        public int Series { get; set; }
        public int Cost { get; set; }
        public Book() { Cost = 100; }
    }
}