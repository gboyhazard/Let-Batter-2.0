using LetsBatter.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsBatter.Shared.Data
{
    public class LetsBatterDbContext : DbContext
    {
        public LetsBatterDbContext(DbContextOptions<LetsBatterDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }  // Added OrderItem DbSet
    }
}
