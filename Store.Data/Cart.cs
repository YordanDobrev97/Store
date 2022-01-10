using System.Collections.Generic;
using System.Linq;

namespace Store.Data
{
    public class Cart
    {
        public Cart()
        {
            this.Products = new HashSet<CartProduct>();
        }

        public ICollection<CartProduct> Products { get; set; }

        public void AddToCart(Product product, IDiscountStrategy discountStrategy)
        {
            var existProduct = this.Products.FirstOrDefault(p => p.Product.Name == product.Name);

            if (existProduct == null)
            {
                this.Products.Add(new CartProduct()
                {
                    Product = product,
                    Quantity = 1,
                    DiscountStrategy = discountStrategy,
                });
            }
            else
            {
                existProduct.Quantity++;
            }
        }
    }
}
