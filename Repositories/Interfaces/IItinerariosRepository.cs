using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface IItinerariosRepository
    {
        Task<List<Itinerarios>> GetItinerarios();

        Task<Itinerarios> GetItinerariosById(int id);

        Task<Itinerarios> GetItinerariosByName(string name);

        Task<bool> PostItinerarios(Itinerarios itinerarios);

        Task<bool> PutItinerarios(Itinerarios itinerarios);

        Task<bool> DeleteItinerarios(Itinerarios itinerarios);
    }
}
