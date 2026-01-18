using conexiondebasededatos.Models;
using conexiondebasededatos.Dtos;
namespace conexiondebasededatos.Services
{
    public interface IUsuarioService
    {
        public Task<List<Usuario>> ObtenerUsuarios();
        public Task<string> createUsuario(AgregarUsuarioDto usuario);

    }
}
