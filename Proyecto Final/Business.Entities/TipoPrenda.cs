using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class TipoPrenda:BusinessEntity
    {
        private int _idTipoPrenda;
        private string _descripcion;

        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
