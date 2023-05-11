using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoinAPI.Logic.Dto
{
    [Table("users")]
    public class UserDto
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        //Relacionamento com outras tabelas
        public virtual List<TransactionDto> Transactions { get; set; }

    }
}
