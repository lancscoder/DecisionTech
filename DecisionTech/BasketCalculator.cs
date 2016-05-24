using System.Collections.Generic;
using System.Linq;
using DecisionTech.Discounts;

namespace DecisionTech
{
    public class BasketCalculator : IBasketCalculator
    {
        private readonly IDiscountApplier _discountApplier;

        public BasketCalculator()
            : this(new DiscountApplier())
        {
        }

        public BasketCalculator(IDiscountApplier discountApplier)
        {
            _discountApplier = discountApplier;
        }

        public decimal CalculateTotal(List<BasketProduct> basketProducts)
        {
            _discountApplier.ApplyDiscounts(basketProducts);

            return basketProducts.Sum(b => b.BasketPrice);
        }
    }
}