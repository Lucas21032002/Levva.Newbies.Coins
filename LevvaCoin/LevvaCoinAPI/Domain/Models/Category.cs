using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoinAPI.Domain.Models
{
    [Table("Categories")]
    public class Category
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        //Relacionamento com outras trabelas
        public virtual List<Transaction> Transactions { get; set; }
    }
}
