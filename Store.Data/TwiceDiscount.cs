namespace Store.Data
{
    public class TwiceDiscount : IDiscountStrategy
    {
        public decimal CalculteDiscount(decimal currentTotalPrice)
        {
            return currentTotalPrice * 0.50M;
        }
    }
}
