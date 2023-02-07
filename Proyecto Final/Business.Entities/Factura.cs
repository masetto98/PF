using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Business.Entities
{
    public class Factura:BusinessEntity
    {
        private int _nroFactura;
        private DateTime _fechaFactura;
        private double _importe;
        private bool _deleted;
        private List<Pago> _pagos;

        [Key]
        [Column("nro_factura")]
        public int NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }
        [Column("fecha_factura")]
        public DateTime FechaFactura
        {
            get { return _fechaFactura; }
            set { _fechaFactura = value; }
        }
        
        [Column("importe")]
        public double Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
        }
        
        public List<Pago> Pagos
        {
            get { return _pagos; }
            set { _pagos = value; }
        }
    }
}
