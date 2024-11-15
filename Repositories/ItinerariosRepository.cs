using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;

namespace WebApp.Repositories
{
    public class ItinerariosRepository : IItinerariosRepository
    {
        private readonly AppDbContext context;

        public ItinerariosRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Itinerarios>> GetItinerarios()
        {
            var data = await context.Itinerarios.ToListAsync();
            return data;
        }

        public async Task<Itinerarios> GetItinerariosById(int id)
        {
            var data = await context.Itinerarios.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Itinerarios> GetItinerariosByName(string name)
        {
            var data = await context.Itinerarios.Where(x => x.ContenidoItinerario == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostItinerarios(Itinerarios itinerarios)
        {
            await context.Itinerarios.AddAsync(itinerarios);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutItinerarios(Itinerarios itinerarios)
        {
            context.Itinerarios.Update(itinerarios);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteItinerarios(Itinerarios itinerarios)
        {
            context.Itinerarios.Remove(itinerarios);
            await context.SaveAsync();
            return true;
        }
    }
}