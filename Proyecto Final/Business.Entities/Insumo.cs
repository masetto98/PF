using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Insumo:BusinessEntity
    {
        private int _idInsumo;
        private string _descripcion;
        private double _stock;
        private double _puntoPedido;
        private bool _deleted;
        private List<InsumoProveedor>? _insumosProveedores;// lista de proveedores que proveen ese insumo
        private List<InsumoServicioTipoPrenda> _insumosServicioTipoPrenda;//lista de serviciosTipoPrenda donde se utiliza ese insumo
        private List<Consumo> _consumos;
        private Medidas _unidadMedida;
        
        public enum Medidas
        {
            Litros=1,
            Kilogramos=2,
            Unidades=3,
        }
        
        [Key]
        [Column("id_insumo")]
        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }

        [Column("descripcion")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        [Column("stock")]
        public double Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        
        [Column("unidad_medida")]
        public Medidas UnidadMedida 
        {
            get {return _unidadMedida; }
            set {_unidadMedida = value; }
        }

        [Column("punto_pedido")]
        public double PuntoPedido
        {
            get { return _puntoPedido; }
            set { _puntoPedido = value; }
        }

        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
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

        public List<Consumo> Consumos
        {
            get { return _consumos; }
            set { _consumos = value; }
        }
    }
}
