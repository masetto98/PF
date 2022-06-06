using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Business.Entities
{
    public class Mantenimiento : BusinessEntity
    {
        private int _idMaquina;
        
        private DateTime _fechaRealizado;
        private string _descripcion;
        private double _costo;
        private Maquina _maquina;

        [Column("id_maquina")]
        public int IdMaquina 
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }
        [Column("fecha_realizado")]
        public DateTime FechaRealizado
        {
            get { return _fechaRealizado; }
            set { _fechaRealizado = value; }
        }
        [Column("descripcion")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        [Column("costo")]
        public double Costo 
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public Maquina Maquina
        {
            get { return _maquina; }
            set { _maquina = value; }
        }
    }
}
