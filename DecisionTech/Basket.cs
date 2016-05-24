﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DecisionTech.Discounts;
using DecisionTech.Products;

namespace DecisionTech
{
    public class Basket : IBasket
    {
        public decimal Total { get; private set; }
        public List<BasketProduct> Contents { get; } = new List<BasketProduct>();

        public void AddProduct(IProduct product, int quantity)
        {
            for (var i = 0; i < quantity; i++)
            {
                Contents.Add(new BasketProduct(product));
            }
        }

        public void CalculateTotal()
        {
            var breadDiscount = new BreadDiscount();
            while (breadDiscount.CanApplyDiscount(Contents))
            {
                breadDiscount.ApplyDiscount(Contents);
            }

            var milkDiscount = new MilkDiscount();
            while (milkDiscount.CanApplyDiscount(Contents))
            {
                milkDiscount.ApplyDiscount(Contents);
            }

            Total = Contents.Sum(b => b.BasketPrice);
        }
    }
}