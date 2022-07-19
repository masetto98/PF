using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Entities
{
    public class Consumo:BusinessEntity
    {
        private int _idMaquina;
        private DateTime _fechaConsumo;
        private int _idInsumo;
        private double _cantidad;
        private int _unidadMedida;
        private MaquinaOrdenServicioTipoPrenda _maquinaOrdenServicioTipoPrenda;
        private Insumo _insumo;
        /*
        public enum Medidas
        {
            Litros = 1,
            Kilogramos = 2,
            Unidades = 3,
        }*/

        [Column("id_maquina")]
        public int IdMaquina 
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }

        [Column("fecha_consumo")]
        public DateTime FechaConsumo
        {
            get { return _fechaConsumo; }
            set { _fechaConsumo = value; }
        }

        [Column("id_insumo")]
        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }

        [Column("cantidad")]
        public double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        [Column("unidad_medida")]
        public int UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }

        public MaquinaOrdenServicioTipoPrenda MaquinaOrdenServicioTipoPrenda
        {
            get { return _maquinaOrdenServicioTipoPrenda; }
            set { _maquinaOrdenServicioTipoPrenda = value; }
        }

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

    }
}
