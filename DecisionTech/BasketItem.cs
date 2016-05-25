using DecisionTech.Products;

namespace DecisionTech
{
    public class BasketItem
    {
        public IProduct Product { get; private set; }
        public decimal Price { get; set; }
        public bool IsOfferApplied { get; set; } = false;

        public BasketItem(IProduct product)
        {
            Product = product;
            Price = product.Price;
        }
    }
}