using System.Collections.Generic;

namespace DecisionTech.Discounts
{
    public interface IDiscount
    {
        bool CanApplyDiscount(List<BasketProduct> basketContents);
        void ApplyDiscount(List<BasketProduct> basketContents);
    }
}