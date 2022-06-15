using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Database;
using Business.Logic;
using Business.Entities;
using MaterialSkin;
using FluentValidation.Results;

namespace UI.Desktop
{
    public partial class ProveedorDesktop : ApplicationForm
    {
        
        public Proveedor ProveedorActual { set; get; }
        private readonly ProveedorLogic _proveedorLogic;
        public ProveedorDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _proveedorLogic = new ProveedorLogic(new ProveedorAdapter(context));
            
        }

        public ProveedorDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
        }

        
        public ProveedorDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                ProveedorActual = _proveedorLogic.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void MapearDeDatos()
        {
            this.txtIDProv.Text = this.ProveedorActual.IdProveedor.ToString();
            this.txtCuitProv.Text = this.ProveedorActual.Cuit;
            this.txtRazonSocialProv.Text = this.ProveedorActual.RazonSocial;
            this.txtTelProv.Text = this.ProveedorActual.Telefono;
            this.txtEmailProv.Text = this.ProveedorActual.Email;
            this.txtDireccionProv.Text = this.ProveedorActual.Direccion;

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
                    this.txtIDProv.Enabled = false;
                    this.txtCuitProv.Enabled = false;
                    this.txtRazonSocialProv.Enabled = false;
                    this.txtTelProv.Enabled = false;
                    this.txtEmailProv.Enabled = false;
                    this.txtDireccionProv.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.txtIDProv.Enabled = false;
                    this.txtCuitProv.Enabled = false;
                    this.txtRazonSocialProv.Enabled = false;
                    this.txtTelProv.Enabled = false;
                    this.txtEmailProv.Enabled = false;
                    this.txtDireccionProv.Enabled = false;
                    break;
            }
        }
        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                ProveedorActual = new Proveedor();
                ProveedorActual.Cuit = this.txtCuitProv.Text;
                ProveedorActual.RazonSocial = this.txtRazonSocialProv.Text;
                ProveedorActual.Telefono = this.txtTelProv.Text;
                ProveedorActual.Email = this.txtEmailProv.Text;
                ProveedorActual.Direccion = this.txtDireccionProv.Text;
                
            }
            if (Modos == ModoForm.Modificacion)
            {
                ProveedorActual.Cuit = this.txtCuitProv.Text;
                ProveedorActual.RazonSocial = this.txtRazonSocialProv.Text;
                ProveedorActual.Telefono = this.txtTelProv.Text;
                ProveedorActual.Email = this.txtEmailProv.Text;
                ProveedorActual.Direccion = this.txtDireccionProv.Text;
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    ProveedorActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ProveedorActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override bool Validar()
        {
            ValidationResult result = new ProveedorValidator().Validate(ProveedorActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion);
                return false;
            }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (Validar())
                {
                    _proveedorLogic.Save(ProveedorActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public virtual void Eliminar()
        {
            try
            {
                _proveedorLogic.Delete(ProveedorActual.IdProveedor);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
