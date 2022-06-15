using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Orden : BusinessEntity
    {
        private int _nroOrden;
        private int _idCliente;
        private int _idEmpleado;
        private int? _nroFactura;
        private DateTime _fechaEntrada;
        private DateTime _fechaSalida;
        private TimeSpan _tiempoFinalizacionEstimado;
        private TimeSpan _tiempoFinalizacionReal;
        private Estados _estado;
        private Prioridades _prioridad;
        private EntregasDomicilio _entregaDomicilio;
        private string _observaciones;
        private string _descuento;
        private Cliente _cliente;
        private Empleado _empleado;
        private Factura? _factura;
        private List<OrdenServicioTipoPrenda> _itemsPedidos;

        public enum Estados
        {
            Pendiente = 1,
            Procesando = 2,
            Finalizado = 3,
            Pagado = 4,
            Retirado = 5,
        }

        public enum Prioridades
        {
            Estandar = 1,
            Alta = 2,
        }

        public enum EntregasDomicilio 
        {
            No=0,
            si=1
        }

        [Key]
        [Column("nro_orden")]
        public int NroOrden
        {
            get { return _nroOrden; }
            set { _nroOrden = value; }
        }
        
        [Column ("id_cliente")]
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
       
        [Column("id_empleado")]
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        
        [Column("nro_factura")]
        public int? NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }
        [Column("prioridad")]
        public Prioridades Prioridad
        {
            get { return _prioridad; }
            set { _prioridad = value; }
        }
        [Column("fecha_entrada")]
        public DateTime FechaEntrada
        {
            get { return _fechaEntrada; }
            set { _fechaEntrada = value; }
        }
        [Column("tiempo_finalizacion_estimado")]
        public TimeSpan TiempofinalizacionEstimado
        {
            get { return _tiempoFinalizacionEstimado; }
            set { _tiempoFinalizacionEstimado = value; }
        }
        [Column("tiempo_finalizacion_real")]
        public TimeSpan TiempoFinalizacionReal
        {
            get { return _tiempoFinalizacionReal; }
            set { _tiempoFinalizacionReal = value; }
        }
        [Column("fecha_salida")]
        public DateTime FechaSalida
        {
            get { return _fechaSalida; }
            set { _fechaSalida = value; }
        }

        [Column("estado")]
        public Estados Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        [Column("observaciones")]
        public string Observaciones 
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        [Column("descuento")]
        public string Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        [Column("entrega_domicilio")]
        public EntregasDomicilio EntregaDomicilio
        {
            get { return _entregaDomicilio; }
            set { _entregaDomicilio = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public Factura? Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public List<OrdenServicioTipoPrenda> ItemsPedidos
        {
            get { return _itemsPedidos; }
            set { _itemsPedidos = value; }
        }
    }
}
