using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class InsumoServicioTipoPrenda:BusinessEntity
    {
        private int _idInsumo;
        private int _idServicio;
        private int _idTipoPrenda;

        public int IdInsumo 
        {
            get {return _idInsumo; }
            set {_idInsumo = value; }
        }

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
    }
}
