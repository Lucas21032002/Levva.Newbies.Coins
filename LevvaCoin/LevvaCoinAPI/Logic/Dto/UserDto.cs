using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoinAPI.Logic.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }

        //Relacionamento com outras tabelas
        public virtual List<TransactionDto>? Transactions { get; set; }

    }
}
