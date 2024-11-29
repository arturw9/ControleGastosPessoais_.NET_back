using System.ComponentModel.DataAnnotations;

namespace ControleGastosPessoais.Models
{
    public class Usuario
    {
        [Key]
        [StringLength(100)]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Relacionamento
        public ICollection<Transacao> Transactions { get; set; } = new List<Transacao>();
        public ICollection<Categoria> Categories { get; set; } = new List<Categoria>();
    }
}
