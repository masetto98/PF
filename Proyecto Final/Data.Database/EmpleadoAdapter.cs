using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class EmpleadoAdapter:Adapter
    {
        private readonly LavanderiaContext _context;
        public EmpleadoAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Empleado> GetAll()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                empleados = _context.Empleados.Include(i => i.Usuarios).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de empleados", e);
                throw ExceptionManejada;
            }
            return empleados;
        }
        public Business.Entities.Empleado GetOne(int idEmpleado)
        {
            try
            {
                return _context.Empleados.Include(i => i.Usuarios).FirstOrDefault(e => e.IdEmpleado == idEmpleado);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del empleado", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Empleado empleado)
        {
            try
            {
                _context.Empleados.Update(empleado);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del empleado", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Empleado empleado)
        {
            try
            {
                _context.Empleados.Add(empleado);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear empleado", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idEmpleado)
        {
            Empleado empleado = new Empleado();
            try
            {
                empleado = _context.Empleados.Find(idEmpleado);
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar empleado", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Empleado empleado)
        {
            if (empleado.State == BusinessEntity.States.New)
            {
                this.Insert(empleado);
            }
            else if (empleado.State == BusinessEntity.States.Deleted)
            {
                this.Delete(empleado.IdEmpleado);
            }
            else if (empleado.State == BusinessEntity.States.Modified)
            {
                this.Update(empleado);
            }
            empleado.State = BusinessEntity.States.Unmodified;
        }

        public Business.Entities.Empleado GetOneConCuit(string Cuit)
        {
            Empleado empleado = new Empleado();
            try
            {
                empleado = _context.Empleados.FirstOrDefault(e => e.Cuit == Cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del cliente", e);
                throw ExceptionManejada;
            }
            return empleado;
        }
    }
}
