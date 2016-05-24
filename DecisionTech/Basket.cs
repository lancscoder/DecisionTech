using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DecisionTech.Discounts;
using DecisionTech.Products;

namespace DecisionTech
{
    public interface IBasketCalculator
    {
        decimal CalculateTotal(List<BasketProduct> basketProducts);
    }

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