using System.Net.Http.Headers;

namespace Eticaret.Models
{
    public class Seller : User
    {
        public string StoreName { get; set; }
        public List<Product> Products { get; set; }
    }
}
