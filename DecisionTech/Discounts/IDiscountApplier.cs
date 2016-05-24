using System.Collections.Generic;

namespace DecisionTech.Discounts
{
    public interface IDiscountApplier
    {
        void ApplyDiscounts(List<BasketProduct> basketProducts);
    }
}