namespace ControleGastosPessoais.ViewsModels
{
    public class TransacaoViewModel
    {
        public string? Descricao { get; set; }
        public Guid? IdCategoria { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Data {  get; set; }
        public Guid? IdUsuario { get; set; }

        // Relacionamento
    }
}
