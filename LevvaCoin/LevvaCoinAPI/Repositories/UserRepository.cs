using LevvaCoinAPI.Database;
using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LevvaCoinAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LevvaCoinsDbContext _context;
        public UserRepository(LevvaCoinsDbContext context) {
            _context = context;
        }
        public Task<User> AddAsync(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddRangeAsync(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public Task<User> GetByIdAsyc(object id)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(User id)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveRangeAsync(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateRangeAsync(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }
    }
}
