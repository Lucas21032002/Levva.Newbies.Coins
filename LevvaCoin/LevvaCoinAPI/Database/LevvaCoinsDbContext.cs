using LevvaCoinAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LevvaCoinAPI.Database
{
    public class LevvaCoinsDbContext : DbContext
    {
        public LevvaCoinsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }
}
