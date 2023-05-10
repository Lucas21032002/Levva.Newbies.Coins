using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Interfaces;

namespace LevvaCoinAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(
            IUserRepository repository
        ) {
            _userRepository = repository;
        }
        Task<IEnumerable<User>> IUserService.list()
        {
          return _userRepository.GetAllAsync();
        }
    }
}
