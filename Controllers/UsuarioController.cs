using conexiondebasededatos.Services;
using Microsoft.AspNetCore.Mvc;
using conexiondebasededatos.Models;
using conexiondebasededatos.Dtos;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace conexiondebasededatos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            var usuarios = await _usuarioService.ObtenerUsuarios();
            return Ok(usuarios);
        }

        

        // POST api/<UsuarioController>
        [HttpPost]
       public async Task<ActionResult<string>> PostUsuario([FromBody]AgregarUsuarioDto usuario)
        {
            var resultado = await _usuarioService.createUsuario(usuario);
            return Ok(resultado);
        }

    }
}
