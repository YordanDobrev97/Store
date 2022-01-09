using System;

namespace Store.Data
{
    public class Cashier
    {
        public void PrintReceipt(Cart cart, Order purchase)
        {
            Console.WriteLine($"Date: {purchase.DatePurchase.ToString("MM/dd/yyyy h:mm tt")}");

            Console.WriteLine("---Products---");

            foreach (var productCart in cart.Products)
            {
                Console.WriteLine(productCart);
                decimal totalPrice = productCart.Product.Price * (decimal)productCart.Quantity;
                var result = Discount.GetDiscount(productCart.Product, purchase, totalPrice);
                decimal discount = result.Item1;
                decimal discountSum = result.Item2;

                if (discount > 0)
                {
                    Console.WriteLine($"#discount {discount}% - ${discountSum:F2}");
                }   
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");


        }
    }
}
