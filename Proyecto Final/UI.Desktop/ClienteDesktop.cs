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

namespace UI.Desktop
{
    public partial class ClienteDesktop : ApplicationForm
    {
        
        public Cliente ClienteActual { set; get; }
        private readonly ClienteLogic _clienteLogic;


        public ClienteDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
        }
        // Este es el constructor cuando se da de alta alta, ya que solo tiene un arg
        public ClienteDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
        }
        // Este es el constructor cuando se edita o elimina algo, ya que tiene 3 args
        public ClienteDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                ClienteActual = _clienteLogic.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ClienteActual.IdCliente.ToString();
            this.txtCuit.Text = this.ClienteActual.Cuit;
            this.txtRazonSocial.Text = this.ClienteActual.RazonSocial;
            this.txtNombre.Text = this.ClienteActual.Nombre;
            this.txtApellido.Text = this.ClienteActual.Apellido;
            this.txtDireccion.Text = this.ClienteActual.Direccion;
            this.txtTelefono.Text = this.ClienteActual.Telefono;
            this.txtEmail.Text = this.ClienteActual.Email;

            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    this.txtID.Enabled = false;
                    this.txtCuit.Enabled = false;
                    this.txtNombre.Enabled = false;
                    this.txtApellido.Enabled = false;
                    this.txtRazonSocial.Enabled = false;
                    this.txtDireccion.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.txtTelefono.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    /*this.btnAceptar.Text = "Aceptar";
                    this.cbMateria.Enabled = false;
                    this.cbComision.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    this.nudAnoCalendario.Enabled = false;
                    this.nudCupo.Enabled = false;*/
                    break;
            }
        }
        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                ClienteActual = new Cliente();
                ClienteActual.Cuit = this.txtCuit.Text;
                ClienteActual.RazonSocial = this.txtRazonSocial.Text;
                ClienteActual.Nombre = this.txtNombre.Text;
                ClienteActual.Apellido = this.txtApellido.Text;
                ClienteActual.Telefono = this.txtTelefono.Text;
                ClienteActual.Email = this.txtEmail.Text;
                ClienteActual.Direccion = this.txtDireccion.Text;
            }
            if (Modos == ModoForm.Modificacion)
            {
                ClienteActual.Cuit = this.txtCuit.Text;
                ClienteActual.RazonSocial = this.txtRazonSocial.Text;
                ClienteActual.Nombre = this.txtNombre.Text;
                ClienteActual.Apellido = this.txtApellido.Text;
                ClienteActual.Telefono = this.txtTelefono.Text;
                ClienteActual.Email = this.txtEmail.Text;
                ClienteActual.Direccion = this.txtDireccion.Text;
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    ClienteActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ClienteActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
//            try
//            {
                MapearADatos();
                _clienteLogic.Save(ClienteActual);
                Close();
                
//            }
/*            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/
        }
        private void btnAceptar_Click(object sender, EventArgs e)
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
        public virtual void Eliminar()
        {
            try
            {
                _clienteLogic.Delete(ClienteActual.IdCliente);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
