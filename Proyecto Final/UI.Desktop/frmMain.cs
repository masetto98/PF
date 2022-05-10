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
        private readonly OrdenLogic _ordenLogic;
        public frmMain(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            CargarOrdenes();
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

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            OrdenDesktop frmOrden = new OrdenDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmOrden.ShowDialog();
        }

        private void btnNuevoServicioTipoPrenda_Click(object sender, EventArgs e)
        {
            ServicioTipoPrendaDesktop frmServicioTipoPrenda = new ServicioTipoPrendaDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmServicioTipoPrenda.ShowDialog();

        }

        private void mnuPrincipal_Selected(object sender, TabControlEventArgs e)
        {
            if (mnuPrincipal.SelectedTab == mnuTabOrdenes)
            {
                CargarOrdenes();
                
            }
            else if (mnuPrincipal.SelectedTab == mnuTabClientes)
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

        private void CargarOrdenes() 
        {
            List<Orden> ordenes = _ordenLogic.GetAll();
            listOrdenes.Items.Clear();
            foreach (Orden o in ordenes)
            {
                ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                item.SubItems.Add(o.IdCliente.ToString());
                item.SubItems.Add(o.IdEmpleado.ToString());
                item.SubItems.Add(o.NroFactura.ToString());
                item.SubItems.Add(o.Prioridad);
                item.SubItems.Add(o.FechaEntrada.ToString());
                item.SubItems.Add(o.TiempofinalizacionEstimado.ToString());
                item.SubItems.Add(o.TiempoFinalizacionReal.ToString());
                item.SubItems.Add(o.FechaSalida.ToString());
                item.SubItems.Add(o.Estado.ToString());
                listOrdenes.Items.Add(item);
            }
        }

        private void btnNuevoTipoPrenda_Click(object sender, EventArgs e)
        {
            TipoPrendaDesktop formTipoPrendaDesktop = new TipoPrendaDesktop(ApplicationForm.ModoForm.Alta, _context);
            formTipoPrendaDesktop.ShowDialog();
        }
    }
}
