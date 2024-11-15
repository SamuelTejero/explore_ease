
using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface IRetroalimentacionRepository
    {
        Task<List<Retroalimentacion>> GetRetroalimentacion();

        Task<Retroalimentacion> GetRetroalimentacionById(int id);

        Task<Retroalimentacion> GetRetroalimentacionByName(string name);

        Task<bool> PostRetroalimentacion(Retroalimentacion retroalimentacion);

        Task<bool> PutRetroalimentacion(Retroalimentacion retroalimentacion);

        Task<bool> DeleteRetroalimentacion(Retroalimentacion retroalimentacion);
    }
}
