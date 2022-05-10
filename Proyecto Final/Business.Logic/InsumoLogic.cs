using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class InsumoLogic:BusinessLogic
    {
        private InsumoAdapter InsumoData { get; set; }

        public InsumoLogic(InsumoAdapter insumoAdapter)
        {
            InsumoData = insumoAdapter;
        }
        public List<Insumo> GetAll()
        {
            try
            {
                return InsumoData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de insumos", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Insumo GetOne(int idInsumo)
        {
            try
            {
                return InsumoData.GetOne(idInsumo);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del insumo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idInsumo)
        {
            try
            {
                InsumoData.Delete(idInsumo);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el insumo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Insumo insumo)
        {
            InsumoData.Save(insumo);
        }
    }
}
