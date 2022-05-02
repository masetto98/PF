using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ServicioLogic : BusinessLogic
    {
        private ServicioAdapter ServicioData { get; set; }

        public ServicioLogic(ServicioAdapter servicioAdapter)
        {
            ServicioData = servicioAdapter;
        }
        public List<Servicio> GetAll()
        {
            try
            {
                return ServicioData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de servicios", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Servicio GetOne(int idServicio)
        {
            try
            {
                return ServicioData.GetOne(idServicio);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del servicio", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idServicio)
        {
            try
            {
                ServicioData.Delete(idServicio);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el servicio", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Servicio servicio)
        {
            ServicioData.Save(servicio);
        }
    }
}
