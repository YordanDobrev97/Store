using System;

namespace Store.Data
{
    public interface IDiscountStrategy
    {
        decimal CalculteDiscount(CartProduct cartProduct, Order order);
    }
}
