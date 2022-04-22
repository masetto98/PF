using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class OrdenServicioTipoPrenda:BusinessEntity
    {
        private int _nroOrden;
        private int _idServicio;
        private int _idTipoPrenda;
        private int _ordenItem;
        private string _estado;

        public int NroOrden
        {
            get { return _nroOrden; }
            set { _nroOrden = value; }
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

        public int OrdenItem
        {
            get { return _ordenItem; }
            set { _ordenItem = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
