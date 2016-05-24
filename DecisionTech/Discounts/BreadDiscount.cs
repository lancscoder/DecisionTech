using System;
using System.Collections.Generic;
using System.Linq;
using DecisionTech.Products;

namespace DecisionTech.Discounts
{
    public class BreadDiscount : IDiscount
    {
        private readonly Func<BasketProduct, bool> _butterDiscountCondition = b => b.Product.GetType() == typeof(Butter) && !b.DiscountApplied;
        private readonly Func<BasketProduct, bool> _breadDiscountCondition = b => b.Product.GetType() == typeof(Bread) && !b.DiscountApplied;

        public bool CanApplyDiscount(List<BasketProduct> basketContents)
        {
            return basketContents.Count(_butterDiscountCondition) >= 2 &&
                   basketContents.Count(_breadDiscountCondition) >= 1;
        }

        public void ApplyDiscount(List<BasketProduct> basketContents)
        {
            if (!CanApplyDiscount(basketContents)) return;

            var butters = basketContents.Where(_butterDiscountCondition).Take(2);

            foreach (var butter in butters)
            {
                butter.DiscountApplied = true;
            }

            var bread = basketContents.FirstOrDefault(_breadDiscountCondition);

            bread.BasketPrice = bread.BasketPrice * 0.5m;
            bread.DiscountApplied = true;

        }
    }
}