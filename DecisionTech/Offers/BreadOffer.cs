using System;
using System.Collections.Generic;
using System.Linq;
using DecisionTech.Products;

namespace DecisionTech.Offers
{
    public class BreadOffer : IOffer
    {
        private readonly Func<BasketItem, bool> _butterOfferCondition = b => b.Product.GetType() == typeof(Butter) && !b.IsOfferApplied;
        private readonly Func<BasketItem, bool> _breadOfferCondition = b => b.Product.GetType() == typeof(Bread) && !b.IsOfferApplied;

        public bool CanApplyOffer(List<BasketItem> basketItems)
        {
            return basketItems.Count(_butterOfferCondition) >= 2 &&
                   basketItems.Count(_breadOfferCondition) >= 1;
        }

        public void ApplyOffer(List<BasketItem> basketItems)
        {
            if (!CanApplyOffer(basketItems)) return;

            var butters = basketItems.Where(_butterOfferCondition).Take(2);

            foreach (var butter in butters)
            {
                butter.IsOfferApplied = true;
            }

            var bread = basketItems.FirstOrDefault(_breadOfferCondition);

            bread.Price = bread.Price * 0.5m;
            bread.IsOfferApplied = true;

        }
    }
}