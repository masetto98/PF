﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class InsumoProveedor:BusinessEntity
    {
        private string _cuitProveedor;
        private int _idInsumo;
        private DateTime _fechaIngreso;
        private decimal _cantidad;
        private Proveedor _proveedor;
        private Insumo _insumo;

        public string CuitProveedor
        {
            get { return _cuitProveedor; }
            set { _cuitProveedor = value; }
        }

        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        public decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
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
}
