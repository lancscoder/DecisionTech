using System;
using TechTalk.SpecFlow;

namespace DecisionTech.AcceptanceTest.Steps
{
    [Binding]
    public class PriceCalculationSteps
    {
        [Given(@"the basket has (.*) bread")]
        public void GivenTheBasketHasBread(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the basket has (.*) butter")]
        public void GivenTheBasketHasButter(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the basket has (.*) milk")]
        public void GivenTheBasketHasMilk(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I total the basket")]
        public void WhenITotalTheBasket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the total should be £(.*)")]
        public void ThenTheTotalShouldBe(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
