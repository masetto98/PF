using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ClienteLogic : BusinessLogic
    {
        private ClienteAdapter ClienteData { get; set; }

        public ClienteLogic(ClienteAdapter clienteAdapter)
        {
            ClienteData = clienteAdapter;
        }
        public List<Cliente> GetAll()
        {
            try
            {
                return ClienteData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de clientes", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Cliente GetOne(int idCliente)
        {
            try
            {
                return ClienteData.GetOne(idCliente);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Cliente GetOneConCuit(string cuit)
        {
            try
            {
                return ClienteData.GetOneConCuit(cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Cliente GetOrdenesCliente(int idCliente)
        {
            try
            {
                return ClienteData.GetOrdenesCliente(idCliente);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de cliente", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idCliente)
        {
            try
            {
                ClienteData.Delete(idCliente);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar el cliente", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Cliente cliente)
        {
            ClienteData.Save(cliente);
        }
    }
}
