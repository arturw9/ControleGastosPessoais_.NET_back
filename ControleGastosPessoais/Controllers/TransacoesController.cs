using ControleGastosPessoais.Data;
using ControleGastosPessoais.Models;
using ControleGastosPessoais.ViewsModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleGastosPessoais.Controllers
{
    public class TransacoesController : MainControllerApi
    {
        private readonly ILogger<TransacoesController> _logger;
        private readonly ApiDbContext _context;

        public TransacoesController(ILogger<TransacoesController> logger, ApiDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("/Transações/Listar")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Listar(Guid idUsuario)
        {
            try
            {
                var listTransacoesUsuario = await _context.Transacoes.Where(x => x.UserId == idUsuario).OrderBy(x=>x.Data).ToListAsync();

                foreach (var item in listTransacoesUsuario)
                {
                    var categoriaNome = await _context.Categorias.Where(x => x.Id == item.CategoryId).FirstOrDefaultAsync();
                    item.Category = categoriaNome;
                }
                
                return Ok(listTransacoesUsuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("/Transações/Inserir")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Inserir(TransacaoViewModel transacaoViewModel)
        {
            try
            {
                var addTransacao = TransacaoViewModelToTransacao(transacaoViewModel);
                _context.Transacoes.Add(addTransacao);
                await _context.SaveChangesAsync();
                return Ok(addTransacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private Transacao TransacaoViewModelToTransacao(TransacaoViewModel transacaoViewModel)
        {
            var newTransacao = new Transacao()
            {
                Id = Guid.NewGuid(),
                Descricao = transacaoViewModel.Descricao,
                Data = transacaoViewModel.Data,
                Valor = (decimal)transacaoViewModel.Valor,
                CategoryId = transacaoViewModel.IdCategoria,
                UserId = transacaoViewModel.IdUsuario,
            };
            return newTransacao;
        }
    }
}
