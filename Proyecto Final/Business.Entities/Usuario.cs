using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private int _idUsuario;
        private string _nombreUsuario;
        private string _clave;
        private bool _habilitado;
        private int _idEmpleado;
        private Empleado _empleado;

        [Key]
        [Column("id_usuario")]
        public int IdUsuario 
        { 
            get
            {
                return _idUsuario;
            }
            set
            {
                _idUsuario = value;
            }
        }
        [Column("nombre_usuario")]
        public string NombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }
            set
            {
                _nombreUsuario = value;
            }
        }
        [Column("clave")]
        public string Clave
        {
            get
            {
                return _clave;
            }
            set
            {
                _clave = value;
            }
        }
        [Column("habilitado")]
        public bool Habilitado
        {
            get
            {
                return _habilitado;
            }
            set
            {
                _habilitado = value;
            }
        }
        [Column("cuit_empleado")]
        //[ForeignKey("Empleado")]
        public int IdEmpleado
        {
            get
            {
                return _idEmpleado;
            }
            set
            {
                _idEmpleado = value;
            }
        }
        public Empleado Empleado
        {
            get
            {
                return _empleado;
            }
            set
            {
                _empleado = value;
            }
        }
        //public string Salt { get; set; }
    }
}
