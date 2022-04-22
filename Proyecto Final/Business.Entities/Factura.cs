using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Factura:BusinessEntity
    {
        private int _nroFactura;
        private DateTime _fechaFactura;
        private decimal _importe;

        public int NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }

        public DateTime FechaFactura
        {
            get { return _fechaFactura; }
            set { _fechaFactura = value; }
        }

        public decimal Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
    }
}
