using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class Calificaciones
    {
        public int Id { get; set; }
        public int IdEstudiantesPorParalelo { get; set; }
        public float GF_P1 { get; set; }
        public float GP_P1 { get; set; }
        public float EXA_P1 { get; set; }
        public float PRO_P1 { get; set; }
        public float GF_P2 { get; set; }
        public float GP_P2 { get; set; }
        public float EXA_P2 { get; set; }
        public float PRO_P2 { get; set; }
        public float PRO_GEN { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public EstudiantesPorParalelo EstudiantesPorParalelo { get; set; }
    }
}
