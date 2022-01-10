using System;

namespace Store.Data
{
    public class Appliance : Product
    {
        public Appliance(string name, string brand, decimal price, string model, DateTime productionDate, double weight, IDiscountStrategy discountStrategy)
            : base (name, brand, price, discountStrategy)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }
        public string Model { get; set; }

        public DateTime ProductionDate { get; set; }

        public double Weight { get; set; }
    }
}
