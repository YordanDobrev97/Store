namespace Store.Data
{
    public interface IDiscountStrategy
    {
        decimal CalculteDiscount(decimal currentTotalPrice);
    }
}
