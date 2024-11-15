using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;
using System.Xml.Linq;

namespace WebApp.Repositories
{
    public class NotificacionesRepository : INotificacionesRepository
    {
        private readonly AppDbContext context;

        public NotificacionesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Notificaciones>> GetNotificaciones()
        {
            var data = await context.Notificaciones.ToListAsync();
            return data;
        }

        public async Task<Notificaciones> GetNotificacionesById(int id)
        {
            var data = await context.Notificaciones.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Notificaciones> GetNotificacionesByName(string name)
        {
            var data = await context.Notificaciones.Where(x => x.ContenidoItinerario == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostNotificaciones(Notificaciones notificaciones)
        {
            await context.Notificaciones.AddAsync(notificaciones);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutNotificaciones(Notificaciones notificaciones)
        {
            context.Notificaciones.Update(notificaciones);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteNotificaciones(Notificaciones notificaciones)
        {
            context.Notificaciones.Remove(notificaciones);
            await context.SaveAsync();
            return true;
        }
    }
}