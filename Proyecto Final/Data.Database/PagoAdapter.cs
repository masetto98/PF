using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class PagoAdapter:Adapter
    {
        private readonly LavanderiaContext _context;
        public PagoAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Pago> GetAll()
        {
            List<Pago> pagos = new List<Pago>();
            try
            {
                pagos = _context.Pagos.Where(p => p.Borrado == false).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de pagos", e);
                throw ExceptionManejada;
            }
            return pagos;
        }
        public Business.Entities.Pago GetOne(int nroFactura, DateTime fechaPago)
        {
            try
            {
                return _context.Pagos.Where(p => p.Borrado == false).FirstOrDefault(p => p.NroFactura == nroFactura && p.FechaPago == fechaPago);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del pago", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Pago pago)
        {
            try
            {
                _context.Pagos.Update(pago);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del pago", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Pago pago)
        {
            try
            {
                _context.Pagos.Add(pago);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear el pago", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int nroFactura, DateTime fechaPago)
        {
            Pago pago = new Pago();
            try
            {
                pago = _context.Pagos.Find(nroFactura,fechaPago);
                _context.Pagos.Remove(pago);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar pago", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Pago pago)
        {
            if (pago.State == BusinessEntity.States.New)
            {
                this.Insert(pago);
            }
            else if (pago.State == BusinessEntity.States.Deleted)
            {
                this.Delete(pago.NroFactura,pago.FechaPago);
            }
            else if (pago.State == BusinessEntity.States.Modified)
            {
                this.Update(pago);
            }
            pago.State = BusinessEntity.States.Unmodified;
        }
        
    }
}
