using System.ComponentModel.DataAnnotations.Schema;

namespace LevvaCoinAPI.Logic.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string? Description { get; set; }
    }
}
