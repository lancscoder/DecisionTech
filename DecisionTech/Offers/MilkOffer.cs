using System;
using System.Collections.Generic;
using System.Linq;
using DecisionTech.Products;

namespace DecisionTech.Offers
{
    public class MilkOffer : IOffer
    {
        private readonly Func<BasketItem, bool> _offerCondition =
            b => b.Product.GetType() == typeof (Milk) && !b.IsOfferApplied;

        public bool CanApplyOffer(List<BasketItem> basketItems)
        {
            return basketItems.Count(_offerCondition) >= 4;
        }

        public void ApplyOffer(List<BasketItem> basketItems)
        {
            if (!CanApplyOffer(basketItems)) return;
            
            var milks = basketItems
                .Where(_offerCondition)
                .Take(4)
                .ToList();

            milks[0].Price = 0m;

            foreach (var basketProduct in milks)
            {
                basketProduct.IsOfferApplied = true;
            }
        }
    }
}