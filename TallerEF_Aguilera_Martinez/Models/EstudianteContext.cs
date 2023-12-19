using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEF_Aguilera_Martinez.Models
{
    public class EstudianteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EstudianteTaller73;Trusted_Connection=True;");
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<ProfesorPorMateria> ProfesoresPorMaterias { get; set; }
        public DbSet<EstudiantesPorParalelo> EstudiantesPorParalelos { get; set; }
        public DbSet<Paralelo> Paralelos { get; set; }
        public DbSet<DetalleParalelo> DetallesParalelos { get; set; }
        public DbSet<Calificaciones> Calificaciones { get; set; }

    }
}
