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
        public InsumoServicioTipoPrenda GetOne(int idServicio,int idTipoPrenda, int idInsumo)
        {
            try
            {
                return InsumoServicioTipoPrendaData.GetOne(idServicio,idTipoPrenda,idInsumo);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del Insumo-ServicioTipoPrenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idServicio, int idTipoPrenda, int idInsumo)
        {
            try
            {
                InsumoServicioTipoPrendaData.Delete(idServicio,idTipoPrenda,idInsumo);
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
