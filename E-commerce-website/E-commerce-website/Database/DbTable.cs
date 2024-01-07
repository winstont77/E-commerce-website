using E_commerce_website.Models.DatabaseEntity;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Database
{
    public class DbTable : DbContext
    {
        public DbTable(DbContextOptions<DbTable> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartContent> CartContent { get; set; }
    }
}
