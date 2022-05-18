using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ServicioTipoPrenda : BusinessEntity
    {
        private int _idServicio;
        private int _idTipoPrenda;
        private TimeSpan _tiempoRequerido; // esta debe ser una variable que indique el tiempo que tarda un servicio para un determinado tipo de prenda
        private Servicio _servicio;
        private TipoPrenda _tipoPrenda;
        private Prioridades _prioridad;
        private TimeSpan _tiempoDemoraMax;
        private List<OrdenServicioTipoPrenda> _itemsPedidos;//Listado de ordenes que tiene ese servicio-tipoPrenda
        private List<Precio> _historicoPrecios;// Lista de todos los precios que tuvo el servicio-tipo Prenda
        private List<InsumoServicioTipoPrenda> _insumoServicioTipoPrenda;//Lista de insumos que requiere el servicio-TipoPrenda

        public enum Prioridades
        {
            Baja = 1,
            Media = 2,
            Alta = 3,
        }

        [Column("id_servicio")]
        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
     
        [Column("id_tp")]
        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }
        [Column("tiempo_requerido")]
        public TimeSpan TiempoRequerido
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

        [Column("tiempo_demora_max")]
        public TimeSpan TiempoDemoraMax
        {
            get { return _tiempoDemoraMax; }
            set { _tiempoDemoraMax = value; }
        }

        [Column("prioridad")]
        public Prioridades Prioridad
        {
            get { return _prioridad; }
            set { _prioridad = value; }
        }

        public List<OrdenServicioTipoPrenda> ItemsPedidos
        {
            get { return _itemsPedidos; }
            set { _itemsPedidos = value; }
        }
        public List<Precio> HistoricoPrecios 
        {
            get { return _historicoPrecios; }
            set { _historicoPrecios = value; }
        }

        public List<InsumoServicioTipoPrenda> InsumoServicioTipoPrenda
        {
            get { return _insumoServicioTipoPrenda; }
            set { _insumoServicioTipoPrenda = value; }
        }

    }
}
