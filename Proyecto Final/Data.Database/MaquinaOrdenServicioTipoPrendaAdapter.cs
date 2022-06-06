using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class MaquinaOrdenServicioTipoPrendaAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        public MaquinaOrdenServicioTipoPrendaAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<MaquinaOrdenServicioTipoPrenda> GetAll()
        {
            List<MaquinaOrdenServicioTipoPrenda> trabajosRealizados = new List<MaquinaOrdenServicioTipoPrenda>();
            try
            {
                trabajosRealizados = _context.MaquinasOrdenesServiciosTipoPrendas
                    .Include(i => i.Maquina)
                    .Include(i => i.OrdenServicioTipoPrenda)
                        .ThenInclude(o=> o.ServicioTipoPrenda)
                            .ThenInclude(st => st.Servicio)
                    .Include(i => i.OrdenServicioTipoPrenda)
                        .ThenInclude(o => o.ServicioTipoPrenda)
                            .ThenInclude(st => st.TipoPrenda)
                    .Include(i => i.Empleado)
                    .ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de trabajos realizados", e);
                throw ExceptionManejada;
            }
            return trabajosRealizados;
        }
        public MaquinaOrdenServicioTipoPrenda GetOne(int idMaquina, DateTime tiempoInicioServicio)
        {
            try
            {
                return _context.MaquinasOrdenesServiciosTipoPrendas
                    .Include(i => i.Maquina)
                    .Include(i => i.OrdenServicioTipoPrenda)
                        .ThenInclude(o => o.ServicioTipoPrenda)
                            .ThenInclude(st => st.Servicio)
                    .Include(i => i.OrdenServicioTipoPrenda)
                        .ThenInclude(o => o.ServicioTipoPrenda)
                            .ThenInclude(st => st.TipoPrenda)
                    .Include(i => i.Empleado)
                    .FirstOrDefault(i => i.IdMaquina == idMaquina && i.TiempoInicioServicio==tiempoInicioServicio );
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del trabajo", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(MaquinaOrdenServicioTipoPrenda trabajo)
        {
            try
            {
                _context.MaquinasOrdenesServiciosTipoPrendas.Update(trabajo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del trabajo", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(MaquinaOrdenServicioTipoPrenda trabajo)
        {
            try
            {
                _context.MaquinasOrdenesServiciosTipoPrendas.Add(trabajo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear un trabajo", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idMaquina, DateTime tiempoInicioServicio)
        {
            MaquinaOrdenServicioTipoPrenda trabajo = new MaquinaOrdenServicioTipoPrenda();
            try
            {
                trabajo = _context.MaquinasOrdenesServiciosTipoPrendas.Find(idMaquina,tiempoInicioServicio);
                _context.MaquinasOrdenesServiciosTipoPrendas.Remove(trabajo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar trabajo", e);
                throw ExceptionManejada;
            }
        }

        public void Save(MaquinaOrdenServicioTipoPrenda trabajo)
        {
            if (trabajo.State == BusinessEntity.States.New)
            {
                this.Insert(trabajo);
            }
            else if (trabajo.State == BusinessEntity.States.Deleted)
            {
                this.Delete(trabajo.IdMaquina, trabajo.TiempoInicioServicio);
            }
            else if (trabajo.State == BusinessEntity.States.Modified)
            {
                this.Update(trabajo);
            }
            trabajo.State = BusinessEntity.States.Unmodified;
        }

    }
}
