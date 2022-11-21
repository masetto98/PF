using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class FacturaAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public FacturaAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Factura> GetAll()
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                facturas = _context.Facturas.Where(f => f.Borrado == false).Include(f => f.Pagos.Where(p => p.Borrado == false)).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de facturas", e);
                throw ExceptionManejada;
            }
            return facturas;
        }
        public Business.Entities.Factura GetOne(int nroFactura)
        {
            try
            {
                return _context.Facturas.Where(f => f.Borrado == false).Include(f => f.Pagos.Where(p => p.Borrado == false)).FirstOrDefault(f => f.NroFactura ==nroFactura);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de la factura", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Factura factura)
        {
            try
            {
                _context.Facturas.Update(factura);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la factura", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Factura factura)
        {
            try
            {
                _context.Facturas.Add(factura);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
            Exception ExceptionManejada = new Exception("Error al crear factura", e);
            throw ExceptionManejada;
            }
        }
        public void Delete(int nroFactura)
        {
            Factura factura = new Factura();
            try
            {
                factura = _context.Facturas.Find(nroFactura);
                _context.Facturas.Remove(factura);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar factura", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Factura factura)
        {
            if (factura.State == BusinessEntity.States.New)
            {
                this.Insert(factura);
            }
            else if (factura.State == BusinessEntity.States.Deleted)
            {
                this.Delete(factura.NroFactura);
            }
            else if (factura.State == BusinessEntity.States.Modified)
            {
                this.Update(factura);
            }
            factura.State = BusinessEntity.States.Unmodified;
        }
    }
}
