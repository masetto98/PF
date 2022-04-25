using System;
using System.Collections.Generic;
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
        private Insumo _insumo;
        private Servicio _servicio;
        private TipoPrenda _tipoPrenda;
        public int IdInsumo 
        {
            get {return _idInsumo; }
            set {_idInsumo = value; }
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

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

        public Servicio Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }

        public TipoPrenda TipoPrenda
        {
            get { return _tipoPrenda; }
            set { _tipoPrenda = value; }
        }
    }

}
