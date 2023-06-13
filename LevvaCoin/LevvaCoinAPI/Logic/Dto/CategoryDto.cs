using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoinAPI.Logic.Dto
{
    [Table("Categories")]
    public class CategoryDto
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        //Relacionamento com outras trabelas
        public virtual List<TransactionDto>? Transactions { get; set; }
    }
}
