using System.Collections.Generic;

namespace DecisionTech
{
    public interface IDiscount
    {
        void ApplyDiscount(List<BasketProduct> basketContents);
    }
}