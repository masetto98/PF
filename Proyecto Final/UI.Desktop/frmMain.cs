using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
using PdfiumViewer;
using Humanizer;
using System.Configuration;
using System.Xml;
using iText.Kernel.Utils;

namespace UI.Desktop
{
    public partial class frmMain : ApplicationForm
    {
        private readonly LavanderiaContext _context;
        private readonly UsuarioLogic _usuarioLogic;
        private readonly ClienteLogic _clienteLogic;
        private readonly AtributosNegocioLogic _atributosNegocioLogic;
        private readonly ProveedorLogic _proveedorLogic;
        private readonly FacturaLogic _facturaLogic;
        private readonly InsumoLogic _insumoLogic;
        private readonly InsumoProveedorLogic _insumoProveedorLogic;
        private readonly OrdenLogic _ordenLogic;
        private readonly OrdenServicioTipoPrendaLogic _ordenServicioTipoPrendaLogic;
        private readonly MaquinaOrdenServicioTipoPrendaLogic _maquinaOrdenServicioTipoPrendaLogic;
        private readonly MaquinaLogic _maquinaLogic;
        private readonly AtributosNegocioLogic _atributosLogic;
        public AtributosNegocio NegocioActual;
        public List<OrdenServicioTipoPrenda> _trabajosPendientes;
        public List<MaquinaOrdenServicioTipoPrenda> _trabajosEnProceso;
        public List<OrdenServicioTipoPrenda> _trabajosFinalizados;
        public List<ItemTrabajo> _listaEspera;
        public List<ItemTrabajo> _listaFinalizados;
        public List<_Movimiento> mov = new List<_Movimiento>();
        public double _deudaCliente;
        public Insumo insumoActual;
        public Cliente clienteActual;
        public List<Orden> ordenesPagadas;
        public double _pagosAnteriores;
        public Pago.FormasPago formaPago;
        public AtributosNegocio negocio { set; get; }


        public frmMain(LavanderiaContext context)
        {
            InitializeComponent();

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
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            _listaEspera = new List<ItemTrabajo>();
            _listaFinalizados = new List<ItemTrabajo>();
            _atributosLogic = new AtributosNegocioLogic(new AtributosNegocioAdapter(context));
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
            if (_atributosNegocioLogic.GetAll().Count > 0)
            {
                NegocioActual = _atributosNegocioLogic.GetAll().FirstOrDefault();
            }
            RellenarComboBox(listClientes, cmbBuscarCliente);
            RellenarComboBox(listOrdenes, cmbBuscarOrden);
            RellenarComboBox(listInsumos, cmbInsumos);
            RellenarComboBox(listTrabajosPendientes, cmbTrabajosPendientes);
            RellenarComboBox(listTrabajosFinalizados,cmbFiltroTrabajosFinalizados);
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
                    //ValidarStock();
                    break;
                case 3:
                    ListarOrdenesTrabajosPendientes();
                    //ListarTrabajosFinalizados();
                    break;
                case 4:
                    verificarEmisionComprobantes();
                    break;
                case 5:
                    obtenerPDF();
                    break;

            }
        }
        
