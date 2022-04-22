using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Maquina:BusinessEntity
    {
        private int _idMaquina;
        private string _descripcion;

        public int IdMaquina 
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
