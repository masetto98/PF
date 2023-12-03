using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class _Movimiento
    {
        public DateTime _fecha;
        public string _tipoMovimiento;
        public int _idInsumo;
        public string _insumo;
        public Decimal _cant;
        private string _unidadMedida;
      

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public String Movimiento //Ingreso  o Consumo
        {
            get { return _tipoMovimiento; }
            set { _tipoMovimiento = value; }
        }

        public int idInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }

        public String Insumo 
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

        public Decimal Cantidad
        {
            get { return _cant; }
            set { _cant = value; }
        }

        public string Unidad
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }
    }
}
