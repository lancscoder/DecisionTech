using System;
using System.Collections.Generic;
using System.Linq;
using DecisionTech.Products;

namespace DecisionTech
{
    public class Basket : IBasket
    {
        private readonly List<Tuple<IProduct, int>> _basketContents = new List<Tuple<IProduct, int>>();

        public decimal Total { get; private set; }

        public void AddProduct(IProduct product, int quantity)
        {
            _basketContents.Add(new Tuple<IProduct, int>(product, quantity));
        }

        public void CalculateTotal()
        {
            Total = _basketContents.Sum(b => b.Item1.Price * b.Item2);
        }
    }
}