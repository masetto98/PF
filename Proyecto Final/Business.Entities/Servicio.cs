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

        [Key]
        [Column("id_servicio")]
        public int IdServicio 
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
