using LevvaCoinAPI.Database;
using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LevvaCoinAPI.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LevvaCoinsDbContext _context;
        public TransactionRepository(LevvaCoinsDbContext context)
        {
            _context = context;
        }

        public void Create(Transaction transaction)
        {
            _context.Transaction.Add(transaction);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var transaction = _context.Transaction.Find(id);
            _context.Transaction.Remove(transaction);
            _context.SaveChanges();
        }

        public Transaction Get(int id)
        {
            return _context.Transaction.Find(id);
        }

        public List<Transaction> GetAll()
        {
            return _context.Transaction.ToList();
        }

        public void Update(Transaction transaction)
        {
            _context.Transaction.Update(transaction);
            _context.SaveChanges();
        }
    }
}
