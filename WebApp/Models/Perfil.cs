using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApp.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Preferencias { get; set; }
        public string Disponibilidad { get; set; }

        public virtual Usuarios Usuario { get; set; }
    }
}
