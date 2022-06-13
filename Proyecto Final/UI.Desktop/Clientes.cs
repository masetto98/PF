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
            
            List<String> columnas= new List<string>();
            foreach (ColumnHeader c in listClientes.Columns) 
            {
                columnas.Add(c.Text);
            }
            this.cmbBuscar.DataSource = columnas;
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
                    listClientes.Items.Add(item);
                }
            }
        }

        private void ListarPagos() 
        {
            listPagos.Items.Clear();
            if (listOrdenes.SelectedItems.Count > 0) 
            {
                int nroOrden = Int32.Parse(listOrdenes.SelectedItems[0].Text);
                Orden ordenActual = _ordenLogic.GetOne(nroOrden);
                if (ordenActual.Factura is not null && ordenActual.Factura.Pagos is not null && ordenActual.Factura.Pagos.Count > 0) 
                {
                    foreach (Pago p in ordenActual.Factura.Pagos) 
                    {
                        ListViewItem item = new ListViewItem(p.FechaPago.ToString());
                        item.SubItems.Add(p.Importe.ToString());
                        item.SubItems.Add(p.FormaPago.ToString());
                        listPagos.Items.Add(item);
                    }
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

        private void listClientes_DoubleClick(object sender, EventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0)
            {
                int idCliente = Int32.Parse(listClientes.SelectedItems[0].Text);
                ClienteDesktop frmCliente = new ClienteDesktop(idCliente, ApplicationForm.ModoForm.Consulta, _context);
                frmCliente.ShowDialog();
            }
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
                    double importe = CalcularImporte(o);
                    item.SubItems.Add(importe.ToString());
                    listOrdenes.Items.Add(item);
                }
            }
        }

        private double CalcularImporte(Orden ordenActual) 
        {
            double importe = 0;
            foreach (OrdenServicioTipoPrenda ostp in ordenActual.ItemsPedidos) 
            {
                Precio precio = ostp.ServicioTipoPrenda.HistoricoPrecios.FindLast(delegate (Precio p)
                {
                    return p.FechaDesde < ordenActual.FechaEntrada;
                });
                if (precio is not null)
                {
                    importe += precio.Valor;
                }
            }
            if (ordenActual.Descuento.StartsWith("%")) 
            {
                
                importe = importe * (1 - Double.Parse(ordenActual.Descuento.Remove(0, 1)) / 100.0);
            }
            if (!ordenActual.Descuento.StartsWith("%")) 
            {
                double resta = Double.Parse(ordenActual.Descuento);
                importe = importe - Double.Parse(ordenActual.Descuento);
            }
            return importe;
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

        private void btnPagos_Click(object sender, EventArgs e)
        {
            ListarPagos();
        }

        private void listClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0)
            {
                this.btnDetalles.Enabled = true;
            }
            else { this.btnDetalles.Enabled = false; }
        }

        private void listOrdenes_MouseClick(object sender, MouseEventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                this.btnVerOrden.Enabled = true;
            }
            else { this.btnVerOrden.Enabled = false; }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            listClientes.Items.Clear();
            List<Cliente> clientes = _clienteLogic.GetAll();
            if (this.cmbBuscar.SelectedItem.ToString() == "ID") 
            {
                foreach (Cliente c in clientes) 
                {
                    if (c.IdCliente.ToString()==this.txtBuscar.Text) 
                    {
                        ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                        item.SubItems.Add(c.Cuit);
                        item.SubItems.Add(c.Nombre);
                        item.SubItems.Add(c.Apellido);
                        item.SubItems.Add(c.RazonSocial);
                        listClientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscar.SelectedItem.ToString() == "Cuit")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.Cuit.ToLower().Contains( this.txtBuscar.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                        item.SubItems.Add(c.Cuit);
                        item.SubItems.Add(c.Nombre);
                        item.SubItems.Add(c.Apellido);
                        item.SubItems.Add(c.RazonSocial);
                        listClientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscar.SelectedItem.ToString() == "Nombre")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.Nombre.ToLower().Contains(this.txtBuscar.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                        item.SubItems.Add(c.Cuit);
                        item.SubItems.Add(c.Nombre);
                        item.SubItems.Add(c.Apellido);
                        item.SubItems.Add(c.RazonSocial);
                        listClientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscar.SelectedItem.ToString() == "Apellido")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.Apellido.ToLower().Contains(this.txtBuscar.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                        item.SubItems.Add(c.Cuit);
                        item.SubItems.Add(c.Nombre);
                        item.SubItems.Add(c.Apellido);
                        item.SubItems.Add(c.RazonSocial);
                        listClientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscar.SelectedItem.ToString() == "Razón Social")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.RazonSocial.ToLower().Contains(this.txtBuscar.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                        item.SubItems.Add(c.Cuit);
                        item.SubItems.Add(c.Nombre);
                        item.SubItems.Add(c.Apellido);
                        item.SubItems.Add(c.RazonSocial);
                        listClientes.Items.Add(item);
                    }
                }
            }
            if (this.txtBuscar.Text == "") { ListarClientes(); }
        }

    }
}
