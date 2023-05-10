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

        public void Create(User user)
        {
            _context.User.Add(user);
        }

        public void Delete(int id)
        {
            var user = _context.User.Find(id);
            _context.User.Remove(user);
        }

        public User Get(int id)
        {
            return _context.User.Find(id);
        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
        }

        public void Update(User user)
        {
            _context.User.Update(user);
        }
    }
}
