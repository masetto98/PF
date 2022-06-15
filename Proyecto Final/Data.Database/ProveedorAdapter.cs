using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class ProveedorAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public ProveedorAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Proveedor> GetAll()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                proveedores = _context.Proveedores
                                                .Include(i => i.InsumosProveedor)
                                                    .ThenInclude(x =>x.Insumo)
                                                .ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de proveedores", e);
                throw ExceptionManejada;
            }
            return proveedores;
        }
        public Business.Entities.Proveedor GetOne(int idProveedor)
        {
            try
            {
                return _context.Proveedores
                                           .Include(i => i.InsumosProveedor)
                                                .ThenInclude(x => x.Insumo)
                                           .FirstOrDefault(c => c.IdProveedor == idProveedor);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del proveedor", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Proveedor proveedor)
        {
            try
            {
                _context.Proveedores.Update(proveedor);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del proveedor", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Proveedor proveedor)
        {
            try
            {
                _context.Proveedores.Add(proveedor);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear proveedor", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idProveedor)
        {
            Proveedor proveedor = new Proveedor();
            try
            {
                proveedor = _context.Proveedores.Find(idProveedor);
                _context.Proveedores.Remove(proveedor);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar proveedor", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Proveedor proveedor)
        {
            if (proveedor.State == BusinessEntity.States.New)
            {
                this.Insert(proveedor);
            }
            else if (proveedor.State == BusinessEntity.States.Deleted)
            {
                this.Delete(proveedor.IdProveedor);
            }
            else if (proveedor.State == BusinessEntity.States.Modified)
            {
                this.Update(proveedor);
            }
            proveedor.State = BusinessEntity.States.Unmodified;
        }

        public Business.Entities.Proveedor GetOneConCuit(string Cuit)
        {
            Proveedor proveedor = new Proveedor();
            try
            {
                proveedor = _context.Proveedores.FirstOrDefault(p => p.Cuit == Cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del proveedor", e);
                throw ExceptionManejada;
            }
            return proveedor;
        }
    }
}
