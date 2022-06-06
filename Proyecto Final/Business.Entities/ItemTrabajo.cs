using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ItemTrabajo
    {
        private OrdenServicioTipoPrenda _trabajo;
        private TimeSpan _tiempoRestante;

        public OrdenServicioTipoPrenda Trabajo 
        {
            get { return _trabajo; }
            set { _trabajo = value; }
        }

        public TimeSpan TiempoRestante
        {
            get { return _tiempoRestante; }
            set { _tiempoRestante = value; }
        }
    }
}
