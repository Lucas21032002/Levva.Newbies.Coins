using LevvaCoinAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoinAPI.Domain.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("price")]
        public decimal? Price { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }
        
        [Column("type")]
        public TransactionTypeEnum Type { get; set; }

        [Column("categoryId")]
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        [Column("userId")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
