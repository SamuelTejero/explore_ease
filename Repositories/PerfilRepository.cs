using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;
using System.Xml.Linq;

namespace WebApp.Repositories
{
    public class PerfilRepository : IPerfilRepository
    {
        private readonly AppDbContext context;

        public PerfilRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Perfil>> GetPerfil()
        {
            var data = await context.Perfil.ToListAsync();
            return data;
        }

        public async Task<Perfil> GetPerfilById(int id)
        {
            var data = await context.Perfil.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Perfil> GetPerfilByName(string name)
        {
            var data = await context.Perfil.Where(x => x.Preferencias == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostPerfil(Perfil perfil)
        {
            await context.Perfil.AddAsync(perfil);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutPerfil(Perfil perfil)
        {
            context.Perfil.Update(perfil);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeletePerfil(Perfil perfil)
        {
            context.Perfil.Remove(perfil);
            await context.SaveAsync();
            return true;
        }
    }
}