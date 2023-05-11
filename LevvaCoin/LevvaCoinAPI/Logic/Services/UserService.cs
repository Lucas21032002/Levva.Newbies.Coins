using AutoMapper;
using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Interfaces;
using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;

namespace LevvaCoinAPI.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(
            IUserRepository repository,
            IMapper mapper
        )
        {
            _userRepository = repository;
            _mapper = mapper;
        }

        public void Create(UserDto user)
        {
            var _user = _mapper.Map<User>(user);
            _userRepository.Create(_user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public UserDto Get(int id)
        {
            var user = _mapper.Map<UserDto>(_userRepository.Get(id));
            return user;
        }

        public List<UserDto> GetAll()
        {
            var users = _mapper.Map<List<UserDto>>(_userRepository.GetAll());
            return users;
        }

        public void Update(UserDto userDto)
        {
            var userAtt = _mapper.Map<User>(userDto);
            _userRepository.Update(userAtt);
        }
    }
}
