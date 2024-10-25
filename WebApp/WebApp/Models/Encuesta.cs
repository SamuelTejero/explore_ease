using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApp.Models
{
    public class Encuesta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string GustoActividades { get; set; }
        public string FrecuenciaActividades { get; set; }
        public string HorariosDisponibles { get; set; }

        public virtual Usuarios Usuario { get; set; }
    }
}
