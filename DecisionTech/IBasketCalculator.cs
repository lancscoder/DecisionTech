using System.Collections.Generic;

namespace DecisionTech
{
    public interface IBasketCalculator
    {
        decimal CalculateTotal(List<BasketItem> basketItems);
    }
}