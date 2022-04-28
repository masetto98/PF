using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Insumo:BusinessEntity
    {
        private int _idInsumo;
        private string _descripcion;
        private decimal _stock;
        [Key]
        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public decimal Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
