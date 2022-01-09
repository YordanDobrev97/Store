using Store.Client.Seeding;
using Store.Data;
using System;

namespace Store.Client
{
    public class StartUp
    {
        public static void Main()
        {
            var product = new Food()
            {
                Name = "apples",
                Brand = "BrandA",
                Price = 1.50M,
                ExpiryDate = new DateTime(2023, 12, 12)
            };

            var beverage = new Beverage()
            {
                Name = "milk 2",
                Brand = "BrandM",
                Price = 0.99M,
                ExpiryDate = new DateTime(2022, 06, 10)
            };

            CartSeeder cartSeeder = new CartSeeder();
            Cart cart = new Cart();
            cartSeeder.Seed(cart);

            cart.AddToCart(product, 2.45);
            cart.AddToCart(beverage, 3);

            Order order = new Order()
            {
                DatePurchase = new DateTime(2021, 06, 14)
            };

            Cashier cashier = new Cashier();
            cashier.PrintReceipt(cart, order);
        }
    }
}
