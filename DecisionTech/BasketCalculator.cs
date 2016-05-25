using System.Collections.Generic;
using System.Linq;
using DecisionTech.Offers;

namespace DecisionTech
{
    public class BasketCalculator : IBasketCalculator
    {
        private readonly IOfferApplier _offerApplier;

        public BasketCalculator()
            : this(new OfferApplier())
        {
        }

        public BasketCalculator(IOfferApplier offerApplier)
        {
            _offerApplier = offerApplier;
        }

        public decimal CalculateTotal(List<BasketItem> basketItems)
        {
            _offerApplier.ApplyOffers(basketItems);

            return basketItems.Sum(b => b.Price);
        }
    }
}