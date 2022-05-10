using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class OrdenAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public OrdenAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Orden> GetAll()
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                ordenes = _context.Ordenes.Include(i => i.Cliente).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de ordenes", e);
                throw ExceptionManejada;
            }
            return ordenes;
        }
        public Business.Entities.Orden GetOne(int nroOrden)
        {
            try
            {
                return _context.Ordenes.FirstOrDefault(o => o.NroOrden == nroOrden);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de la orden", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Orden orden)
        {
            try
            {
                _context.Ordenes.Update(orden);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la orden", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Orden orden)
        {
            try
            {
                _context.Ordenes.Add(orden);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear orden", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int nroOrden)
        {
            Orden orden = new Orden();
            try
            {
               orden = _context.Ordenes.Find(nroOrden);
                _context.Ordenes.Remove(orden);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar orden", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Orden orden)
        {
            if (orden.State == BusinessEntity.States.New)
            {
                this.Insert(orden);
            }
            else if (orden.State == BusinessEntity.States.Deleted)
            {
                this.Delete(orden.NroOrden);
            }
            else if (orden.State == BusinessEntity.States.Modified)
            {
                this.Update(orden);
            }
            orden.State = BusinessEntity.States.Unmodified;
        }
        /*
        public Business.Entities.Cliente GetOneConCuit(string Cuit)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente = _context.Clientes.FirstOrDefault(c => c.Cuit == Cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                throw ExceptionManejada;
            }
            return cliente;
        }*/
    }
}
