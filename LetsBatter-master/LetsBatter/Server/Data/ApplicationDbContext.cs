using Microsoft.EntityFrameworkCore;
using LetsBatter.Server.Models;


namespace LetsBatter.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Add DbSet properties for your database tables
        public DbSet<Product> Products { get; set; }
    }
}
