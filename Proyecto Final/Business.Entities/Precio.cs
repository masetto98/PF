using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Precio : BusinessEntity
    {
        private int _idServicio;
        private int _idTipoPrenda;
        [DataType(DataType.Date)]
        private DateTime _fechaDesde;
        private double _valor;
        private ServicioTipoPrenda _servicioTipoPrenda;
        //private Servicio _servicio;
        //private TipoPrenda _tipoPrenda;



        //[ForeignKey("ServicioTipoPrenda")]
        [Column("id_servicio")]
        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
        //[ForeignKey("ServicioTipoPrenda")]
        [Column("id_tp")]
        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }
        [Column("fecha_desde")]
        public DateTime FechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }
        [Column("valor")]
        public double Valor 
        { 
            get { return _valor; }
            set { _valor = value; }
        }
        
        public ServicioTipoPrenda ServicioTipoPrenda
        {
            get { return _servicioTipoPrenda; }
            set { _servicioTipoPrenda = value; }
        }

        /*public Servicio Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }

        public TipoPrenda TipoPrenda
        {
            get { return _tipoPrenda; }
            set { _tipoPrenda = value; }
        }*/


    }
}
