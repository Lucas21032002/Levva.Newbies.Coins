using LevvaCoinAPI.Domain.Models;

namespace LevvaCoinAPI.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user); 
        User Get(int id);
        List<User> GetAll();
        void Update(User user);
        void Delete(int id);
        User GetByEmailAndPassword(string email, string password);
    }
}
