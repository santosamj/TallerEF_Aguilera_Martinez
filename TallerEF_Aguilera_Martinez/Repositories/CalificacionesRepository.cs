using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class CalificacionesRepository
    {
        private readonly EstudianteContext _context;

        public CalificacionesRepository()
        {
            _context = new EstudianteContext();
        }

        public void AgregarCalificacion(Calificaciones calificacion)
        {
            _context.Calificaciones.Add(calificacion);
            _context.SaveChanges();
        }

        public void ActualizarCalificacion(Calificaciones calificacion)
        {
            _context.Entry(calificacion).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarCalificacion(int calificacionId)
        {
            var calificacion = _context.Calificaciones.Find(calificacionId);
            _context.Calificaciones.Remove(calificacion);
            _context.SaveChanges();
        }

        public Calificaciones ConsultarCalificacionPorId(int calificacionId)
        {
            return _context.Calificaciones.Find(calificacionId);
        }

        public List<Calificaciones> ConsultarTodasLasCalificaciones()
        {
            return _context.Calificaciones.ToList();
        }
    }
}
