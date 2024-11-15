using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApp.Models
{
    public class Notificaciones
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string TipoNotificacion { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }

        public virtual Usuarios Usuario { get; set; }
    }
}
