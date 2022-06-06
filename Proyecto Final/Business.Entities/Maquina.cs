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
        private List<Mantenimiento> _mantenimientos;// Listado de mantenimientos realizados
        private List<MaquinaOrdenServicioTipoPrenda> _itemsAtendidos; // Lista de items de ordenes atendidos en esa maquina

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
