using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class InsumoAdapter:Adapter
    {
        private readonly LavanderiaContext _context;
        public InsumoAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Insumo> GetAll()
        {
            List<Insumo> insumos = new List<Insumo>();
            try
            {
                insumos = _context.Insumos.
                    ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de insumos", e);
                throw ExceptionManejada;
            }
            return insumos;
        }
        public Business.Entities.Insumo GetOne(int idInsumo)
        {
            try
            {
                return _context.Insumos.FirstOrDefault(i => i.IdInsumo == idInsumo);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del insumo", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Insumo insumo)
        {
            try
            {
                _context.Insumos.Update(insumo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del insumo", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Insumo insumo)
        {
            try
            {
                _context.Insumos.Add(insumo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear insumo", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idInsumo)
        {
            Insumo insumo = new Insumo();
            try
            {
                insumo = _context.Insumos.Find(idInsumo);
                _context.Insumos.Remove(insumo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar insumo", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Insumo insumo)
        {
            if (insumo.State == BusinessEntity.States.New)
            {
                this.Insert(insumo);
            }
            else if (insumo.State == BusinessEntity.States.Deleted)
            {
                this.Delete(insumo.IdInsumo);
            }
            else if (insumo.State == BusinessEntity.States.Modified)
            {
                this.Update(insumo);
            }
            insumo.State = BusinessEntity.States.Unmodified;
        }

    }
}
