using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Pago:BusinessEntity
    {
        private int _nroFactura;
        private DateTime _fechaPago;
        private double _importe;
        public enum FormasPago
        {
            Seña = 0,
            Efectivo = 1,
            TarjetaCredito = 2,
            TarjetaDebito = 3,
            BilleteraElectronica = 4,
            TransferenciaBancaria = 5,
        }
        public FormasPago _formaPago;
        private Factura _factura;

        //[ForeignKey("Factura")]
        [Column("nro_factura")]
        public int NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }
        [Column("fecha_pago")]
        public DateTime FechaPago
        {
            get { return _fechaPago; }
            set { _fechaPago = value; }
        }
        [Column("importe_pago")]
        public double Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        [Column("forma_pago")]
        public FormasPago FormaPago
        {
            get { return _formaPago; }
            set { _formaPago = value; }
        }
        public Factura Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }
    }
}
