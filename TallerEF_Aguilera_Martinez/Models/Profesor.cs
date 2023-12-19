using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<ProfesorPorMateria> ProfesorPorMateria { get; set; }
        public List<DetalleParalelo> DetallesParalelos { get; set; }
    }
}
