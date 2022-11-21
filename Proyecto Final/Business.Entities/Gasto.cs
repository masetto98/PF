using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Gasto : BusinessEntity
    {
        private int _idGasto;
        private string _descripcion;
        private DateTime _fechaRealizado;
        private double _importe;
        private TiposGasto _tipoGasto;
        private bool _deleted;

        public enum TiposGasto
        {
            Impuestos = 1,
            Servicios = 2,
            Productos =3,
            Varios = 4,
            Matenimientos =5,
        }
        [Key]
        [Column("id_gasto")]
        public int IdGasto
        {
            get { return _idGasto; }
            set { _idGasto = value; }
        }
        [Column("descripcion")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        [Column("fecha_realizado")]
        public DateTime FechaRealizado
        {
            get { return _fechaRealizado; }
            set { _fechaRealizado = value; }
        }
        [Column("importe")]
        public double Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        [Column("tipo_gasto")]
        public TiposGasto TipoGasto 
        {
            get { return _tipoGasto; }
            set { _tipoGasto = value; }
        }

        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

    }
}
