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
        private DateTime _fechaDesde;
        private double _cantidad;
        private int _idTipoMaquina;
        //private bool _deleted;
        private Insumo _insumo;
        private ServicioTipoPrenda _servicioTipoPrenda;
        private TiposMaquina _tipoMaquina;

       
        [Column("id_insumo")]
        public int IdInsumo 
        {
            get {return _idInsumo; }
            set {_idInsumo = value; }
        }
        
        [Column("id_servicio")]
        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
        
        [Column("id_tp")]
        public int IdTipoPrenda
        {
            get { return _idTipoPrenda; }
            set { _idTipoPrenda = value; }
        }

        [Column("fecha_desde")]
        public DateTime FechaDesde 
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }

        [Column("cantidad")]
        public double Cantidad 
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        [Column("id_tpm")]
        public int IdTipoMaquina
        {
            get { return _idTipoMaquina; }
            set { _idTipoMaquina = value; }
        }
        /*
        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
        }*/

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

        public ServicioTipoPrenda ServicioTipoPrenda
        {
            get { return _servicioTipoPrenda; }
            set { _servicioTipoPrenda = value; }
        }

        public TiposMaquina TipoMaquina
        {
            get { return _tipoMaquina; }
            set { _tipoMaquina = value; }
        }
    }

}
