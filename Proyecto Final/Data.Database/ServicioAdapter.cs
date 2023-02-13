using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class ServicioAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public ServicioAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Servicio> GetAll()
        {
            List<Servicio> servicios = new List<Servicio>();
            try
            {
                servicios = _context.Servicios.Where(s => s.Borrado == false).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de servicios", e);
                throw ExceptionManejada;
            }
            return servicios;
        }
        public Business.Entities.Servicio GetOne(int idServicio)
        {
            try
            {
                return _context.Servicios.Where(s => s.Borrado == false).FirstOrDefault(s => s.IdServicio == idServicio);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del servicio", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Servicio servicio)
        {
            try
            {
                _context.Servicios.Update(servicio);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del servicio", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Servicio servicio)
        {
            try
            {
                _context.Servicios.Add(servicio);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear servicio", e);
                throw ExceptionManejada;
            }
        }
        /*
        public void Delete(int idServicio)
        {
            Servicio servicio = new Servicio();
            try
            {
                servicio = _context.Servicios.Find(idServicio);
                _context.Servicios.Remove(servicio);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar servicio", e);
                throw ExceptionManejada;
            }
        }*/

        public void Delete(int idServicio)
        {
            Servicio servicio = new Servicio();
            try
            {
                servicio = _context.Servicios.Find(idServicio);
                servicio.Borrado = true;
                servicio.State = BusinessEntity.States.Modified;
                foreach (ServicioTipoPrenda stp in servicio.ServicioTipoPrenda)
                {
                    stp.Borrado = true;
                    stp.State = BusinessEntity.States.Modified;
                }
                _context.Servicios.Update(servicio);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al borrar servicio", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Servicio servicio)
        {
            if (servicio.State == BusinessEntity.States.New)
            {
                this.Insert(servicio);
            }
            else if (servicio.State == BusinessEntity.States.Deleted)
            {
                this.Delete(servicio.IdServicio);
            }
            else if (servicio.State == BusinessEntity.States.Modified)
            {
                this.Update(servicio);
            }
            servicio.State = BusinessEntity.States.Unmodified;
        }
    }
}
