using WebApp.Models;
using WebApp.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApp.Context;
using System.Xml.Linq;

namespace WebApp.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly AppDbContext context;

        public UsuariosRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            var data = await context.Usuarios.ToListAsync();
            return data;
        }

        public async Task<Usuarios> GetUsuariosById(int id)
        {
            var data = await context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Usuarios> GetUsuariosByName(string name)
        {
            var data = await context.Usuarios.Where(x => x.Nombre == name).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostUsuarios(Usuarios usuarios)
        {
            await context.Usuarios.AddAsync(usuarios);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutUsuarios(Usuarios usuarios)
        {
            context.Usuarios.Update(usuarios);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteUsuarios(Usuarios usuarios)
        {
            context.Usuarios.Remove(usuarios);
            await context.SaveAsync();
            return true;
        }
    }
}