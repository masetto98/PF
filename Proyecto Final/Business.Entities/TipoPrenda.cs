using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class TipoPrenda:BusinessEntity
    {
        private int _idTipoPrenda;
        private string _descripcion;
        private List<ServicioTipoPrenda> _servicioTipoPrenda;//Lista de servicios que se aplica a ese tipo de prenda

        [Key]
        [Column("id_tp")]
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

        public List<ServicioTipoPrenda> ServicioTipoPrenda
        {
            get { return _servicioTipoPrenda; }
            set { _servicioTipoPrenda = value; }
        }
    }
}
