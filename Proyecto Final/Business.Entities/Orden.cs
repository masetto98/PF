using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Orden:BusinessEntity
    {
        private int _nroOrden;
        private int _idCliente;
        private int _idEmpleado;
        private int _nroFactura;
        private string _prioridad;
        [DataType(DataType.Date)]
        private DateTime _fechaEntrada;
        private DateTime _tiempoEntregaEstimado; //necesitamos que cuente el tiempo estimado para que se realiza el pedido
        private DateTime _tiempoEntregaReal; // lo mismo que el de arriba
        private Cliente _cliente;
        private Empleado _empleado;
        private Factura _factura;
        private List<OrdenServicioTipoPrenda> _itemsPedidos;

        public enum Estados
        {
            Pendiente = 1,
            Procesando = 2,
            Finalizado =3,
        }
        public Estados _estado;
        [Key]
        public int NroOrden
        {
            get { return _nroOrden; }
            set { _nroOrden = value; }
        }
        [ForeignKey("Cliente")]
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        [ForeignKey("Empleado")]
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        [ForeignKey("Factura")]
        public int NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }

        public string Prioridad
        {
            get { return _prioridad; }
            set { _prioridad = value; }
        }

        public DateTime FechaEntrada
        {
            get { return _fechaEntrada; }
            set { _fechaEntrada = value; }
        }

        public DateTime TiempoEntegaEstimado
        {
            get { return _tiempoEntregaEstimado; }
            set { _tiempoEntregaEstimado = value; }
        }

        public DateTime TiempoEntegaReal
        {
            get { return _tiempoEntregaReal; }
            set { _tiempoEntregaReal = value; }
        }

        [Column("estado")]
        public Estados Estado
        {
            get { return _estado; }
            set { _estado = value; }
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

        public Factura Factura
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
