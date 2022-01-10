namespace Store.Data
{
    public class Clothes : Product
    {
        public Clothes(string name, string brand, decimal price, SizeClothes size, string color, IDiscountStrategy discountStrategy)
            : base (name, brand, price, discountStrategy)
        {
            this.Size = size;
            this.Color = color;
        }

        public SizeClothes Size { get; set; }

        public string Color { get; set; }
    }
}
