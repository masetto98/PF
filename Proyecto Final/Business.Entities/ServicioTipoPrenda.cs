using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ServicioTipoPrenda:BusinessEntity
    {
        private int _idServicio;
        private int _idTipoPrenda;
        private DateTime _tiempoRequerido; // esta debe ser una variable que indique el tiempo que tarda un servicio para un determinado tipo de prenda
        private Servicio _servicio;
        private TipoPrenda _tipoPrenda;

        [ForeignKey("Servicio")]
        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
        [ForeignKey("TipoPrenda")]
        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }

        public DateTime TiempoRequerido
        {
            get { return _tiempoRequerido; }
            set { _tiempoRequerido = value; }
        }

        public Servicio Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }

        public TipoPrenda TipoPrenda
        {
            get { return _tipoPrenda; }
            set { _tipoPrenda = value; }
        }
    }
}
