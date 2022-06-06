using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class AtributosNegocioAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public AtributosNegocioAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        
        public Business.Entities.AtributosNegocio GetOne(int id)
        {
            try
            {
                return _context.AtributosNegocio.FirstOrDefault(f => f.ID == id);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del negocio", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(AtributosNegocio an)
        {
            try
            {
                _context.AtributosNegocio.Update(an);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del negocio", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(AtributosNegocio an)
        {
            try
            {
                _context.AtributosNegocio.Add(an);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear atributos negocio", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int id)
        {
            AtributosNegocio an = new AtributosNegocio();
            try
            {
                an = _context.AtributosNegocio.Find(id);
                _context.AtributosNegocio.Remove(an);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar atributos del negocio", e);
                throw ExceptionManejada;
            }
        }

        public void Save(AtributosNegocio an)
        {
            if (an.State == BusinessEntity.States.New)
            {
                this.Insert(an);
            }
            else if (an.State == BusinessEntity.States.Deleted)
            {
                this.Delete(an.ID);
            }
            else if (an.State == BusinessEntity.States.Modified)
            {
                this.Update(an);
            }
            an.State = BusinessEntity.States.Unmodified;
        }
    }
}
