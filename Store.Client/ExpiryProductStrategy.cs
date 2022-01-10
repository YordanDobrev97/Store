using System;

namespace Store.Data
{
    public class ExpiryProductStrategy : IDiscountStrategy
    {
        private readonly DateTime productExpiry;

        public ExpiryProductStrategy(DateTime productExpiry)
        {
            this.productExpiry = productExpiry;
        }

        public decimal CalculteDiscount(CartProduct cartProduct, Order order)
        {
            var orderDate = order.DatePurchase;

            // expiration date is the same day
            if (this.CompareDates(orderDate, this.productExpiry))
            {
                return (cartProduct.Product.Price * (decimal)cartProduct.Quantity) * 0.50M;
            }

            orderDate = orderDate.AddDays(-5);

            if (this.CompareDates(orderDate, this.productExpiry))
            {
                return (cartProduct.Product.Price * (decimal)cartProduct.Quantity) * 0.10M;
            }

            return 0;
        }

        private bool CompareDates(DateTime d1, DateTime d2)
        {
            return d1.Day == d2.Day &&
               d1.Month == d2.Month &&
               d1.Year == d2.Year;
        }
    }
}
