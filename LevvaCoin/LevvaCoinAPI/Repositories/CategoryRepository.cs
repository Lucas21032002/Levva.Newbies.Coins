using LevvaCoinAPI.Database;
using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Interfaces;

namespace LevvaCoinAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly LevvaCoinsDbContext _context;
        public CategoryRepository(LevvaCoinsDbContext context)
        {
            _context = context;
        }

        public void Create(CategoryDto category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Category.Find(id);
            _context.Category.Remove(category);
            _context.SaveChanges();
        }

        public CategoryDto Get(int id)
        {
            return _context.Category.Find(id);
        }

        public List<CategoryDto> GetAll()
        {
            return _context.Category.ToList();
        }

        public void Update(CategoryDto category)
        {
            _context.Category.Update(category);
            _context.SaveChanges();
        }
    }
}
