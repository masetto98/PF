using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class MaquinaAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public MaquinaAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Maquina> GetAll()
        {
            List<Maquina> maquinas = new List<Maquina>();
            try
            {
                maquinas = _context.Maquinas.ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de maquinas", e);
                throw ExceptionManejada;
            }
            return maquinas;
        }
        public Business.Entities.Maquina GetOne(int idMaquina)
        {
            try
            {
                return _context.Maquinas.FirstOrDefault(s => s.IdMaquina == idMaquina);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de la maquina", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Maquina maquina)
        {
            try
            {
                _context.Maquinas.Update(maquina);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la maquina", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Maquina maquina)
        {
            try
            {
                _context.Maquinas.Add(maquina);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear maquina", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idMaquina)
        {
            Maquina maquina = new Maquina();
            try
            {
                maquina = _context.Maquinas.Find(idMaquina);
                _context.Maquinas.Remove(maquina);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar maquina", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Maquina maquina)
        {
            if (maquina.State == BusinessEntity.States.New)
            {
                this.Insert(maquina);
            }
            else if (maquina.State == BusinessEntity.States.Deleted)
            {
                this.Delete(maquina.IdMaquina);
            }
            else if (maquina.State == BusinessEntity.States.Modified)
            {
                this.Update(maquina);
            }
            maquina.State = BusinessEntity.States.Unmodified;
        }
    }
}
