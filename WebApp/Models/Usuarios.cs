using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models

{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoRegistro { get; set; }

        public virtual ICollection<Perfil> Perfiles { get; set; }
        public virtual ICollection<Encuesta> Encuestas { get; set; }
        public virtual ICollection<Itinerarios> Itinerarios { get; set; }
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }
        public virtual ICollection<Retroalimentacion> Retroalimentaciones { get; set; }
    }
}
