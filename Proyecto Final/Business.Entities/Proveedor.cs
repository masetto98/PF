using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Business.Entities
{
    public class Proveedor:BusinessEntity
    {
        private int _idProveedor;
        private string _cuit;
        private string _razon_social;
        private string _telefono;
        private string _email;
        private string _direccion;
        private bool _deleted;
        private List<InsumoProveedor> _insumosProveedor;//Lista de insumos que provee ese proveedor

        [Key]
        [Column("id_proveedor")]
        public int IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }
        [Column("cuit")]
        public string Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
        [Column("razon_social")]
        public string RazonSocial
        {
            get { return _razon_social; }
            set { _razon_social = value; }
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

        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public List<InsumoProveedor> InsumosProveedor
        {
            get { return _insumosProveedor; }
            set { _insumosProveedor = value; }
        }
    }
}
