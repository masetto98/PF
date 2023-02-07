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
        private readonly LavanderiaContext _context;

        public frmLogin(LavanderiaContext context)
        {
            _context = context;
            InitializeComponent();
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
            
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //try
            //{
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
            //}
            /*
            catch (Exception ex)
            {
                MessageBox.Show("Usuario incorrecto", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }
        private bool VerificarExistenciaUsuarios()
        {
            Usuario us = _usuarioLogic.GetAll().Find(
                delegate (Usuario us) {
                    return us.Empleado.TipoEmpleado == Empleado.TiposEmpleado.Admin;
                });
            
            if(us is null)
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }
        private void showPass1_Click(object sender, EventArgs e)
        {
            hidePass1.BringToFront();
            txtContrasenia.UseSystemPasswordChar = false;
            txtContrasenia.PasswordChar = '\0';
        }

        private void hidePass1_Click(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = true;
            showPass1.BringToFront();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (!VerificarExistenciaUsuarios())
            {
                EmpleadoDesktop frmEmpleado = new EmpleadoDesktop(ApplicationForm.ModoForm.Alta, _context);
                frmEmpleado.ShowDialog();
                List<Empleado> empleados = _empleadoLogic.GetAll();
                if (empleados.Count > 0)
                {
                    UsuarioDesktop frmUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta, _context);
                    frmUsuario.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("¡Atención! Debe contactarse con un Administrador para poder crear una nueva cuenta.", "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void linklblLoginHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginHelpForm frmLoginHelp = new LoginHelpForm(ApplicationForm.ModoForm.Alta, _context);
            frmLoginHelp.ShowDialog();
        }
        
    }
}
