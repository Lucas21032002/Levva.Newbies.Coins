using LevvaCoinAPI.Domain.Models;

namespace LevvaCoinAPI.Interfaces
{
    public interface ITransactionRepository
    {
        void Create(Transaction transaction);
        Transaction Get(int id);
        List<Transaction> GetAll();
        void Update(Transaction transaction);
        void Delete(int id);
    }
}
