using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class MantenimientoLogic : BusinessLogic
    {
        private MantenimientoAdapter MantenimientoData { get; set; }

        public MantenimientoLogic(MantenimientoAdapter mantenimientoAdapter)
        {
            MantenimientoData = mantenimientoAdapter;
        }
        public List<Mantenimiento> GetAll()
        {
            try
            {
                return MantenimientoData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de mantenimientos", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Mantenimiento GetOne(int idMaquina,DateTime fechaRealizacion)
        {
            try
            {
                return MantenimientoData.GetOne(idMaquina,fechaRealizacion);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del mantenimiento", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idMaquina,DateTime fechaRealizacion)
        {
            try
            {
                MantenimientoData.Delete(idMaquina,fechaRealizacion);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el mantenimiento", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Mantenimiento mantenimiento)
        {
            MantenimientoData.Save(mantenimiento);
        }
    }
}
