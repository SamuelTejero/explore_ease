using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;

namespace WebApp.Repositories
{
    public class ActividadesRepository : IActividadesRepository
    {
        private readonly AppDbContext context;

        public ActividadesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Actividades>> GetActividades()
        {
            var data = await context.Actividades.ToListAsync();
            return data;
        }

        public async Task<Actividades> GetActividadesById(int id)
        {
            var data = await context.Actividades.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Actividades> GetActividadesByName(string name)
        {
            var data = await context.Actividades.Where(x => x.NombreActividad == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostActividades(Actividades actividades)
        {
            await context.Actividades.AddAsync(actividades);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutActividades(Actividades actividades)
        {
            context.Actividades.Update(actividades);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteActividades(Actividades actividades)
        {
            context.Actividades.Remove(actividades);
            await context.SaveAsync();
            return true;
        }
    }
}