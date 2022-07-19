using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class TiposMaquinaLogic : BusinessLogic
    {
        private TiposMaquinaAdapter TiposMaquinaData { get; set; }

        public TiposMaquinaLogic(TiposMaquinaAdapter tipoMaquinaAdapter)
        {
            TiposMaquinaData = tipoMaquinaAdapter;
        }
        public List<TiposMaquina> GetAll()
        {
            try
            {
                return TiposMaquinaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de tipos de maquina", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public TiposMaquina GetOne(int idTipoMaquina)
        {
            try
            {
                return TiposMaquinaData.GetOne(idTipoMaquina);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del tipo de maquina", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idTiposMaquina)
        {
            try
            {
                TiposMaquinaData.Delete(idTiposMaquina);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el tipo de maquina", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(TiposMaquina tipoMaquina)
        {
            TiposMaquinaData.Save(tipoMaquina);
        }
    }
}
