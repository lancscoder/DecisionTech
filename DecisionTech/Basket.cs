using System.Collections.Generic;
using DecisionTech.Products;

namespace DecisionTech
{
    public class Basket : IBasket
    {
        private readonly IBasketCalculator _basketCalculator;
        public decimal Total { get; private set; }
        public List<BasketItem> Items { get; } = new List<BasketItem>();

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
                Items.Add(new BasketItem(product));
            }
        }

        public void CalculateTotal()
        {
            Total = _basketCalculator.CalculateTotal(Items);
        }
    }
}