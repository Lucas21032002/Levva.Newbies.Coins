using AutoMapper;
using LevvaCoinAPI.Interfaces;
using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;
using LevvaCoinAPI.Domain.Models;

namespace LevvaCoinAPI.Logic.Services
{
    public class TransactionServices : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;

        public TransactionServices(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TransactionDto Create(int userId, CreateTransactionDto transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);

            _transaction.UserId = userId;
            _transaction.Date = DateTime.Now;

            var transactionCreated = _repository.Create(_transaction);
            return _mapper.Map<TransactionDto>(_transaction);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public TransactionDto Get(int id)
        {
            var _transaction = _mapper.Map<TransactionDto>(_repository.Get(id));
            return _transaction;
        }

        public List<TransactionDto> GetAll()
        {
            var transactions = _mapper.Map<List<TransactionDto>>(_repository.GetAll());
            transactions.Reverse();
            return transactions;
        }

        public void Update(TransactionDto transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);
            _repository.Update(_transaction);

        }
    }
}
