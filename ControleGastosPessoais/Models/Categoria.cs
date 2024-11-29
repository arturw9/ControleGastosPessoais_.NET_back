using System.ComponentModel.DataAnnotations;

namespace ControleGastosPessoais.Models
{
    public class Categoria
    {
        [Key]
        [StringLength(100)]
        public Guid? Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
