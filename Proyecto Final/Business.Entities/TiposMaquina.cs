using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class TiposMaquina:BusinessEntity
    {
        private int _idTipoMaquina;
        private string _descripcion;
        private List<Maquina> _maquinas;
        private List<InsumoServicioTipoPrenda> _insumosServicioTipoPrendaTiposMaquina;

        [Key]
        [Column("id_tpm")]
        public int IdTipoMaquina
        {
            get { return _idTipoMaquina; }
            set { _idTipoMaquina = value; }
        }
        [Column("descripcion")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public List<Maquina> Maquinas 
        {
            get { return _maquinas; }
            set { _maquinas = value; }

        }

        public List<InsumoServicioTipoPrenda> InsumosServicioTipoPrendaTiposMaquina
        {
            get { return _insumosServicioTipoPrendaTiposMaquina; }
            set { _insumosServicioTipoPrendaTiposMaquina = value; }

        }
    }
}
