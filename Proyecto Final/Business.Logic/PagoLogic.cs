using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PagoLogic:BusinessLogic
    {
        private PagoAdapter PagoData { get; set; }
        public PagoLogic(PagoAdapter pagoAdapter)
        {
            PagoData = pagoAdapter;
        }
        public List<Pago> GetAll()
        {
            try
            {
                return PagoData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de pagos", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Pago GetOne(int nroFactura,DateTime fechaPago)
        {
            try
            {
                return PagoData.GetOne(nroFactura,fechaPago);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del pago", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public void Delete(int nroFactura, DateTime fechaPago)
        {
            try
            {
                PagoData.Delete(nroFactura,fechaPago);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el pago", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Pago pago)
        {
            PagoData.Save(pago);
        }

    }
}
