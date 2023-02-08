using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class InsumoProveedor:BusinessEntity
    {
        private int _idProveedor;
        private int _idInsumo;
        private DateTime _fechaIngreso;
        private double _cantidad;
        private bool _deleted;
        private Proveedor _proveedor;
        private Insumo _insumo;

        [Column("id_proveedor")]
        public int IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }
        
        [Column("id_insumo")]
        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }

        [Column("fecha_ingreso")]
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        [Column("cantidad")]
        public double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public Proveedor Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }
    }

    
}
