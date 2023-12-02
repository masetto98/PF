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
        //private TimeSpan _horasLaboralesDiarias;
        private string _logo_negocio;
        private string _cuitEmpresa;
        private string _nombreEmpresa;
        private string _direccionEmpresa;
        private string _telEmpresa;
        private string _redesEmpresa;
        private string _email;
        private string _emailPass;
        private string _salt;

        [Column ("id")]
        public int ID 
        {
            get { return _id; }
            set { _id = value; }
        }

        /*[Column("horas_laborales_diarias")]
        public TimeSpan HorasLaboralesDiarias 
        {
            get {return _horasLaboralesDiarias; }
            set {_horasLaboralesDiarias = value; }
        }*/

        [Column("logo_negocio")]
        public string LogoNegocio
        {
            get { return _logo_negocio;}
            set { _logo_negocio = value; }
        }
        [Column("cuit_empresa")]
        public string CuitEmpresa
        {
            get { return _cuitEmpresa; }
            set { _cuitEmpresa = value; }
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
        [Column("email")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [Column("email_pass")]
        public string Contrasenia
        {
            get { return _emailPass; }
            set { _emailPass = value; }
        }
        [Column("salt")]
        public string Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }

    }
}
