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
        public void Buy_One_Book_for_Series01_expected_Fee_is_100()
        {
            //arrange
            var expected = 100;
            var target = new PotterShop();
            Books = new List<Book> {
                new Book {Name = "Series01" }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
        [TestMethod()]
        public void Buy_One_Book_for_Series01_and_Series02_expected_Fee_is_190()
        {
            //arrange
            var expected = 190;
            var target = new PotterShop();
            Books = new List<Book> {
                new Book {Name = "Series01" },
                new Book {Name = "Series02" }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

       

    }

    
}