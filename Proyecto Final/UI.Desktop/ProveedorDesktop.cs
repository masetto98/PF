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

namespace UI.Desktop
{
    public partial class ProveedorDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Proveedor ProveedorActual { set; get; }
        private readonly ProveedorLogic _proveedorLogic;
        public ProveedorDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _proveedorLogic = new ProveedorLogic(new ProveedorAdapter(context));
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public ProveedorDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
        }
        // Este es el constructor cuando se edita o elimina algo, ya que tiene 3 args
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
        public override void GuardarCambios()
        {
            //            try
            //            {
            MapearADatos();
            _proveedorLogic.Save(ProveedorActual);
            Close();

            //            }
            /*            catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            */
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                _proveedorLogic.Delete(ProveedorActual.IdProveedor);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
