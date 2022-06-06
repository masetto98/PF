﻿using MaterialSkin;
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
            _listaEspera = new List<ItemTrabajo>();
            //NegocioActual = _atributosNegocioLogic.GetOne(1);
            CargarOrdenes();
            Planificar();
            /* materialSkinManager = MaterialSkinManager.Instance;
             materialSkinManager.AddFormToManage(this);
             materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
             materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            */
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmCliente.ShowDialog();

        }

        private void mnuPrincipal_Selected(object sender, TabControlEventArgs e)
        {
            if (mnuPrincipal.SelectedTab == mnuTabOrdenes)
            {
                CargarOrdenes();
            }
            else if (mnuPrincipal.SelectedIndex == 1)
            {
                ListarClientes();

            }
            else if (mnuPrincipal.SelectedIndex == 2)
            {
                ListarStock();

                ListarProveedores();


                ListarInsumos();


                ListarIngresos();


            }
            else if (mnuPrincipal.SelectedIndex == 3)
            {
                Planificar();
                ListarOrdenesTrabajosPrendientes();
                ListarEstadoMaquinas();

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
                item.SubItems.Add(c.Direccion);
                item.SubItems.Add(c.RazonSocial);
                item.SubItems.Add(c.Email);
                item.SubItems.Add(c.Telefono);
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
                MessageBox.Show("Seleccionar una fila en la lista para poder editar");
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
                MessageBox.Show("Seleccionar una fila en la lista para poder eliminar");
            }

        }
        private void buscarCliente()
        {
            ListViewItem foundItem = listClientes.FindItemWithText(txtBuscarCliente.Text, true, 0, true);
            if (foundItem != null)
            {
                listClientes.Items.Clear();
                listClientes.Items.Add(foundItem);
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text == "")
            {
                ListarClientes();
            }
            else
            {
                buscarCliente();
            }
        }

        //evento para fixear columnas del listview
        private void listClientes_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listClientes.Columns[e.ColumnIndex].Width;
        }

        private void btnOrdenesCliente_Click(object sender, EventArgs e)
        {

            if (listClientes.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listClientes.SelectedItems[0].Text);
                ClienteOrdenDesktop oClientes = new ClienteOrdenDesktop(ID, _context);
                oClientes.ShowDialog();
                //listClientes.Items.Remove(listClientes.SelectedItems[0]); Otra forma de borrar de la lista
                ListarClientes();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder observar las ordenes");
            }
        }
        #endregion

        #region ------- INVENTARIO -------
        private void ListarStock()
        {
            List<Insumo> insumos = _insumoLogic.GetAll();
            listStock.Items.Clear();
            foreach (Insumo i in insumos)
            {
                ListViewItem item = new ListViewItem(i.Descripcion);
                item.SubItems.Add(i.Stock.ToString());
                listStock.Items.Add(item);
            }
        }
        private void ListarProveedores()
        {
            List<Proveedor> proveedores = _proveedorLogic.GetAll();
            listProveedores.Items.Clear();
            foreach (Proveedor p in proveedores)
            {
                ListViewItem item = new ListViewItem(p.IdProveedor.ToString());
                item.SubItems.Add(p.Cuit);
                item.SubItems.Add(p.RazonSocial);
                item.SubItems.Add(p.Telefono);
                item.SubItems.Add(p.Email);
                item.SubItems.Add(p.Direccion);
                listProveedores.Items.Add(item);
            }
        }

        private void ListarInsumos()
        {
            List<Insumo> insumos = _insumoLogic.GetAll();
            listInsumos.Items.Clear();
            foreach (Insumo i in insumos)
            {
                ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                item.SubItems.Add(i.Descripcion);
                item.SubItems.Add(i.Stock.ToString());
                item.SubItems.Add(i.UnidadMedida.ToString());

                listInsumos.Items.Add(item);
            }

        }

        private void ListarIngresos()
        {
            List<InsumoProveedor> insumosproveedores = _insumoProveedorLogic.GetAll();
            insumosproveedores.OrderByDescending(ip => ip.FechaIngreso);
            listIngresos.Items.Clear();
            foreach (InsumoProveedor ip in insumosproveedores)
            {
                ListViewItem item = new ListViewItem(ip.Proveedor.IdProveedor.ToString());
                item.SubItems.Add(ip.Proveedor.RazonSocial);
                item.SubItems.Add(ip.Insumo.IdInsumo.ToString());
                item.SubItems.Add(ip.Insumo.Descripcion);
                item.SubItems.Add(ip.FechaIngreso.ToString());
                item.SubItems.Add(ip.Cantidad.ToString());
                listIngresos.Items.Add(item);
            }
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            ProveedorDesktop frmProveedor = new ProveedorDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmProveedor.ShowDialog();
            ListarProveedores();
        }

        private void btnEditarProv_Click(object sender, EventArgs e)
        {
            if (listProveedores.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listProveedores.SelectedItems[0].Text);
                ProveedorDesktop formProveedor = new ProveedorDesktop(ID, ApplicationForm.ModoForm.Modificacion, _context);
                formProveedor.ShowDialog();
                ListarProveedores();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder editar");
            }
        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            if (listProveedores.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listProveedores.SelectedItems[0].Text);
                ProveedorDesktop formProveedor = new ProveedorDesktop(ID, ApplicationForm.ModoForm.Baja, _context);
                formProveedor.ShowDialog();
                //listClientes.Items.Remove(listClientes.SelectedItems[0]); Otra forma de borrar de la lista
                ListarProveedores();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder eliminar");
            }
        }

        private void listProveedores_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listProveedores.Columns[e.ColumnIndex].Width;
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            InsumoDesktop frmInsumo = new InsumoDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmInsumo.ShowDialog();
            ListarInsumos();
        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listInsumos.SelectedItems[0].Text);
                InsumoDesktop formInsumo = new InsumoDesktop(ID, ApplicationForm.ModoForm.Modificacion, _context);
                formInsumo.ShowDialog();
                ListarInsumos();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder editar");
            }
        }

        private void btnEliminarInsumo_Click(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                int ID = Int32.Parse(this.listInsumos.SelectedItems[0].Text);
                InsumoDesktop formInsumo = new InsumoDesktop(ID, ApplicationForm.ModoForm.Baja, _context);
                formInsumo.ShowDialog();
                //listClientes.Items.Remove(listClientes.SelectedItems[0]); Otra forma de borrar de la lista
                ListarInsumos();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder eliminar");
            }
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
                ListarIngresos();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder editar");
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
                ListarIngresos();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila en la lista para poder eliminar");
            }

        }
        private void dtpFiltrarFechaIngreso_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaFiltro = dtpFiltrarFechaIngreso.Value;
            List<InsumoProveedor> insumosproveedores = _insumoProveedorLogic.GetAll();
            List<InsumoProveedor> ipFecha = insumosproveedores.FindAll(ip => ip.FechaIngreso == fechaFiltro.Date);
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

        }

        private void listIngresos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listIngresos.Columns[e.ColumnIndex].Width;
        }

        private void listInsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listInsumos.Columns[e.ColumnIndex].Width;
        }
        private void btnActualizarIngresos_Click(object sender, EventArgs e)
        {
            ListarIngresos();
        }
        #endregion


        #region ------- ORDENES -------
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
                item.SubItems.Add(o.Prioridad.ToString());
                item.SubItems.Add(o.FechaEntrada.ToString());
                //item.SubItems.Add(o.TiempofinalizacionEstimado.ToString());
                //item.SubItems.Add(o.TiempoFinalizacionReal.ToString());
                item.SubItems.Add(o.FechaSalida.ToString());
                item.SubItems.Add(o.Estado.ToString());
                listOrdenes.Items.Add(item);
            }
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            OrdenDesktop frmOrden = new OrdenDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmOrden.ShowDialog();
            CargarOrdenes();
        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            if (listOrdenes.SelectedItems.Count > 0)
            {
                int nroOrden = Int32.Parse(this.listOrdenes.SelectedItems[0].Text);
                OrdenDesktop frmOrden = new OrdenDesktop(nroOrden, ApplicationForm.ModoForm.Baja, _context);
                frmOrden.ShowDialog();
                CargarOrdenes();
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
        public void ListarOrdenesTrabajosPrendientes()
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
                item.SubItems.Add(i.TiempoRestante.ToString());
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
                    listTrabajosPendientes.Items[i].BackColor = Color.Green;
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
            Planificar();
            ListarOrdenesTrabajosPrendientes();
            ListarTrabajosEnProceso();
            ListarEstadoMaquinas();

        }

        private void btnFinalizarTrabajo_Click_1(object sender, EventArgs e)
        {
            if (listTrabajosPendientes.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Quieres terminar este trabajo?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OrdenServicioTipoPrenda t = _trabajosPendientes.Find(delegate (OrdenServicioTipoPrenda item)
                    {
                        return item.NroOrden == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].Text) &&
                               item.ServicioTipoPrenda.Servicio.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[1].Text &&
                               item.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listTrabajosPendientes.SelectedItems[0].SubItems[2].Text &&
                               item.OrdenItem == Int32.Parse(this.listTrabajosPendientes.SelectedItems[0].SubItems[3].Text);
                    });
                    t.Estado = OrdenServicioTipoPrenda.Estados.Finalizado;
                    t.State = BusinessEntity.States.Modified;
                    _ordenServicioTipoPrendaLogic.Save(t);
                }
            }
            Planificar();
            ListarOrdenesTrabajosPrendientes();
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
                if (MessageBox.Show("Quieres terminar este trabajo?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            ListarTrabajosEnProceso();
        }

        #endregion

        #endregion

        #region ------- UTILIDADES -------
        
        private void btnObjetosPerdidos_Click(object sender, EventArgs e)
        {
            ObjetosPerdidosForm frmObjetosPerdidos = new ObjetosPerdidosForm(_context);
            frmObjetosPerdidos.ShowDialog();
        }


        #endregion

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
    }
}
