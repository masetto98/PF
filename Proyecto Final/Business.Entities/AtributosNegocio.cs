using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AtributosNegocio:BusinessEntity
    {
        private int _id;
        private TimeSpan _horasLaboralesDiarias;
        private string _diasLaborales;
        private string _nombreEmpresa;
        private string _direccionEmpresa;
        private string _telEmpresa;
        private string _redesEmpresa;

        [Column ("id")]
        public int ID 
        {
            get { return _id; }
            set { _id = value; }
        }

        [Column("horas_laborales_diarias")]
        public TimeSpan HorasLaboralesDiarias 
        {
            get {return _horasLaboralesDiarias; }
            set {_horasLaboralesDiarias = value; }
        }

        [Column("dias_laborables")]
        public string DiasLaborales 
        {
            get { return _diasLaborales;}
            set { _diasLaborales = value; }
        }
        [Column("nombre_empresa")]
        public string NombreEmpresa
        {
            get { return _nombreEmpresa; }
            set { _nombreEmpresa = value; }
        }
        [Column("direccion_empresa")]
        public string DireccionEmpresa
        {
            get { return _direccionEmpresa; }
            set { _direccionEmpresa = value; }
        }
        [Column("tel_empresa")]
        public string TelEmpresa
        {
            get { return _telEmpresa; }
            set { _telEmpresa = value; }
        }
        [Column("redes_empresa")]
        public string RedesEmpresa
        {
            get { return _redesEmpresa; }
            set { _redesEmpresa = value; }
        }
    }
}
