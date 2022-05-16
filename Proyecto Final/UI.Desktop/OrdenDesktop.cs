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
    public partial class OrdenDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly LavanderiaContext _context;
        public Orden OrdenActual { set; get; }
        public List<OrdenServicioTipoPrenda>? _itemsServicio;
        private readonly OrdenLogic _ordenLogic;
        private readonly ClienteLogic _clienteLogic;
        private readonly ServicioLogic _servicioLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        private readonly EmpleadoLogic _empleadoLogic;
        private readonly FacturaLogic _facturaLogic;
        public decimal _total;
        public OrdenDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            _servicioTipoPrendaLogic = new ServicioTipoPrendaLogic(new ServicioTipoPrendaAdapter(context));
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            listItemsServicio.Items.Clear();
            _itemsServicio = new List<OrdenServicioTipoPrenda>();

            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtRazonSocial.Enabled = false;
            this.txtIdCliente.Enabled = false;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public OrdenDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                List<Servicio> cursos = _servicioLogic.GetAll();
                this.cmbServicios.DataSource = cursos;
                this.cmbServicios.SelectedIndex = 0;
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbTipoPrenda.DataSource = tipoPrendas;
                this.cmbTipoPrenda.SelectedIndex = 0;
                this.cmbEstado.DataSource = Enum.GetNames(typeof(Business.Entities.Orden.Estados));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public OrdenDesktop(int nroOrden, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                OrdenActual = _ordenLogic.GetOne(nroOrden);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtIdCliente.Text = OrdenActual.IdCliente.ToString();
            this.cmbEstado.SelectedIndex = cmbEstado.FindStringExact(Enum.GetName(OrdenActual.Estado));
            this.dtpFechaIngreso.Value = OrdenActual.FechaEntrada.Date;
            this.txtTiempoFinalizacionEstimado.Text = OrdenActual.TiempofinalizacionEstimado.Hours.ToString() + " : " + OrdenActual.TiempofinalizacionEstimado.Minutes.ToString();
            this.dtpFechaSalida.Value = OrdenActual.FechaSalida.Date;
            try
            {
                List<OrdenServicioTipoPrenda> itemsOrdenActual = OrdenActual.ItemsPedidos;
                listItemsServicio.Items.Clear();
                foreach (OrdenServicioTipoPrenda i in itemsOrdenActual) 
                {
                    ListViewItem item = new ListViewItem((listItemsServicio.Items.Count + 1).ToString());
                    item.SubItems.Add(i.ServicioTipoPrenda.Servicio.Descripcion);
                    item.SubItems.Add(i.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    listItemsServicio.Items.Add(item);
                }
                List<Servicio> servicios = _servicioLogic.GetAll();
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbTipoPrenda.DataSource = tipoPrendas;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.dtpFechaSalida.Enabled = false;
                    
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrenda.Enabled = false;
                    this.txtCuit.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrenda.Enabled = false;
                    ;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                OrdenActual = new Orden();
                _total = 0;
                OrdenActual.Cliente = _clienteLogic.GetOne(Int32.Parse(this.txtIdCliente.Text));
                //OrdenActual.Empleado = Singleton.getInstance().EmpleadoLogged;
                OrdenActual.Factura = _facturaLogic.GetOne(1);
                OrdenActual.Empleado = _empleadoLogic.GetOne(1);
                OrdenActual.FechaEntrada = dtpFechaIngreso.Value;
                OrdenActual.Estado = Orden.Estados.Pendiente;
                OrdenActual.ItemsPedidos = _itemsServicio;
            }
            if (Modos == ModoForm.Modificacion)
            {
                //ServicioTipoPrendaActual.TiempoRequerido = new TimeSpan(Int32.Parse(this.txtHoras.Text), Int32.Parse(this.txtMinutos.Text), 00);
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    OrdenActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    OrdenActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void Eliminar()
        {
            try
            {
                _ordenLogic.Delete(OrdenActual.NroOrden);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region -------Buscar Cliente--------

        private void txtCuit_Leave(object sender, EventArgs e)
        {
            cargarCliente();
        }

        private void cargarCliente()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtRazonSocial.Text = "";
            try
            {
                Cliente cli = _clienteLogic.GetOneConCuit(this.txtCuit.Text);
                if (cli == null)
                {
                    Exception e = new Exception("No existe cliente para el cuit ingresado.");
                    throw e;
                }
                this.txtNombre.Text = cli.Nombre;
                this.txtApellido.Text = cli.Apellido;
                this.txtIdCliente.Text = cli.IdCliente.ToString();
                this.txtRazonSocial.Text = cli.RazonSocial;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region ------manejo de items de la orden------
        private void AgregarItem(ServicioTipoPrenda servicioTipoPrenda) 
        {
            OrdenServicioTipoPrenda itemActual = new OrdenServicioTipoPrenda();
            itemActual.ServicioTipoPrenda = servicioTipoPrenda;
            itemActual.Estado = OrdenServicioTipoPrenda.Estados.Pendiente;
            itemActual.OrdenItem = ContarItems(servicioTipoPrenda.IdServicio,servicioTipoPrenda.IdTipoPrenda);
            _itemsServicio.Add(itemActual);
            
        }

        private int ContarItems(int idServicio, int idTipoPrenda) 
        {
            int _cont = 0;
            if( _itemsServicio is null)
            {
                return 1;
            }
            else {
                foreach (OrdenServicioTipoPrenda item in _itemsServicio)
                {
                    if (item.IdServicio == idServicio && item.IdTipoPrenda == idTipoPrenda)
                    {
                        _cont += 1;
                    }
                }
                return _cont;
            }
            
        }

        private void EliminarItem() 
        {
            
            if (listItemsServicio.SelectedItems.Count >0)
            { 
                var _itemDelete = _itemsServicio.FindLast(
                    delegate (OrdenServicioTipoPrenda item)
                    {
                        return 
                            item.ServicioTipoPrenda.Servicio.Descripcion == this.listItemsServicio.SelectedItems[0].SubItems[1].Text 
                            &&
                            item.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listItemsServicio.SelectedItems[0].SubItems[2].Text;
                    }
                );
                Precio precioActual = _itemDelete.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde < DateTime.Today;
                    });
                _total -= precioActual.Valor;
                this.txtPrecioTotal.Text = _total.ToString();
                //int _indice = listItemsServicio.SelectedItems.IndexOf(listItemsServicio.SelectedItems[0]);
                //_itemsServicio.FindLastIndex(listItemsServicio.SelectedItems[0])
                _itemsServicio.Remove(_itemDelete);
                listItemsServicio.Items.Remove(listItemsServicio.SelectedItems[0]);
            }
        }
        

        private void btnAgregarItemOrden_Click(object sender, EventArgs e)
        {
            try 
            {
                int idServicio = (int)this.cmbServicios.SelectedValue;
                int idTipoPrenda = (int)this.cmbTipoPrenda.SelectedValue;
                ServicioTipoPrenda servicioTp = _servicioTipoPrendaLogic.GetOne(idServicio, idTipoPrenda);
                if (servicioTp == null)
                {
                    Exception r = new Exception("No existe el servicio ingresado.");
                    throw r;
                }
                else 
                {
                    AgregarItem(servicioTp);
                    Precio precioActual = servicioTp.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde < DateTime.Today;
                    });
                    _total += precioActual.Valor;
                    ListViewItem item = new ListViewItem((listItemsServicio.Items.Count+1).ToString());
                    item.SubItems.Add(this.cmbServicios.Text);
                    item.SubItems.Add(this.cmbTipoPrenda.Text);
                    item.SubItems.Add(precioActual.Valor.ToString());
                    item.SubItems.Add("Pendiente");
                    listItemsServicio.Items.Add(item);
                    this.txtPrecioTotal.Text = _total.ToString();
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "ItemServicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarItem();
        }

        #endregion

        public override void GuardarCambios()
        {
            try
            {
                if (true)
                {
                    MapearADatos();
                    _ordenLogic.Save(OrdenActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmCliente.ShowDialog();
        }
    }
}
