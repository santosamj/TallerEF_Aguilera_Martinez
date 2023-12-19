using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class ParaleloRepository
    {
        private readonly EstudianteContext _context;

        public ParaleloRepository()
        {
            _context = new EstudianteContext();
        }

        public void AgregarParalelo(Paralelo paralelo)
        {
            _context.Paralelos.Add(paralelo);
            _context.SaveChanges();
        }

        public void ActualizarParalelo(Paralelo paralelo)
        {
            _context.Entry(paralelo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarParalelo(int paraleloId)
        {
            var paralelo = _context.Paralelos.Find(paraleloId);
            _context.Paralelos.Remove(paralelo);
            _context.SaveChanges();
        }

        public Paralelo ConsultarParaleloPorId(int paraleloId)
        {
            return _context.Paralelos.Find(paraleloId);
        }

        public List<Paralelo> ConsultarTodosLosParalelos()
        {
            return _context.Paralelos.ToList();
        }
    }
}
