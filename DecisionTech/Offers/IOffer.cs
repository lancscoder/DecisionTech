using System.Collections.Generic;

namespace DecisionTech.Offers
{
    public interface IOffer
    {
        bool CanApplyOffer(List<BasketItem> basketItems);
        void ApplyOffer(List<BasketItem> basketItems);
    }
}