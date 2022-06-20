using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class GastoLogic:BusinessLogic
    {
        private GastoAdapter GastoData { get; set; }

        public GastoLogic(GastoAdapter gastoAdapter)
        {
            GastoData = gastoAdapter;
        }

        public List<Gasto> GetAll()
        {
            try
            {
                return GastoData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de gastos", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public Gasto GetOne(int idGasto)
        {
            try
            {
                return GastoData.GetOne(idGasto);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del gasto", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public void Delete(int idGasto)
        {
            try
            {
                GastoData.Delete(idGasto);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el gasto", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public void Save(Gasto gasto)
        {
            GastoData.Save(gasto);
        }
    }
}
