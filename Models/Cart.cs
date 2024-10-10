namespace Eticaret.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalPrice => Products.Sum(p => p.Price);
    }
}
