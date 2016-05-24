using System.Collections.Generic;
using System.Linq;
using DecisionTech.Discounts;

namespace DecisionTech
{
    public class BasketCalculator : IBasketCalculator
    {
        public decimal CalculateTotal(List<BasketProduct> basketProducts)
        {
            var breadDiscount = new BreadDiscount();
            while (breadDiscount.CanApplyDiscount(basketProducts))
            {
                breadDiscount.ApplyDiscount(basketProducts);
            }

            var milkDiscount = new MilkDiscount();
            while (milkDiscount.CanApplyDiscount(basketProducts))
            {
                milkDiscount.ApplyDiscount(basketProducts);
            }

            return basketProducts.Sum(b => b.BasketPrice);
        }
    }
}