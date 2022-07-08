using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    class Singleton
    {
        private Singleton() { }
        private Business.Entities.Empleado _empleadoActual;
        private Usuario _usuarioActual;
        private System.Windows.Forms.ListView _listActual;
        private System.Windows.Forms.ListView _listAlternativa;
        private string _moduloActual;
        private static Singleton _instance;
        public static Singleton getInstance()
        {
            return _instance;
        }
        public static void setInstance(Business.Entities.Empleado emp, Usuario usr)
        {
            _instance = new Singleton();
            _instance._empleadoActual = emp;
            _instance._usuarioActual = usr;
        }
        public Business.Entities.Empleado EmpleadoLogged
        {
            get
            {
                return _empleadoActual;
            }
        }
        public Usuario UserLogged
        {
            get
            {
                return _usuarioActual;
            }
        }
       public System.Windows.Forms.ListView ListActual
        {
            get
            {
                return _listActual;
            }
            set
            {
                _listActual = value;
            }
        }
        public System.Windows.Forms.ListView ListAlternativa
        {
            get
            {
                return _listAlternativa;
            }
            set
            {
                _listAlternativa = value;
            }
        }
        public string ModuloActual
        {
            get
            {
                return _moduloActual;
            }
            set
            {
                _moduloActual = value;
            }
        }
    }
}
