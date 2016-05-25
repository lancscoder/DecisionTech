using System.Collections.Generic;

namespace DecisionTech.Offers
{
    public interface IOfferApplier
    {
        void ApplyOffers(List<BasketItem> basketItems);
    }
}