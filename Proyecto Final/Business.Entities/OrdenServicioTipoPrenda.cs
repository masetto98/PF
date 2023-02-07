using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class OrdenServicioTipoPrenda : BusinessEntity
    {
        private int _nroOrden;
        private int _idServicio;
        private int _idTipoPrenda;
        private int _ordenItem;
        //private DateTime _fecha_cambio_prioridad;
        private Estados _estado;
        private Prioridades _prioridad;
        private Orden _orden;
        private bool _deleted;
        private ServicioTipoPrenda _servicioTipoPrenda;
        private List<MaquinaOrdenServicioTipoPrenda> _maquinasItem;// un item de orden puede pasar por varias maquinas como en el caso de lavado y secado que debe pasar por el lavaropas y secarropas.
        
        public enum Estados
        {
            Pendiente = 1,
            Iniciado = 2,
            Procesando = 3,
            Finalizado = 4,
        }

        public enum Prioridades
        {
            Estandar=1,
            Alta = 2,
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
        [Column("estado")]
        public Estados Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        [Column("prioridad")]
        public Prioridades Prioridad
        {
            get { return _prioridad; }
            set { _prioridad = value; }
        }
        /*
        [Column("fecha_cambio_prioridad")]
        public DateTime FechaCambioPrioridad
        {
            get { return _fecha_cambio_prioridad; }
            set { _fecha_cambio_prioridad = value; }
        }
        */
        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public ServicioTipoPrenda ServicioTipoPrenda
        {
            get { return _servicioTipoPrenda; }
            set { _servicioTipoPrenda = value; }
        }

        public Orden Orden
        {
            get { return _orden; }
            set { _orden = value; }
        }

        public List<MaquinaOrdenServicioTipoPrenda> MaquinaOrdenServicioTipoPrenda
        {
            get { return _maquinasItem; }
            set { _maquinasItem = value; }
        }
    }
}
