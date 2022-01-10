using System.Text;

namespace Store.Data
{
    public class CartProduct
    {
        public Product Product { get; set; }

        public double Quantity { get; set; }

        public IDiscountStrategy DiscountStrategy { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(this.Product.ToString());
            output.Append($"{this.Quantity} x {this.Product.Price} = {this.CalculateTotalPrice():F2}");

            return output.ToString();
        }

        private decimal CalculateTotalPrice()
        {
            return this.Product.Price * (decimal)this.Quantity;
        }
    }
}
