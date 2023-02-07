using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Data.Database;
using FluentValidation.Results;
using System.Security.Cryptography;

namespace UI.Desktop
{
    public partial class LoginHelpForm : ApplicationForm
    {
        private readonly UsuarioLogic _usuarioLogic;
        private readonly LavanderiaContext _context;
        public Usuario usuarioActual;
        private Usuario UsuarioModif { set; get; }

        public LoginHelpForm(LavanderiaContext context)
        {
            _context = context;
            InitializeComponent();
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
        }

        public LoginHelpForm(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            usuarioActual = _usuarioLogic.GetAll().Find(x => x.NombreUsuario == this.txtUsuario.Text);
            if (usuarioActual is not null)
            {
                this.cmbPreguntas.Enabled = true;
                this.txtRespuesta.Enabled = true;
                CargarPreguntas();
            }
            else
            {
                this.cmbPreguntas.Enabled = false;
                this.txtRespuesta.Enabled = false;
                MessageBox.Show("El usuario ingresado es incorrecto", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPreguntas() 
        {
            List<string> preguntas = new List<string>();
            preguntas.Add("¿Como es el nombre de tu perro de la infancia?");
            preguntas.Add("¿Cual es el nombre de tu superheroe favorito?");
            preguntas.Add("¿Como es el apellido de soltera de tu madre?");
            preguntas.Add("¿Cual es el nombre de un amigo de la infancia?");
            this.cmbPreguntas.DataSource = preguntas;
        }
        

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                UsuarioModif = new Usuario();
                UsuarioModif.IdUsuario = usuarioActual.IdUsuario;
                UsuarioModif.IdEmpleado = usuarioActual.IdEmpleado;
                UsuarioModif.Empleado = usuarioActual.Empleado;
                UsuarioModif.Habilitado = true;
                UsuarioModif.NombreUsuario = usuarioActual.NombreUsuario;
                UsuarioModif.Clave = this.txtNewPass.Text;
                UsuarioModif.Pregunta = usuarioActual.Pregunta;
                UsuarioModif.Respuesta = usuarioActual.Respuesta;
                UsuarioModif.State = BusinessEntity.States.Modified;
            }
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (Validar())
                {
                    _usuarioLogic.Save(UsuarioModif);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public override bool Validar()
        {
            ValidationResult result = new UsuarioValidator().Validate(usuarioActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion,"Usuario",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respuesta = new Hasher().GenerateHash(this.txtRespuesta.Text, usuarioActual.Salt);
            if (usuarioActual.Respuesta == respuesta && this.cmbPreguntas.SelectedIndex == usuarioActual.Pregunta)
            {
                this.txtNewPass.Enabled = true;
                this.txtRepeatNewPass.Enabled = true;
                this.btnAceptar.Enabled = true;
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (this.txtNewPass.Text!="" && this.txtNewPass.Text == this.txtRepeatNewPass.Text)
            {
                GuardarCambios();
            }
            else { MessageBox.Show("Las constraseñas no coinciden", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
