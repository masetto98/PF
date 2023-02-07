using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Maquina:BusinessEntity
    {
        private int _idMaquina;
        private string _descripcion;
        private int _idTipoMaquina;
        private bool _deleted;
        private List<Mantenimiento> _mantenimientos;// Listado de mantenimientos realizados
        private List<MaquinaOrdenServicioTipoPrenda> _itemsAtendidos; // Lista de items de ordenes atendidos en esa maquina
        private TiposMaquina _tipoMaquina;

        [Key]
        [Column("id_maquina")]
        public int IdMaquina 
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }

        [Column("descripcion")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        [Column("id_tpm")]
        public int IdTipoMaquina
        {
            get { return _idTipoMaquina; }
            set { _idTipoMaquina = value; }
        }

        [Column("deleted")]
        public bool Borrado
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public TiposMaquina TipoMaquina 
        {
            get { return _tipoMaquina; }
            set { _tipoMaquina = value; }
        }

        public List<Mantenimiento> Mantenimientos
        {
            get { return _mantenimientos; }
            set { _mantenimientos = value; }
        }

        public List<MaquinaOrdenServicioTipoPrenda> itemsAtendidos
        {
            get { return _itemsAtendidos; }
            set { _itemsAtendidos = value; }
        }
    }
}
