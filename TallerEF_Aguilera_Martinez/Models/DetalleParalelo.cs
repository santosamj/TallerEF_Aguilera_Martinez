using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class DetalleParalelo
    {
        public int Id { get; set; }
        public int IdParalelo { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }

        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Paralelo Paralelo { get; set; }
        public Materia Materia { get; set; }
        public Profesor Profesor { get; set; }
        public List<EstudiantesPorParalelo> EstudiantesPorParalelos { get; set; }
    }
}
