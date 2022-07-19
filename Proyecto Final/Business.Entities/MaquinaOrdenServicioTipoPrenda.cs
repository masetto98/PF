using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class MaquinaOrdenServicioTipoPrenda:BusinessEntity
    {
        private int _idMaquina;
        private DateTime _tiempoInicioServicio;
        private DateTime _tiempoFinServicio;
        private int _nroOrden;
        private int _idServicio;
        private int _idTipoPrenda;
        private int _ordenItem;
        private int _idEmpleado;
        private Maquina _maquina;
        private OrdenServicioTipoPrenda _ordenServicioTipoPrenda;
        private Empleado _empleado;
        private List<Consumo> _consumos;


        [Column("id_maquina")]
        public int IdMaquina
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }

        [Column("tiempo_inicio_servicio")]
        public DateTime TiempoInicioServicio
        {
            get { return _tiempoInicioServicio; }
            set { _tiempoInicioServicio = value; }
        }

        [Column("tiempo_fin_servicio")]
        public DateTime TiempoFinServicio
        {
            get { return _tiempoFinServicio; }
            set { _tiempoFinServicio = value; }
        }

        [Column("nro_orden")]
        public int NroOrden
        {
            get { return _nroOrden; }
            set { _nroOrden = value; }
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

        [Column("orden_item")]
        public int OrdenItem
        {
            get { return _ordenItem; }
            set { _ordenItem = value; }
        }

        [Column("id_empleado")]
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public Maquina Maquina
        {
            get { return _maquina; }
            set { _maquina = value; }
        }

        public OrdenServicioTipoPrenda OrdenServicioTipoPrenda
        {
            get { return _ordenServicioTipoPrenda; }
            set { _ordenServicioTipoPrenda = value; }
        }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public List<Consumo> Consumos
        {
            get { return _consumos; }
            set { _consumos = value; }
        }



    }
}
