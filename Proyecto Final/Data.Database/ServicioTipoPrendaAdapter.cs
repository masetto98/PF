using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class ServicioTipoPrendaAdapter : Adapter
    {
        private readonly LavanderiaContext _context;

        public ServicioTipoPrendaAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<ServicioTipoPrenda> GetAll()
        {
            List<ServicioTipoPrenda> serviciosTipoPrendas = new List<ServicioTipoPrenda>();
            try
            {
                serviciosTipoPrendas = _context.ServiciosTipoPrendas.Include(i=>i.Servicio).Include(i => i.TipoPrenda).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de servicios - tipo prenda", e);
                throw ExceptionManejada;
            }
            return serviciosTipoPrendas;
        }
        public Business.Entities.ServicioTipoPrenda GetOne(int idServicio,int idTipoPrenda)
        {
            try
            {
                return _context.ServiciosTipoPrendas.Include(i => i.Servicio).Include(i => i.TipoPrenda).FirstOrDefault(stp => stp.IdTipoPrenda == idTipoPrenda && stp.IdServicio == idServicio );
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del servicio-tipo prenda", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(ServicioTipoPrenda servicioTipoPrenda)
        {
            try
            {
                _context.ServiciosTipoPrendas.Update(servicioTipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del servicio - tipo prenda", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(ServicioTipoPrenda servicioTipoPrenda)
        {
            try
            {
                _context.ServiciosTipoPrendas.Add(servicioTipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear servicio - tipo prenda", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idServicio,int idTipoPrenda)
        {
            ServicioTipoPrenda servicioTipoPrenda = new ServicioTipoPrenda();
            try
            {
                servicioTipoPrenda = _context.ServiciosTipoPrendas.Find(idServicio,idTipoPrenda);
                _context.ServiciosTipoPrendas.Remove(servicioTipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar tipo de prenda", e);
                throw ExceptionManejada;
            }
        }

        public void Save(ServicioTipoPrenda servicioTipoPrenda)
        {
            if (servicioTipoPrenda.State == BusinessEntity.States.New)
            {
                this.Insert(servicioTipoPrenda);
            }
            else if (servicioTipoPrenda.State == BusinessEntity.States.Deleted)
            {
                this.Delete(servicioTipoPrenda.IdServicio,servicioTipoPrenda.IdTipoPrenda );
            }
            else if (servicioTipoPrenda.State == BusinessEntity.States.Modified)
            {
                this.Update(servicioTipoPrenda);
            }
            servicioTipoPrenda.State = BusinessEntity.States.Unmodified;
        }
    }
}
