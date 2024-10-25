using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApp.Models
{
    public class Actividades
    {
        public int Id { get; set; }
        public string NombreActividad { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }

        public virtual ICollection<Retroalimentacion> Retroalimentaciones { get; set; }
    }

}
