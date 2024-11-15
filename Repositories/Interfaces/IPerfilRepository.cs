
using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface IPerfilRepository
    {
        Task<List<Perfil>> GetPerfil();

        Task<Perfil> GetPerfilById(int id);

        Task<Perfil> GetPerfilByName(string name);

        Task<bool> PostPerfil(Perfil perfil);

        Task<bool> PutPerfil(Perfil perfil);

        Task<bool> DeletePerfil(Perfil perfil);
    }
}
