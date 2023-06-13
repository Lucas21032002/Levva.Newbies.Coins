using LevvaCoinAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LevvaCoinAPI.Database // Pedir explicação pro thales.
{
    public class LevvaCoinsDbContext : DbContext
    {
        public LevvaCoinsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
