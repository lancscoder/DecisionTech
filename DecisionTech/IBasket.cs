using System.Collections.Generic;
using DecisionTech.Products;

namespace DecisionTech
{
    public interface IBasket
    {
        decimal Total { get; }
        List<BasketProduct> Contents { get; } 
        void AddProduct(IProduct product, int quantity);
        void CalculateTotal();
    }
}
