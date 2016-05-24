using System.Collections.Generic;
using System.Linq;
using DecisionTech.Products;

namespace DecisionTech
{
    public class BreadDiscount : IDiscount
    {
        public void ApplyDiscount(List<BasketProduct> basketContents)
        {
            if (basketContents.Count(b => b.Product.GetType() == typeof (Butter) && !b.DiscountApplied) < 2 ||
                basketContents.Count(b => b.Product.GetType() == typeof (Bread) && !b.DiscountApplied) < 1) return;
            {
                var butters =
                    basketContents.Where(b => b.Product.GetType() == typeof (Butter) && !b.DiscountApplied).Take(2);

                foreach (var butter in butters)
                {
                    butter.DiscountApplied = true;
                }

                var bread =
                    basketContents.FirstOrDefault(b => b.Product.GetType() == typeof (Bread) && !b.DiscountApplied);

                bread.BasketPrice = bread.BasketPrice*0.5m;
                bread.DiscountApplied = true;
            }
        }
    }
}