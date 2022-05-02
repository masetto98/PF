using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class ClienteAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public ClienteAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                clientes = _context.Clientes.
                    ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de clientes", e);
                throw ExceptionManejada;
            }
            return clientes;
        }
        public Business.Entities.Cliente GetOne(int idCliente)
        {
            try
            {
                return _context.Clientes.FirstOrDefault(c => c.IdCliente == idCliente);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Cliente cliente)
        {
            try
            {
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del cliente", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear cliente", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idCliente)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente = _context.Clientes.Find(idCliente);
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar cliente", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Cliente cliente)
        {
            if (cliente.State == BusinessEntity.States.New)
            {
                this.Insert(cliente);
            }
            else if (cliente.State == BusinessEntity.States.Deleted)
            {
                this.Delete(cliente.IdCliente);
            }
            else if (cliente.State == BusinessEntity.States.Modified)
            {
                this.Update(cliente);
            }
            cliente.State = BusinessEntity.States.Unmodified;
        }

        public Business.Entities.Cliente GetOneConCuit(string Cuit)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente = _context.Clientes.FirstOrDefault(c => c.Cuit == Cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                throw ExceptionManejada;
            }
            return cliente;
        }
    }
}
