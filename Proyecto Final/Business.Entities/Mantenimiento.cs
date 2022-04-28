using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Mantenimiento : BusinessEntity
    {
        private int _idMaquina;
        private DateTime _fechaRealizado;
        private string _descripcion;
        private decimal _costo;
        private Maquina _maquina;
        [ForeignKey("Maquina")]
        public int IdMaquina 
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }

        public DateTime FechaRealizado
        {
            get { return _fechaRealizado; }
            set { _fechaRealizado = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public decimal Costo 
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
