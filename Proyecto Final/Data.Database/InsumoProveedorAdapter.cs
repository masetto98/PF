using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class InsumoProveedorAdapter : Adapter
    {
        private readonly LavanderiaContext _context;

        public InsumoProveedorAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<InsumoProveedor> GetAll()
        {
            List<InsumoProveedor> insumosProveedores = new List<InsumoProveedor>();
            try
            {
                insumosProveedores = _context.InsumosProveedores.Include(ip => ip.Proveedor).Include(ip => ip.Insumo).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de insumos - proveedores", e);
                throw ExceptionManejada;
            }
            return insumosProveedores;
        }
        public Business.Entities.InsumoProveedor GetOne(int idProveedor, int idInsumo, DateTime fechaIngreso)
        {
            try
            {
               
                return GetAll().Find(ip => ip.IdProveedor == idProveedor && ip.IdInsumo == idInsumo && ip.FechaIngreso == fechaIngreso);
                /*
               return _context.InsumosProveedores
                    .Include(ip => ip.Proveedor)
                    .Include(ip => ip.Insumo)
                    .FirstOrDefault(ip => ip.IdInsumo == idInsumo && ip.IdProveedor == idProveedor && ip.FechaIngreso ==  fechaIngreso);
                */
            }
            catch (Exception e)
            {
            Exception ExceptionManejada = new Exception("Error al recuperar datos del insumo - proveedor", e);
            throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(InsumoProveedor insumoProveedor)
        {
            try
            {
                _context.InsumosProveedores.Update(insumoProveedor);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del insumo - proveedor", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(InsumoProveedor insumoProveedor)
        {
            try
            {
                _context.InsumosProveedores.Add(insumoProveedor);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear insumo - proveedor", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idProveedor, int idInsumo, DateTime fechaIngreso)
        {
            InsumoProveedor insumoProveedor = new InsumoProveedor();
            try
            {
                insumoProveedor = _context.InsumosProveedores.Find(idProveedor, idInsumo, fechaIngreso);
                _context.InsumosProveedores.Remove(insumoProveedor);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar insumo - proveedor", e);
                throw ExceptionManejada;
            }
        }

        public void Save(InsumoProveedor insumoProveedor)
        {
            if (insumoProveedor.State == BusinessEntity.States.New)
            {
                this.Insert(insumoProveedor);
            }
            else if (insumoProveedor.State == BusinessEntity.States.Deleted)
            {
                this.Delete(insumoProveedor.IdProveedor, insumoProveedor.IdInsumo, insumoProveedor.FechaIngreso);
            }
            else if (insumoProveedor.State == BusinessEntity.States.Modified)
            {
                this.Update(insumoProveedor);
            }
            insumoProveedor.State = BusinessEntity.States.Unmodified;
        }
    }
}
