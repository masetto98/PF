using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class MaquinaOrdenServicioTipoPrendaLogic : BusinessLogic
    {
        private MaquinaOrdenServicioTipoPrendaAdapter MaquinaOrdenServicioTipoPrendaData { get; set; }

        public MaquinaOrdenServicioTipoPrendaLogic(MaquinaOrdenServicioTipoPrendaAdapter maquinaOrdenServicioTipoPrendaAdapter)
        {
            MaquinaOrdenServicioTipoPrendaData = maquinaOrdenServicioTipoPrendaAdapter;
        }
        public List<MaquinaOrdenServicioTipoPrenda> GetAll()
        {
            try
            {
                return MaquinaOrdenServicioTipoPrendaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de trabajos", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public MaquinaOrdenServicioTipoPrenda GetOne(int idMaquina, DateTime fechaInicioServicio)
        {
            try
            {
                return MaquinaOrdenServicioTipoPrendaData.GetOne(idMaquina,fechaInicioServicio);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del trabajo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idMaquina, DateTime fechaInicioServicio)
        {
            try
            {
                MaquinaOrdenServicioTipoPrendaData.Delete(idMaquina,fechaInicioServicio);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el trabajo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Save(MaquinaOrdenServicioTipoPrenda trabajo)
        {
            MaquinaOrdenServicioTipoPrendaData.Save(trabajo);
        }

    }
}
