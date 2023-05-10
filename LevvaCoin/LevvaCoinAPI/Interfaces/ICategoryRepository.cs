using LevvaCoinAPI.Domain.Models;

namespace LevvaCoinAPI.Interfaces
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        Category Get(int id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(int id);
    }
}
