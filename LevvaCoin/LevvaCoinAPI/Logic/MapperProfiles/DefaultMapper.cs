using AutoMapper;
using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Logic.Dto;

namespace LevvaCoinAPI.Logic.MapperProfiles
{
    public class DefaultMapper : Profile
    {   
        public DefaultMapper()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
