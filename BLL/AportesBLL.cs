using Abraham_API1_P1.DAL;
using Abraham_API1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace Abraham_API1_P1.BLL
{
    public class AportesBLL
    {
        private readonly Context _context;

        public AportesBLL(Context context)
        {
            _context = context;
        }

        public bool Existe(int id)
        {
           return _context.Aportes.Any(a => a.AporteId == id);
        }

        public bool Insertar(Aportes aportes)
        {
            if(aportes != null)
            {
                _context.Aportes.Add(aportes);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Modificar(Aportes aportes)
        {
            if(aportes != null)
            {
                _context.Entry(aportes).State = EntityState.Modified;
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Guardar(Aportes aportes) 
        {
            if(Existe(aportes.AporteId))
                return Modificar(aportes);
            else
                return Insertar(aportes);
        }

        public bool Eliminar(Aportes aportes) 
        {
                _context.Entry(aportes).State = EntityState.Deleted;
                return _context.SaveChanges() > 0;
        }

        public Aportes? Buscar(int id)
        {
            return _context.Aportes.AsNoTracking().Where(a => a.AporteId == id).SingleOrDefault();
        }

        public List<Aportes> GetList(Expression<Func<Aportes,bool>> criterio)
        {
            return _context.Aportes.AsNoTracking().Where(criterio).ToList();
        }
    }
}
