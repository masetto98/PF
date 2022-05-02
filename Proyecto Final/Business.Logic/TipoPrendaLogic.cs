using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class TipoPrendaLogic : BusinessLogic
    {
        private TipoPrendaAdapter TipoPrendaData { get; set; }

        public TipoPrendaLogic(TipoPrendaAdapter tipoPrendaAdapter)
        {
            TipoPrendaData = tipoPrendaAdapter;
        }
        public List<TipoPrenda> GetAll()
        {
            try
            {
                return TipoPrendaData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de tipos de prendas", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public TipoPrenda GetOne(int idTipoPrenda)
        {
            try
            {
                return TipoPrendaData.GetOne(idTipoPrenda);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del tipo de prenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(int idTipoPrenda)
        {
            try
            {
                TipoPrendaData.Delete(idTipoPrenda);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el tipo de prenda", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(TipoPrenda tipoPrenda)
        {
            TipoPrendaData.Save(tipoPrenda);
        }
    }
}
