using conexiondebasededatos.Data;
using conexiondebasededatos.Dtos;
using conexiondebasededatos.Models;
using Microsoft.EntityFrameworkCore;
namespace conexiondebasededatos.Services
{
    public class UsuarioService: IUsuarioService
    {
       private readonly AppDBContext  _dbContext;
        public UsuarioService (AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Usuario>> ObtenerUsuarios()
        {
            return await _dbContext.usuarios.Include(u => u.contactos).ToListAsync();
        }
        public async Task<string> createUsuario(AgregarUsuarioDto usuarioDto)
        {
            var nuevoUsuario = new Usuario()
            {
                nombre = usuarioDto.nombre,
                edad = usuarioDto.edad
            };
            _dbContext.usuarios.Add(nuevoUsuario);
            await _dbContext.SaveChangesAsync();
            return "Usuario creado exitosamente";
        }
    }
}
