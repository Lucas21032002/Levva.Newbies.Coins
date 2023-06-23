using LevvaCoinAPI.Logic.Dto;

namespace LevvaCoinAPI.Logic.Interfaces
{
    public interface IUserService
    {
        void Create(UserDto userDto);
        UserDto Get(int id);
        List<UserDto> GetAll();
        void Update(UserDto userDto);
        void Delete(int id);

        LoginResponseDto Login(LoginDto loginDto);

    }
}
