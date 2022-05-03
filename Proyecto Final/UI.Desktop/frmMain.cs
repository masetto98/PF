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
using Data.Database;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class frmMain : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly LavanderiaContext _context;
        private readonly ClienteLogic _clienteLogic;
        public frmMain(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta,_context);
            frmCliente.ShowDialog();
        }

        /*private void frmMain_Shown(object sender, EventArgs e)
        {
            frmLogin appLogin = new frmLogin(_context);
            if(appLogin.ShowDialog()!= DialogResult.OK)
            {
                this.Dispose();
            }
        }
        */
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoDesktop frmEmpleado = new EmpleadoDesktop(_context);
            frmEmpleado.ShowDialog();
        }

        private void mnuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cliente> clientes = _clienteLogic.GetAll();
            listClientes.Items.Clear();
            foreach (Cliente c in clientes)
            {
                ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                item.SubItems.Add(c.Cuit);
                item.SubItems.Add(c.Nombre);
                item.SubItems.Add(c.Apellido);
                item.SubItems.Add(c.Direccion);
                item.SubItems.Add(c.RazonSocial);
                item.SubItems.Add(c.Email);
                item.SubItems.Add(c.Telefono);
                listClientes.Items.Add(item);
            }

        }
        
    }
}
