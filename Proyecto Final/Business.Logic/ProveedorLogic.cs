using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ProveedorLogic : BusinessLogic
    {
        private ProveedorAdapter ProveedorData { get; set; }

        public ProveedorLogic(ProveedorAdapter proveedorAdapter)
        {
            ProveedorData = proveedorAdapter;
        }
        public List<Proveedor> GetAll()
        {
            try
            {
                return ProveedorData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de proveedores", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Proveedor GetOne(int idProveedor)
        {
            try
            {
                return ProveedorData.GetOne(idProveedor);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del proveedor", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Proveedor GetOneConCuit(string cuit)
        {
            try
            {
                return ProveedorData.GetOneConCuit(cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cproveedor", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idProveedor)
        {
            try
            {
                ProveedorData.Delete(idProveedor);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el proveedor", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Proveedor proveedor)
        {
            ProveedorData.Save(proveedor);
        }
    }
}
