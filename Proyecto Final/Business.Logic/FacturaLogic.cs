using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class FacturaLogic : BusinessLogic
    {
        private FacturaAdapter FacturaData { get; set; }

        public FacturaLogic(FacturaAdapter facturaAdapter)
        {
            FacturaData = facturaAdapter;
        }
        public List<Factura> GetAll()
        {
            try
            {
                return FacturaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de facturas", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Factura GetOne(int nroFactura)
        {
            try
            {
                return FacturaData.GetOne(nroFactura);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de la factura", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int nroFactura)
        {
            try
            {
                FacturaData.Delete(nroFactura);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar la factura", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Factura factura)
        {
            FacturaData.Save(factura);
        }
    }
}
