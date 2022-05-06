using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class OrdenLogic : BusinessLogic
    {
        private OrdenAdapter OrdenData { get; set; }

        public OrdenLogic(OrdenAdapter ordenAdapter)
        {
            OrdenData = ordenAdapter;
        }
        public List<Orden> GetAll()
        {
            try
            {
                return OrdenData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de ordenes", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Orden GetOne(int nroOrden)
        {
            try
            {
                return OrdenData.GetOne(nroOrden);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de la orden", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        /*public Cliente GetOneConCuit(string cuit)
        {
            try
            {
                return OrdenData.GetOneConCuit(cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }*/
        public void Delete(int nroOrden)
        {
            try
            {
                OrdenData.Delete(nroOrden);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar la orden", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Orden orden)
        {
            OrdenData.Save(orden);
        }
    }
}
