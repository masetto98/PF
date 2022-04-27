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
    public partial class ClienteDesktop : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Cliente ClienteActual { set; get; }
        private readonly ClienteLogic _clienteLogic;


        public ClienteDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteActual = new Cliente();
            ClienteActual.Cuit = this.txtCuit.Text;
            ClienteActual.RazonSocial = this.txtRazonSocial.Text;
            ClienteActual.Nombre = this.txtNombre.Text;
            ClienteActual.Apellido = this.txtApellido.Text;
            ClienteActual.Telefono = this.txtTelefono.Text;
            ClienteActual.Email = this.txtEmail.Text;
            ClienteActual.Direccion = this.txtDireccion.Text;
            ClienteActual.State = BusinessEntity.States.New;
            _clienteLogic.Save(ClienteActual);
            this.Close();

        }
    }
}
