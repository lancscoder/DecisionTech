using System.Collections.Generic;
using System.Linq;
using DecisionTech.Products;

namespace DecisionTech.Discounts
{
    public class MilkDiscount : IDiscount
    {
        public bool CanApplyDiscount(List<BasketProduct> basketContents)
        {
            return basketContents.Count(b => b.Product.GetType() == typeof (Milk) && !b.DiscountApplied) >= 4;
        }

        public void ApplyDiscount(List<BasketProduct> basketContents)
        {
            if (!CanApplyDiscount(basketContents)) return;
            
            var milks =
                basketContents.Where(b => b.Product.GetType() == typeof(Milk) && !b.DiscountApplied).Take(4).ToList();

            for (var i = 0; i < 4; i++)
            {
                milks[i].DiscountApplied = true;

                if (i == 0)
                {
                    milks[i].BasketPrice = 0m;
                }
            }
        }
    }
}