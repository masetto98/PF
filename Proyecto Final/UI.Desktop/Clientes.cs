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
    public partial class Clientes : ApplicationForm
    {
        private readonly ClienteLogic _clienteLogic;
        private readonly OrdenLogic _ordenLogic;
        private readonly LavanderiaContext _context;

        public Clientes(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            ListarClientes();
        }

        private void ListarClientes() 
        {
            listClientes.Items.Clear();
            List<Cliente> clientes = _clienteLogic.GetAll();
            if (clientes is not null) 
            {
                foreach (Cliente c in clientes) 
                {
                    ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                    item.SubItems.Add(c.Cuit);
                    item.SubItems.Add(c.Nombre);
                    item.SubItems.Add(c.Apellido);
                    item.SubItems.Add(c.RazonSocial);
                    item.SubItems.Add(c.Telefono);
                    item.SubItems.Add(c.Email);
                    item.SubItems.Add(c.Direccion);
                    listClientes.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta,_context);
            frmCliente.ShowDialog();
            ListarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0) 
            {
                int idCliente = Int32.Parse(listClientes.SelectedItems[0].Text);
                ClienteDesktop frmCliente = new ClienteDesktop(idCliente,ApplicationForm.ModoForm.Modificacion, _context) ;
                frmCliente.ShowDialog();
            }
            ListarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0)
            {
                int idCliente = Int32.Parse(listClientes.SelectedItems[0].Text);
                ClienteDesktop frmCliente = new ClienteDesktop(idCliente, ApplicationForm.ModoForm.Baja, _context);
                frmCliente.ShowDialog();
            }
            ListarClientes();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.lblOrdenesRealizadas.Text = " - ";
            if (listClientes.SelectedItems.Count > 0)
            {
                int idCliente = Int32.Parse(listClientes.SelectedItems[0].Text);
                Cliente clienteActual = _clienteLogic.GetOne(idCliente);
                if (clienteActual is not null) 
                {
                    if (clienteActual.Ordenes is not null) 
                    {
                        this.lblOrdenesRealizadas.Text = clienteActual.Ordenes.Count.ToString();
                    }
                }
                CargarOrdenes(idCliente);
            }
        }

        public void CargarOrdenes(int idCliente) 
        {
            listOrdenes.Items.Clear();
            Cliente clienteActual = _clienteLogic.GetOne(idCliente);
            if (clienteActual.Ordenes is not null) 
            {
                foreach (Orden o in clienteActual.Ordenes) 
                {
                    ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                    item.SubItems.Add(o.FechaEntrada.ToString());
                    listOrdenes.Items.Add(item);
                }
            }
        }

        private void btnVerOrden_Click(object sender, EventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(listOrdenes.SelectedItems[0].Text);
                OrdenDesktop frmOrden = new OrdenDesktop(nroOrden, ApplicationForm.ModoForm.Modificacion, _context);
                frmOrden.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
