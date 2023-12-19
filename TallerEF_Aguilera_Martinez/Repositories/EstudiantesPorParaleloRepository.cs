using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class EstudiantesPorParaleloRepository
    {
        private readonly EstudianteContext _context;

        public EstudiantesPorParaleloRepository()
        {
            _context = new EstudianteContext();
        }

        public void AgregarEstudiantesPorParalelo(EstudiantesPorParalelo estudiantesPorParalelo)
        {
            _context.EstudiantesPorParalelos.Add(estudiantesPorParalelo);
            _context.SaveChanges();
        }

        public void ActualizarEstudiantesPorParalelo(EstudiantesPorParalelo estudiantesPorParalelo)
        {
            _context.Entry(estudiantesPorParalelo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarEstudiantesPorParalelo(int estudiantesPorParaleloId)
        {
            var estudiantesPorParalelo = _context.EstudiantesPorParalelos.Find(estudiantesPorParaleloId);
            _context.EstudiantesPorParalelos.Remove(estudiantesPorParalelo);
            _context.SaveChanges();
        }

        public EstudiantesPorParalelo ConsultarEstudiantesPorParaleloPorId(int estudiantesPorParaleloId)
        {
            return _context.EstudiantesPorParalelos.Find(estudiantesPorParaleloId);
        }

        public List<EstudiantesPorParalelo> ConsultarTodosLosEstudiantesPorParalelo()
        {
            return _context.EstudiantesPorParalelos.ToList();
        }
    }
}
