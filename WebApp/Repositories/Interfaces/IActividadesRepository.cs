using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface IActividadesRepository
    {
        Task<List<Actividades>> GetActividades();

        Task<Actividades> GetActividadesById(int id);

        Task<Actividades> GetActividadesByName(string name);

        Task<bool> PostActividades(Actividades actividades);

        Task<bool> PutActividades(Actividades actividades);

        Task<bool> DeleteActividades(Actividades actividades);
    }
}
