using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;
using System.Xml.Linq;

namespace WebApp.Repositories
{
    public class RetroalimentacionRepository : IRetroalimentacionRepository
    {
        private readonly AppDbContext context;

        public RetroalimentacionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Retroalimentacion>> GetRetroalimentacion()
        {
            var data = await context.Retroalimentacion.ToListAsync();
            return data;
        }

        public async Task<Retroalimentacion> GetRetroalimentacionById(int id)
        {
            var data = await context.Retroalimentacion.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Retroalimentacion> GetRetroalimentacionByName(string name)
        {
            var data = await context.Retroalimentacion.Where(x => x.Comentarios == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostRetroalimentacion(Retroalimentacion retroalimentacion)
        {
            await context.Retroalimentacion.AddAsync(retroalimentacion);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutRetroalimentacion(Retroalimentacion retroalimentacion)
        {
            context.Retroalimentacion.Update(retroalimentacion);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteRetroalimentacion(Retroalimentacion retroalimentacion)
        {
            context.Retroalimentacion.Remove(retroalimentacion);
            await context.SaveAsync();
            return true;
        }
    }
}