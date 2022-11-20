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
        private Usuario UsuarioModif { set; get; }
        public UsuarioDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
            
        }
        public UsuarioDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {

            Modos = modo;
            UsuarioActual = new Usuario();
            
            this.txtNombreUsuario.Enabled = false;
            this.chkHabilitado.Enabled = false;
            this.txtClaveUser.Enabled = false;
            this.txtConfirmarClave.Enabled = false;
            this.btnAceptarUsuario.Enabled = false;
        }
        public UsuarioDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                UsuarioActual = _usuarioLogic.GetOne(ID);
                // Como estoy modificando o borrando el usuario, no tengo que poder modificar el cuit
                // al cual está asociado
                this.txtCuit.Enabled = false;
                /*
                this.txtNombreUsuario.ReadOnly = true;
                this.chkHabilitado.Enabled = false;
                this.txtClaveUser.ReadOnly = true;
                this.txtConfirmarClave.ReadOnly = true;
                */
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
                this.txtCuit.Text = emp.Cuit.ToString();
                this.txtNombre.Text = emp.Nombre;
                this.txtApellido.Text = emp.Apellido;
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
                    this.txtIdUsuario.Enabled = false;
                    this.btnBuscar.Enabled = false;
                    break;
                case ModoForm.Baja:
                    this.btnAceptarUsuario.Text = "Eliminar";
                    this.txtNombreUsuario.Enabled = false;
                    this.txtClaveUser.Enabled = false;
                    this.txtConfirmarClave.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptarUsuario.Text = "Aceptar";
                    break;
            }

        }
        public override void MapearADatos()
        {
            if(Modos == ModoForm.Alta)
            {
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                UsuarioActual.NombreUsuario = this.txtNombreUsuario.Text;
                if (this.txtClaveUser.Text != "")
                {
                    UsuarioActual.Clave = this.txtClaveUser.Text;
                }
                
            }
            else if(Modos == ModoForm.Modificacion)
            {
                UsuarioModif = new Usuario();
                UsuarioModif.IdUsuario = UsuarioActual.IdUsuario;
                UsuarioModif.IdEmpleado = UsuarioActual.IdEmpleado;
                UsuarioModif.Empleado = UsuarioActual.Empleado;
                UsuarioModif.Habilitado = this.chkHabilitado.Checked;
                UsuarioModif.NombreUsuario = this.txtNombreUsuario.Text;
                if(this.txtClaveUser.Text != "")
                {
                    UsuarioModif.Clave = this.txtClaveUser.Text;
                }
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    UsuarioModif.State = BusinessEntity.States.Modified;
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
                    if(Modos == ModoForm.Alta)
                    {
                        _usuarioLogic.Save(UsuarioActual);
                        
                    }
                    else if(Modos == ModoForm.Modificacion)
                    {
                        _usuarioLogic.Save(UsuarioModif);
                    }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarEmpleado();
        }

        private void cargarEmpleado()
        {
            this.btnAceptarUsuario.Enabled = false;
            Empleado empleado = _empleadoLogic.GetAll().Find(delegate (Empleado em) { return em.Cuit == this.txtCuit.Text; });
            try
            {
                if (empleado is null)
                {
                    Exception e = new Exception("No existe empleado para el cuit ingresado.");
                    throw e;
                }
                this.txtNombre.Text = empleado.Nombre;
                this.txtApellido.Text = empleado.Apellido;
                if (empleado.Usuarios.Count>0)
                {
                    Exception e = new Exception("Ya existe un usuario para el empleado ingresado.");
                    throw e;
                }
                UsuarioActual.IdEmpleado = empleado.IdEmpleado;
                this.btnAceptarUsuario.Enabled = true;
                this.txtNombreUsuario.Enabled = true;
                this.chkHabilitado.Enabled = true;
                this.txtClaveUser.Enabled = true;
                this.txtConfirmarClave.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Empleado",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                        if (MessageBox.Show($"¿Está seguro que desea modificar el usuario {UsuarioActual.NombreUsuario}?", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el usuario {UsuarioActual.NombreUsuario}?", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Eliminar();
                            Close();
                        }
                    };
                        
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

        private void showPass1_Click(object sender, EventArgs e)
        {
           
                hidePass1.BringToFront();
                txtClaveUser.UseSystemPasswordChar = false;
                txtClaveUser.PasswordChar = '\0';
            
        }

        private void hidePass1_Click(object sender, EventArgs e)
        {
            txtClaveUser.UseSystemPasswordChar = true;
            showPass1.BringToFront();
        }

        private void showPass2_Click(object sender, EventArgs e)
        {
            hidePass2.BringToFront();
            txtConfirmarClave.UseSystemPasswordChar = false;
            txtConfirmarClave.PasswordChar = '\0';
        }

        private void hidePass2_Click(object sender, EventArgs e)
        {
            txtConfirmarClave.UseSystemPasswordChar = true;
            showPass2.BringToFront();
        }
    }
}
