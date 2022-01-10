using Store.Client.Seeding;
using Store.Data;
using System;

namespace Store.Client
{
    public class StartUp
    {
        public static void Main()
        {
            /*
             * There may be a difference between the output of the assignment task and the output of the program 
             * because of seeder of data (more precisely because of quantity of product), but I think it works properly
             */

            CartSeeder cartSeeder = new CartSeeder();
            Cart cart = new Cart();
            cartSeeder.Seed(cart);

            Order order = new Order()
            {
                DatePurchase = new DateTime(2021, 06, 14, 12, 34, 56)
            };

            // weekend order
            Order weekendOrder = new Order()
            {
                DatePurchase = new DateTime(2021, 06, 13)
            };

            Cashier cashier = new Cashier();
            cashier.PrintReceipt(cart, order);
            //cashier.PrintReceipt(cart, weekendOrder);

        }
    }
}
