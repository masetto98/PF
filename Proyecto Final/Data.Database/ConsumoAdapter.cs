using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class ConsumoAdapter:Adapter
    {
        private readonly LavanderiaContext _context;
        public ConsumoAdapter(LavanderiaContext context)
        {
            _context = context;
        }
        public List<Consumo> GetAll()
        {
            List<Consumo> consumos = new List<Consumo>();
            try
            {
                consumos = _context.Consumos.Where(c => c.Borrado == false).ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de consumos", e);
                throw ExceptionManejada;
            }
            return consumos;
        }
        public Consumo GetOne(int idMaquina, DateTime fecha_consumo, int idInsumo)
        {
            try
            {
                return _context.Consumos.Where(e => e.Borrado == false).FirstOrDefault(e => e.IdMaquina == idMaquina && e.FechaConsumo==fecha_consumo && e.IdInsumo==idInsumo);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos del consumo", e);
                throw ExceptionManejada;
            }
            return null;
        }
        protected void Update(Consumo consumo)
        {
            try
            {
                _context.Consumos.Update(consumo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del consumo", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Consumo consumo)
        {
            try
            {
                _context.Consumos.Add(consumo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear un consumo", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int idMaquina, DateTime fecha_consumo, int idInsumo)
        {
            Consumo consumo = new Consumo();
            try
            {
                consumo = _context.Consumos.Find(idMaquina,fecha_consumo,idInsumo);
                _context.Consumos.Remove(consumo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar consumo", e);
                throw ExceptionManejada;
            }
        }

        public void Save(Consumo consumo)
        {
            if (consumo.State == BusinessEntity.States.New)
            {
                this.Insert(consumo);
            }
            else if (consumo.State == BusinessEntity.States.Deleted)
            {
                this.Delete(consumo.IdMaquina,consumo.FechaConsumo,consumo.IdInsumo);
            }
            else if (consumo.State == BusinessEntity.States.Modified)
            {
                this.Update(consumo);
            }
            consumo.State = BusinessEntity.States.Unmodified;
        }
    }
}
