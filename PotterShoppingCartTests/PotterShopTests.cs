﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod()]
        public void Buy_Series1_Series2_Series3_Series4_and_expected_fee_is_320()
        {
            //arrange
            var expected = 320;
            var target = new PotterShop();
            Books = new List<Book>
            {
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

        [TestMethod()]
        public void Buy_Series1_Series2_Series3_Series4_Series5_and_expected_fee_is_375()
        {
            //arrange
            var expected = 375;
            var target = new PotterShop();
            Books = new List<Book>
            {
                new Book {Series = 1 },
                new Book {Series = 2 },
                new Book {Series = 3 },
                new Book {Series = 4 },
                new Book {Series = 5 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void Buy_Series1_Series2_Series3_Series3_and_expected_fee_is_370()
        {
            //arrange
            var expected = 370;
            var target = new PotterShop();
            Books = new List<Book>
            {
                new Book {Series = 1 },
                new Book {Series = 2 },
                new Book {Series = 3 },
                new Book {Series = 3 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void Buy_Series1_Series2_Series2_Series3_Series3_and_expected_fee_is_460()
        {
            //arrange
            var expected = 460;
            var target = new PotterShop();
            Books = new List<Book>
            {
                new Book {Series = 1 },
                new Book {Series = 2 },
                new Book {Series = 2 },
                new Book {Series = 3 },
                new Book {Series = 3 }
            };

            //act
            var actual = target.CalculateFee(Books);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }

    
}