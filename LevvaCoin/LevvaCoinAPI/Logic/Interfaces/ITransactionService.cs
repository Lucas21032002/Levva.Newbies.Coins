using LevvaCoinAPI.Logic.Dto;

namespace LevvaCoinAPI.Logic.Interfaces
{
    public interface ITransactionService
    {
        TransactionDto Create(int userId, CreateTransactionDto trasaction);
        TransactionDto Get(int id); //perguntar sobre síntaxe
        List<TransactionDto> GetAll();
        void Update(TransactionDto trasaction);
        void Delete(int id);

    }
}
