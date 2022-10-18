using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class AtributosNegocioLogic : BusinessLogic
    {
        private AtributosNegocioAdapter AtributosNegocioData { get; set; }

        public AtributosNegocioLogic(AtributosNegocioAdapter atributosNegocioAdapter)
        {
            AtributosNegocioData = atributosNegocioAdapter;
        }
        
        public AtributosNegocio GetOne(int id)
        {
            try
            {
                return AtributosNegocioData.GetOne(id);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del negocio", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public List<AtributosNegocio> GetAll()
        {
            try
            {
                return AtributosNegocioData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de atributos del negocio", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public void Delete(int id)
        {
            try
            {
                AtributosNegocioData.Delete(id);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar datos del negocio", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(AtributosNegocio an)
        {
            AtributosNegocioData.Save(an);
        }
    }
}