        private void tabControlInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlInventario.SelectedIndex)
            {
                case 0:
                    ListarStock();
                    //ValidarStock();
                    this.dtpFiltroFechaIngreso.Value = DateTime.Today.Date.AddYears(-1);
                    break;
                case 1:
                    ListarIngresos();
                    this.dtpDesdeMovimientos.Value = DateTime.Today.Date.AddYears(-1);
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
                MessageBox.Show("Seleccionar una fila en la lista para poder editar", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (this.switchMostrarImpagas.Checked)
            {
                ListarOrdenesImpagas();
            }
            else
            {
                ListarOrdenesCliente();
            }
            
            CalcularCuentaCorrienteCliente();
            listPagosOrden.Items.Clear();
        }

        private void ListarOrdenesCliente()
        {
            listOrdenesCliente.Items.Clear();
            if (listClientes.SelectedItems.Count > 0)
            {
                Cliente clienteActual = _clienteLogic.GetOne(Int32.Parse(listClientes.SelectedItems[0].Text));
                if (clienteActual.Ordenes is not null && clienteActual.Ordenes.Count > 0)
                {
                    //clienteActual.Ordenes.Sort((x, y) => x.Estado.CompareTo(y.Estado));
                    List<Orden> orderOrdenes = clienteActual.Ordenes.OrderBy(x => x.Estado).ToList();
                    //maquinasItem.Sort((x, y) => x.TiempoInicioServicio.CompareTo(y.TiempoInicioServicio));
                    foreach (Orden o in orderOrdenes)
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        double pagos = 0;
                        double deudas = 0;
                        if (o.Factura.Importe != 0 && o.Factura.FechaFactura.ToString("yyyy/MM/dd") != "0001/01/01")
                        {

                            pagos = CalcularPagosOrden(o);
                            deudas = o.Factura.Importe - pagos;
                            item.SubItems.Add(String.Concat("$",o.Factura.Importe.ToString()));
                        }
                        else
                        {
                            double importe = CalcularImporteOrden(o);
                            if (o.Factura.Importe != importe)
                            {
                                o.Factura.Importe = importe;
                                o.Factura.State = BusinessEntity.States.Modified;
                                _facturaLogic.Save(o.Factura);
                            }
                            pagos = CalcularPagosOrden(o);
                            deudas = importe - pagos;
                            item.SubItems.Add(String.Concat("$",importe.ToString()));
                        }

                        if (deudas == 0) { item.SubItems.Add("Pagado"); }
                        else { item.SubItems.Add(String.Concat("$", deudas.ToString())); }
                        if (o.FechaSalida == DateTime.MinValue) { item.SubItems.Add("Sin retirar"); }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }
                        listOrdenesCliente.Items.Add(item);
                        
                    }
                }
                else { MessageBox.Show("El cliente seleccionado NO posee ordenes registradas", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder observar los detalles", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void switchMostrarImpagas_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.switchMostrarImpagas.Checked)
            {
                ListarOrdenesImpagas();
            }
            else 
            {
                ListarOrdenesCliente();
            }
        }

        private void ListarOrdenesImpagas() 
        {
            
                listOrdenesCliente.Items.Clear();
                if (listClientes.SelectedItems.Count > 0)
                {
                    Cliente clienteActual = _clienteLogic.GetOne(Int32.Parse(listClientes.SelectedItems[0].Text));
                    if (clienteActual.Ordenes is not null && clienteActual.Ordenes.Count > 0)
                    {
                        List<Orden> orderOrdenes = clienteActual.Ordenes.OrderBy(x => x.Estado).ToList();
                        foreach (Orden o in orderOrdenes)
                        {
                            ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                            item.SubItems.Add(o.FechaEntrada.ToString());
                            double pagos = 0;
                            double deudas = 0;
                            if (o.Factura.Importe != 0 && o.Factura.FechaFactura.ToString("yyyy/MM/dd") != "0001/01/01")
                            {

                                pagos = CalcularPagosOrden(o);
                                deudas = o.Factura.Importe - pagos;
                                item.SubItems.Add(String.Concat("$", o.Factura.Importe.ToString()));
                            }
                            else
                            {
                                double importe = CalcularImporteOrden(o);
                                if (o.Factura.Importe != importe)
                                {
                                    o.Factura.Importe = importe;
                                    o.Factura.State = BusinessEntity.States.Modified;
                                    _facturaLogic.Save(o.Factura);
                                }
                                pagos = CalcularPagosOrden(o);
                                deudas = importe - pagos;
                                item.SubItems.Add(String.Concat("$", importe.ToString()));
                            }

                            if (deudas == 0) { item.SubItems.Add("Pagado"); }
                            else { item.SubItems.Add(String.Concat("$", deudas.ToString())); }
                            if (o.FechaSalida == DateTime.MinValue) { item.SubItems.Add("Sin retirar"); }
                            else { item.SubItems.Add(o.FechaSalida.ToString()); }
                            if (item.SubItems[3].Text != "Pagado")
                            {
                                listOrdenesCliente.Items.Add(item);
                            }
                        }
                    }

                }
            
        }

        private double CalcularImporteOrden(Orden ordenActual)
        {
            double importe = 0;
            if (ordenActual.Estado == Orden.Estados.Pagado)
            {
                Pago pago = ordenActual.Factura.Pagos.FindLast(delegate (Pago p) { return p.FechaPago <= DateTime.Now; });
                foreach (OrdenServicioTipoPrenda ostp in ordenActual.ItemsPedidos)
                {
                    Precio pre = ostp.ServicioTipoPrenda.HistoricoPrecios.FindLast(delegate (Precio p)
                    {
                        return p.FechaDesde < pago.FechaPago;
                    });
                    importe += pre.Valor;
                }
            }
            else
            {
                foreach (OrdenServicioTipoPrenda ostp in ordenActual.ItemsPedidos)
                {
                    Precio precio = ostp.ServicioTipoPrenda.HistoricoPrecios.FindLast(delegate (Precio p)
                    {
                        return p.FechaDesde < DateTime.Now;
                    });
                    if (precio is not null)
                    {
                        importe += precio.Valor;
                    }
                }
            }

            if (ordenActual.Descuento != null)
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

                        ListViewItem item = new ListViewItem(ordenActual.NroOrden.ToString());
                        item.SubItems.Add(p.FechaPago.ToString());
                        item.SubItems.Add(String.Concat("$", p.Importe.ToString()));
                        item.SubItems.Add(p.FormaPago.ToString());
                        listPagosOrden.Items.Add(item);
                    }
                }
                else { MessageBox.Show("La orden no contiene ningún pago", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista de \"Ordenes del cliente\" para poder observar los pagos", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            if(o.Factura.FechaFactura == DateTime.MinValue)
                            {
                                double importe = CalcularImporteOrden(o);
                                double pagos = CalcularPagosOrden(o);
                                _deudaCliente += (importe - pagos);
                            }
                           
                            
                        }
                    }
                }
                this.lblCuentaCorriente.Text = String.Concat("$", _deudaCliente.ToString());
                this.lblDatosCliente.Text = String.Concat(clienteActual.IdCliente, " - ", clienteActual.Apellido, " ", clienteActual.Nombre);
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
                
                listPagosOrden.Items.Clear();
                if (OrdenActual.Factura is not null && OrdenActual.Factura.Pagos is not null && OrdenActual.Factura.Pagos.Count > 0)
                {
                    foreach (Pago p in OrdenActual.Factura.Pagos)
                    {
                        ListViewItem item = new ListViewItem(OrdenActual.NroOrden.ToString());
                        item.SubItems.Add(p.FechaPago.ToString());
                        item.SubItems.Add(String.Concat("$", p.Importe.ToString()));
                        item.SubItems.Add(p.FormaPago.ToString());
                        listPagosOrden.Items.Add(item);
                    }
                }
                //ListarPagosOrden();
                
            }

            else
            {
                MessageBox.Show("Debe seleccionar una orden de la lista \"Ordenes del cliente\" para poder agregar pagos", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void verificarAtributosNegocio()
        {
            negocio = _atributosLogic.GetAll().FirstOrDefault();
            if (negocio is null)
            {
                if (MessageBox.Show("No fue posible emitir el comprobante debido a que aún no se encuentran registrado los atributos del negocio." + "\n" + "¿Desea registrar los atributos en este momento?", "Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmAtributosNegocio frmAtributosnegocio = new frmAtributosNegocio(ModoForm.Alta, _context);
                    frmAtributosnegocio.ShowDialog();
                    emitirComprobantePago();
                }
            }
            else
            {
                emitirComprobantePago();
            }
        }

        private void emitirComprobantePago()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = $"Comprobante de Pago-{clienteActual.Cuit}-{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";
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

                        AtributosNegocio negocio = new AtributosNegocio();
                        AtributosNegocioLogic negocioLogic = new AtributosNegocioLogic(new AtributosNegocioAdapter(_context));
                        negocio = negocioLogic.GetAll().FirstOrDefault();
                        if(negocio is not null)
                        {
                            string factura = Properties.Resources.comprobantepago_original.ToString();
                            factura = factura.Replace("@nombrempresa", negocio.NombreEmpresa);
                            factura = factura.Replace("@cuitempresa", negocio.CuitEmpresa);
                            factura = factura.Replace("@direccionempresa", negocio.DireccionEmpresa);
                            factura = factura.Replace("@telempresa", negocio.TelEmpresa);
                            factura = factura.Replace("@redes", negocio.RedesEmpresa);
                            factura = factura.Replace("@fechafactura", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                            factura = factura.Replace("@hsfactura", DateTime.Now.ToString("HH:mm:ss"));
                            factura = factura.Replace("@cuit", clienteActual.Cuit);
                            if (clienteActual.RazonSocial == "")
                            {
                                factura = factura.Replace("@nombre", clienteActual.Apellido + "," + clienteActual.Nombre);
                            }
                            else
                            {
                                factura = factura.Replace("@nombre", clienteActual.RazonSocial);
                            }

                            factura = factura.Replace("@direcli", clienteActual.Direccion);
                            factura = factura.Replace("@telcli", clienteActual.Telefono);
                            string items = string.Empty;
                            double totalItems = 0;
                            _pagosAnteriores = 0;
                            foreach (Orden row in ordenesPagadas)
                            {
                                items += "<tr>";
                                items += "<td align=" + "\"center\">" + row.NroOrden.ToString() + "</td>";
                                items += "<td align=" + "\"center\">" + row.FechaEntrada.ToString("dd/MM/yyyy HH:ss:mm") + "</td>";
                                items += "<td align=" + "\"center\">";
                                foreach (OrdenServicioTipoPrenda servicios in row.ItemsPedidos)
                                {
                                    items += "<br>" + servicios.ServicioTipoPrenda.Servicio.Descripcion + " " + servicios.ServicioTipoPrenda.TipoPrenda.Descripcion +"</br>";
                                }
                                items += "</td>";
                                //items += "<td align=" + "\"center\">" + row.ServicioTipoPrenda.TipoPrenda.Descripcion + "</td>";

                                items += "<td align=" + "\"center\">" +"$"+ row.Factura.Importe.ToString() + "</td>";
                                items += "</tr>";
                                totalItems += row.Factura.Importe;
                                if(row.Factura.Pagos.Count > 0)
                                {
                                    row.Factura.Pagos.Sort((a, b) => a.FechaPago.CompareTo(b.FechaPago));
                                    Pago ultPago = row.Factura.Pagos.Last();
                                    foreach(Pago p in row.Factura.Pagos)
                                    {
                                        if(p.FechaPago < ultPago.FechaPago)
                                        {
                                            _pagosAnteriores += p.Importe;
                                        }
                                       
                                    }
                                }
                            }
                            factura = factura.Replace("@items", items);
                            factura = factura.Replace("@totalitems", "$" + totalItems.ToString());
                            double totalfactura;
                            if (_pagosAnteriores != 0)
                            {
                                factura = factura.Replace("@pagosrealizados", "$"+ _pagosAnteriores.ToString());
                                totalfactura = totalItems - _pagosAnteriores;
                            }
                            else
                            {
                                factura = factura.Replace("@pagosrealizados", "0");
                                totalfactura = totalItems - 0;
                            }
                            Empleado empActual = Singleton.getInstance().UserLogged.Empleado;
                            int parteEntera = Convert.ToInt32((Math.Truncate(totalfactura)));
                            double parteDecimal = totalfactura - Convert.ToDouble(parteEntera);
                            string Decimal = "";
                            int pDecimal = 0;
                            if (parteDecimal != 0)
                            {
                                Decimal = parteDecimal.ToString().Split(",")[1];
                                pDecimal = Convert.ToInt32(Decimal);
                            }
                           
                            factura = factura.Replace("@totalfact", "$"+totalfactura.ToString());
                            factura = factura.Replace("@empleado", empActual.Apellido + ", "+empActual.Nombre);
                            factura = factura.Replace("@fechapago", "el día "+ DateTime.Now.Day.ToString() + " del mes de " + DateTime.Now.ToString("MMMM") +" del año " + DateTime.Now.Year.ToString());
                            if(pDecimal != 0)
                            {
                                factura = factura.Replace("@monto", " un monto de $" + totalfactura.ToString() + "(" + parteEntera.ToWords().ToUpper() + " CON " + pDecimal.ToWords().ToUpper() + ")");
                            }
                            else
                            {
                                factura = factura.Replace("@monto", " un monto de $" + totalfactura.ToString() + "(" + parteEntera.ToWords() + ")");
                            }
                            
                            factura = factura.Replace("@formpago", formaPago.ToString());
                            factura = factura.Replace("@concepto", "Saldar Deuda Cta.Cte");
                            int nroComprobante = generarNumeroComprobante();
                            factura = factura.Replace("@nrocomprobante", nroComprobante.ToString());



                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                PdfWriter writer = new PdfWriter(stream);
                                //iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(writer);
                                //pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4);

                                //Paragraph p = new Paragraph();
                                //p.SetTextAlignment(TextAlignment.CENTER);
                                //p.Add($"Reporte de {Singleton.getInstance().ModuloActual} \n");
                                //p.SetBold();
                                //p.SetUnderline();
                                //p.SetFontSize(18);
                                using (StringReader sr = new StringReader(factura))
                                {
                                    Document document = iText.Html2pdf.HtmlConverter.ConvertToDocument(factura, writer);
                                    document.Close();
                                }
                                stream.Close();
                            }

                            MessageBox.Show("El comprobante fue generado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private int generarNumeroComprobante()
        {
            int numComprobanteActual = Properties.Settings.Default.nroComprobante;
            numComprobanteActual += 1;
            Properties.Settings.Default.nroComprobante = numComprobanteActual;
            Properties.Settings.Default.Save();
            return numComprobanteActual;
        }

        private void btnSaldarDeuda_Click(object sender, EventArgs e)
        {
            
            if (listClientes.SelectedItems.Count > 0) 
            {
                CalcularCuentaCorrienteCliente();
                if(_deudaCliente > 0)
                {
                    FormaPagoDesktop fp = new FormaPagoDesktop();
                    if(fp.ShowDialog() == DialogResult.OK)
                    {
                        formaPago = fp.GetFormaPago();
                        if (MessageBox.Show("¿Está seguro que desea saldar la deuda con la siguiente información?" + "\n"
                               + "Cuit: " + listClientes.SelectedItems[0].SubItems[1].Text + "\n"
                               + "Cliente: " + listClientes.SelectedItems[0].SubItems[2].Text + " " + listClientes.SelectedItems[0].SubItems[3].Text + " | " + listClientes.SelectedItems[0].SubItems[4].Text + "\n"
                               + "Forma de pago: " + formaPago + "\n"
                               + "Total: " + this.lblCuentaCorriente.Text
                               , "Saldar Deuda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            clienteActual = _clienteLogic.GetOne(Int32.Parse(listClientes.SelectedItems[0].Text));
                            if (clienteActual is not null)
                            {
                                ordenesPagadas = new List<Orden>();
                                if (clienteActual.Ordenes is not null)
                                {
                                    foreach (Orden o in clienteActual.Ordenes)
                                    {
                                        if (o.Factura.Importe == 0 && o.Factura.FechaFactura == DateTime.MinValue)
                                        {
                                            double importe = CalcularImporteOrden(o);
                                            o.Factura.Importe = importe;
                                            o.Factura.State = BusinessEntity.States.Modified;
                                            _facturaLogic.Save(o.Factura);
                                            double pagos = CalcularPagosOrden(o);
                                            if (importe != pagos)
                                            {
                                                o.Factura.FechaFactura = DateTime.Now;
                                                Pago pagoActual = new Pago();
                                                pagoActual.FechaPago = DateTime.Now;
                                                pagoActual.FormaPago = formaPago;
                                                pagoActual.Importe = importe - pagos;
                                                o.Factura.Pagos.Add(pagoActual);
                                                ordenesPagadas.Add(o);

                                            }
                                        }
                                        else if (o.Factura.Importe != 0 && o.Factura.FechaFactura == DateTime.MinValue)
                                        {
                                            double importe = CalcularImporteOrden(o);
                                            if (o.Factura.Importe != importe)
                                            {
                                                o.Factura.Importe = importe;
                                                o.Factura.State = BusinessEntity.States.Modified;
                                                _facturaLogic.Save(o.Factura);
                                            }
                                            double pagos = CalcularPagosOrden(o);
                                            if (importe != pagos)
                                            {
                                                o.Factura.FechaFactura = DateTime.Now;
                                                Pago pagoActual = new Pago();
                                                pagoActual.FechaPago = DateTime.Now;
                                                pagoActual.FormaPago = formaPago;
                                                pagoActual.Importe = importe - pagos;
                                                o.Factura.Pagos.Add(pagoActual);
                                                ordenesPagadas.Add(o);

                                            }
                                        }
                                        if (o.Estado == Orden.Estados.Finalizado) 
                                        {
                                            o.Estado = Orden.Estados.Pagado;
                                            o.State = BusinessEntity.States.Modified;
                                        }
                                                                              
                                    }
                                    clienteActual.State = BusinessEntity.States.Modified;
                                    _clienteLogic.Save(clienteActual);
                                }
                            }
                            if (Properties.Settings.Default.emitirComprobantes)
                            {
                                verificarAtributosNegocio();
                            }
                        }
                        CalcularCuentaCorrienteCliente();
                        ListarOrdenesCliente();
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("El Cliente seleccionado no posee deudas a saldar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente del listado para poder continuar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOrdenesCliente.Items.Clear();
            listPagosOrden.Items.Clear();
            this.lblDatosCliente.Text = "-";
            this.lblCuentaCorriente.Text = "-";
        }

        private void listOrdenesCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPagosOrden.Items.Clear();
        }

        #endregion

        #region ------- INVENTARIO -------
        private void ListarIngresos()
        {
            listIngresos.Items.Clear();
            List<InsumoProveedor> ingresos = _insumoProveedorLogic.GetAll();
            ingresos.Sort((x, y) => DateTime.Compare(y.FechaIngreso, x.FechaIngreso));
            foreach (InsumoProveedor ig in ingresos)
            {
                if (ig.FechaIngreso >= dtpDesdeMovimientos.Value && ig.FechaIngreso <= dtpHastaMovimientos.Value)
                {
                    ListViewItem item = new ListViewItem(ig.FechaIngreso.ToShortDateString());
                    item.SubItems.Add(ig.IdProveedor.ToString());
                    item.SubItems.Add(ig.Proveedor.RazonSocial);
                    item.SubItems.Add(ig.IdInsumo.ToString());
                    item.SubItems.Add(ig.Insumo.Descripcion);
                    /*ToString("yyyy-MM-dd HH:mm:ss.fffffff")*/
                    item.SubItems.Add(ig.Cantidad.ToString());
                    item.SubItems.Add(ig.Insumo.UnidadMedida.ToString());
                    listIngresos.Items.Add(item);
                }
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
                    if (i.Stock < i.PuntoPedido)
                    {
                        item.SubItems.Add("* "+i.Descripcion);
                    }
                    else 
                    {
                        item.SubItems.Add(i.Descripcion);
                    }
                    item.SubItems.Add(i.Stock.ToString("N2"));
                    item.SubItems.Add(i.UnidadMedida.ToString());
                    listInsumos.Items.Add(item);
                }
            }
        }
        /* --------------------------------------------------------------------*/
        private void MovimientosInsumos()
        {
            listAllMov.Items.Clear();
            mov.Clear();
            Insumo insumoActual = _insumoLogic.GetOne(Int32.Parse(this.listInsumos.SelectedItems[0].Text));
            //List<Consumo> consumosInsumos =//_consumoLogic.GetAll();
            //List<InsumoProveedor> movimientos = _insumoProveedorLogic.GetAll();
            
            if (insumoActual.Consumos is not null)
            {
                var consumosAgrupados = insumoActual.Consumos.GroupBy(l => new { l.FechaConsumo.Date,l.Insumo.UnidadMedida })
                                                             .Select(x => new _Movimiento()
                                                             {
                                                                 Fecha = x.Key.Date,
                                                                 Movimiento = "Consumo",
                                                                 Cantidad = x.Sum(s => (decimal)s.Cantidad),
                                                                 Unidad = x.Key.UnidadMedida.ToString()
                                                             }).ToList();
                mov.AddRange(consumosAgrupados);

            }

            if (insumoActual.InsumosProveedores is not null)
            {
                var movimientosAgrupados = insumoActual.InsumosProveedores.GroupBy(m => new { m.FechaIngreso.Date, m.Insumo.UnidadMedida })
                                                      .Select(r => new _Movimiento()
                                                      {
                                                          Fecha = r.Key.Date,
                                                          Movimiento = "Ingreso",
                                                          Cantidad = r.Sum(t => (decimal)t.Cantidad),
                                                          Unidad = r.Key.UnidadMedida.ToString()
                                                      }).ToList();
                mov.AddRange(movimientosAgrupados);

            }
        }

        private void ListarMovimientosPorInsumo(DateTime fechaDesde, DateTime fechaHasta)
        {
            listAllMov.Items.Clear();
            mov.Sort((x, y) => DateTime.Compare(x.Fecha, y.Fecha));
            foreach (_Movimiento m in mov)
            {
                if (m.Fecha >= fechaDesde && m.Fecha <= fechaHasta)
                {
                    ListViewItem item = new ListViewItem(m.Fecha.Date.ToShortDateString());
                    item.SubItems.Add(m.Movimiento.ToString());
                    if (m.Movimiento == "Consumo")
                    {
                        item.SubItems.Add("- " + m.Cantidad.ToString());
                    }
                    else { item.SubItems.Add("  " + m.Cantidad.ToString()); }
                    item.SubItems.Add(m.Unidad.ToString());
                    listAllMov.Items.Add(item);
                }
            }
        }
        /* --------------------------------------------------------------------*/

        private void listInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                MovimientosInsumos();
                ListarMovimientosPorInsumo(dtpFiltroFechaIngreso.Value.Date, dtpHastaIngreso.Value.Date);
            }
            else 
            {
                listAllMov.Items.Clear();
                this.listIngresosInsumos.Items.Clear();
            }
            
        }
        private void listInsumos_ColumnWidthChanging_1(object sender, ColumnWidthChangingEventArgs e)
        {

            e.Cancel = true;
            e.NewWidth = listInsumos.Columns[e.ColumnIndex].Width;

        }

        private void listInsumosFaltantes_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {

            e.Cancel = true;
            e.NewWidth = listInsumosFaltantes.Columns[e.ColumnIndex].Width;
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
            ValidarStock();
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
                MessageBox.Show("Seleccionar una fila en la lista para poder editar", "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarStock();
            ValidarStock();
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
                insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
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

        private void filtroFechaIngresos()
        {
            if(insumoActual is not null)
            {
                if(dtpHastaIngreso.Value.Date != DateTime.Now.Date)
                {
                    if(dtpFiltroFechaIngreso.Value.Date != DateTime.Now.Date)
                    {
                        List<InsumoProveedor> ipFiltro = insumoActual.InsumosProveedores.FindAll(
                        delegate (InsumoProveedor ip)
                        {
                            return ip.FechaIngreso.Date >= dtpFiltroFechaIngreso.Value.Date && ip.FechaIngreso.Date <= dtpHastaIngreso.Value.Date;
                        });
                        listarIngresosFiltrados(ipFiltro);
                    }
                    else
                    {
                        List<InsumoProveedor> ipFiltro = insumoActual.InsumosProveedores.FindAll(
                        delegate (InsumoProveedor ip)
                        {
                            return ip.FechaIngreso.Date <= dtpHastaIngreso.Value.Date;
                        });
                        listarIngresosFiltrados(ipFiltro);
                    }
                }
                else
                {
                    List<InsumoProveedor> ipFiltro = insumoActual.InsumosProveedores.FindAll(
                        delegate (InsumoProveedor ip)
                        {
                            return ip.FechaIngreso.Date >= dtpFiltroFechaIngreso.Value.Date;
                        });
                    listarIngresosFiltrados(ipFiltro);
                }
            }
        }

        private void filtroFechaMovimientos()
        {
           
                if (dtpHastaIngreso.Value.Date != DateTime.Now.Date)
                {
                    if (dtpFiltroFechaIngreso.Value.Date != DateTime.Now.Date)
                    {
                        List<InsumoProveedor> ipFiltro = _insumoProveedorLogic.GetAll().FindAll(
                        delegate (InsumoProveedor ip)
                        {
                            return ip.FechaIngreso.Date >= dtpDesdeMovimientos.Value.Date && ip.FechaIngreso.Date <= dtpHastaMovimientos.Value;
                        });
                        listarMovimientosFiltrados(ipFiltro);
                    }
                    else
                    {
                        List<InsumoProveedor> ipFiltro = _insumoProveedorLogic.GetAll().FindAll(
                        delegate (InsumoProveedor ip)
                        {
                            return ip.FechaIngreso.Date <= dtpHastaMovimientos.Value;
                        });
                        listarMovimientosFiltrados(ipFiltro);
                    }
                }
                else
                {
                    List<InsumoProveedor> ipFiltro = _insumoProveedorLogic.GetAll().FindAll(
                        delegate (InsumoProveedor ip)
                        {
                            return ip.FechaIngreso.Date >= dtpDesdeMovimientos.Value.Date;
                        });
                        listarMovimientosFiltrados(ipFiltro);
                }
            
        }

        private void listarMovimientosFiltrados(List<InsumoProveedor> ipFiltro)
        {
            listIngresos.Items.Clear();
            foreach (InsumoProveedor ip in ipFiltro)
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

        private void listarIngresosFiltrados(List<InsumoProveedor> ipFiltro)
        {
            listIngresosInsumos.Items.Clear();
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

        private void dtpHastaIngreso_ValueChanged(object sender, EventArgs e)
        {
            filtroFechaIngresos();
            ListarMovimientosPorInsumo(dtpFiltroFechaIngreso.Value.Date, dtpHastaIngreso.Value.Date);
        }

        private void dtpFiltroFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            filtroFechaIngresos();
            ListarMovimientosPorInsumo(dtpFiltroFechaIngreso.Value.Date, dtpHastaIngreso.Value.Date);
        }

        private void dtpDesdeMovimientos_ValueChanged(object sender, EventArgs e)
        {
            //filtroFechaMovimientos();
            ListarIngresos();



        }

        private void dtpHastaMovimientos_ValueChanged(object sender, EventArgs e)
        {
            //filtroFechaMovimientos();
            ListarIngresos();
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            ListarIngresosInsumo();
        }

        #endregion

        private void ValidarStock() 
        {

            List<Insumo> insumos = _insumoLogic.GetAll().FindAll(delegate (Insumo i) 
            {
                return i.Stock < i.PuntoPedido;
            });
            if (insumos.Count > 0)
            {
                cardReferencias.Visible = true;
                this.cardInsumosFaltantes.Visible = true;
                this.pxRojo.Visible = true;
                this.lblInsumosFaltantes.Visible = true;
                this.listInsumosFaltantes.Visible = true;
                ///Notificacion
                niFaltaInsumos.BalloonTipTitle = "IMPORTANTE!! Hay insumos con poco stock!";
                niFaltaInsumos.BalloonTipText = "Ver detalles";
                niFaltaInsumos.ShowBalloonTip(3000);

            }
            else
            {
                this.cardReferencias.Visible = false;
                this.cardInsumosFaltantes.Visible = false;
                this.pxRojo.Visible = false;
                this.lblInsumosFaltantes.Visible = false;
                this.listInsumosFaltantes.Visible = false;
            }
            /*
            List<Insumo> insumos = _insumoLogic.GetAll();
            if (insumos is not null && insumos.Count>0) 
            {
                listInsumosFaltantes.Items.Clear();
                foreach (Insumo i in insumos) 
                {
                    if (i.Stock < i.PuntoPedido) 
                    {
                        ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                        item.SubItems.Add(i.Descripcion);
                        listInsumosFaltantes.Items.Add(item);
                    }
                }
            }
            if (listInsumosFaltantes.Items.Count > 0)
            {
                this.cardInsumosFaltantes.Visible = true;
                this.pxRojo.Visible = true;
                this.lblInsumosFaltantes.Visible = true;
                this.listInsumosFaltantes.Visible = true;
                ///Notificacion
                niFaltaInsumos.BalloonTipTitle = "IMPORTANTE!! Hay insumos con poco stock!";
                niFaltaInsumos.BalloonTipText = "Ver detalles";
                niFaltaInsumos.ShowBalloonTip(3000);
                
            }
            else 
            {
                this.cardInsumosFaltantes.Visible = false;
                this.pxRojo.Visible = false;
                this.lblInsumosFaltantes.Visible = false;
                this.listInsumosFaltantes.Visible = false;
                
            }*/

        }

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
            ValidarStock();
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
            if (this.txtBuscarInsumos.Text == "") { ListarStock(); }
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
            ListarIngresos();
        }

        private void niFaltaInsumos_BalloonTipClicked(object sender, EventArgs e)
        {
            Insumos frmInsumos = new Insumos(_context);
            frmInsumos.ShowDialog();
        }
        #endregion

        #region ------- ORDENES -------
        private void CargarOrdenes()
        {
            List<Orden> ordenes = _ordenLogic.GetAll().FindAll(delegate (Orden or) { return or.Estado != Orden.Estados.Retirado;});
            //ordenes.Sort((x, y) => y.NroOrden.CompareTo(x.NroOrden));
            ordenes = ordenes.OrderBy(x => x.FechaHoraEntregaIngresada).ThenBy(x => x.Estado).ToList();
            listOrdenes.Items.Clear();
            foreach (Orden o in ordenes)
            {
                ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                item.SubItems.Add(String.Concat(o.Cliente.Cuit," - ",o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                item.SubItems.Add(o.Prioridad.ToString());
                item.SubItems.Add(o.FechaEntrada.ToString());
                /*if (o.FechaSalida == DateTime.MinValue)
                {
                    item.SubItems.Add("No Retirado");
                }
                else { item.SubItems.Add(o.FechaSalida.ToString()); }*/
                item.SubItems.Add(o.FechaHoraEntregaIngresada.ToString());
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
                        item.SubItems.Add(String.Concat(o.Cliente.Cuit, " - ", o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        /*if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }*/
                        item.SubItems.Add(o.FechaHoraEntregaIngresada.ToString());
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Cliente")
            {
                foreach (Orden o in ordenes)
                {
                    string cliente = String.Concat(o.Cliente.Cuit, " - ", o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial);
                    //if (o.Cliente.Nombre.ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()) || o.Cliente.Apellido.ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()) || o.Cliente.RazonSocial.ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()))
                    if (cliente.ToLower().Contains(this.txtBuscarOrdenes.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Cuit, " - ", o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        /*if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }*/
                        item.SubItems.Add(o.FechaHoraEntregaIngresada.ToString());
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.txtBuscarOrdenes.Text == "") { CargarOrdenes(); }

        }

        private void dtpOrdenesFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            ListarOrdenesPorFecha();
        }

        private void dtpOrdenesFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            ListarOrdenesPorFecha();
        }

        private void ListarOrdenesPorFecha() 
        {
            listOrdenes.Items.Clear();
            List<Orden> ordenes = _ordenLogic.GetAll();
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Fecha Ingreso" )
            {
                foreach (Orden o in ordenes)
                {
                    if (o.FechaEntrada.Date >= this.dtpOrdenesFechaDesde.Value.Date && o.FechaEntrada.Date <= this.dtpOrdenesFechaHasta.Value.Date)
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        /*if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }*/
                        item.SubItems.Add(o.FechaHoraEntregaIngresada.ToString());
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Fecha retiro est.")
            {
                foreach (Orden o in ordenes)
                {
                    if (o.FechaHoraEntregaIngresada.Date >= this.dtpOrdenesFechaDesde.Value.Date && o.FechaHoraEntregaIngresada.Date <= this.dtpOrdenesFechaHasta.Value.Date)
                    {
                        ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                        item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                        item.SubItems.Add(o.Prioridad.ToString());
                        item.SubItems.Add(o.FechaEntrada.ToString());
                        /*if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No Retirado");
                        }
                        else { item.SubItems.Add(o.FechaSalida.ToString()); }*/
                        item.SubItems.Add(o.FechaHoraEntregaIngresada.ToString());
                        item.SubItems.Add(o.Estado.ToString());
                        listOrdenes.Items.Add(item);
                    }
                }
            }
        }

        private void cmbEstadosOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOrdenes.Items.Clear();
            List<Orden> ordenes = _ordenLogic.GetAll();
            
            foreach (Orden o in ordenes)
            {
                if (o.Estado.ToString() == this.cmbEstadosOrdenes.SelectedItem.ToString() || o.Prioridad.ToString() == this.cmbEstadosOrdenes.SelectedItem.ToString())
                {
                    ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                    item.SubItems.Add(String.Concat(o.Cliente.Nombre, " ", o.Cliente.Apellido, " / ", o.Cliente.RazonSocial));
                    item.SubItems.Add(o.Prioridad.ToString());
                    item.SubItems.Add(o.FechaEntrada.ToString());
                    /*if (o.FechaSalida == DateTime.MinValue)
                    {
                        item.SubItems.Add("No Retirado");
                    }
                    else { item.SubItems.Add(o.FechaSalida.ToString()); }*/
                    item.SubItems.Add(o.FechaHoraEntregaIngresada.ToString());
                    item.SubItems.Add(o.Estado.ToString());
                    listOrdenes.Items.Add(item);
                }
            }
        }

        private void cmbBuscarOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarOrdenes();
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Prioridad" || this.cmbBuscarOrden.SelectedItem.ToString() =="Estado")
            {
                this.cmbEstadosOrdenes.Visible = true;
                this.txtBuscarOrdenes.Visible = false;
                this.lblFechaDesdeOrdenes.Visible = false;
                this.lblFechaHastaOrdenes.Visible = false;
                this.dtpOrdenesFechaDesde.Visible = false;
                this.dtpOrdenesFechaHasta.Visible = false;
                
                if (this.cmbBuscarOrden.SelectedItem.ToString() == "Prioridad") 
                {
                    this.cmbEstadosOrdenes.DataSource = cmbEstados.DataSource = Enum.GetValues(typeof(Orden.Prioridades));
                }
                if (this.cmbBuscarOrden.SelectedItem.ToString() == "Estado") 
                {
                    this.cmbEstadosOrdenes.DataSource = Enum.GetValues(typeof(Orden.Estados));
                }
            }
            if (this.cmbBuscarOrden.SelectedItem.ToString() == "Fecha Ingreso" || this.cmbBuscarOrden.SelectedItem.ToString() == "Fecha retiro est.")
            {
                this.txtBuscarOrdenes.Visible = false;
                this.lblFechaDesdeOrdenes.Visible = true;
                this.lblFechaHastaOrdenes.Visible = true;
                this.dtpOrdenesFechaDesde.Visible = true;
                this.dtpOrdenesFechaHasta.Visible = true;
                this.cmbEstadosOrdenes.Visible = false;
            }
            if(this.cmbBuscarOrden.SelectedItem.ToString() != "Prioridad" && this.cmbBuscarOrden.SelectedItem.ToString() != "Estado" && this.cmbBuscarOrden.SelectedItem.ToString() != "Fecha Ingreso" && this.cmbBuscarOrden.SelectedItem.ToString() != "Fecha retiro est.")
            {
                this.txtBuscarOrdenes.Visible = true;
                this.lblFechaDesdeOrdenes.Visible = false;
                this.lblFechaHastaOrdenes.Visible = false;
                this.dtpOrdenesFechaDesde.Visible = false;
                this.dtpOrdenesFechaHasta.Visible = false;
                this.cmbEstadosOrdenes.Visible = false;
            }
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
                Orden orden = _ordenLogic.GetOne(nroOrden);
                if (orden.Estado != Orden.Estados.Finalizado && orden.Estado != Orden.Estados.Retirado && orden.Estado != Orden.Estados.Pagado)
                {
                    OrdenDesktop frmOrden = new OrdenDesktop(nroOrden, ApplicationForm.ModoForm.Modificacion, _context);
                    frmOrden.ShowDialog();
                    CargarOrdenes();
                    Planificar();
                }
                else 
                {
                    MessageBox.Show("La orden seleccionada se encuentra FINALIZADA, PAGADA o RETIRADA y por lo tanto NO es posible modificarla", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar una orden", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccionar una fila en la lista para poder retirar la Orden", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                this.mnuPrincipal.Visible = true;
                this.epUser.Visible = true;
                this.epUser.Title = $"{Singleton.getInstance().UserLogged.NombreUsuario}";
                ConfiguracionAdministrador();
                ValidarStock();
            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.frmMain_Shown(sender, e);
            this.epUser.Collapse = true;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {

            int ID = Singleton.getInstance().UserLogged.IdUsuario;
            Usuario userAnt = ObtenerValor(ID);
            UsuarioDesktop frmUser = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion, _context);
            frmUser.ShowDialog();
            Usuario userNew = _usuarioLogic.GetOne(ID);
            if (userAnt.NombreUsuario!=userNew.NombreUsuario || userAnt.Clave!=userNew.Clave)
            { 
                btnCerrarSesion.PerformClick();
            }
        }
        //Uso este metodo para que me guarde los valores anteriores de la clase, si los saco de aca cambian y entonces
        //no puedo hacer la comparacion para cerrar la session
        private Usuario ObtenerValor(int ID) 
        {
            Usuario userAnt = _usuarioLogic.GetOne(ID);
            Usuario user = new Usuario();
            user.NombreUsuario = userAnt.NombreUsuario;
            user.Clave = userAnt.Clave;
            return user;
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
            _listaFinalizados.Clear();
            CargarListaEspera();
            ListarOrdenesTrabajosPendientes();
            //ListarEstadoMaquinas();
            ListarTrabajosEnProceso();
            CargarListaFinalizados();
            ListarTrabajosFinalizados();
        }
        /*
        private void listEstadoMaquinas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listEstadoMaquinas.Columns[e.ColumnIndex].Width;
        }*/

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
                TimeSpan tiempoRestante = item.Orden.FechaHoraEntregaIngresada - DateTime.Now;
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
                    item.SubItems.Add("-" + i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                }
                else
                {
                    item.SubItems.Add(i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
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
                if (maquinasItem is not null)
                {
                    maquinasItem.Sort((x, y) => x.TiempoInicioServicio.CompareTo(y.TiempoInicioServicio));
                    if (maquinasItem.Count > 0)
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
                    else
                    {
                        MessageBox.Show("El item seleccionado no tiene servicios realizados", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }   
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajo en la lista para poder observar los detalles", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnIniciarServicio_Click(object sender, EventArgs e)
        {
            List<Maquina> maquinas = _maquinaLogic.GetAll();
            if(maquinas.Count > 0)
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
                    if (t.Estado != OrdenServicioTipoPrenda.Estados.Procesando)
                    {
                        MaquinaOrdenServicioTipoPrendaDesktop frmTrabajos = new MaquinaOrdenServicioTipoPrendaDesktop(t.NroOrden, t.IdServicio, t.IdTipoPrenda, t.OrdenItem, ApplicationForm.ModoForm.Alta, _context);
                        frmTrabajos.ShowDialog();
                    }
                    else { MessageBox.Show("Actualmente se le esta dando servicio al trabajo seleccionado", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un trabajo en la lista para poder iniciarlo", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Planificar();
                ListarOrdenesTrabajosPendientes();
                ListarTrabajosEnProceso();
                //ListarEstadoMaquinas();
            }
            else
            {
                MessageBox.Show("No es posible iniciar el servicio debido a que no se han encontrado máquinas en el sistema. Por favor, registre nuevas máquinas para continuar.","Iniciar Servicio",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnFinalizarTrabajo_Click_1(object sender, EventArgs e)
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
                if(t.Estado != OrdenServicioTipoPrenda.Estados.Procesando)
                {
                    if (t.MaquinaOrdenServicioTipoPrenda is null || t.MaquinaOrdenServicioTipoPrenda.Count == 0)
                    {
                        if (MessageBox.Show("Este trabajo NO contiene servicios realizados ¿Esta seguro que desea finalizarlo?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            t.Estado = OrdenServicioTipoPrenda.Estados.Finalizado;
                            if (ValidarFinalizacionOrden(t.NroOrden))
                            {
                                t.Orden.Estado = Orden.Estados.Finalizado;
                                if (NegocioActual is not null && NegocioActual.Email is not null & NegocioActual.Contrasenia is not null)
                                {
                                    EnviarMail(NegocioActual.Email, t.Orden.Cliente.Email);
                                }
                            }
                            if (ValidarOrdenSaldada(t.NroOrden)) {t.Orden.Estado = Orden.Estados.Pagado; }
                            t.State = BusinessEntity.States.Modified;
                            _ordenServicioTipoPrendaLogic.Save(t);
                        }

                    }
                    else
                    {
                        if (MessageBox.Show("¿Esta seguro que desea finalizar este trabajo?" + "\n" + 
                            "Orden N°" + t.NroOrden +" | "+ t.ServicioTipoPrenda.Servicio.Descripcion + " " + 
                            t.ServicioTipoPrenda.TipoPrenda.Descripcion + "| Item: " + t.OrdenItem.ToString(), "Finalizar Trabajo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        { 
                            t.Estado = OrdenServicioTipoPrenda.Estados.Finalizado;
                            if (ValidarFinalizacionOrden(t.NroOrden))
                            {
                                t.Orden.Estado = Orden.Estados.Finalizado;
                                if (NegocioActual is not null && NegocioActual.Email is not null & NegocioActual.Contrasenia is not null)
                                {
                                    EnviarMail(NegocioActual.Email, t.Orden.Cliente.Email);
                                }
                            }
                            if (ValidarOrdenSaldada(t.NroOrden)) { t.Orden.Estado = Orden.Estados.Pagado; }
                            t.State = BusinessEntity.States.Modified;
                            _ordenServicioTipoPrendaLogic.Save(t);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El trabajo que desea finalizar se encuentra Procesando. Por favor, detenga el servicio actual del trabajo para poder continuar.", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajo en la lista para poder finalizarlo", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Planificar();
            ListarOrdenesTrabajosPendientes();

        }
        
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

        private void EnviarMail(string de, string para) 
        {
            string error = "";
            if (NegocioActual is null && _atributosNegocioLogic.GetAll().Count > 0) 
            {
                NegocioActual = _atributosNegocioLogic.GetAll().FirstOrDefault();
            }
            if (NegocioActual is not null) 
            {
                if (NegocioActual.Email is not null && NegocioActual.Contrasenia is not null) 
                {
                    try
                    {
                        StringBuilder Mensaje = new StringBuilder();
                        Mensaje.Append(Environment.NewLine);
                        Mensaje.Append(string.Format("Su pedido a sido completado. Ya puede pasar a retirlo si asi lo desea"));
                        Mensaje.Append(Environment.NewLine);
                        Mensaje.Append(string.Format("Saludos!"));
                        Mensaje.Append(Environment.NewLine);
                        Mensaje.Append(string.Format($"{NegocioActual.NombreEmpresa}"));
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(de);
                        mail.To.Add(para);
                        mail.Subject = "Finalizacion de pedido de lavanderia";
                        mail.Body = Mensaje.ToString();
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.Port = 587;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential(NegocioActual.Email, SecurityManager.Decrypt(NegocioActual.Contrasenia));
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        error = "El aviso ha sido enviado al cliente!";
                        MessageBox.Show(error, "Aviso Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        error = error + ex.Message;
                        MessageBox.Show(error,"Aviso Email",MessageBoxButtons.OK , MessageBoxIcon.Error);
                        return;
                    }

                }
            }
        } 


        private bool ValidarOrdenSaldada(int nroOrden) 
        {
            Orden ordenActual = _ordenLogic.GetOne(nroOrden);
            if (ordenActual.Factura is not null && ordenActual.Factura.Pagos is not null)
            {
                double pagos = 0.0;
                foreach (Pago p in ordenActual.Factura.Pagos)
                {
                    pagos += p.Importe;
                }
                if (ordenActual.Factura.Importe != 0 && ordenActual.Factura.Importe == pagos) { return true; }
                else return false;
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
            if (this.txtBuscarTrabajosPendientes.Text == "") { ListarOrdenesTrabajosPendientes(); }
        }

        private void cmbTrabajosPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarOrdenesTrabajosPendientes();
            if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Prioridad")
            {
                txtBuscarTrabajosPendientes.Visible = false;
                this.lblElijaFechaEntrega.Visible = false;
                this.dtpFechaVencitmiento.Visible = false;
                cmbEstados.DataSource = Enum.GetValues(typeof(OrdenServicioTipoPrenda.Prioridades));
                //cmbEstados.SelectedItem = null;
                cmbEstados.Visible = true;
            }
            else if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Estado")
            {
                List<string> opciones = new List<string>();
                opciones.Add("Pendiente");
                opciones.Add("Iniciado");
                cmbEstados.DataSource = opciones;
                //cmbEstados.SelectedItem = null;
                txtBuscarTrabajosPendientes.Visible = false;
                this.lblElijaFechaEntrega.Visible = false;
                this.dtpFechaVencitmiento.Visible = false;
                cmbEstados.Visible = true;
            }
            else if (this.cmbTrabajosPendientes.SelectedItem.ToString() == "Tiempo Restante") 
            {
                this.txtBuscarTrabajosPendientes.Visible = false;
                this.cmbEstados.Visible = false;
                this.lblElijaFechaEntrega.Visible = true;
                this.dtpFechaVencitmiento.Visible = true;
            }
            else
            {
                cmbEstados.Visible = false;
                txtBuscarTrabajosPendientes.Visible = true;
                this.lblElijaFechaEntrega.Visible = false;
                this.dtpFechaVencitmiento.Visible = false;
            }
        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEstados.SelectedItem.ToString() == "Estandar" )
            {
                listTrabajosPendientes.Items.Clear();
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.Prioridad.ToString().Contains(this.cmbEstados.SelectedItem.ToString()))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        if (i.TiempoRestante.ToString().Contains("-"))
                        {
                            item.SubItems.Add("-" + i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        else
                        {
                            item.SubItems.Add(i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbEstados.SelectedItem.ToString() == "Alta")
            {
                listTrabajosPendientes.Items.Clear();
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.Prioridad.ToString().Contains(this.cmbEstados.SelectedItem.ToString()))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        if (i.TiempoRestante.ToString().Contains("-"))
                        {
                            item.SubItems.Add("-" + i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        else
                        {
                            item.SubItems.Add(i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbEstados.SelectedItem.ToString() == "Pendiente")
            {
                listTrabajosPendientes.Items.Clear();
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.Estado.ToString().Contains(this.cmbEstados.SelectedItem.ToString()))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        if (i.TiempoRestante.ToString().Contains("-"))
                        {
                            item.SubItems.Add("-" + i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        else
                        {
                            item.SubItems.Add(i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        listTrabajosPendientes.Items.Add(item);
                    }
                }
            }
            if (this.cmbEstados.SelectedItem.ToString() == "Iniciado")
            {
                listTrabajosPendientes.Items.Clear();
                foreach (ItemTrabajo i in _listaEspera)
                {
                    if (i.Trabajo.Estado.ToString().Contains(this.cmbEstados.SelectedItem.ToString()))
                    {
                        ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(i.Trabajo.Estado.ToString());
                        item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                        if (i.TiempoRestante.ToString().Contains("-"))
                        {
                            item.SubItems.Add("-" + i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        else
                        {
                            item.SubItems.Add(i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                        }
                        listTrabajosPendientes.Items.Add(item);
                    }
                }

            }
        }

        private void dtpFechaVencitmiento_ValueChanged(object sender, EventArgs e)
        {
            listTrabajosPendientes.Items.Clear();
            foreach (ItemTrabajo i in _listaEspera)
            {
                if (i.Trabajo.Orden.FechaHoraEntregaIngresada.Date <= this.dtpFechaVencitmiento.Value.Date)
                {
                    ListViewItem item = new ListViewItem(i.Trabajo.Orden.NroOrden.ToString());
                    item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                    item.SubItems.Add(i.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    item.SubItems.Add(i.Trabajo.OrdenItem.ToString());
                    item.SubItems.Add(i.Trabajo.Estado.ToString());
                    item.SubItems.Add(i.Trabajo.Prioridad.ToString());
                    if (i.TiempoRestante.ToString().Contains("-"))
                    {
                        item.SubItems.Add("-" + i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                    }
                    else
                    {
                        item.SubItems.Add(i.TiempoRestante.ToString(@"d\d\:h\h\:m\m"));
                    }
                    listTrabajosPendientes.Items.Add(item);
                }
            }
        }

        private void listTrabajosPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listMaquinasItem.Items.Clear();
            lblCliente.Text = "";
            lblFechaEntrega.Text = "";
            if (listTrabajosPendientes.SelectedItems.Count > 0)
            {
                OrdenServicioTipoPrenda t = _trabajosPendientes.Find(delegate (OrdenServicioTipoPrenda item)
                {
                    return item.NroOrden == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].Text) &&
                           item.ServicioTipoPrenda.Servicio.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[1].Text &&
                           item.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[2].Text &&
                           item.OrdenItem == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].SubItems[3].Text);
                });
                if (t is not null)
                {
                    if (t.Orden.Cliente.RazonSocial != "")
                    {
                        lblCliente.Text = t.Orden.Cliente.RazonSocial;
                        
                    }
                    else
                    {
                        lblCliente.Text = t.Orden.Cliente.Apellido + ", " + t.Orden.Cliente.Nombre;
                    }

                    lblFechaEntrega.Text = t.Orden.FechaHoraEntregaIngresada.ToString();

                }

            }
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
                item.SubItems.Add(i.TiempoInicioServicio.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                item.SubItems.Add(i.OrdenServicioTipoPrenda.Estado.ToString());
                listTrabajosEnProceso.Items.Add(item);
            }

        }

        private void btnTerminarServicio_Click(object sender, EventArgs e)
        {
            if (listTrabajosEnProceso.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea detener el servicio a este trabajo?" + "\n" + "Maquina: " +
                    listTrabajosEnProceso.SelectedItems[0].Text + " | " +
                    "Orden N°: " + listTrabajosEnProceso.SelectedItems[0].SubItems[1].Text + " | "
                    + listTrabajosEnProceso.SelectedItems[0].SubItems[2].Text + " " + listTrabajosEnProceso.SelectedItems[0].SubItems[3].Text +" | "
                    + "Item: " + listTrabajosEnProceso.SelectedItems[0].SubItems[4].Text, "Detener Servicio", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
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
            //ListarEstadoMaquinas();
        }

        private void listTrabajosEnProceso_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listTrabajosEnProceso.Columns[e.ColumnIndex].Width;
        }

        #endregion

        #region ------- TRABAJOS FINALIZADOS -------
        private void listTrabajosFinalizados_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listTrabajosFinalizados.Columns[e.ColumnIndex].Width;
        }

        private void listServiciosOrden_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listServiciosOrden.Columns[e.ColumnIndex].Width;
        }
        private void ListarTrabajosFinalizados() 
        {
            
            listTrabajosFinalizados.Items.Clear();
            if (_listaFinalizados.Count > 0) {
                foreach (ItemTrabajo it in _listaFinalizados) {
                    ListViewItem item =  new ListViewItem(it.Trabajo.Orden.NroOrden.ToString());
                    item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                    item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    item.SubItems.Add(it.Trabajo.OrdenItem.ToString());
                    item.SubItems.Add(it.Trabajo.Estado.ToString());
                    item.SubItems.Add(it.Fecha.ToString());
                    listTrabajosFinalizados.Items.Add(item);
                }
            }
        }

        private void CargarListaFinalizados()
        {
            _trabajosFinalizados = _ordenServicioTipoPrendaLogic.GetAll().FindAll(delegate (OrdenServicioTipoPrenda o) { return o.Estado == OrdenServicioTipoPrenda.Estados.Finalizado;});
            foreach (OrdenServicioTipoPrenda item in _trabajosFinalizados)
            {
                ItemTrabajo trabajo = new ItemTrabajo();
                trabajo.Trabajo = item;
                List<MaquinaOrdenServicioTipoPrenda> servicios = item.MaquinaOrdenServicioTipoPrenda.OrderByDescending(x => x.TiempoFinServicio).ToList();
                if (servicios.Count >0)
                {
                    trabajo.Fecha = servicios.First().TiempoFinServicio;
                    _listaFinalizados.Add(trabajo);
                }
            }
            List<ItemTrabajo> orderList = _listaFinalizados.OrderByDescending(i => i.Fecha).ToList();
            _listaFinalizados.Clear();
            _listaFinalizados = orderList;
        }

        private void btnServiciosDetallados_Click(object sender, EventArgs e)
        {
            List<MaquinaOrdenServicioTipoPrenda> maquinasItem = new List<MaquinaOrdenServicioTipoPrenda>();
            if (listTrabajosFinalizados.SelectedItems.Count > 0)
            {
                maquinasItem = _maquinaOrdenServicioTipoPrendaLogic.GetAll().FindAll(delegate (MaquinaOrdenServicioTipoPrenda item)
                {
                    return item.NroOrden == Int32.Parse(this.listTrabajosFinalizados.SelectedItems[0].Text) &&
                           item.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion == this.listTrabajosFinalizados.SelectedItems[0].SubItems[1].Text &&
                           item.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listTrabajosFinalizados.SelectedItems[0].SubItems[2].Text &&
                           item.OrdenItem == Int32.Parse(this.listTrabajosFinalizados.SelectedItems[0].SubItems[3].Text);
                });
                if (maquinasItem is not null)
                {
                    maquinasItem.Sort((x, y) => x.TiempoInicioServicio.CompareTo(y.TiempoInicioServicio));
                    if (maquinasItem.Count > 0)
                    {
                        listServiciosOrden.Items.Clear();
                        foreach (MaquinaOrdenServicioTipoPrenda mi in maquinasItem)
                        {
                            ListViewItem mir = new ListViewItem(mi.Maquina.Descripcion);
                            mir.SubItems.Add(mi.TiempoInicioServicio.ToString());
                            if (mi.TiempoFinServicio == DateTime.MinValue)
                            {
                                mir.SubItems.Add("");
                            }
                            else { mir.SubItems.Add(mi.TiempoFinServicio.ToString()); }
                            mir.SubItems.Add(String.Concat(mi.Empleado.Nombre, " ", mi.Empleado.Apellido));
                            listServiciosOrden.Items.Add(mir);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El item seleccionado no tiene servicios realizados", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajo en la lista para poder observar los detalles", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscarTrabajosFinalizados_TextChanged(object sender, EventArgs e)
        {
            //_trabajosFinalizados = _maquinaOrdenServicioTipoPrendaLogic.GetAll().FindAll(delegate (MaquinaOrdenServicioTipoPrenda m) { return m.TiempoFinServicio != DateTime.MinValue; });
            listTrabajosFinalizados.Items.Clear();
            if (this.cmbFiltroTrabajosFinalizados.SelectedItem.ToString() == "N°")
            {
                foreach (ItemTrabajo it in _listaFinalizados)
                {
                    if (it.Trabajo.NroOrden.ToString().Contains(this.txtBuscarTrabajosFinalizados.Text))
                    {
                        ListViewItem item = new ListViewItem(it.Trabajo.NroOrden.ToString());
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(it.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(it.Trabajo.Estado.ToString());
                        item.SubItems.Add(it.Fecha.ToString());
                        listTrabajosFinalizados.Items.Add(item);
                    }
                }

            }
            if (this.cmbFiltroTrabajosFinalizados.SelectedItem.ToString() == "Servicio")
            {
                foreach (ItemTrabajo it in _listaFinalizados)
                {
                    if (it.Trabajo.ServicioTipoPrenda.Servicio.Descripcion.Contains(this.txtBuscarTrabajosFinalizados.Text))
                    {
                        ListViewItem item = new ListViewItem(it.Trabajo.NroOrden.ToString());
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(it.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(it.Trabajo.Estado.ToString());
                        item.SubItems.Add(it.Fecha.ToString());
                        listTrabajosFinalizados.Items.Add(item);
                    }
                }
            }
            if (this.cmbFiltroTrabajosFinalizados.SelectedItem.ToString() == "Tipo Prenda")
            {
                foreach (ItemTrabajo it in _listaFinalizados)
                {
                    if (it.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion.Contains(this.txtBuscarTrabajosFinalizados.Text))
                    {
                        ListViewItem item = new ListViewItem(it.Trabajo.NroOrden.ToString());
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(it.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(it.Trabajo.Estado.ToString());
                        item.SubItems.Add(it.Fecha.ToString());
                        listTrabajosFinalizados.Items.Add(item);
                    }
                }
            }
            if (this.cmbFiltroTrabajosFinalizados.SelectedItem.ToString() == "Item")
            {
                foreach (ItemTrabajo it in _listaFinalizados)
                {
                    if (it.Trabajo.OrdenItem.ToString().Contains(this.txtBuscarTrabajosFinalizados.Text))
                    {
                        ListViewItem item = new ListViewItem(it.Trabajo.NroOrden.ToString());
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(it.Trabajo.OrdenItem.ToString());
                        item.SubItems.Add(it.Trabajo.Estado.ToString());
                        item.SubItems.Add(it.Fecha.ToString());
                        listTrabajosFinalizados.Items.Add(item);
                    }
                }
            }
            if (this.txtBuscarTrabajosFinalizados.Text == "") { ListarTrabajosFinalizados(); }
            
        }

        private void btnEnviarPendientes_Click(object sender, EventArgs e)
        {
            if (listTrabajosFinalizados.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿ Está seguro que desea enviar este item a pendientes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    OrdenServicioTipoPrenda ostp = _ordenServicioTipoPrendaLogic.GetAll().Find(x =>
                          x.NroOrden == Int32.Parse(this.listTrabajosFinalizados.SelectedItems[0].Text) &&
                          x.ServicioTipoPrenda.Servicio.Descripcion == this.listTrabajosFinalizados.SelectedItems[0].SubItems[1].Text &&
                          x.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listTrabajosFinalizados.SelectedItems[0].SubItems[2].Text &&
                          x.OrdenItem == Int32.Parse(this.listTrabajosFinalizados.SelectedItems[0].SubItems[3].Text));

                        Orden ordenItemActual = _ordenLogic.GetOne(ostp.NroOrden);
                        if (ordenItemActual is not null && ordenItemActual.Estado != Orden.Estados.Retirado)
                        {
                            ostp.Estado = OrdenServicioTipoPrenda.Estados.Iniciado;
                            ostp.State = BusinessEntity.States.Modified;
                            ordenItemActual.Estado = Orden.Estados.Procesando;
                            ordenItemActual.State = BusinessEntity.States.Modified;
                            ordenItemActual.ItemsPedidos.Add(ostp);
                            _ordenLogic.Save(ordenItemActual);
                            Planificar();
                        }
                        else { MessageBox.Show("La orden a la cual pertenece el item seleccionado ya se encuentra registrada como RETIRADA debido a esto no fue posible realizar la acción correspondiente.", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                
                //else { MessageBox.Show("La orden del item selecciona ya se encuentra registrada como RETIRADA, y por lo tanto no es posible realizar la acción", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            else { MessageBox.Show("Se debe seleccionar un item de la lista", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            
        }

        private void cmbFiltroTrabajosFinalizados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //listTrabajosFinalizados.Items.Clear();
            if (this.cmbFiltroTrabajosFinalizados.SelectedItem.ToString() == "Fecha y hora fin")
            {
                this.txtBuscarTrabajosFinalizados.Visible = false;
                this.lblDesde.Visible = true;
                this.dtpBuscarFechaMenor.Visible = true;
                this.lblHasta.Visible = true;
                this.dtpBuscarFechaMayor.Visible = true;
                this.dtpBuscarFechaMenor.Value = DateTime.Today;
                this.dtpBuscarFechaMayor.Value = DateTime.Today;

            }
            else 
            {
                this.txtBuscarTrabajosFinalizados.Visible = true;
                this.lblDesde.Visible = false;
                this.dtpBuscarFechaMenor.Visible = false;
                this.lblHasta.Visible = false;
                this.dtpBuscarFechaMayor.Visible = false;
                ListarTrabajosFinalizados();
            }
        }

        private void dtpBuscarFechaMenor_ValueChanged(object sender, EventArgs e)
        {
            ListarTrabajosFinalizadosPorFecha();
        }

        private void dtpBuscarFechaMayor_ValueChanged(object sender, EventArgs e)
        {
            ListarTrabajosFinalizadosPorFecha();
        }

        private void ListarTrabajosFinalizadosPorFecha() 
        {
            listTrabajosFinalizados.Items.Clear();
            foreach (ItemTrabajo it in _listaFinalizados)
            {
                if (it.Fecha.Date >= dtpBuscarFechaMenor.Value.Date && it.Fecha.Date <= dtpBuscarFechaMayor.Value.Date)
                {
                    ListViewItem item = new ListViewItem(it.Trabajo.NroOrden.ToString());
                    item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.Servicio.Descripcion);
                    item.SubItems.Add(it.Trabajo.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    item.SubItems.Add(it.Trabajo.OrdenItem.ToString());
                    item.SubItems.Add(it.Trabajo.Estado.ToString());
                    item.SubItems.Add(it.Fecha.ToString());
                    listTrabajosFinalizados.Items.Add(item);
                }
            }

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
                this.btnEliminarOrden.Enabled = false;
            }
            if (Singleton.getInstance().EmpleadoLogged.TipoEmpleado == Empleado.TiposEmpleado.Admin)
            {
                this.btnUsuarios.Enabled = true;
                this.btnEmpleados.Enabled = true;
                this.btnEliminarOrden.Enabled = true;
            }
        }

        //Utilidades
        private void btnObjetosPerdidos_Click(object sender, EventArgs e)
        {
            ObjetosPerdidosForm frmObjetosPerdidos = new ObjetosPerdidosForm(_context);
            frmObjetosPerdidos.ShowDialog();
        }

        private void btnAtributos_Click(object sender, EventArgs e)
        {
            List<AtributosNegocio> atributosNegocio = _atributosNegocioLogic.GetAll();
            if (atributosNegocio.Count > 0)
            {
                
                frmAtributosNegocio frmAtributosnegocio = new frmAtributosNegocio(atributosNegocio.FirstOrDefault().ID, ModoForm.Modificacion, _context);
                frmAtributosnegocio.ShowDialog();
            }
            else 
            {
                frmAtributosNegocio frmAtributosnegocio = new frmAtributosNegocio(ModoForm.Alta, _context);
                frmAtributosnegocio.ShowDialog();
            }
        }

        //Administrar negocio
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

        private void btnMaquinas_Click(object sender, EventArgs e)
        {
            Maquinas frmMaquinas = new Maquinas(_context);
            frmMaquinas.ShowDialog();
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

        //Finanzas

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

        //Administracion externa 
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frmProveedores = new Proveedores(_context);
            frmProveedores.ShowDialog();
        }

        

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            Insumos frmInsumo = new Insumos(_context);
            frmInsumo.ShowDialog();
        }

        //Reportes
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

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            ReporteMovimientos frmMovimientos = new ReporteMovimientos(_context);
            frmMovimientos.ShowDialog();
        }

        private void btnReporteEmpleados_Click(object sender, EventArgs e)
        {
            ReporteEmpleado frmEmpleados = new ReporteEmpleado(_context);
            frmEmpleados.ShowDialog();
        }

        private void btnReporteDomicilio_Click(object sender, EventArgs e)
        {

            ReporteEnvioDomicilio frmEnvioDomicilio = new ReporteEnvioDomicilio(_context);
            frmEnvioDomicilio.ShowDialog();
        }
        private void verificarEmisionComprobantes()
        {
            this.switchComprobantes.Checked = Properties.Settings.Default.emitirComprobantes;
        }

        private void switchComprobantes_CheckedChanged(object sender, EventArgs e)
        {
            if (switchComprobantes.Checked)
            {
                Properties.Settings.Default.emitirComprobantes = true;
            }
            else
            {
                Properties.Settings.Default.emitirComprobantes = false;
            }
            Properties.Settings.Default.Save();
        }

        #endregion

        #region ------- AYUDA -------

        private void obtenerPDF()
        {
            byte[] PDF = Properties.Resources.Manual_de_Usuario;
            var stream = new MemoryStream(PDF);

            PdfiumViewer.PdfDocument pdfDocument = PdfiumViewer.PdfDocument.Load(stream);

            pdfViewerHelpUser.Document = pdfDocument;
            
        }



        #endregion

        // NO ESTA IMPLEMENTADO LOS REPORTES DE LOS LISTVIEW
        /*
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
        */
        

        private void chkCambioColor_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColor(chkCambioColor.Checked);
        }

        
    }
}
