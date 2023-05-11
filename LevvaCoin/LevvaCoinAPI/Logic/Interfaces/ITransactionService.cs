using LevvaCoinAPI.Logic.Dto;

namespace LevvaCoinAPI.Logic.Interfaces
{
    public interface ITransactionService
    {
        void Create(TransactionDto trasaction);
        TransactionDto Get(int id); //perguntar sobre síntaxe
        List<TransactionDto> GetAll();
        void Update(TransactionDto trasaction);
        void Delete(int id);

    }
}
