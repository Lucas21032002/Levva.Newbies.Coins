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

        public void Create(UserDto user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.User.Find(id);
            _context.User.Remove(user);
            _context.SaveChanges();
        }

        public UserDto Get(int id)
        {
            return _context.User.Find(id);
        }

        public List<UserDto> GetAll()
        {
            return _context.User.ToList();
        }

        public void Update(UserDto user)
        {
            _context.User.Update(user);
            _context.SaveChanges();
        }
    }
}
