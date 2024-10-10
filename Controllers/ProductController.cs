using Eticaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context; //Veritabanı erişimi
        public ProductController(AppDbContext context) //constructer method , dependency injection
        {
            _context = context;

        }

        //Resim dosyasını döndürecek metod
        public IActionResult GetImage(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null && product.ImageUrl != null)
            {
                return File(product.ImageUrl, "image/jpg");
            }
            return NotFound();
        }
    }
}
