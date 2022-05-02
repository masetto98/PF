using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class MaquinaLogic : BusinessLogic
    {
        private MaquinaAdapter MaquinaData { get; set; }

        public MaquinaLogic(MaquinaAdapter maquinaAdapter)
        {
            MaquinaData = maquinaAdapter;
        }
        public List<Maquina> GetAll()
        {
            try
            {
                return MaquinaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de maquinas", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Maquina GetOne(int idMaquina)
        {
            try
            {
                return MaquinaData.GetOne(idMaquina);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de la maquina", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idMaquina)
        {
            try
            {
                MaquinaData.Delete(idMaquina);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar la maquina", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Maquina maquina)
        {
            MaquinaData.Save(maquina);
        }
    }
}
