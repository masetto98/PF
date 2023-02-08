using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ServicioTipoPrendaLogic : BusinessLogic
    {
        private ServicioTipoPrendaAdapter ServicioTipoPrendaData { get; set; }

        public ServicioTipoPrendaLogic(ServicioTipoPrendaAdapter servicioTipoPrendaAdapter)
        {
            ServicioTipoPrendaData = servicioTipoPrendaAdapter;
        }
        public List<ServicioTipoPrenda> GetAll()
        {
            try
            {
                return ServicioTipoPrendaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de servicios - tipo prendas", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public ServicioTipoPrenda GetOne(int idServicio,int idTipoPrenda)
        {
            try
            {
                return ServicioTipoPrendaData.GetOne(idServicio,idTipoPrenda);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del servicio-tipo prenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public ServicioTipoPrenda GetOneSinBorrado(int idServicio, int idTipoPrenda)
        {
            try
            {
                return ServicioTipoPrendaData.GetOneSinBorrado(idServicio, idTipoPrenda);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del servicio-tipo prenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public void Delete(int idServicio, int idTipoPrenda)
        {
            try
            {
                ServicioTipoPrendaData.Delete(idServicio,idTipoPrenda);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el servicio-tipo prenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(ServicioTipoPrenda servicioTipoPrenda)
        {
            ServicioTipoPrendaData.Save(servicioTipoPrenda);
        }
    }
}
