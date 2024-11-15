using WebApp.Models;

namespace WebApp.Repositories.Interfaces
{
    public interface IAuditoriasRepository
    {
        Task<List<Auditorias>> GetAuditorias();

        Task<Auditorias> GetAuditoriasById(int id);

        Task<Auditorias> GetAuditoriasByName(string name);

        Task<bool> PostAuditorias(Auditorias auditorias);

        Task<bool> PutAuditorias(Auditorias auditorias);

        Task<bool> DeleteAuditorias(Auditorias auditorias);
    }
}