using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class OrdenServicioTipoPrendaLogic : BusinessLogic
    {
        private OrdenServicioTipoPrendaAdapter OrdenServicioTipoPrendaData { get; set; }

        public OrdenServicioTipoPrendaLogic(OrdenServicioTipoPrendaAdapter ordenServicioTipoPrendaAdapter)
        {
            OrdenServicioTipoPrendaData = ordenServicioTipoPrendaAdapter;
        }
        public List<OrdenServicioTipoPrenda> GetAll()
        {
            try
            {
                return OrdenServicioTipoPrendaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de trabajos", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public OrdenServicioTipoPrenda GetOne(int nroOrden, int idServicio, int idTipoPrenda, int ordenItem)
        {
            try
            {
                return OrdenServicioTipoPrendaData.GetOne(nroOrden,idServicio,idTipoPrenda,ordenItem);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del trabajo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        /*public Cliente GetOneConCuit(string cuit)
        {
            try
            {
                return OrdenData.GetOneConCuit(cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }*/
        public void Delete(int nroOrden, int idServicio, int idTipoPrenda, int ordenItem)
        {
            try
            {
                OrdenServicioTipoPrendaData.Delete(nroOrden,idServicio,idTipoPrenda,ordenItem);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el trabajo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Save(OrdenServicioTipoPrenda itemOrden)
        {
            OrdenServicioTipoPrendaData.Save(itemOrden);
        }

        public List<OrdenServicioTipoPrenda> GetItemsPendientes()
        {
            try
            {
                return OrdenServicioTipoPrendaData.GetItemsPendientes();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar trabajos pendientes", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public List<OrdenServicioTipoPrenda> GetItemsEnProceso()
        {
            try
            {
                return OrdenServicioTipoPrendaData.GetItemsEnProceso();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar trabajos en proceso", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
    }
}
