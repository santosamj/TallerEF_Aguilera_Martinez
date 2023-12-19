using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<EstudiantesPorParalelo> EstudiantesPorParalelos { get; set; }
        

    }
}
