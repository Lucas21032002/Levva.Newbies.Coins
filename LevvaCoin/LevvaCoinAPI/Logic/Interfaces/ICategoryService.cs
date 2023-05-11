using LevvaCoinAPI.Logic.Dto;

namespace LevvaCoinAPI.Logic.Interfaces
{
    public interface ICategoryService
    {
        void Create(CategoryDto category);
        CategoryDto Get(int id); //perguntar sobre síntaxe
        List<CategoryDto> GetAll();
        void Update(CategoryDto category);
        void Delete(int id);

    }
}
