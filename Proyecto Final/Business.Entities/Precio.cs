﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Precio : BusinessEntity
    {
        private int _idServicio;
        private int _idTipoPrenda;
        private DateTime _fechaDesde;
        private decimal _valor;

        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }

        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }

        public DateTime FechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }

        public decimal Valor 
        { 
            get { return _valor; }
            set { _valor = value; }
        }


    }
}
