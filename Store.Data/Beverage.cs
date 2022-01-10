using System;

namespace Store.Data
{
    public class Beverage : Product
    {
        public Beverage(string name, string brand, decimal price, DateTime expiryDate, IDiscountStrategy discountStrategy)
            : base (name, brand, price, discountStrategy)
        {
            this.ExpiryDate = expiryDate;
        }

        public DateTime ExpiryDate { get; set; }
    }
}
