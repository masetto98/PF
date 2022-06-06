using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Empleado:BusinessEntity
    {
        private int _idEmpleado;
        public enum TiposEmpleado
        {
            Admin = 1,
            Usuario = 2,
        }
        private string _cuit;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _email;
        private string _direccion;
        [DataType(DataType.Date)]
        private DateTime _fechaInicio;
        public TiposEmpleado _tipoEmpleado;
        private List<Orden> _ordenesRegistradas;
        private List<MaquinaOrdenServicioTipoPrenda> _ordenesAtendidas;
        private List<Usuario> _usuarios;

        [Key]
        [Column("id_empleado")]
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        [Column("cuit")]
        public string Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
        [Column("nombre")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        [Column("apellido")]
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        [Column("telefono")]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        [Column("email")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [Column("direccion")]
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        [Column("fecha_inicio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }
        [Column("tipo_empleado")]
        public TiposEmpleado TipoEmpleado
        {
            get { return _tipoEmpleado; }
            set { _tipoEmpleado = value; }
        }

        public List<Orden> OrdenesRegistradas
        {
            get { return _ordenesRegistradas; }
            set { _ordenesRegistradas = value; }
        }

        public List<MaquinaOrdenServicioTipoPrenda> OrdenesAtendidas
        {
            get { return _ordenesAtendidas; }
            set { _ordenesAtendidas = value; }
        }

        public List<Usuario> Usuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }
    }
}
