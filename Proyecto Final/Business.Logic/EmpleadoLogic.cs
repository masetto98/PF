using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EmpleadoLogic:BusinessLogic
    {
        private EmpleadoAdapter EmpleadoData { get; set; }
        public EmpleadoLogic(EmpleadoAdapter empleadoAdapter)
        {
            EmpleadoData = empleadoAdapter;
        }
        public List<Empleado> GetAll()
        {
            try
            {
                return EmpleadoData.GetAll();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar lista de empleados", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public Empleado GetOne(string cuit)
        {
            try
            {
                return EmpleadoData.GetOne(cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de empleado", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        
        public void Delete(string cuit)
        {
            try
            {
                EmpleadoData.Delete(cuit);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar empleado", e);
                Logger.Log(ExceptionManejada.Message);
                throw ExceptionManejada;
            }
        }
        public void Save(Empleado empleado)
        {
            EmpleadoData.Save(empleado);
        }
    }
}

