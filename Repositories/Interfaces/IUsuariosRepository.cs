
using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<List<Usuarios>> GetUsuarios();

        Task<Usuarios> GetUsuariosById(int id);

        Task<Usuarios> GetUsuariosByName(string name);

        Task<bool> PostUsuarios(Usuarios usuarios);

        Task<bool> PutUsuarios(Usuarios usuarios);

        Task<bool> DeleteUsuarios(Usuarios usuarios);
    }
}
