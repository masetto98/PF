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
        private string _cuitCliente;
        private string _cuitEmpleado;
        private int _nroFactura;
        private string _prioridad;
        private DateTime _fechaEntrada;
        private DateTime _tiempoEntregaEstimado; //necesitamos que cuente el tiempo estimado para que se realiza el pedido
        private DateTime _tiempoEntregaReal; // lo mismo que el de arriba
        private string _estado;
        private Cliente _cliente;
        private Empleado _empleado;
        private Factura _factura;
        private Empleado _emplAtencion;

        [Key]
        public int NroOrden
        {
            get { return _nroOrden; }
            set { _nroOrden = value; }
        }
        [ForeignKey("Cliente")]
        public string CuitCliente
        {
            get { return _cuitCliente; }
            set { _cuitCliente = value; }
        }
        [ForeignKey("Empleado")]
        public string CuitEmpleado
        {
            get { return _cuitEmpleado; }
            set { _cuitEmpleado = value; }
        }
        [ForeignKey("Factura")]
        public int NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }

        public string prioridad
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

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }  //esto deberia ser parte del la relacion entre la orden y el item
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

        public Empleado EmpleadoAtencion
        {
            get { return _emplAtencion; }
            set { _emplAtencion = value; }
        }

        public Factura Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

    }
}
