using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LetsBatter.Shared.Data
{
    public class LetsBatterDbContextFactory : IDesignTimeDbContextFactory<LetsBatterDbContext>
    {
        public LetsBatterDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LetsBatterDbContext>();

            // Directly specify the connection string here
            string connectionString = "Server=MARIA\\SQLEXPRESS;Database=LetsBatter;Trusted_Connection=True;"; // Replace with your actual connection string

            optionsBuilder.UseSqlServer(connectionString);

            return new LetsBatterDbContext(optionsBuilder.Options);
        }
    }
}

