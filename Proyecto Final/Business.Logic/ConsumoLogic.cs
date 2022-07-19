using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ConsumoLogic:BusinessLogic
    {
        private ConsumoAdapter ConsumoData { get; set; }
        public ConsumoLogic(ConsumoAdapter consumoAdapter)
        {
            ConsumoData = consumoAdapter;
        }
        public List<Consumo> GetAll()
        {
            try
            {
                return ConsumoData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de consumos", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Consumo GetOne(int idMaquina,DateTime fecha_consumo,int idInsumo)
        {
            try
            {
                return ConsumoData.GetOne(idMaquina,fecha_consumo,idInsumo);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del consumo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }

        public void Delete(int idMaquina, DateTime fecha_consumo, int idInsumo)
        {
            try
            {
                ConsumoData.Delete(idMaquina,fecha_consumo,idInsumo);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el consumo", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Consumo consumo)
        {
            ConsumoData.Save(consumo);
        }
    }
}
