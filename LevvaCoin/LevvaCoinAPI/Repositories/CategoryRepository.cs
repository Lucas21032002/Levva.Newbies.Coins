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

        public void Create(Category category)
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

        public Category Get(int id)
        {
            return _context.Category.Find(id);
        }

        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public void Update(Category category)
        {
            _context.Category.Update(category);
            _context.SaveChanges();
        }
    }
}
