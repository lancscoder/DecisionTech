using DecisionTech.Products;

namespace DecisionTech
{
    public class BasketProduct
    {
        public IProduct Product { get; private set; }
        public decimal BasketPrice { get; set; }
        public bool DiscountApplied { get; set; } = false;

        public BasketProduct(IProduct product)
        {
            Product = product;
            BasketPrice = product.Price;
        }
    }
}