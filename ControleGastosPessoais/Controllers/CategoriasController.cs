using ControleGastosPessoais.Data;
using ControleGastosPessoais.Models;
using ControleGastosPessoais.ViewsModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleGastosPessoais.Controllers
{
    public class CategoriasController : MainControllerApi
    {
        private readonly ILogger<CategoriasController> _logger;
        private readonly ApiDbContext _context;

        public CategoriasController(ILogger<CategoriasController> logger, ApiDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("/Categorias/Listar")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Listar()
        {
            try
            {
                var listCategorias = await _context.Categorias.ToListAsync();
                return Ok(listCategorias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("/Categorias/Inserir")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Inserir(CategoriaViewModel categoriaViewModel)
        {
            try
            {
                var addCategoria = CategoriaViewModelToCategoria(categoriaViewModel);
                _context.Categorias.Add(addCategoria);
                await _context.SaveChangesAsync();
                return Ok(addCategoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private Categoria CategoriaViewModelToCategoria(CategoriaViewModel categoriaViewModel)
        {
            var newCategoria = new Categoria()
            {
                Id = Guid.NewGuid(),
                Name = categoriaViewModel.Name
            };
            return newCategoria;
        }
    }
}
