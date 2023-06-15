using AutoMapper;
using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Interfaces;
using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LevvaCoinAPI.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UserService(
            IUserRepository repository,
            IMapper mapper,
            IConfiguration configuration
        )
        {
            _userRepository = repository;
            _mapper = mapper;
            _configuration = configuration;
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
            var user = _mapper.Map<UserDto>(_userRepository.Get(id)); // Explicação sobre autoMapper
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

        public LoginDto Login(LoginDto loginDto)
        {
            var usuario = _userRepository.GetByEmailAndPassword(loginDto.Email, loginDto.Password);

            if (usuario == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("Secret").Value);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            loginDto.Token = tokenHandler.WriteToken(token);
            loginDto.Password = null;
            loginDto.Username = usuario.Name;
            loginDto.Email = usuario.Email;
            loginDto.Id = usuario.Id;

            return loginDto;

        }
    }
}
