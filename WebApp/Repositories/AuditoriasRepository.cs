using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;

namespace WebApp.Repositories
{
    public class AuditoriasRepository : IAuditoriasRepository
    {
        private readonly AppDbContext context;

        public AuditoriasRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Auditorias>> GetAuditorias()
        {
            var data = await context.Auditorias.ToListAsync();
            return data;
        }

        public async Task<Auditorias> GetAuditoriasById(int id)
        {
            var data = await context.Auditorias.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Auditorias> GetAuditoriasByName(string name)
        {
            var data = await context.Auditorias.Where(x => x.Accion == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostAuditorias(Auditorias auditorias)
        {
            await context.Auditorias.AddAsync(auditorias);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutAuditorias(Auditorias auditorias)
        {
            context.Auditorias.Update(auditorias);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteAuditorias(Auditorias auditorias)
        {
            context.Auditorias.Remove(auditorias);
            await context.SaveAsync();
            return true;
        }
    }
}