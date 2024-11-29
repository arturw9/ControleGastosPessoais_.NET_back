using ControleGastosPessoais.Models;
using System.ComponentModel.DataAnnotations;

namespace ControleGastosPessoais.ViewsModels
{
    public class UsuarioViewModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        // Relacionamento
    }
}
