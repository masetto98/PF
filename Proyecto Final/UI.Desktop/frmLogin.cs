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
using MaterialSkin;

namespace UI.Desktop
{
    public partial class frmLogin : ApplicationForm
    {
        private readonly UsuarioLogic _usuarioLogic;
        private readonly EmpleadoLogic _empleadoLogic;
        public frmLogin(LavanderiaContext context)
        {
            InitializeComponent();
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usr = _usuarioLogic.Login(this.txtNombreUsuario.Text, this.txtContrasenia.Text);
                if (usr != null)
                {
                    if (usr.Habilitado == true)
                    {
                        Singleton.setInstance(_empleadoLogic.GetOne(usr.IdEmpleado), usr);
                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {

                        MessageBox.Show("Usuario no habilitado, contactese con su administrador", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Contraseña incorrecta", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario incorrecto", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
