using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEF_Aguilera_Martinez.Models;

namespace TallerEF_Aguilera_Martinez.Repositories
{
    public class DetalleParaleloRepository
    {
        private readonly EstudianteContext _context;

        public DetalleParaleloRepository()
        {
            _context = new EstudianteContext();
        }

        public void AgregarDetalleParalelo(DetalleParalelo detalleParalelo)
        {
            _context.DetallesParalelos.Add(detalleParalelo);
            _context.SaveChanges();
        }

        public void ActualizarDetalleParalelo(DetalleParalelo detalleParalelo)
        {
            _context.Entry(detalleParalelo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarDetalleParalelo(int detalleParaleloId)
        {
            var detalleParalelo = _context.DetallesParalelos.Find(detalleParaleloId);
            _context.DetallesParalelos.Remove(detalleParalelo);
            _context.SaveChanges();
        }

        public DetalleParalelo ConsultarDetalleParaleloPorId(int detalleParaleloId)
        {
            return _context.DetallesParalelos.Find(detalleParaleloId);
        }

        public List<DetalleParalelo> ConsultarTodosLosDetallesParalelo()
        {
            return _context.DetallesParalelos.ToList();
        }
    }
}
