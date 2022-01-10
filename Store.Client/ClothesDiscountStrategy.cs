using System;

namespace Store.Data
{
    public class ClothesDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculteDiscount(CartProduct cartProduct, Order order)
        {
            if (BuyWorkingDays(order))
            {
                return (cartProduct.Product.Price * (decimal)cartProduct.Quantity) * 0.10M;
            }

            return 0;
        }

        private bool BuyWorkingDays(Order order)
        {
            return order.DatePurchase.DayOfWeek != DayOfWeek.Saturday && order.DatePurchase.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
