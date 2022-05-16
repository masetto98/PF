using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
namespace UI.Desktop
{
    class Singleton
    {
        private Singleton() { }
        private Empleado _empleadoActual;
        private Usuario _usuarioActual;
        private static Singleton _instance;
        public static Singleton getInstance()
        {
            return _instance;
        }
        public static void setInstance(Empleado emp, Usuario usr)
        {
            _instance = new Singleton();
            _instance._empleadoActual = emp;
            _instance._usuarioActual = usr;
        }
        public Empleado EmpleadoLogged
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
    }
}
