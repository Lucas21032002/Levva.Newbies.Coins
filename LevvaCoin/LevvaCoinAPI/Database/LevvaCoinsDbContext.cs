using LevvaCoinAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LevvaCoinAPI.Database
{
    public class LevvaCoinsDbContext : DbContext
    {
        public LevvaCoinsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<UserDto> User { get; set; }
        public DbSet<TransactionDto> Transaction { get; set; }
        public DbSet<CategoryDto> Category { get; set; }

    }
}
