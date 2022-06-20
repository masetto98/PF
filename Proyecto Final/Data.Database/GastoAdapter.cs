using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class GastoAdapter:Adapter
    {
        private readonly LavanderiaContext _context;

        public GastoAdapter(LavanderiaContext context)
        {
            _context = context;
        }

        public List<Gasto> GetAll()
        {
            List<Gasto> gastos = new List<Gasto>();
            try
            {
                gastos = _context.Gastos.ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de gastos", e);
                throw ExceptionManejada;
            }
            return gastos;
        }

        public Gasto GetOne(int idGasto)
        {
            try
            {
                return _context.Gastos.FirstOrDefault(g => g.IdGasto == idGasto);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del gasto", e);
                throw ExceptionManejada;
            }
            return null;
        }

        protected void Update(Gasto gasto)
        {
            try
            {
                _context.Gastos.Update(gasto);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del gasto", e);
                throw ExceptionManejada;
            }
        }

        protected void Insert(Gasto gasto)
        {
            try
            {
                _context.Gastos.Add(gasto);
                _context.SaveChanges();
            }
             catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear gasto", e);
                throw ExceptionManejada;
            }
        }

        public void Delete(int idGasto)
        {
            Gasto gasto = new Gasto();
            try
            {
                gasto = _context.Gastos.Find(idGasto);
                _context.Gastos.Remove(gasto);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar gasto", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Gasto gasto )
        {
            if (gasto.State == BusinessEntity.States.New)
            {
                this.Insert(gasto);
            }
            else if (gasto.State == BusinessEntity.States.Deleted)
            {
                this.Delete(gasto.IdGasto);
            }
            else if (gasto.State == BusinessEntity.States.Modified)
            {
                this.Update(gasto);
            }
            gasto.State = BusinessEntity.States.Unmodified;
        }
    }
}
