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
        private List<Book> Bootlist { get; set; }

        [TestMethod()]
        public void CalculateFeeTest()
        {
            //arrange
            var target = new PotterShop();

            //act
            var actual = target.CalculateFee<Book>(Bootlist);

            //assert
            Assert.Fail();
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}