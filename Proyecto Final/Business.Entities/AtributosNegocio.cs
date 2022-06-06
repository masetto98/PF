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
    }
}
