using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class MantenimientoAdapter : Adapter
    {
        private readonly LavanderiaContext _context;

        public MantenimientoAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Mantenimiento> GetAll()
        {
            List<Mantenimiento> mantenimientos = new List<Mantenimiento>();
            try
            {
                mantenimientos = _context.Mantenimientos
                                            .Include(i=>i.Maquina)
                                            .ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de mantenimientos", e);
                throw ExceptionManejada;
            }
            return mantenimientos;
        }
        public Mantenimiento GetOne(int idMaquina,DateTime fechaRealizacion)
        {
            try
            {
                return _context.Mantenimientos
                                            .Include(s => s.Maquina)
                                            .FirstOrDefault(s => s.IdMaquina == idMaquina && s.FechaRealizado == fechaRealizacion);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del mantenimiento", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Mantenimiento mantenimiento)
        {
            try
            {
                _context.Mantenimientos.Update(mantenimiento);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del mantenimiento", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Mantenimiento mantenimiento)
        {
            try
            {
                _context.Mantenimientos.Add(mantenimiento);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear mantenimiento", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idMaquina, DateTime fechaRealizacion)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            try
            {
                mantenimiento = _context.Mantenimientos.Find(idMaquina, fechaRealizacion);
                _context.Mantenimientos.Remove(mantenimiento);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar mantenimiento", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Mantenimiento mantenimiento)
        {
            if (mantenimiento.State == BusinessEntity.States.New)
            {
                this.Insert(mantenimiento);
            }
            else if (mantenimiento.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mantenimiento.IdMaquina,mantenimiento.FechaRealizado);
            }
            else if (mantenimiento.State == BusinessEntity.States.Modified)
            {
                this.Update(mantenimiento);
            }
            mantenimiento.State = BusinessEntity.States.Unmodified;
        }
    }
}
