using System;
using System.Linq;

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
                var discount = this.CalculateDiscount(productCart.DiscountStrategy, productCart, purchase);

                if (discount > 0)
                {
                    Console.WriteLine($"#discount <discount %> {discount:f2} ");
                }
                Console.WriteLine();
            }

            var totalPrice = cart.Products.Sum(x => x.Product.Price);
            Console.WriteLine($"SUBTOTAL: ${totalPrice:F2}");

            Console.WriteLine("-----------------------------------------------------------------------------------");
        }

        private decimal CalculateDiscount(IDiscountStrategy discountStrategy, CartProduct cartProduct, Order order)
        {
            return discountStrategy.CalculteDiscount(cartProduct, order);
        }
    }
}
