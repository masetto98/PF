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
        private DateTime _fechaHoraServicio;
        private int _nroOrden;
        private int _idServicio;
        private int _idTipoPrenda;
        private int _ordenItem;
        private int _idEmpleado;
        private Maquina _maquina;
        private OrdenServicioTipoPrenda _ordenServicioTipoPrenda;
        private Empleado _empleado;
        //private Orden _orden;
        //private Servicio _servicio;
        //private TipoPrenda _tipoPrenda;


        [ForeignKey("Maquina")]
        public int IdMaquina
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }

        public DateTime FechaHoraServicio
        {
            get { return _fechaHoraServicio; }
            set { _fechaHoraServicio = value; }
        }
        
        public int NroOrden
        {
            get { return _nroOrden; }
            set { _nroOrden = value; }
        }
        
        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
        
        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }
        
        public int OrdenItem
        {
            get { return _ordenItem; }
            set { _ordenItem = value; }
        }
        [ForeignKey("Empleado")]
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

        /*public Servicio Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }

        public TipoPrenda TipoPrenda
        {
            get { return _tipoPrenda; }
            set { _tipoPrenda = value; }
        }

        public Orden Orden
        {
            get { return _orden; }
            set { _orden = value; }
        }*/


    }
}
