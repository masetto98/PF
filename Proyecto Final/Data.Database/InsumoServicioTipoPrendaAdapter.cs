using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class InsumoServicioTipoPrendaAdapter:Adapter
    {
        private readonly LavanderiaContext _context;

        public InsumoServicioTipoPrendaAdapter(LavanderiaContext context)
        {
            _context = context;
        }

        public List<InsumoServicioTipoPrenda> GetAll()
        {
            List<InsumoServicioTipoPrenda> insumosServicioTipoPrendas = new List<InsumoServicioTipoPrenda>();
            try
            {
                insumosServicioTipoPrendas = _context.InsumosServiciosTipoPrendas
                    .Include(i => i.ServicioTipoPrenda)
                    .Include(i => i.Insumo)
                    .ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de Insumo-ServicioTipoPrenda", e);
                throw ExceptionManejada;
            }
            return insumosServicioTipoPrendas;
        }
        public Business.Entities.InsumoServicioTipoPrenda GetOne(int idInsumo,int idServicio, int idTipoPrenda,DateTime fechaDesde)
        {
            try
            {
                return _context.InsumosServiciosTipoPrendas
                    .Include(i => i.ServicioTipoPrenda)
                    .Include(i => i.Insumo)
                    .FirstOrDefault(i => i.IdInsumo == idInsumo &&
                                         i.IdServicio == idServicio &&
                                         i.IdTipoPrenda == idTipoPrenda && 
                                         i.FechaDesde == fechaDesde
                                         );
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del Insumo-ServicioTipoPrenda", e);
                throw ExceptionManejada;
            }
            return null;
        }

        protected void Update(InsumoServicioTipoPrenda insumoServicioTipoPrenda)
        {
            try
            {
                _context.InsumosServiciosTipoPrendas.Update(insumoServicioTipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del Insumo-ServicioTipoPrenda", e);
                throw ExceptionManejada;
            }
        }

        protected void Insert(InsumoServicioTipoPrenda insumoServicioTipoPrenda)
        {
            try
            {
                _context.InsumosServiciosTipoPrendas.Add(insumoServicioTipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear Insumo-ServicioTipoPrenda", e);
                throw ExceptionManejada;
            }
        }

        public void Delete(int idServicio, int idTipoPrenda, int idInsumo, DateTime fechaDesde)
        {
            InsumoServicioTipoPrenda insumoServicioTipoPrenda = new InsumoServicioTipoPrenda();
            try
            {
                insumoServicioTipoPrenda = _context.InsumosServiciosTipoPrendas.Find(idInsumo,idServicio, idTipoPrenda,fechaDesde);
                _context.InsumosServiciosTipoPrendas.Remove(insumoServicioTipoPrenda);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar Insumo-ServicioTipoPrenda", e);
                throw ExceptionManejada;
            }
        }

        public void Save(InsumoServicioTipoPrenda insumoServicioTipoPrenda)
        {
            if (insumoServicioTipoPrenda.State == BusinessEntity.States.New)
            {
                this.Insert(insumoServicioTipoPrenda);
            }
            else if (insumoServicioTipoPrenda.State == BusinessEntity.States.Deleted)
            {
                this.Delete(insumoServicioTipoPrenda.IdInsumo,insumoServicioTipoPrenda.IdServicio, insumoServicioTipoPrenda.IdTipoPrenda,insumoServicioTipoPrenda.FechaDesde);
            }
            else if (insumoServicioTipoPrenda.State == BusinessEntity.States.Modified)
            {
                this.Update(insumoServicioTipoPrenda);
            }
            insumoServicioTipoPrenda.State = BusinessEntity.States.Unmodified;
        }
    }
}
