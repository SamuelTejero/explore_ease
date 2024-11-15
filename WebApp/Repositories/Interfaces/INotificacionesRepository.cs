using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface INotificacionesRepository
    {
        Task<List<Notificaciones>> GetNotificaciones();

        Task<Notificaciones> GetNotificacionesById(int id);

        Task<Notificaciones> GetNotificacionesByName(string name);

        Task<bool> PostNotificaciones(Notificaciones notificaciones);

        Task<bool> PutNotificaciones(Notificaciones notificaciones);

        Task<bool> DeleteNotificaciones(Notificaciones notificaciones);
    }
}
