using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class ProfesorPorMateriaRepository
    {
        private readonly EstudianteContext _context;

        public ProfesorPorMateriaRepository()
        {
            _context = new EstudianteContext();
        }

        public void AgregarProfesorPorMateria(ProfesorPorMateria profesorPorMateria)
        {
            _context.ProfesoresPorMaterias.Add(profesorPorMateria);
            _context.SaveChanges();
        }

        public void ActualizarProfesorPorMateria(ProfesorPorMateria profesorPorMateria)
        {
            _context.Entry(profesorPorMateria).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarProfesorPorMateria(int profesorPorMateriaId)
        {
            var profesorPorMateria = _context.ProfesoresPorMaterias.Find(profesorPorMateriaId);
            _context.ProfesoresPorMaterias.Remove(profesorPorMateria);
            _context.SaveChanges();
        }

        public ProfesorPorMateria ConsultarProfesorPorMateriaPorId(int profesorPorMateriaId)
        {
            return _context.ProfesoresPorMaterias.Find(profesorPorMateriaId);
        }

        public List<ProfesorPorMateria> ConsultarTodosLosProfesoresPorMateria()
        {
            return _context.ProfesoresPorMaterias.ToList();
        }

    }
}
