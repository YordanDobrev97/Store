using System;

namespace Store.Data
{
    /// <summary>
    /// Standard expired product discount of 10%
    /// </summary>
    public class StandartDiscount : IDiscountStrategy
    {
        private decimal standartDiscount = 0.10M;
        private int days = 5;
        private DateTime d1;
        private DateTime d2;

        public StandartDiscount(DateTime d1, DateTime d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        public decimal CalculteDiscount(decimal currentTotalPrice)
        {
            d1 = d1.AddDays(-days);

            bool hasDiscount = this.CompareDates(this.d1, this.d2);
            if (hasDiscount)
            {
                return currentTotalPrice * this.standartDiscount;
            }

            return 0;
        }

        // it is possible to think of a smarter solution
        private bool CompareDates(DateTime d1, DateTime d2)
        {
            return d1.Day == d2.Day &&
               d1.Month == d2.Month &&
               d1.Year == d2.Year;
        }
    }
}
