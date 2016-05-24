using System;
using System.Collections.Generic;
using System.Linq;
using DecisionTech.Products;

namespace DecisionTech.Discounts
{
    public class MilkDiscount : IDiscount
    {
        private readonly Func<BasketProduct, bool> _discountCondition =
            b => b.Product.GetType() == typeof (Milk) && !b.DiscountApplied;

        public bool CanApplyDiscount(List<BasketProduct> basketContents)
        {
            return basketContents.Count(_discountCondition) >= 4;
        }

        public void ApplyDiscount(List<BasketProduct> basketContents)
        {
            if (!CanApplyDiscount(basketContents)) return;
            
            var milks = basketContents
                .Where(_discountCondition)
                .Take(4)
                .ToList();

            milks[0].BasketPrice = 0m;

            foreach (var basketProduct in milks)
            {
                basketProduct.DiscountApplied = true;
            }
        }
    }
}