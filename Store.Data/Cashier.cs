using System;
using System.Linq;

namespace Store.Data
{
    public class Cashier
    {
        public void PrintReceipt(Cart cart, Order purchase)
        {
            Console.WriteLine($"Date: {purchase.DatePurchase.ToString("yyyy/MM/dd hh:mm:ss")}");

            Console.WriteLine("---Products---");

            decimal totalDiscount = 0;
            foreach (var productCart in cart.Products)
            {
                Console.WriteLine(productCart);
                var discount = this.CalculateDiscount(productCart.DiscountStrategy, productCart, purchase);

                if (discount > 0)
                {
                    Console.WriteLine($"#discount <discount %> {discount:f2} ");
                    totalDiscount += discount;
                }
                Console.WriteLine();
            }

            var totalPrice = cart.Products.Sum(x => x.Product.Price);
            Console.WriteLine($"SUBTOTAL: ${totalPrice:F2}");

            Console.WriteLine($"DISCOUNT: -${totalDiscount:F2}");
            Console.WriteLine($"TOTAL: ${totalPrice - totalDiscount:F2}");

            Console.WriteLine("-----------------------------------------------------------------------------------");
        }

        private decimal CalculateDiscount(IDiscountStrategy discountStrategy, CartProduct cartProduct, Order order)
        {
            return discountStrategy.CalculteDiscount(cartProduct, order);
        }
    }
}
