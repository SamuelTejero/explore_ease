using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApp.Models
{
    public class Retroalimentacion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ActividadId { get; set; }
        public string Comentarios { get; set; }
        public int Calificacion { get; set; }

        public virtual Usuarios Usuario { get; set; }
        public virtual Actividades Actividad { get; set; }
    }
}
