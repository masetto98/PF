using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class TipoPrendaAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public TipoPrendaAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<TipoPrenda> GetAll()
        {
            List<TipoPrenda> tipoPrendas = new List<TipoPrenda>();
            try
            {
                tipoPrendas = _context.TipoPrendas.Where(tp => tp.Borrado == false).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de servicios", e);
                throw ExceptionManejada;
            }
            return tipoPrendas;
        }
        public Business.Entities.TipoPrenda GetOne(int idTipoPrenda)
        {
            try
            {
                return _context.TipoPrendas.Where(tp => tp.Borrado == false).FirstOrDefault(s => s.IdTipoPrenda == idTipoPrenda);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del tipo de prenda", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(TipoPrenda tipoPrenda)
        {
            try
            {
                _context.TipoPrendas.Update(tipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del tipo de prenda", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(TipoPrenda tipoPrenda)
        {
            try
            {
                _context.TipoPrendas.Add(tipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear tipo de prenda", e);
                throw ExceptionManejada;
            }
        }
        /*
        public void Delete(int idTipoPrenda)
        {
            TipoPrenda tipoPrenda = new TipoPrenda();
            try
            {
                tipoPrenda = _context.TipoPrendas.Find(idTipoPrenda);
                _context.TipoPrendas.Remove(tipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar tipo de prenda", e);
                throw ExceptionManejada;
            }
        }*/

        public void Delete(int idTipoPrenda)
        {
            TipoPrenda tipoPrenda = new TipoPrenda();
            try
            {
                tipoPrenda = _context.TipoPrendas.Find(idTipoPrenda);
                tipoPrenda.Borrado = true;
                tipoPrenda.State = BusinessEntity.States.Modified;
                foreach (ServicioTipoPrenda stp in tipoPrenda.ServicioTipoPrenda)
                {
                    stp.Borrado = true;
                    stp.State = BusinessEntity.States.Modified;
                }
                _context.TipoPrendas.Update(tipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al borrar tipo de prenda", e);
                throw ExceptionManejada;
            }
        }

        public void Save(TipoPrenda tipoPrenda)
        {
            if (tipoPrenda.State == BusinessEntity.States.New)
            {
                this.Insert(tipoPrenda);
            }
            else if (tipoPrenda.State == BusinessEntity.States.Deleted)
            {
                this.Delete(tipoPrenda.IdTipoPrenda);
            }
            else if (tipoPrenda.State == BusinessEntity.States.Modified)
            {
                this.Update(tipoPrenda);
            }
            tipoPrenda.State = BusinessEntity.States.Unmodified;
        }
    }
}
