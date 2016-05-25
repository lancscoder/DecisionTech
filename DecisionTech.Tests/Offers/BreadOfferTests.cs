using System.Collections.Generic;
using DecisionTech.Offers;
using DecisionTech.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecisionTech.Tests.Offers
{
    [TestClass]
    public class BreadOfferTests
    {
        [TestMethod]
        public void Can_Apply_Offer_Returns_True_When_Basket_Contains_Exact_Quantities()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Bread()));

            var breadOffer = new BreadOffer();

            // Act
            var canApplyOffer = breadOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsTrue(canApplyOffer);
        }

        [TestMethod]
        public void Can_Apply_Offer_Returns_True_When_Basket_Contains_Extra_Bread()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Bread()));
            contents.Add(new BasketItem(new Bread()));

            var breadOffer = new BreadOffer();

            // Act
            var canApplyOffer = breadOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsTrue(canApplyOffer);
        }

        [TestMethod]
        public void Can_Apply_Offer_Returns_True_When_Basket_Contains_Extra_Butter()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Bread()));

            var breadOffer = new BreadOffer();

            // Act
            var canApplyOffer = breadOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsTrue(canApplyOffer);
        }

        [TestMethod]
        public void Can_Apply_Offer_Returns_True_When_Basket_Contains_Extra_Bread_And_Butter()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Bread()));

            var breadOffer = new BreadOffer();

            // Act
            var canApplyOffer = breadOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsTrue(canApplyOffer);
        }

        [TestMethod]
        public void Can_Apply_Offer_Returns_False_When_Basket_Does_Not_Contains_Enough_Bread()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Butter()));

            var breadOffer = new BreadOffer();

            // Act
            var canApplyOffer = breadOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsFalse(canApplyOffer);
        }

        [TestMethod]
        public void Can_Apply_Offer_Returns_False_When_Basket_Does_Not_Contains_Enough_Butter()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Butter()));
            contents.Add(new BasketItem(new Bread()));

            var brwadOffer = new BreadOffer();

            // Act
            var canApplyOffer = brwadOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsFalse(canApplyOffer);
        }
    }
}
