using System.Collections.Generic;
using DecisionTech.Products;

namespace DecisionTech
{
    public class Basket : IBasket
    {
        private readonly IBasketCalculator _basketCalculator;
        public decimal Total { get; private set; }
        public List<BasketProduct> Contents { get; } = new List<BasketProduct>();

        public Basket()
            : this(new BasketCalculator())
        {
        }

        public Basket(IBasketCalculator basketCalculator)
        {
            _basketCalculator = basketCalculator;
        }

        public void AddProduct(IProduct product, int quantity)
        {
            for (var i = 0; i < quantity; i++)
            {
                Contents.Add(new BasketProduct(product));
            }
        }

        public void CalculateTotal()
        {
            Total = _basketCalculator.CalculateTotal(Contents);
        }
    }
}