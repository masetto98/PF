using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        private double _cantidad;
        private Insumo _insumo;
        private ServicioTipoPrenda _servicioTipoPrenda;
        //private Servicio _servicio;
        //private TipoPrenda _tipoPrenda;
        //private List<Consumo> _historicoConsumos;

        //[ForeignKey("Insumo")]
        [Column("id_insumo")]
        public int IdInsumo 
        {
            get {return _idInsumo; }
            set {_idInsumo = value; }
        }
        //[ForeignKey("ServicioTipoPrenda")]
        [Column("id_servicio")]
        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
        //[ForeignKey("ServicioTipoPrenda")]
        [Column("id_tp")]
        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }
        [Column("cantidad")]
        public double Cantidad 
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

        /*public Servicio Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }

        public TipoPrenda TipoPrenda
        {
            get { return _tipoPrenda; }
            set { _tipoPrenda = value; }
        }*/
        /*
        public List<Consumo> HistoricoConsumos
        {
            get { return _historicoConsumos; }
            set { _historicoConsumos = value; }
        }*/

        public ServicioTipoPrenda ServicioTipoPrenda
        {
            get { return _servicioTipoPrenda; }
            set { _servicioTipoPrenda = value; }
        }
    }

}
