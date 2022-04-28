using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Proveedor:BusinessEntity
    {
        private string _cuit;
        private string _razon_social;
        private string _telefono;
        private string _email;
        private string _direccion;

        [Key]
        public string Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

        public string RazonSocial
        {
            get { return _razon_social; }
            set { _razon_social = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
    }
}
