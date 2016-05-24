using System.CodeDom;
using System.Collections.Generic;

namespace DecisionTech.Discounts
{
    public class DiscountApplier : IDiscountApplier
    {
        private  readonly List<IDiscount> _discounts;

        public DiscountApplier()
            :this(new List<IDiscount>() { new BreadDiscount(), new MilkDiscount()})
        {
        }

        public DiscountApplier(List<IDiscount> discounts)
        {
            _discounts = discounts;
        }

        public void ApplyDiscounts(List<BasketProduct> basketProducts)
        {
            foreach (var discount in _discounts)
            {
                while (discount.CanApplyDiscount(basketProducts))
                {
                    discount.ApplyDiscount(basketProducts);
                }
            }
        }
    }
}