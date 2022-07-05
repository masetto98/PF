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
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.IO;


namespace UI.Desktop
{
    public partial class frmMain : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly LavanderiaContext _context;
        private readonly ClienteLogic _clienteLogic;
        private readonly AtributosNegocioLogic _atributosNegocioLogic;
        private readonly ProveedorLogic _proveedorLogic;
        private readonly InsumoLogic _insumoLogic;
        private readonly InsumoProveedorLogic _insumoProveedorLogic;
        private readonly OrdenLogic _ordenLogic;
        private readonly OrdenServicioTipoPrendaLogic _ordenServicioTipoPrendaLogic;
        private readonly MaquinaOrdenServicioTipoPrendaLogic _maquinaOrdenServicioTipoPrendaLogic;
        private readonly MaquinaLogic _maquinaLogic;
        public AtributosNegocio NegocioActual;
        public List<OrdenServicioTipoPrenda> _trabajosPendientes;
        public List<MaquinaOrdenServicioTipoPrenda> _trabajosEnProceso;
        public List<ItemTrabajo> _listaEspera;
        public double _deudaCliente;

        public frmMain(LavanderiaContext context)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _context = context;
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            _atributosNegocioLogic = new AtributosNegocioLogic(new AtributosNegocioAdapter(context));
            _proveedorLogic = new ProveedorLogic(new ProveedorAdapter(context));
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            _insumoProveedorLogic = new InsumoProveedorLogic(new InsumoProveedorAdapter(context));
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _ordenServicioTipoPrendaLogic = new OrdenServicioTipoPrendaLogic(new OrdenServicioTipoPrendaAdapter(context));
            _maquinaOrdenServicioTipoPrendaLogic = new MaquinaOrdenServicioTipoPrendaLogic(new MaquinaOrdenServicioTipoPrendaAdapter(context));
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
            _listaEspera = new List<ItemTrabajo>();
            //NegocioActual = _atributosNegocioLogic.GetOne(1);
            RellenarComboBox(listClientes, cmbBuscarCliente);
            RellenarComboBox(listOrdenes, cmbBuscarOrden);
            RellenarComboBox(listInsumos, cmbInsumos);
            RellenarComboBox(listTrabajosPendientes, cmbTrabajosPendientes);
            CargarOrdenes();
            Planificar();
        }

        private void RellenarComboBox(ListView listActual, ComboBox cbActual) 
        {
            List<string> columnas = new List<string>();
            foreach (ColumnHeader c in listActual.Columns) 
            {
                columnas.Add(c.Text);
            }
            cbActual.DataSource = columnas;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmCliente.ShowDialog();

        }

        private void mnuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mnuPrincipal.SelectedIndex)
            {
                case 0:
                    CargarOrdenes();
                    break;
                case 1:
                    ListarClientes();
                    break;
                case 2:
                    tabControlInventario_SelectedIndexChanged(sender, e);
                    break;
                case 3:
                    ListarOrdenesTrabajosPendientes();
                    break;

            }
        }

        private void tabControlInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlInventario.SelectedIndex)
            {
                case 0:
                    ListarStock();
                    break;
                case 1:
                    ListarIngresos();
                    break;
                case 2:
                    //ListarInsumos();
                    break;
                case 3:
                    
                    break;

            }
        }


        #region ------- CLIENTES -------

        private void ListarClientes()
        {
            List<Cliente> clientes = _clienteLogic.GetAll();
            listClientes.Items.Clear();
            foreach (Cliente c in clientes)
            {
                ListViewItem item = new ListViewItem(c.IdCliente.ToString());
                item.SubItems.Add(c.Cuit);
                item.SubItems.Add(c.Nombre);
                item.SubItems.Add(c.Apellido);
                item.SubItems.Add(c.RazonSocial);
                listClientes.Items.Add(item);
                CargarOrdenes();

            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmCliente.ShowDialog();
            ListarClientes();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listClientes.SelectedItems[0].Text);
                ClienteDesktop formCliente = new ClienteDesktop(ID, ApplicationForm.ModoForm.Modificacion, _context);
                formCliente.ShowDialog();
                ListarClientes();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder editar","Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listClientes.SelectedItems[0].Text);
                ClienteDesktop formCliente = new ClienteDesktop(ID, ApplicationForm.ModoForm.Baja, _context);
                formCliente.ShowDialog();
                //listClientes.Items.Remove(listClientes.SelectedItems[0]); Otra forma de borrar de la lista
                ListarClientes();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder eliminar", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            listClientes.Items.Clear();
            List<Cliente> clientes = _clienteLogic.GetAll();
            if (this.cmbBuscarCliente.SelectedItem.ToString() == "ID")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.IdCliente.ToString() == this.txtBuscarCliente.Text)
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
            if (this.cmbBuscarCliente.SelectedItem.ToString() == "Cuit")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.Cuit.ToLower().Contains(this.txtBuscarCliente.Text.ToLower()))
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
            if (this.cmbBuscarCliente.SelectedItem.ToString() == "Nombre")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.Nombre.ToLower().Contains(this.txtBuscarCliente.Text.ToLower()))
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
            if (this.cmbBuscarCliente.SelectedItem.ToString() == "Apellido")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.Apellido.ToLower().Contains(this.txtBuscarCliente.Text.ToLower()))
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
            if (this.cmbBuscarCliente.SelectedItem.ToString() == "Razón Social")
            {
                foreach (Cliente c in clientes)
                {
                    if (c.RazonSocial.ToLower().Contains(this.txtBuscarCliente.Text.ToLower()))
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
            if (this.txtBuscarCliente.Text == "") { ListarClientes(); }
        }

        //evento para fixear columnas del listview
        private void listClientes_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listClientes.Columns[e.ColumnIndex].Width;
        }
        private void listOrdenesCliente_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {


            e.Cancel = true;
            e.NewWidth = listOrdenesCliente.Columns[e.ColumnIndex].Width;
        }
        private void listPagosOrden_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listPagosOrden.Columns[e.ColumnIndex].Width;
        }
        private void btnOrdenesCliente_Click(object sender, EventArgs e)
        {
            ListarOrdenesCliente();
            CalcularCuentaCorrienteCliente();
        }

        private void ListarOrdenesCliente() 
        {
            listOrdenesCliente.Items.Clear();
            if (listClientes.SelectedItems.Count > 0)
            {
                Cliente clienteActual = _clienteLogic.GetOne(Int32.Parse(listClientes.SelectedItems[0].Text));
                if (clienteActual.Ordenes is not null)
                {
                    foreach (Orden o in clienteActual.Ordenes)
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        double importe = CalcularImporteOrden(o);
                        item.SubItems.Add(importe.ToString());
                        double pagos = CalcularPagosOrden(o);
                        double deudas = importe - pagos;
                        item.SubItems.Add(deudas.ToString());
                        listOrdenesCliente.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder observar los detalles", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private double CalcularImporteOrden(Orden ordenActual)
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
            if(ordenActual.Descuento != null)
            {
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
            else
            {
                return importe;
            }
        }

        private double CalcularPagosOrden(Orden ordenActual) 
        {
            double pagos = 0;
            if (ordenActual.Factura is not null && ordenActual.Factura.Pagos is not null)
            {
                foreach (Pago p in ordenActual.Factura.Pagos)
                {
                    pagos += p.Importe;
                }
            }
            return pagos;
        }

        private void ListarPagosOrden() 
        {
            listPagosOrden.Items.Clear();
            if (listOrdenesCliente.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(listOrdenesCliente.SelectedItems[0].Text);
                Orden ordenActual = _ordenLogic.GetOne(nroOrden);
                if (ordenActual.Factura is not null && ordenActual.Factura.Pagos is not null && ordenActual.Factura.Pagos.Count > 0)
                {
                    foreach (Pago p in ordenActual.Factura.Pagos)
                    {
                        ListViewItem item = new ListViewItem(p.FechaPago.ToString());
                        item.SubItems.Add(p.Importe.ToString());
                        item.SubItems.Add(p.FormaPago.ToString());
                        listPagosOrden.Items.Add(item);
                    }
                }
                else { MessageBox.Show("La orden no contiene ningún pago","Pago",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista de \"Ordenes del cliente\" para poder ver los pagos", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            ListarPagosOrden();
        }

        private void CalcularCuentaCorrienteCliente() 
        {
            _deudaCliente = 0;
            if (listClientes.SelectedItems.Count > 0) 
            {
                Cliente clienteActual = _clienteLogic.GetOne(Int32.Parse(listClientes.SelectedItems[0].Text));
                if (clienteActual is not null) 
                {
                    if (clienteActual.Ordenes is not null) 
                    {
                        foreach (Orden o in clienteActual.Ordenes) 
                        {
                            double importe = CalcularImporteOrden(o);
                            double pagos = CalcularPagosOrden(o);
                            _deudaCliente += (importe - pagos);
                        }
                    }
                }
                this.lblCuentaCorriente.Text = _deudaCliente.ToString();
            }
            
        }

        private void listClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listClientes.SelectedItems[0].Text);
                ClienteDesktop formCliente = new ClienteDesktop(ID, ApplicationForm.ModoForm.Consulta, _context);
                formCliente.ShowDialog();
            }

        }
        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (listOrdenesCliente.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listOrdenesCliente.SelectedItems[0].Text);
                Orden OrdenActual = _ordenLogic.GetOne(ID);
                if (OrdenActual.Factura.Pagos.Count > 0)
                {
                    PagoDesktop frmPago = new PagoDesktop(OrdenActual, ApplicationForm.ModoForm.Modificacion, _context);
                    frmPago.ShowDialog();
                }
                else
                {
                    PagoDesktop frmPago = new PagoDesktop(OrdenActual, ApplicationForm.ModoForm.Alta, _context);
                    frmPago.ShowDialog();
                }
                ListarOrdenesCliente();
                CalcularCuentaCorrienteCliente();
                ListarPagosOrden();
            }
            
            else
            {
                MessageBox.Show("Debe seleccionar una orden de la lista \"Ordenes del cliente\" para poder agregar pagos","Pago",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
                
        }

        #endregion

        #region ------- INVENTARIO -------
        private void ListarIngresos()
        {
            listIngresos.Items.Clear();
            List<InsumoProveedor> ingresos = _insumoProveedorLogic.GetAll();
            foreach(InsumoProveedor ig in ingresos)
            {
                ListViewItem item = new ListViewItem(ig.IdProveedor.ToString());
                item.SubItems.Add(ig.Proveedor.RazonSocial);
                item.SubItems.Add(ig.IdInsumo.ToString());
                item.SubItems.Add(ig.Insumo.Descripcion);
                item.SubItems.Add(ig.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                item.SubItems.Add(ig.Cantidad.ToString());
                listIngresos.Items.Add(item);
            }
        }
        #region ------- Stock -------

        private void ListarStock()
        {
            listInsumos.Items.Clear();
            List<Insumo> insumos = _insumoLogic.GetAll();
            if (insumos.Count > 0)
            {
                foreach (Insumo i in insumos)
                {
                    ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                    item.SubItems.Add(i.Descripcion);
                    item.SubItems.Add(i.Stock.ToString());
                    item.SubItems.Add(i.UnidadMedida.ToString());
                    listInsumos.Items.Add(item);
                }
            }
        }
        private void listInsumos_ColumnWidthChanging_1(object sender, ColumnWidthChangingEventArgs e)
        {

            e.Cancel = true;
            e.NewWidth = listInsumos.Columns[e.ColumnIndex].Width;

        }
        private void listIngresosInsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {


            e.Cancel = true;
            e.NewWidth = listIngresosInsumos.Columns[e.ColumnIndex].Width;


        }
        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            InsumoDesktop frmInsumo = new InsumoDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmInsumo.ShowDialog();
            ListarStock();
        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listInsumos.SelectedItems[0].Text);
                InsumoDesktop formInsumo = new InsumoDesktop(ID, ApplicationForm.ModoForm.Modificacion, _context);
                formInsumo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder editar","Insumo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            ListarStock();
        }

        private void btnEliminarInsumo_Click(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listInsumos.SelectedItems[0].Text);
                InsumoDesktop formInsumo = new InsumoDesktop(ID, ApplicationForm.ModoForm.Baja, _context);
                formInsumo.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder eliminar", "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarStock();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            ListarIngresosInsumo();
        }

        private void ListarIngresosInsumo()
        {
            listIngresosInsumos.Items.Clear();
            if (listInsumos.SelectedItems.Count > 0)
            {
                Insumo insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
                if (insumoActual is not null && insumoActual.InsumosProveedores.Count > 0)
                {
                    foreach (InsumoProveedor ip in insumoActual.InsumosProveedores)
                    {
                        ListViewItem item = new ListViewItem(ip.Proveedor.RazonSocial);
                        item.SubItems.Add(ip.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                        item.SubItems.Add(ip.Cantidad.ToString());
                        item.SubItems.Add(ip.Insumo.UnidadMedida.ToString());
                        listIngresosInsumos.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder observar los detalles", "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIngresoInsumo_Click(object sender, EventArgs e)
        {
            InsumoProveedorDesktop frmInsumoProveedor = new InsumoProveedorDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmInsumoProveedor.ShowDialog();
            //ListarIngresos();

        }

        private void btnEditarIngresoInsumo_Click(object sender, EventArgs e)
        {
            if (listIngresosInsumos.SelectedItems.Count > 0)
            {
                InsumoProveedor ipActual = _insumoProveedorLogic.GetAll().Find(delegate (InsumoProveedor ip)
                {
                    return ip.Proveedor.RazonSocial == listIngresosInsumos.SelectedItems[0].Text &&
                           ip.IdInsumo == Int32.Parse(listInsumos.SelectedItems[0].Text) &&
                           ip.FechaIngreso == DateTime.Parse(listIngresosInsumos.SelectedItems[0].SubItems[1].Text);
                });
                if (ipActual is not null)
                {
                    InsumoProveedorDesktop frmInsumoProveedor = new InsumoProveedorDesktop(ipActual.IdProveedor, ipActual.IdInsumo, ipActual.FechaIngreso, ApplicationForm.ModoForm.Modificacion, _context);
                    frmInsumoProveedor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccionar una fila en la lista para poder editar","Ingreso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                //ListarIngresos();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista de \"Movimientos del insumo\" para editar un ingreso", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminarIngresoInsumo_Click(object sender, EventArgs e)
        {
            if (listIngresosInsumos.SelectedItems.Count > 0)
            {
                InsumoProveedor ipActual = _insumoProveedorLogic.GetAll().Find(delegate (InsumoProveedor ip)
                {
                    return ip.Proveedor.RazonSocial == listIngresosInsumos.SelectedItems[0].Text &&
                           ip.IdInsumo == Int32.Parse(listInsumos.SelectedItems[0].Text) &&
                           ip.FechaIngreso == DateTime.Parse(listIngresosInsumos.SelectedItems[0].SubItems[1].Text);
                });
                if (ipActual is not null)
                {
                    InsumoProveedorDesktop frmInsumoProveedor = new InsumoProveedorDesktop(ipActual.IdProveedor, ipActual.IdInsumo, ipActual.FechaIngreso, ApplicationForm.ModoForm.Baja, _context);
                    frmInsumoProveedor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccionar una fila en la lista para poder editar");
                }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista de \"Movimientos del insumo\" para eliminar un ingreso", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ListarIngresos();
        }

        private void dtpFiltrarFechaIngreso_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaFiltro = dtpFiltrarFechaIngreso.Value;
            List<InsumoProveedor> insumosproveedores = _insumoProveedorLogic.GetAll();
            List<InsumoProveedor> ipFecha = insumosproveedores.FindAll(
                delegate(InsumoProveedor ip) {
                    return ip.FechaIngreso.Date >= fechaFiltro.Date;
                }
                );
            listIngresos.Items.Clear();
            foreach (InsumoProveedor ip in ipFecha)
            {

                ListViewItem item = new ListViewItem(ip.IdProveedor.ToString());
                item.SubItems.Add(ip.Proveedor.RazonSocial);
                item.SubItems.Add(ip.IdInsumo.ToString());
                item.SubItems.Add(ip.Insumo.Descripcion);
                item.SubItems.Add(ip.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                item.SubItems.Add(ip.Cantidad.ToString());
                listIngresos.Items.Add(item);
            }
        }
        private void dtpFiltroFechaIngreso_CloseUp(object sender, EventArgs e)
        {

            listIngresosInsumos.Items.Clear();
            if (listInsumos.SelectedItems.Count > 0)
            {
                Insumo insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
                List<InsumoProveedor> ip = insumoActual.InsumosProveedores;
                List<InsumoProveedor> ipFiltro = ip.FindAll(
                    delegate (InsumoProveedor ip)
                    {
                        return ip.FechaIngreso.Date == dtpFiltroFechaIngreso.Value.Date;
                    });
                if (insumoActual is not null && ipFiltro.Count > 0)
                {
                    foreach (InsumoProveedor insP in ipFiltro)
                    {
                        ListViewItem item = new ListViewItem(insP.Proveedor.RazonSocial);
                        item.SubItems.Add(insP.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                        item.SubItems.Add(insP.Cantidad.ToString());
                        item.SubItems.Add(insP.Insumo.UnidadMedida.ToString());
                        listIngresosInsumos.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder observar los detalles", "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*
            DateTime fechaFiltro = dtpFiltroFechaIngreso.Value;
            List<InsumoProveedor> insumosproveedores = _insumoProveedorLogic.GetAll();
            List<InsumoProveedor> ipFecha = insumosproveedores.FindAll(ip => ip.FechaIngreso.ToString("yyyy/MM/dd") == fechaFiltro.ToString("yyyy/MM/dd"));
            listIngresosInsumos.Items.Clear();
            foreach (InsumoProveedor ip in ipFecha)
            {
                ListViewItem item = new ListViewItem(ip.Proveedor.RazonSocial);
                item.SubItems.Add(ip.FechaIngreso.ToString());
                item.SubItems.Add(ip.Cantidad.ToString());
                listIngresosInsumos.Items.Add(item);
            }
            */
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ListarIngresosInsumo();
        }

        #endregion




        private void listProveedores_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {/*
            e.Cancel = true;
            e.NewWidth = listProveedores.Columns[e.ColumnIndex].Width;*/
        }



        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            InsumoProveedorDesktop frmInsumoProveedor = new InsumoProveedorDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmInsumoProveedor.ShowDialog();
            ListarIngresos();
        }

        private void btnEditarIngreso_Click(object sender, EventArgs e)
        {
            if (listIngresos.SelectedItems.Count > 0)
            {

                int IDProv = Int32.Parse(this.listIngresos.SelectedItems[0].Text);
                int IDIns = Int32.Parse(this.listIngresos.SelectedItems[0].SubItems[2].Text);
                DateTime fechaIngreso = DateTime.Parse(this.listIngresos.SelectedItems[0].SubItems[4].Text);
                InsumoProveedorDesktop formInsumoProveedor = new InsumoProveedorDesktop(IDProv, IDIns, fechaIngreso, ApplicationForm.ModoForm.Modificacion, _context);
                formInsumoProveedor.ShowDialog();
                //ListarIngresos();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder editar","Ingreso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (listIngresos.SelectedItems.Count > 0)
            {
                int IDProv = Int32.Parse(this.listIngresos.SelectedItems[0].Text);
                int IDIns = Int32.Parse(this.listIngresos.SelectedItems[0].SubItems[2].Text);
                DateTime fechaIngreso = DateTime.Parse(this.listIngresos.SelectedItems[0].SubItems[4].Text);
                InsumoProveedorDesktop formInsumoProveedor = new InsumoProveedorDesktop(IDProv, IDIns, fechaIngreso, ApplicationForm.ModoForm.Baja, _context);
                formInsumoProveedor.ShowDialog();
                //listClientes.Items.Remove(listClientes.SelectedItems[0]); Otra forma de borrar de la lista
                //ListarIngresos();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder eliminar", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /*
        private void dtpFiltrarFechaIngreso_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaFiltro = dtpFiltrarFechaIngreso.Value;
            List<InsumoProveedor> insumosproveedores = _insumoProveedorLogic.GetAll();
            List<InsumoProveedor> ipFecha = insumosproveedores.FindAll(ip => ip.FechaIngreso.ToString("yyyy/MM/dd") == fechaFiltro.ToString("yyyy/MM/dd"));
            listIngresos.Items.Clear();
            foreach (InsumoProveedor ip in ipFecha)
            {
                ListViewItem item = new ListViewItem(ip.Proveedor.IdProveedor.ToString());
                item.SubItems.Add(ip.Proveedor.RazonSocial);
                item.SubItems.Add(ip.Insumo.IdInsumo.ToString());
                item.SubItems.Add(ip.Insumo.Descripcion);
                item.SubItems.Add(ip.FechaIngreso.ToString());
                item.SubItems.Add(ip.Cantidad.ToString());
                listIngresos.Items.Add(item);
            }

        }*/

        private void txtBuscarInsumos_TextChanged(object sender, EventArgs e)
        {
            listInsumos.Items.Clear();
            List<Insumo> insumos = _insumoLogic.GetAll();
            if (this.cmbInsumos.SelectedItem.ToString() == "ID")
            {
                foreach (Insumo i in insumos)
                {
                    if (i.IdInsumo.ToString().ToLower().Contains(this.txtBuscarInsumos.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                        item.SubItems.Add(i.Descripcion);
                        item.SubItems.Add(i.Stock.ToString());
                        item.SubItems.Add(i.UnidadMedida.ToString());
                        listInsumos.Items.Add(item);
                    }
                }
                
            }
            if (this.cmbInsumos.SelectedItem.ToString() == "Descripción")
            {
                foreach (Insumo i in insumos)
                {
                    if (i.Descripcion.ToLower().Contains(this.txtBuscarInsumos.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                        item.SubItems.Add(i.Descripcion);
                        item.SubItems.Add(i.Stock.ToString());
                        item.SubItems.Add(i.UnidadMedida.ToString());
                        listInsumos.Items.Add(item);
                    }
                }

            }
            if (this.cmbInsumos.SelectedItem.ToString() == "Stock")
            {
                foreach (Insumo i in insumos)
                {
                    if (i.Stock.ToString().ToLower().Contains(this.txtBuscarInsumos.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                        item.SubItems.Add(i.Descripcion);
                        item.SubItems.Add(i.Stock.ToString());
                        item.SubItems.Add(i.UnidadMedida.ToString());
                        listInsumos.Items.Add(item);
                    }
                }

            }
            if (this.cmbInsumos.SelectedItem.ToString() == "Unidad")
            {
                foreach (Insumo i in insumos)
                {
                    if (i.UnidadMedida.ToString().ToLower().Contains(this.txtBuscarInsumos.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                        item.SubItems.Add(i.Descripcion);
                        item.SubItems.Add(i.Stock.ToString());
                        item.SubItems.Add(i.UnidadMedida.ToString());
                        listInsumos.Items.Add(item);
                    }
                }

            }
            if (this.txtBuscarInsumos.Text == "") { ListarStock();}
        }

        private void listIngresos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listIngresos.Columns[e.ColumnIndex].Width;
        }

        private void listInsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {/*
            e.Cancel = true;
            e.NewWidth = listInsumos1.Columns[e.ColumnIndex].Width;*/
        }
        private void btnActualizarIngresos_Click(object sender, EventArgs e)
        {
            //ListarIngresos();
        }
        #endregion

        #region ------- ORDENES -------
        private void CargarOrdenes()
        {
            List<Orden> ordenes = _ordenLogic.GetAll();
            ordenes.Sort((x, y) => y.NroOrden.CompareTo(x.NroOrden));
            listOrdenes.Items.Clear();
            foreach (Orden o in ordenes)
            {
                ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                item.SubItems.Add(o.Prioridad.ToString());
                item.SubItems.Add(o.FechaEntrada.ToString());
                if (o.FechaSalida == DateTime.MinValue)
                {
                    item.SubItems.Add("No Retirado");
                }
                else { item.SubItems.Add(o.FechaSalida.ToString()); }
                item.SubItems.Add(o.Estado.ToString());
                listOrdenes.Items.Add(item);
            }
        }
        #region --- Buscar orden ---
        private void txtBuscarOrdenes_TextChanged(object sender, EventArgs e)
        {
            listOrdenes.Items.Clear();
            List<Orden> ordenes = _ordenLogic.GetAll();
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "N° Orden")
            {
                foreach (Orden o in ordenes)
                {
                    if (o.NroOrden.ToString() == this.txtBuscarOrdenes.Text)
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Cliente(Nombre y Apellido/Razón Social)")
            {
                foreach (Orden o in ordenes)
                {
                    if (o.Cliente.Nombre.ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()) || o.Cliente.Apellido.ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()) || o.Cliente.RazonSocial.ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Prioridad")
            {
                foreach (Orden o in ordenes)
                {
                    if (o.Prioridad.ToString().ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Fecha Ingreso")
            {
                foreach (Orden o in ordenes)
                {
                    if (o.FechaEntrada.ToString().ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Fecha Salida")
            {
                foreach (Orden o in ordenes)
                {
                    if (o.FechaSalida.ToString().ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Estado")
            {
                foreach (Orden o in ordenes)
                {
                    if (o.Estado.ToString().ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.txtBuscarOrdenes.Text == "") { CargarOrdenes(); }

        }
        #endregion

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            OrdenDesktop frmOrden = new OrdenDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmOrden.ShowDialog();
            CargarOrdenes();
            Planificar();
        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(this.listOrdenes.SelectedItems[0].Text);
                OrdenDesktop frmOrden = new OrdenDesktop(nroOrden, ApplicationForm.ModoForm.Baja, _context);
                frmOrden.ShowDialog();
                CargarOrdenes();
                Planificar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar una Orden", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEditarOrden_Click(object sender, EventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(this.listOrdenes.SelectedItems[0].Text);
                OrdenDesktop frmOrden = new OrdenDesktop(nroOrden, ApplicationForm.ModoForm.Modificacion, _context);
                frmOrden.ShowDialog();
                CargarOrdenes();
                Planificar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar una Orden", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool VerificarEstadoItems(Orden ordenActual)
        {
            List<OrdenServicioTipoPrenda> itemsOrden = ordenActual.ItemsPedidos;
            bool ok = true;
            foreach (OrdenServicioTipoPrenda item in itemsOrden)
            {
                if (item.Estado != OrdenServicioTipoPrenda.Estados.Finalizado)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
        private void btnRetirarOrden_Click(object sender, EventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(this.listOrdenes.SelectedItems[0].Text);
                Orden ordenActual = _ordenLogic.GetOne(nroOrden);
                if (!VerificarEstadoItems(ordenActual))
                {
                    MessageBox.Show("¡Atención! No todos los items de la Orden se encuentran finalizados. Por favor, finalice todos los items necesarios para proceder con el retiro.", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RetirarOrdenDesktop frmRetirarOrden = new RetirarOrdenDesktop(nroOrden, ApplicationForm.ModoForm.Modificacion, _context);
                    frmRetirarOrden.ShowDialog();
                    CargarOrdenes();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder retirar la Orden","Orden",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(this.listOrdenes.SelectedItems[0].Text);
                OrdenDesktop frmOrden = new OrdenDesktop(nroOrden, ApplicationForm.ModoForm.Consulta, _context);
                frmOrden.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder observar los detalles", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listOrdenes_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listOrdenes.Columns[e.ColumnIndex].Width;
        }

        private void listOrdenes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(this.listOrdenes.SelectedItems[0].Text);
                OrdenDesktop frmOrden = new OrdenDesktop(nroOrden, ApplicationForm.ModoForm.Consulta, _context);
                frmOrden.ShowDialog();
            }
        }

        #endregion

        #region ------- LOGIN -------
        private void frmMain_Shown(object sender, EventArgs e)
        { 
            
            this.mnuPrincipal.Visible = false;

            this.epUser.Visible = false;
            frmLogin appLogin = new frmLogin(_context);
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }

            this.mnuPrincipal.Visible = true;
            this.epUser.Visible = true;
            this.epUser.Title = $"{Singleton.getInstance().UserLogged.NombreUsuario}";
            ConfiguracionAdministrador();
            

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.frmMain_Shown(sender, e);
            this.epUser.Collapse = true;
        }

        private void epUser_Leave(object sender, EventArgs e)
        {
            this.epUser.Collapse = true;
        }
        #endregion

        #region ------- PLANIFICACION -------

        public void Planificar()
        {
            _trabajosPendientes = _ordenServicioTipoPrendaLogic.GetItemsPendientes();
            _listaEspera.Clear();
            CargarListaEspera();
            ListarEstadoMaquinas();
            ListarTrabajosEnProceso();
        }
        private void listEstadoMaquinas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listEstadoMaquinas.Columns[e.ColumnIndex].Width;
        }

        private void listTrabajosPendientes_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listTrabajosPendientes.Columns[e.ColumnIndex].Width;
        }

        private void listMaquinasItem_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listMaquinasItem.Columns[e.ColumnIndex].Width;
        }
        #region ------- TRABAJOS PENDIENTES -------

        private void CargarListaEspera()
        {

            foreach (OrdenServicioTipoPrenda item in _trabajosPendientes)
            {
                ItemTrabajo trabajo = new ItemTrabajo();
                trabajo.Trabajo = item;
                TimeSpan tiempoTranscurrido = DateTime.Today - item.Orden.FechaEntrada;
                TimeSpan tiempoRestante = TimeSpan.Parse(item.ServicioTipoPrenda.TiempoDemoraMax) - tiempoTranscurrido - item.ServicioTipoPrenda.TiempoRequerido;
                trabajo.TiempoRestante = tiempoRestante;
                _listaEspera.Add(trabajo);

            }
            List<ItemTrabajo> orderList = _listaEspera.OrderByDescending(i => i.Trabajo.Prioridad).ThenBy(i => i.Trabajo.Estado).ThenBy(i => i.TiempoRestante).ToList();
            _listaEspera.Clear();
            _listaEspera = orderList;
        }
        public void ListarOrdenesTrabajosPendientes()
        {
            listTrabajosPendientes.Items.Clear();
            foreach (ItemTrabajo i in _listaEspera)
            {
                ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                item.SubItems.Add(i.Trabajo.Estado.ToString());
                item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                if (i.TiempoRestante.ToString().Contains("-"))
                {
                    item.SubItems.Add("-" + i.TiempoRestante.ToString(@"d\d\:h\h\:m\m\:s\s"));
                }
                else
                {
                    item.SubItems.Add(i.TiempoRestante.ToString(@"d\d\:h\h\:m\m\:s\s"));
                }
                
                listTrabajosPendientes.Items.Add(item);
            }
            ColorCeldaListView();
        }

        private void ColorCeldaListView()
        {
           
            for (int i = 0; i <= listTrabajosPendientes.Items.Count - 1; i++)
            {
                if (listTrabajosPendientes.Items[i].SubItems[4].Text == OrdenServicioTipoPrenda.Estados.Iniciado.ToString())
                {
                    listTrabajosPendientes.Items[i].UseItemStyleForSubItems = false;
                    listTrabajosPendientes.Items[i].SubItems[4].ForeColor = System.Drawing.Color.Green;
                }
                else { listTrabajosPendientes.Items[i].BackColor = Color.White; }
            }
        }

        private void ListarEstadoMaquinas()
        {
            List<Maquina> maquinas = _maquinaLogic.GetAll();
            listEstadoMaquinas.Items.Clear();
            foreach (Maquina m in maquinas)
            {
                List<MaquinaOrdenServicioTipoPrenda> ordenesAtendidas = m.itemsAtendidos;
                if (m.itemsAtendidos is null) { ordenesAtendidas = new List<MaquinaOrdenServicioTipoPrenda>(); }
                MaquinaOrdenServicioTipoPrenda? itemEnAtencion = ordenesAtendidas.Find(delegate (MaquinaOrdenServicioTipoPrenda item)
                {
                    return item.TiempoFinServicio == DateTime.MinValue;
                });
                if (itemEnAtencion is null)
                {
                    ListViewItem estadoMaquina = new ListViewItem(m.Descripcion);
                    estadoMaquina.SubItems.Add("Disponible");
                    listEstadoMaquinas.Items.Add(estadoMaquina);

                }
                else
                {
                    ListViewItem estadoMaquina = new ListViewItem(m.Descripcion);
                    estadoMaquina.SubItems.Add("En servicio");
                    listEstadoMaquinas.Items.Add(estadoMaquina);
                }
            }
            listMaquinasItem.Sort();
        }

        private void btnMostrarServicios_Click(object sender, EventArgs e)
        {
            List<MaquinaOrdenServicioTipoPrenda> maquinasItem = new List<MaquinaOrdenServicioTipoPrenda>();
            if (listTrabajosPendientes.SelectedItems.Count > 0)
            {
                maquinasItem = _maquinaOrdenServicioTipoPrendaLogic.GetAll().FindAll(delegate (MaquinaOrdenServicioTipoPrenda item)
                {
                    return item.NroOrden == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].Text) &&
                           item.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[1].Text &&
                           item.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[2].Text &&
                           item.OrdenItem == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].SubItems[3].Text);
                });
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajo en la lista para poder observar los detalles", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (maquinasItem is not null)
            {
                listMaquinasItem.Items.Clear();
                foreach (MaquinaOrdenServicioTipoPrenda mi in maquinasItem)
                {
                    ListViewItem mir = new ListViewItem(mi.Maquina.Descripcion);
                    mir.SubItems.Add(mi.TiempoInicioServicio.ToString());
                    if (mi.TiempoFinServicio == DateTime.MinValue)
                    {
                        mir.SubItems.Add("");
                    }
                    else { mir.SubItems.Add(mi.TiempoFinServicio.ToString()); }
                    listMaquinasItem.Items.Add(mir);
                }
            }

        }

        private void btnIniciarServicio_Click(object sender, EventArgs e)
        {
            if (listTrabajosPendientes.SelectedItems.Count > 0)
            {
                OrdenServicioTipoPrenda t = _trabajosPendientes.Find(delegate (OrdenServicioTipoPrenda item)
                {
                    return item.NroOrden == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].Text) &&
                           item.ServicioTipoPrenda.Servicio.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[1].Text &&
                           item.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[2].Text &&
                           item.OrdenItem == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].SubItems[3].Text);
                });
                MaquinaOrdenServicioTipoPrendaDesktop frmTrabajos = new MaquinaOrdenServicioTipoPrendaDesktop(t.NroOrden, t.IdServicio, t.IdTipoPrenda, t.OrdenItem, ApplicationForm.ModoForm.Alta, _context);
                frmTrabajos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajo en la lista para poder iniciarlo", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Planificar();
            ListarOrdenesTrabajosPendientes();
            ListarTrabajosEnProceso();
            ListarEstadoMaquinas();
        }

        private void btnFinalizarTrabajo_Click_1(object sender, EventArgs e)
        {
            if (listTrabajosPendientes.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea finalizar este trabajo?", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OrdenServicioTipoPrenda t = _trabajosPendientes.Find(delegate (OrdenServicioTipoPrenda item)
                    {
                        return item.NroOrden == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].Text) &&
                               item.ServicioTipoPrenda.Servicio.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[1].Text &&
                               item.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[2].Text &&
                               item.OrdenItem == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].SubItems[3].Text);
                    });
                    t.Estado = OrdenServicioTipoPrenda.Estados.Finalizado;
                    if (ValidarFinalizacionOrden(t.NroOrden)) 
                    {
                        t.Orden.Estado = Orden.Estados.Finalizado;
                    }
                    t.State = BusinessEntity.States.Modified;
                    _ordenServicioTipoPrendaLogic.Save(t);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajo en la lista para poder finalizarlo", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Planificar();
            ListarOrdenesTrabajosPendientes();

        }
        /*
        private void ValidarTerminacionOrden(int nroOrden)
        {
            Orden ordenActual = _ordenLogic.GetOne(nroOrden);
            List<OrdenServicioTipoPrenda> ordenesPendientes = ordenActual.ItemsPedidos.FindAll(delegate (OrdenServicioTipoPrenda ostp)
            { return ostp.Estado != OrdenServicioTipoPrenda.Estados.Finalizado; });
            if (ordenesPendientes.Count == 0)
            {
                ordenActual.Estado = Orden.Estados.Finalizado;
                ordenActual.State = BusinessEntity.States.Modified;
                _ordenLogic.Save(ordenActual);
            }
        }*/

        private bool ValidarFinalizacionOrden(int nroOrden)
        {
            Orden ordenActual = _ordenLogic.GetOne(nroOrden);
            if (ordenActual is not null)
            {
                if (ordenActual.ItemsPedidos is not null)
                {
                    OrdenServicioTipoPrenda ostp = ordenActual.ItemsPedidos.Find(delegate (OrdenServicioTipoPrenda o)
                    {
                        return o.Estado != OrdenServicioTipoPrenda.Estados.Finalizado;
                    });
                    if (ostp is null)
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            else { return false; }
        }

        private void txtBuscarTrabajosPendientes_TextChanged(object sender, EventArgs e)
        {
            listTrabajosPendientes.Items.Clear();
            if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Orden")
            {
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.Orden.NroOrden.ToString().Contains(this.txtBuscarTrabajosPendientes.Text))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        item.SubItems.Add(i.TiempoRestante.ToString());
                        listTrabajosPendientes.Items.Add(item);
                    }
                }

            }
            if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Servicio")
            {
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion.Contains(this.txtBuscarTrabajosPendientes.Text))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        item.SubItems.Add(i.TiempoRestante.ToString());
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Tipo de Prenda")
            {
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion.Contains(this.txtBuscarTrabajosPendientes.Text))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        item.SubItems.Add(i.TiempoRestante.ToString());
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Item")
            {
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.OrdenItem.ToString().Contains(this.txtBuscarTrabajosPendientes.Text))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        item.SubItems.Add(i.TiempoRestante.ToString());
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Estado")
            {
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.Estado.ToString().Contains(this.txtBuscarTrabajosPendientes.Text))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        item.SubItems.Add(i.TiempoRestante.ToString());
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Prioridad")
            {
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.Prioridad.ToString().Contains(this.txtBuscarTrabajosPendientes.Text))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        item.SubItems.Add(i.TiempoRestante.ToString());
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.txtBuscarTrabajosPendientes.Text == "") { ListarOrdenesTrabajosPendientes(); }
        }

        #endregion

        #region ------- TRABAJOS EN PROCESO -------
        private void ListarTrabajosEnProceso()
        {
            _trabajosEnProceso = _maquinaOrdenServicioTipoPrendaLogic.GetAll().FindAll(delegate (MaquinaOrdenServicioTipoPrenda m) { return m.TiempoFinServicio == DateTime.MinValue; });
            listTrabajosEnProceso.Items.Clear();
            foreach (MaquinaOrdenServicioTipoPrenda i in _trabajosEnProceso)
            {
                ListViewItem item = new ListViewItem(i.Maquina.Descripcion);
                item.SubItems.Add(i.NroOrden.ToString());
                item.SubItems.Add(i.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion);
                item.SubItems.Add(i.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                item.SubItems.Add(i.OrdenServicioTipoPrenda.OrdenItem.ToString());
                item.SubItems.Add(i.TiempoInicioServicio.ToString("O"));
                item.SubItems.Add(i.OrdenServicioTipoPrenda.Estado.ToString());
                listTrabajosEnProceso.Items.Add(item);
            }

        }

        private void btnTerminarServicio_Click(object sender, EventArgs e)
        {
            if (listTrabajosEnProceso.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea detener el servicio a este trabajo?", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MaquinaOrdenServicioTipoPrenda mostpActual = _trabajosEnProceso.Find(delegate (MaquinaOrdenServicioTipoPrenda mostp)
                    {
                        return mostp.Maquina.Descripcion == this.listTrabajosEnProceso.SelectedItems[0].Text &&
                        mostp.TiempoInicioServicio == DateTime.Parse(this.listTrabajosEnProceso.SelectedItems[0].SubItems[5].Text);
                    });
                    mostpActual.TiempoFinServicio = DateTime.Now;
                    mostpActual.OrdenServicioTipoPrenda.Estado = OrdenServicioTipoPrenda.Estados.Iniciado;
                    mostpActual.State = BusinessEntity.States.Modified;
                    _maquinaOrdenServicioTipoPrendaLogic.Save(mostpActual);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder detener un trabajo", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarOrdenesTrabajosPendientes();
            ListarTrabajosEnProceso();
            ListarEstadoMaquinas();
        }

        private void listTrabajosEnProceso_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listTrabajosEnProceso.Columns[e.ColumnIndex].Width;
        }

        #endregion

        #endregion

        #region ------- UTILIDADES -------

        private void ConfiguracionAdministrador() 
        {
            if(Singleton.getInstance().EmpleadoLogged.TipoEmpleado != Empleado.TiposEmpleado.Admin) 
            {
                this.btnUsuarios.Enabled = false;
                this.btnEmpleados.Enabled = false;
            }
        }

        private void btnObjetosPerdidos_Click(object sender, EventArgs e)
        {
            ObjetosPerdidosForm frmObjetosPerdidos = new ObjetosPerdidosForm(_context);
            frmObjetosPerdidos.ShowDialog();
        }

        

        private void btnServicioTipoPrenda_Click(object sender, EventArgs e)
        {
            ServicioTipoPrenda frmServicioTipoPrenda = new ServicioTipoPrenda(_context);
            frmServicioTipoPrenda.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleados = new Empleados(_context);
            frmEmpleados.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes frmClientes = new Clientes(_context);
            frmClientes.ShowDialog();
        }

        private void btnMaquinas_Click(object sender, EventArgs e)
        {
            Maquinas frmMaquinas = new Maquinas(_context);
            frmMaquinas.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frmProveedores = new Proveedores(_context);
            frmProveedores.ShowDialog();
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            Servicios frmServicios = new Servicios(_context);
            frmServicios.ShowDialog();
        }

        private void btnTipoPrenda_Click(object sender, EventArgs e)
        {
            TipoPrendas frmTipoPrendas = new TipoPrendas(_context);
            frmTipoPrendas.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios(_context);
            frmUsuarios.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            Caja frmCaja = new Caja(_context);
            frmCaja.ShowDialog();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            Gastos frmGastos = new Gastos(_context);
            frmGastos.ShowDialog();
        }

        #endregion


        // NO ESTA IMPLEMENTADO LOS REPORTES DE LOS LISTVIEW
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (Singleton.getInstance().ListActual != null && Singleton.getInstance().ListActual.SelectedItems.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Reporte de {Singleton.getInstance().ModuloActual} - {DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible escribir el archivo en el disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Table pdfTable = new Table(Singleton.getInstance().ListActual.Columns.Count - 1);
                            pdfTable.SetPadding(3);
                            pdfTable.SetWidth(UnitValue.CreatePercentValue(100));
                            pdfTable.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                            foreach (ColumnHeader column in Singleton.getInstance().ListActual.Columns)
                            {
                                    
                                    Cell cell = new Cell().Add(new Paragraph(column.Text).SetBold());
                                    cell.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                                    cell.SetTextAlignment(TextAlignment.CENTER);
                                    pdfTable.AddCell(cell);
                                
                            }
                            
                            foreach (ListViewItem row in Singleton.getInstance().ListActual.Items)
                            {
                               foreach(ListViewItem.ListViewSubItem cell in row.SubItems)
                                {
                                    pdfTable.AddCell(cell.Text);
                                }

                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                PdfWriter writer = new PdfWriter(stream);
                                PdfDocument pdf = new PdfDocument(writer);
                                Document document = new Document(pdf);
                                pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4);
                                document.SetMargins(10f, 20f, 20f, 10f);
                                Paragraph p = new Paragraph();
                                p.SetTextAlignment(TextAlignment.CENTER);
                                p.Add($"Reporte de {Singleton.getInstance().ModuloActual} \n");
                                p.SetBold();
                                p.SetUnderline();
                                p.SetFontSize(18);
                                document.Add(p);
                                document.Add(pdfTable);
                                document.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Reporte exportado exitosamente", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros para exportar", "Info");
            }
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            
            int ID = Singleton.getInstance().UserLogged.IdUsuario;
            UsuarioDesktop frmUser = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion, _context);
            frmUser.ShowDialog();
        }

        
        private void chkCambioColor_CheckedChanged(object sender, EventArgs e)
        {
           
                CambiarColor(chkCambioColor.Checked);
            
            
        }

        private void btnDeudas_Click(object sender, EventArgs e)
        {
            ReporteDeudas frmDeuda = new ReporteDeudas(_context);
            frmDeuda.ShowDialog();
        }

        private void btnReporteGastos_Click(object sender, EventArgs e)
        {
            ReporteGastos frmGasto = new ReporteGastos(_context);
            frmGasto.ShowDialog();
        }

       
    }
}
