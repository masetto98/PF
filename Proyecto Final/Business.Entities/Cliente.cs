using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class Cliente:BusinessEntity
    {
        private int _idCliente;
        private string _cuit;
        private string _razon_social;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _email;
        private string _direccion;
        [Key]
        [Column("id_cliente")]
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        [Column("cuit")]
        public string Cuit 
        {
            get { return _cuit; }
            set { _cuit = value;  }
        }
        [Column("razon_social")]
        public string RazonSocial
        {
            get { return _razon_social; }
            set { _razon_social = value; }
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
    }
}
