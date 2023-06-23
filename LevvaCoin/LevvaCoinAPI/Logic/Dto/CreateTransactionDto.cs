using LevvaCoinAPI.Domain.Enums;

namespace LevvaCoinAPI.Logic.Dto
{
    public class CreateTransactionDto
    {

        public decimal? Price { get; set; }

        public string? Description { get; set; }

        public TransactionTypeEnum Type { get; set; }

        public int CategoryId { get; set; }

    }
}
