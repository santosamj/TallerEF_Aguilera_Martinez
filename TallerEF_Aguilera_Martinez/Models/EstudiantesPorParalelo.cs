using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class EstudiantesPorParalelo
    {
        public int Id { get; set; }
        public int IdDetalleParalelo { get; set; }
        public int IdEstudiante { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public DetalleParalelo DetalleParalelo { get; set; }
        public Estudiante Estudiante { get; set; }
        public List<Calificaciones> Calificaciones { get; set; }
    }
}
