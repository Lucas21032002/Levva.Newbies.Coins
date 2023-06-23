using LevvaCoinAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;


namespace LevvaCoinAPI.Logic.Dto
{
    [Table("Transactions")]
    public class TransactionDto
    {
        public int Id { get; set; }

        public decimal? Price { get; set; }

        public string? Description { get; set; }

        public DateTime? Date { get; set; }
        
        public TransactionTypeEnum Type { get; set; }

        public virtual CategoryDto? Category { get; set; }

    }
}
