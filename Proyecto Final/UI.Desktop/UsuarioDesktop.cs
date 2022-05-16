using Business.Entities;
using Business.Logic;
using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private readonly UsuarioLogic _usuarioLogic;
        private readonly EmpleadoLogic _empleadoLogic;
        private Usuario UsuarioActual { set; get; }
        public UsuarioDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
        }
        public UsuarioDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            // Este constructor es cuando doy de alta un nuevo usuario
            Modos = modo;
            // Creo el nuevo usuario acá para después poder asignarle el ID de persona
            UsuarioActual = new Usuario();
            // Está todo deshabilitado hasta que cargues un legajo que coincida con una persona
            this.txtNombreUsuario.ReadOnly = true;
            this.chkHabilitado.Enabled = false;
            this.txtClaveUser.ReadOnly = true;
            this.txtConfirmarClave.ReadOnly = true;
        }
        public UsuarioDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                UsuarioActual = _usuarioLogic.GetOne(ID);
                // Como estoy modificando o borrando el usuario, no tengo que poder modificar el legajo
                // al cual está asociado
                
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void MapearDeDatos()
        {
            this.txtIdUsuario.Text = this.UsuarioActual.IdUsuario.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombreUsuario.Text = this.UsuarioActual.NombreUsuario;
            // La clave no la tengo que cargar porque no se muestra, siempre se vuelve a poner de 0
            // Ahora tengo que cargar los datos de la persona también
            try
            {
                Empleado emp = _empleadoLogic.GetOne(UsuarioActual.IdEmpleado);
                this.txtCuitEmpleado.Text = emp.Cuit.ToString();
                this.txtNombreEmpleado.Text = emp.Nombre;
                this.txtApellidoEmpleado.Text = emp.Apellido;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnAceptarUsuario.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptarUsuario.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptarUsuario.Text = "Eliminar";
                    this.txtNombreUsuario.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptarUsuario.Text = "Aceptar";
                    break;
            }

        }
        public override void MapearADatos()
        {
            UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            if (this.txtClaveUser.Text != "")
            {
                UsuarioActual.Clave = this.txtClaveUser.Text;
            }
            UsuarioActual.NombreUsuario = this.txtNombreUsuario.Text;
            switch (Modos)
            {
                case ModoForm.Alta:
                    UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (this.txtConfirmarClave.Text == this.txtClaveUser.Text)
                {
                 _usuarioLogic.Save(UsuarioActual);
                 Close();
                    
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarEmpleado()
        {
            this.btnAceptarUsuario.Enabled = false;
            List<Empleado> empleados = _empleadoLogic.GetAll();
            try
            {
                // Esta validacion tiene q ser q no es vacio y q son solo numeros
                // Metele regex a este if pa
                if (this.txtCuitEmpleado.Text.Length == 0)
                {
                    Exception e = new Exception("Ingrese un cuit.");
                    throw e;
                }
                var empleado = (from e in empleados
                               where e.Cuit == this.txtCuitEmpleado.Text
                               select e).ToList();
                if (empleado.Count == 0)
                {
                    Exception e = new Exception("No existe empleado para el cuit ingresado.");
                    throw e;
                }
                Empleado emp = _empleadoLogic.GetOne(empleado[0].IdEmpleado);
                // Asigno los datos de la persona a los textbox
                this.txtNombreEmpleado.Text = emp.Nombre;
                this.txtApellidoEmpleado.Text = emp.Apellido;
                // Verifico que no exista un usuario ya para esta persona
                var usuarios = (from u in _usuarioLogic.GetAll()
                                where u.IdEmpleado == emp.IdEmpleado
                                select u);
                if (usuarios.Any())
                {
                    Exception e = new Exception("Ya existe un usuario para el empleado ingresado.");
                    throw e;
                }
                UsuarioActual.IdEmpleado = emp.IdEmpleado;
                // Una vez que cargo la persona, vuelvo a habilitar el resto de los elementos
                this.btnAceptarUsuario.Enabled = true;
                this.txtNombreUsuario.ReadOnly = false;
                this.chkHabilitado.Enabled = true;
                this.txtClaveUser.ReadOnly = false;
                this.txtConfirmarClave.ReadOnly = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            switch (Modos)
            {
                case ModoForm.Alta:
                    {
                        GuardarCambios();
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        GuardarCambios();
                    };
                    break;
                case ModoForm.Baja:
                    Eliminar();
                    Close();
                    break;
                case ModoForm.Consulta:
                    Close();
                    break;
            }
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
        public virtual void Eliminar()
        {
            try
            {
                _usuarioLogic.Delete(UsuarioActual.IdUsuario);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCuitEmpleado_Leave(object sender, EventArgs e)
        {
            cargarEmpleado();
        }
    }
}
