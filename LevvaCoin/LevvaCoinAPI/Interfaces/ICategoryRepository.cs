using LevvaCoinAPI.Domain.Models;

namespace LevvaCoinAPI.Interfaces
{
    public interface ICategoryRepository
    {
        Category Create(Category category);
        Category Get(int id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(int id);
    }
}
