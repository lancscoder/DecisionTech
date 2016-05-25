using System.Collections.Generic;

namespace DecisionTech.Offers
{
    public class OfferApplier : IOfferApplier
    {
        private  readonly List<IOffer> _offers;

        public OfferApplier()
            :this(new List<IOffer> { new BreadOffer(), new MilkOffer()})
        {
        }

        public OfferApplier(List<IOffer> offers)
        {
            _offers = offers;
        }

        public void ApplyOffers(List<BasketItem> basketItems)
        {
            foreach (var offer in _offers)
            {
                while (offer.CanApplyOffer(basketItems))
                {
                    offer.ApplyOffer(basketItems);
                }
            }
        }
    }
}