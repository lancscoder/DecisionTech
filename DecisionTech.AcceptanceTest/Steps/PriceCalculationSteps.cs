using DecisionTech.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace DecisionTech.AcceptanceTest.Steps
{
    [Binding]
    public class PriceCalculationSteps
    {
        private IBasket _basket;

        public PriceCalculationSteps()
        {
            _basket = new Basket();
        }

        [Given(@"the basket has (.*) bread")]
        public void GivenTheBasketHasBread(int quantity)
        {
            _basket.AddProduct(new Bread(), quantity);
        }

        [Given(@"the basket has (.*) butter")]
        public void GivenTheBasketHasButter(int quantity)
        {
            _basket.AddProduct(new Butter(), quantity);
        }

        [Given(@"the basket has (.*) milk")]
        public void GivenTheBasketHasMilk(int quantity)
        {
            _basket.AddProduct(new Milk(), quantity);
        }

        [When(@"I total the basket")]
        public void WhenITotalTheBasket()
        {
            _basket.CalculateTotal();
        }

        [Then(@"the total should be £(.*)")]
        public void ThenTheTotalShouldBe(decimal total)
        {
            Assert.AreEqual(total, _basket.Total);
        }
    }
}
