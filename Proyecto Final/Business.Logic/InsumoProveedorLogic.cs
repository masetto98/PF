using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class InsumoProveedorLogic:BusinessLogic
    {
        private InsumoProveedorAdapter InsumoProveedorData { get; set; }

        public InsumoProveedorLogic(InsumoProveedorAdapter insumoProveedorAdapter)
        {
            InsumoProveedorData = insumoProveedorAdapter;
        }
        public List<InsumoProveedor> GetAll()
        {
            try
            {
                return InsumoProveedorData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de insumos - proveedores", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public InsumoProveedor GetOne(int idProveedor, int idInsumo, DateTime fechaIngreso)
        {
            try
            {
            return InsumoProveedorData.GetOne(idProveedor, idInsumo, fechaIngreso);
            }
            catch (Exception e)
            {
            Exception ExceptionManejada = new Exception("Error al recuperar datos del insumo - proveedor", e);
            Logger.Log(ExceptionManejada.Message);
            throw ExceptionManejada;
            }
        }

        public void Delete(int idInsumo, int idProveedor, DateTime fechaIngreso)
        {
            try
            {
                InsumoProveedorData.Delete(idInsumo, idProveedor, fechaIngreso);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el insumo - proveedor", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(InsumoProveedor insumoProveedor)
        {
            InsumoProveedorData.Save(insumoProveedor);
        }
    }
}
