using System;
using System.Collections.Generic;
using DecisionTech.Discounts;
using DecisionTech.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecisionTech.Tests.Discounts
{
    [TestClass]
    public class BreadDiscountTests
    {
        [TestMethod]
        public void Can_Apply_Discount_Returns_True_When_Basket_Contains_Exact_Quantities()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Bread()));

            var breadDiscount = new BreadDiscount();

            // Act
            var canApplyDiscount = breadDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsTrue(canApplyDiscount);
        }

        [TestMethod]
        public void Can_Apply_Discount_Returns_True_When_Basket_Contains_Extra_Bread()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Bread()));
            contents.Add(new BasketProduct(new Bread()));

            var breadDiscount = new BreadDiscount();

            // Act
            var canApplyDiscount = breadDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsTrue(canApplyDiscount);
        }

        [TestMethod]
        public void Can_Apply_Discount_Returns_True_When_Basket_Contains_Extra_Butter()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Bread()));

            var breadDiscount = new BreadDiscount();

            // Act
            var canApplyDiscount = breadDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsTrue(canApplyDiscount);
        }

        [TestMethod]
        public void Can_Apply_Discount_Returns_True_When_Basket_Contains_Extra_Bread_And_Butter()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Bread()));

            var breadDiscount = new BreadDiscount();

            // Act
            var canApplyDiscount = breadDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsTrue(canApplyDiscount);
        }

        [TestMethod]
        public void Can_Apply_Discount_Returns_False_When_Basket_Does_Not_Contains_Enough_Bread()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Butter()));

            var breadDiscount = new BreadDiscount();

            // Act
            var canApplyDiscount = breadDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsFalse(canApplyDiscount);
        }

        [TestMethod]
        public void Can_Apply_Discount_Returns_False_When_Basket_Does_Not_Contains_Enough_Butter()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Butter()));
            contents.Add(new BasketProduct(new Bread()));

            var breadDiscount = new BreadDiscount();

            // Act
            var canApplyDiscount = breadDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsFalse(canApplyDiscount);
        }
    }

    [TestClass]
    public class MilkDiscountTests
    {
        [TestMethod]
        public void Can_Apply_Discount_Returns_True_When_Basket_Contains_Exact_Quantities()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));

            var milkDiscount = new MilkDiscount();

            // Act
            var canApplyDiscount = milkDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsTrue(canApplyDiscount);
        }

        [TestMethod]
        public void Can_Apply_Discount_Returns_True_When_Basket_Contains_Extra_Milk()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));

            var milkDiscount = new MilkDiscount();

            // Act
            var canApplyDiscount = milkDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsTrue(canApplyDiscount);
        }

        [TestMethod]
        public void Can_Apply_Discount_Returns_False_When_Basket_Does_Not_Contains_Enough_Milk()
        {
            // Arrange
            var contents = new List<BasketProduct>();
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));
            contents.Add(new BasketProduct(new Milk()));

            var milkDiscount = new MilkDiscount();

            // Act
            var canApplyDiscount = milkDiscount.CanApplyDiscount(contents);

            // Assert
            Assert.IsFalse(canApplyDiscount);
        }
    }
}
