using System.ComponentModel.DataAnnotations;

namespace ControleGastosPessoais.Models
{
    public class Transacao
    {
        [Key]
        [StringLength(100)]
        public Guid? Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? Data { get; set; }

        // Relacionamento
        public Guid? CategoryId { get; set; }
        public Categoria Category { get; set; } = null!;

        public Guid? UserId { get; set; }
        public Usuario User { get; set; } = null!;
    }
}
