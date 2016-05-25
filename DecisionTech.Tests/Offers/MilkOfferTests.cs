using System.Collections.Generic;
using DecisionTech.Offers;
using DecisionTech.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecisionTech.Tests.Offers
{
    [TestClass]
    public class MilkOfferTests
    {
        [TestMethod]
        public void Can_Apply_Offer_Returns_True_When_Basket_Contains_Exact_Quantities()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));

            var milkOffer = new MilkOffer();

            // Act
            var canApplyOffer = milkOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsTrue(canApplyOffer);
        }

        [TestMethod]
        public void Can_Apply_Offer_Returns_True_When_Basket_Contains_Extra_Milk()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));

            var milkOffer = new MilkOffer();

            // Act
            var canApplyOffer = milkOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsTrue(canApplyOffer);
        }

        [TestMethod]
        public void Can_Apply_Offer_Returns_False_When_Basket_Does_Not_Contains_Enough_Milk()
        {
            // Arrange
            var contents = new List<BasketItem>();
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));
            contents.Add(new BasketItem(new Milk()));

            var milkOffer = new MilkOffer();

            // Act
            var canApplyOffer = milkOffer.CanApplyOffer(contents);

            // Assert
            Assert.IsFalse(canApplyOffer);
        }
    }
}