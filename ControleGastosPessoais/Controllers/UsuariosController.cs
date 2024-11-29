using ControleGastosPessoais.Models;
using ControleGastosPessoais.ViewsModels;
using ControleGastosPessoais.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace ControleGastosPessoais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : MainControllerApi
    {
        private readonly ILogger<UsuariosController> _logger;
        private readonly ApiDbContext _context;

        public UsuariosController(ILogger<UsuariosController> logger, ApiDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("/Usuarios/Login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel loginViewModel)
        {
            try
            {
                var usuarioCadastrado = await _context.Usuarios.Where(x => x.Email == loginViewModel.Email && x.Password == loginViewModel.Senha).FirstOrDefaultAsync();
                return Ok(usuarioCadastrado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("/Usuarios/Inserir")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Inserir(UsuarioViewModel usuarioViewModel)
        {
            try
            {
                var addUsuario = UsuarioViewModelToUsuario(null, usuarioViewModel);
                _context.Usuarios.Add(addUsuario);
                await _context.SaveChangesAsync();
                return Ok(addUsuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private Usuario UsuarioViewModelToUsuario(Guid? id, UsuarioViewModel usuarioViewModel)
        {
            var newUsuario = new Usuario()
            {
                Id = Guid.NewGuid(),
                Name = usuarioViewModel.Name,
                Email = usuarioViewModel.Email,
                Password = usuarioViewModel.Password
            };
            return newUsuario;
        }
    }
}