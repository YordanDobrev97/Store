namespace Store.Data
{
    public abstract class Product
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Brand}";
        }
    }
}
