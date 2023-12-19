using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class EstudianteReposity
    {
        //establecer el objeto de contexto    
        private readonly EstudianteContext _context = new EstudianteContext();

        //establecer los metodos crud
        public void agregarEstudiante(Estudiante estudiante)
        {
            //agregar el objeto
            _context.Estudiantes.Add(estudiante);
            //actualizar los cambios
            _context.SaveChanges();
        }

        public void actualizarEstudiante(Estudiante estudiante)
        {
            //actualizar el objeto
            _context.Entry(estudiante).State = EntityState.Modified;
            //actualizar los cambios
            _context.SaveChanges();
        }

        public void eliminarEstudiante(int codigo)
        {
            //buscar el objeto por id
            var estudiante = _context.Estudiantes.Find(codigo);
            //eliminar el objeto
            _context.Estudiantes.Remove(estudiante);
            //actualizar los cambios
            _context.SaveChanges();
        }

        public Estudiante consultarEstudiantePorId(int codigo)
        {
            return _context.Estudiantes.Find(codigo);
        }

        public List<Estudiante> consultarEstudiantes()
        {
            return _context.Estudiantes.ToList();
        }

    }
}
