using Microsoft.EntityFrameworkCore;

namespace Eticaret.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("YourConnectionStringHere"); // Replace with your actual connection string
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial data

            // Seed Seller
            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                UserId = 1,
                UserName = "JohnSeller",
                Password = "12345",
                Email = "john@seller.com",
                Role = "Seller",
                StoreName = "John's Store"
            });

            // Seed Customer
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                UserId = 2,
                UserName = "JaneCustomer",
                Password = "54321",
                Email = "jane@customer.com",
                Role = "Customer"
            });

            // Seed Product
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Laptop",
                Description = "High-end gaming laptop",
                Price = 1200.00m,
                ImageUrl = "/images/laptop.jpg",
                SellerId = 1 // Reference the Seller by Id
            });
        }
    }
}
