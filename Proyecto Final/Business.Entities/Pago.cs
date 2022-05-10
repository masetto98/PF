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
        private decimal _importe;
        private Factura _factura;

        //[ForeignKey("Factura")]
        public int NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }

        public DateTime FechaPago
        {
            get { return _fechaPago; }
            set { _fechaPago = value; }
        }

        public decimal Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        public Factura Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }
    }
}
