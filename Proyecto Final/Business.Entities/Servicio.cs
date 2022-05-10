using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Business.Entities
{
    public class Servicio: BusinessEntity
    {
        private int _idServicio;
        private string _descripcion;
        private List<ServicioTipoPrenda>_servicioTipoPrenda;//Listas de prendas a las cuales se puede aplicar ese servicio

        [Key]
        [Column("id_servicio")]
        public int IdServicio 
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
        [Column("descripcion")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public List<ServicioTipoPrenda> ServicioTipoPrenda
        {
            get { return _servicioTipoPrenda; }
            set { _servicioTipoPrenda = value; }
        }
    }
}
