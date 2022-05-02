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

namespace UI.Desktop
{
    public partial class frmMain : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly LavanderiaContext _context;
        public frmMain(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(_context);
            frmCliente.ShowDialog();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmLogin appLogin = new frmLogin(_context);
            if(appLogin.ShowDialog()!= DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoDesktop frmEmpleado = new EmpleadoDesktop(_context);
            frmEmpleado.ShowDialog();
        }
    }
}
