using LevvaCoinAPI.Domain.Models;

namespace LevvaCoinAPI.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> list();
    }
}
