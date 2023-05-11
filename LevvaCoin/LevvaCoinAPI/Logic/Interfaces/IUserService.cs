using LevvaCoinAPI.Logic.Dto;

namespace LevvaCoinAPI.Logic.Interfaces
{
    public interface IUserService
    {
        void Create(UserDto userDto);
        UserDto Get(int id); //perguntar sobre síntaxe
        List<UserDto> GetAll();
        void Update(UserDto userDto);
        void Delete(int id);

    }
}
