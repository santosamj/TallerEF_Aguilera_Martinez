using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class MateriaRepository
    {
        private readonly EstudianteContext _context;

        public MateriaRepository()
        {
            _context = new EstudianteContext();
        }

        public void AgregarMateria(Materia materia)
        {
            _context.Materias.Add(materia);
            _context.SaveChanges();
        }

        public void ActualizarMateria(Materia materia)
        {
            _context.Entry(materia).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarMateria(int materiaId)
        {
            var materia = _context.Materias.Find(materiaId);
            _context.Materias.Remove(materia);
            _context.SaveChanges();
        }

        public Materia ConsultarMateriaPorId(int materiaId)
        {
            return _context.Materias.Find(materiaId);
        }

        public List<Materia> ConsultarTodasLasMaterias()
        {
            return _context.Materias.ToList();
        }
    }
}