using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoinAPI.Domain.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("password")]
        public string? Password { get; set; }

        //Relacionamento com outras tabelas
        public virtual List<Transaction>? Transactions { get; set; }

    }
}
