using System;

namespace Store.Data
{
    public class Discount
    {
        public static Tuple<int, decimal> GetDiscount(Product product, Order purchase, decimal currentPrice)
        {
            if (IsPurchaseExpiryDate(product, purchase))
            {
                var discount = new TwiceDiscount().CalculteDiscount(currentPrice);
                return new Tuple<int, decimal>(50, discount);
            }

            if (HasValidFiveDay(product, purchase))
            {
                var expiryProductDate = (DateTime)product.GetType().GetProperty("ExpiryDate").GetValue(product);
                var discount = new StandartDiscount(expiryProductDate, purchase.DatePurchase).CalculteDiscount(currentPrice);
                return new Tuple<int, decimal>(10, discount);
            }

            return new Tuple<int, decimal>(0, 0);
        }

        private static bool HasValidFiveDay(Product product, Order purchase)
        {
            var property = product.GetType().GetProperty("ExpiryDate");
            if (property == null) return false;

            var expiryProductDate = (DateTime)property.GetValue(product);
            expiryProductDate = expiryProductDate.AddDays(-5);

            return CompareDates(expiryProductDate, purchase.DatePurchase);
        }

        private static bool IsPurchaseExpiryDate(Product product, Order order)
        {
            var property = product.GetType().GetProperty("ExpiryDate");
            if (property == null) return false;

            var expiryProductDate = (DateTime)property.GetValue(product);
            return CompareDates(expiryProductDate, order.DatePurchase);
        }

        private static bool CompareDates(DateTime d1, DateTime d2)
        {
            return d1.Day == d2.Day &&
               d1.Month == d2.Month &&
               d1.Year == d2.Year;
        }
    }
}
