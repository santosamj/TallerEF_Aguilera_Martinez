using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class ProfesorPorMateria
    {
        public int ProfesorPorMateriaId { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
