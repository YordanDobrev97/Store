namespace Store.Data
{
    public abstract class Product
    {
        public Product(string name, string brand, decimal price, IDiscountStrategy discountStrategy)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.DiscountStrategy = discountStrategy;
        }

        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public IDiscountStrategy DiscountStrategy { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Brand}";
        }
    }
}
