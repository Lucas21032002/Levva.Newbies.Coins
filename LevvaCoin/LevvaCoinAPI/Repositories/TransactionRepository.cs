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

        public Transaction Create(Transaction transaction)
        {
        
            _context.Transaction.Add(transaction);
            _context.SaveChanges();
            return transaction;
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
            return _context.Transaction.Include(x => x.Category).ToList();
        }

        public void Update(Transaction transaction)
        {
            _context.Transaction.Update(transaction);
            _context.SaveChanges();
        }
    }
}
