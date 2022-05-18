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
        public Business.Entities.InsumoServicioTipoPrenda GetOne(int idServicio, int idTipoPrenda,int idInsumo)
        {
            try
            {
                return _context.InsumosServiciosTipoPrendas
                    .Include(i => i.ServicioTipoPrenda)
                    .Include(i => i.Insumo)
                    .FirstOrDefault(i => i.IdTipoPrenda == idTipoPrenda && 
                                         i.IdServicio == idServicio &&
                                         i.IdInsumo == idInsumo);
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
        public void Delete(int idServicio, int idTipoPrenda, int idInsumo)
        {
            InsumoServicioTipoPrenda insumoServicioTipoPrenda = new InsumoServicioTipoPrenda();
            try
            {
                insumoServicioTipoPrenda = _context.InsumosServiciosTipoPrendas.Find(idServicio, idTipoPrenda,idInsumo);
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
                this.Delete(insumoServicioTipoPrenda.IdServicio, insumoServicioTipoPrenda.IdTipoPrenda, insumoServicioTipoPrenda.IdInsumo);
            }
            else if (insumoServicioTipoPrenda.State == BusinessEntity.States.Modified)
            {
                this.Update(insumoServicioTipoPrenda);
            }
            insumoServicioTipoPrenda.State = BusinessEntity.States.Unmodified;
        }
    }
}
