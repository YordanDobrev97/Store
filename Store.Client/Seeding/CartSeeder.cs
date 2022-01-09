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
                new Food()
                    {
                        Name = "apples",
                        Brand = "BrandA",
                        Price = 1.50M,
                        ExpiryDate = new DateTime(2021, 06, 14)
                    },
                new Beverage()
                    {
                        Name = "milk",
                        Brand = "BrandM",
                        Price = 0.99M,
                        ExpiryDate = new DateTime(2022, 02, 02),
                    },
                new Clothes()
                    {
                        Name = "T-shirt",
                        Brand = "BrandT",
                        Price = 15.99M,
                        Size = SizeClothes.M,
                        Color = "violet",
                    },
                new Appliance()
                    {
                        Name = "laptop",
                        Brand = "BrandL",
                        Price = 2345M,
                        Model = "ModelL",
                        ProductionDate = new DateTime(2021, 03, 03),
                        Weight = 1.125,
                    }
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
                cart.AddToCart(product, 1);
            }
        }
    }
}
