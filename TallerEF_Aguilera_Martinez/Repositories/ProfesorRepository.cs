using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class ProfesorRepository
    {
        private readonly EstudianteContext _context;

        public ProfesorRepository()
        {
            _context = new EstudianteContext();
        }

        public void AgregarProfesor(Profesor profesor)
        {
            _context.Profesores.Add(profesor);
            _context.SaveChanges();
        }

        public void ActualizarProfesor(Profesor profesor)
        {
            _context.Entry(profesor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarProfesor(int profesorId)
        {
            var profesor = _context.Profesores.Find(profesorId);
            _context.Profesores.Remove(profesor);
            _context.SaveChanges();
        }

        public Profesor ConsultarProfesorPorId(int profesorId)
        {
            return _context.Profesores.Find(profesorId);
        }

        public List<Profesor> ConsultarTodosLosProfesores()
        {
            return _context.Profesores.ToList();
        }
    }
}
