using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class InsumoServicioTipoPrendaLogic : BusinessLogic
    {
        private InsumoServicioTipoPrendaAdapter InsumoServicioTipoPrendaData { get; set; }

        public InsumoServicioTipoPrendaLogic(InsumoServicioTipoPrendaAdapter insumoServicioTipoPrendaAdapter)
        {
            InsumoServicioTipoPrendaData = insumoServicioTipoPrendaAdapter;
        }
        public List<InsumoServicioTipoPrenda> GetAll()
        {
            try
            {
                return InsumoServicioTipoPrendaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de Insumo-ServicioTipoPrenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public InsumoServicioTipoPrenda GetOne(int idInsumo,int idServicio,int idTipoPrenda,DateTime fechaDesde)
        {
            try
            {
                return InsumoServicioTipoPrendaData.GetOne(idInsumo, idServicio, idTipoPrenda,fechaDesde);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del Insumo-ServicioTipoPrenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idInsumo, int idServicio, int idTipoPrenda, DateTime fechaDesde)
        {
            try
            {
                InsumoServicioTipoPrendaData.Delete(idInsumo, idServicio, idTipoPrenda, fechaDesde);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el Insumo-ServicioTipoPrenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(InsumoServicioTipoPrenda insumoServicioTipoPrenda)
        {
            InsumoServicioTipoPrendaData.Save(insumoServicioTipoPrenda);
        }
    }
}
