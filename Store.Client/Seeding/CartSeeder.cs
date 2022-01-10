using Store.Data;
using System;
using System.Collections.Generic;

namespace Store.Client.Seeding
{
    public class CartSeeder
    {
        private readonly ICollection<Product> products;

        public CartSeeder()
        {
            this.products = new List<Product>()
            {
                new Food("apples", "BrandA", 1.50M, new DateTime(2021, 06, 14), new ExpiryProductStrategy(new DateTime(2021, 06, 14))),
                new Food("apples", "BrandA", 1.50M, new DateTime(2021, 06, 14), new ExpiryProductStrategy(new DateTime(2021, 06, 14))),
               
                new Beverage("milk", "BrandM", 0.99M, new DateTime(2022, 02, 02), new ExpiryProductStrategy(new DateTime(2022, 02, 02))),
                
                new Clothes("T-shirt", "BrandT", 15.99M, SizeClothes.M, "violet", new ClothesDiscountStrategy()),
                new Clothes("T-shirt", "BrandT", 15.99M, SizeClothes.M, "violet", new ClothesDiscountStrategy()),

                new Appliance("laptop", "BrandL", 2345M, "ModelL", new DateTime(2021, 03, 03), 1.125,  new ApplianceDiscountStrategy()),
               // new Appliance("laptop 2", "BrandN", 5345M, "ModelX", new DateTime(2021, 01, 08), 1.125,  new ApplianceDiscountStrategy())

            };
        }

        public CartSeeder(ICollection<Product> products)
        {
            this.products = products;
        }

        public void Seed(Cart cart)
        {
            foreach (var product in products)
            {
                cart.AddToCart(product, product.DiscountStrategy);
            }
        }
    }
}
