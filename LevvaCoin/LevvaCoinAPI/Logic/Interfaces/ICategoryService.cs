using LevvaCoinAPI.Logic.Dto;

namespace LevvaCoinAPI.Logic.Interfaces
{
    public interface ICategoryService
    {
        CategoryDto Create(createCategoryDto category);
        CategoryDto Get(int id);
        List<CategoryDto> GetAll();
        void Update(CategoryDto category);
        void Delete(int id);

    }
}
