using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;

namespace WebApp.Repositories
{
    public class EncuestaRepository : IEncuestaRepository
    {
        private readonly AppDbContext context;

        public EncuestaRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Encuesta>> GetEncuesta()
        {
            var data = await context.Encuesta.ToListAsync();
            return data;
        }

        public async Task<Encuesta> GetEncuestaById(int id)
        {
            var data = await context.Encuesta.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Encuesta> GetEncuestaByName(string name)
        {
            var data = await context.Encuesta.Where(x => x.GustoActividades == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostEncuesta(Encuesta encuesta)
        {
            await context.Encuesta.AddAsync(encuesta);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutEncuesta(Encuesta encuesta)
        {
            context.Encuesta.Update(encuesta);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteEncuesta(Encuesta encuesta)
        {
            context.Encuesta.Remove(encuesta);
            await context.SaveAsync();
            return true;
        }
    }
}