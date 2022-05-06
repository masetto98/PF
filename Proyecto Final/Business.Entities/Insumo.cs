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
        private List<InsumoProveedor> _insumosProveedores;// lista de proveedores que proveen ese insumo
        private List<InsumoServicioTipoPrenda> _insumosServicioTipoPrenda;//lista de serviciosTipoPrenda donde se utiliza ese insumo

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

        public List<InsumoProveedor> InsumosProveedores
        {
            get { return _insumosProveedores; }
            set { _insumosProveedores = value; }
        }

        public List<InsumoServicioTipoPrenda> InsumoServicioTipoPrenda
        {
            get { return _insumosServicioTipoPrenda; }
            set { _insumosServicioTipoPrenda = value; }
        }
    }
}
