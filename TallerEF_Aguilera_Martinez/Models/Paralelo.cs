using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class Paralelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Grupo { get; set; }
        public string Jornada { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<DetalleParalelo> DetallesParalelos { get; set; }
    }
}
