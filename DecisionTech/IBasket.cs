using DecisionTech.Products;

namespace DecisionTech
{
    public interface IBasket
    {
        decimal Total { get; }
        void AddProduct(IProduct product, int quantity);
        void CalculateTotal();
    }
}
