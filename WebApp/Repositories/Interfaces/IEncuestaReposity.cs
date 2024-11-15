using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface IEncuestaRepository
    {
        Task<List<Encuesta>> GetEncuesta();

        Task<Encuesta> GetEncuestaById(int id);

        Task<Encuesta> GetEncuestaByName(string name);

        Task<bool> PostEncuesta(Encuesta encuesta);

        Task<bool> PutEncuesta(Encuesta encuesta);

        Task<bool> DeleteEncuesta(Encuesta encuesta);
    }
}