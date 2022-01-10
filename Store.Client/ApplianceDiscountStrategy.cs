using Store.Data;

namespace Store.Client
{
    public class ApplianceDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculteDiscount(CartProduct cartProduct, Order order)
        {
            if (cartProduct.Product.Price > 999 && (order.DatePurchase.DayOfWeek == System.DayOfWeek.Saturday || 
                order.DatePurchase.DayOfWeek == System.DayOfWeek.Sunday))
            {
                return (cartProduct.Product.Price * (decimal)cartProduct.Quantity) * 0.05M;
            }

            return 0;
        }
    }
}
