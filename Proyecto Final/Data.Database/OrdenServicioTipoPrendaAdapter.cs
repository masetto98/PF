using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class OrdenServicioTipoPrendaAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public OrdenServicioTipoPrendaAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<OrdenServicioTipoPrenda> GetAll()
        {
            List<OrdenServicioTipoPrenda> itemsOrden = new List<OrdenServicioTipoPrenda>();
            try
            {
                itemsOrden = _context.OrdenesServiciosTipoPrendas.Where(i => i.Borrado == false)
                    .Include(i => i.Orden)
                    .Include(i => i.ServicioTipoPrenda)
                        .ThenInclude(stp => stp.Servicio)
                    .Include(i => i.ServicioTipoPrenda)
                        .ThenInclude(stp => stp.TipoPrenda)
                    .ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de trabajos", e);
                throw ExceptionManejada;
            }
            return itemsOrden;
        }
        public Business.Entities.OrdenServicioTipoPrenda GetOne(int nroOrden,int idServicio, int idTipoPrenda,int ordenItem)
        {
            try
            {
                return _context.OrdenesServiciosTipoPrendas.Where(i => i.Borrado == false)
                    .Include(i => i.Orden)
                    .Include(i => i.ServicioTipoPrenda)
                        .ThenInclude(stp => stp.InsumoServicioTipoPrenda)
                            .ThenInclude(stp => stp.Insumo)
                    .Include(i => i.ServicioTipoPrenda)
                        .ThenInclude(stp => stp.TipoPrenda)
                    .Include(i => i.MaquinaOrdenServicioTipoPrenda.Where(mostp => mostp.Borrado == false))
                    .FirstOrDefault(o => o.NroOrden == nroOrden && o.IdServicio==idServicio && o.IdTipoPrenda==idTipoPrenda && o.OrdenItem==ordenItem);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del trabajo", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(OrdenServicioTipoPrenda itemOrden)
        {
            try
            {
                _context.OrdenesServiciosTipoPrendas.Update(itemOrden);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del trabajo", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(OrdenServicioTipoPrenda itemOrden)
        {
            try
            {
                _context.OrdenesServiciosTipoPrendas.Add(itemOrden);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear un trabajo", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int nroOrden, int idServicio, int idTipoPrenda, int ordenItem)
        {
            OrdenServicioTipoPrenda itemOrden = new OrdenServicioTipoPrenda();
            try
            {
               itemOrden = _context.OrdenesServiciosTipoPrendas.Find(nroOrden,idServicio,idTipoPrenda,ordenItem);
                _context.OrdenesServiciosTipoPrendas.Remove(itemOrden);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar trabajo", e);
                throw ExceptionManejada;
            }
        }

        public void Save(OrdenServicioTipoPrenda itemOrden)
        {
            if (itemOrden.State == BusinessEntity.States.New)
            {
                this.Insert(itemOrden);
            }
            else if (itemOrden.State == BusinessEntity.States.Deleted)
            {
                this.Delete(itemOrden.NroOrden,itemOrden.IdServicio,itemOrden.IdTipoPrenda,itemOrden.OrdenItem);
            }
            else if (itemOrden.State == BusinessEntity.States.Modified)
            {
                this.Update(itemOrden);
            }
            itemOrden.State = BusinessEntity.States.Unmodified;
        }

        public List<OrdenServicioTipoPrenda> GetItemsPendientes()
        {
            try
            {
                var consulta = from items in GetAll() where items.Estado != OrdenServicioTipoPrenda.Estados.Finalizado && items.Borrado == false
                               orderby items.Orden.FechaEntrada descending
                               select items;
                               
                return consulta.ToList<OrdenServicioTipoPrenda>();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar trabajos pendientes", e);
                throw ExceptionManejada;
            }
        }

        public List<OrdenServicioTipoPrenda> GetItemsEnProceso()
        {
            try
            {
                var consulta = from items in GetAll()
                               where items.Estado == OrdenServicioTipoPrenda.Estados.Procesando && items.Borrado == false
                               orderby items.Orden.FechaEntrada descending
                               select items;

                return consulta.ToList<OrdenServicioTipoPrenda>();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar trabajos en proceso", e);
                throw ExceptionManejada;
            }
        }

    }
}
