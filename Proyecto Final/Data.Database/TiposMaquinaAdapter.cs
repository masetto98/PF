using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class TiposMaquinaAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public TiposMaquinaAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<TiposMaquina> GetAll()
        {
            List<TiposMaquina> tiposMaquinas = new List<TiposMaquina>();
            try
            {
                tiposMaquinas = _context.TiposMaquinas.Include(m => m.Maquinas).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de tipos de máquinas", e);
                throw ExceptionManejada;
            }
            return tiposMaquinas;
        }
        public TiposMaquina GetOne(int idTipoMaquina)
        {
            try
            {
                return _context.TiposMaquinas.Include(m => m.Maquinas).FirstOrDefault(s => s.IdTipoMaquina == idTipoMaquina);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del tipo de máquina", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(TiposMaquina tipoMaquina)
        {
            try
            {
                _context.TiposMaquinas.Update(tipoMaquina);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del tipo de máquina", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(TiposMaquina tipoMaquina)
        {
            // try
            //   {
            _context.TiposMaquinas.Add(tipoMaquina);
                _context.SaveChanges();
            //  }
            // catch (Exception e)
            //  {
            // Exception ExceptionManejada = new Exception("Error al crear un tipo de máquina", e);
            // throw ExceptionManejada;
            // }
        }
        public void Delete(int idTipoMaquina)
        {
            TiposMaquina tipoMaquina = new TiposMaquina();
            try
            {
                tipoMaquina = _context.TiposMaquinas.Find(idTipoMaquina);
                _context.TiposMaquinas.Remove(tipoMaquina);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar tipo de maquina", e);
                throw ExceptionManejada;
            }
        }

        public void Save(TiposMaquina tipoMaquina)
        {
            if (tipoMaquina.State == BusinessEntity.States.New)
            {
                this.Insert(tipoMaquina);
            }
            else if (tipoMaquina.State == BusinessEntity.States.Deleted)
            {
                this.Delete(tipoMaquina.IdTipoMaquina);
            }
            else if (tipoMaquina.State == BusinessEntity.States.Modified)
            {
                this.Update(tipoMaquina);
            }
            tipoMaquina.State = BusinessEntity.States.Unmodified;
        }
    }
}
