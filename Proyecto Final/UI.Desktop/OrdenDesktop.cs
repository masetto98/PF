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
        public List<OrdenServicioTipoPrenda> _itemsServicio;
        private readonly OrdenLogic _ordenLogic;
        private readonly ClienteLogic _clienteLogic;
        private readonly ServicioLogic _servicioLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
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
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            listItemsServicio.Items.Clear();
            _itemsServicio = new List<OrdenServicioTipoPrenda>();

            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtRazonSocial.Enabled = false;
            this.txtIdCliente.Enabled = false;
            this.dtpFechaIngreso.Value = DateTime.Now;
            _total = 0;

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
                List<Servicio> servicios = _servicioLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbServicios.SelectedIndex = 0;
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbTipoPrenda.DataSource = tipoPrendas;
                this.cmbTipoPrenda.SelectedIndex = 0;
                this.cmbEstado.DataSource = Enum.GetNames(typeof(Business.Entities.Orden.Estados));
                this.cmbPrioridad.DataSource = Enum.GetNames(typeof(Business.Entities.Orden.Prioridades));
                this.cmbTipoPrenda.SelectedIndex = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtIdCliente.Text = OrdenActual.IdCliente.ToString();
            this.txtApellido.Text = OrdenActual.Cliente.Apellido;
            this.txtNombre.Text = OrdenActual.Cliente.Nombre;
            this.txtRazonSocial.Text = OrdenActual.Cliente.RazonSocial;
            this.txtCuit.Text = OrdenActual.Cliente.Cuit;
            this.cmbEstado.SelectedIndex = cmbEstado.FindStringExact(Enum.GetName(OrdenActual.Estado));
            this.dtpFechaIngreso.Value = OrdenActual.FechaEntrada.Date;
            this.txtTiempoFinalizacionEstimado.Text = OrdenActual.TiempofinalizacionEstimado.Hours.ToString() + " : " + OrdenActual.TiempofinalizacionEstimado.Minutes.ToString();
            this.dtpFechaSalida.Value = OrdenActual.FechaSalida.Date;
            this.cmbPrioridad.SelectedIndex = cmbEstado.FindStringExact(Enum.GetName(OrdenActual.Prioridad));
            try
            {
                _itemsServicio = OrdenActual.ItemsPedidos;
                ListarItems();
                List<Servicio> servicios = _servicioLogic.GetAll();
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbTipoPrenda.DataSource = tipoPrendas;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.dtpFechaSalida.Enabled = false;
                    this.cmbEstado.Enabled = false;
                    
                    break;
                case ModoForm.Modificacion:
                    this.txtCuit.Enabled = false;
                    this.cmbEstado.Enabled = false;
                    this.dtpFechaIngreso.Enabled = false;
                    this.btnAgregarCliente.Enabled = false;
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrenda.Enabled = false;
                    this.txtCuit.Enabled = false;
                    this.btnAgregarItemOrden.Enabled = false;
                    this.btnEliminarItemOrden.Enabled = false;
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
                OrdenActual.Cliente = _clienteLogic.GetOne(Int32.Parse(this.txtIdCliente.Text));
                OrdenActual.Empleado = Singleton.getInstance().EmpleadoLogged;
                OrdenActual.Factura = _facturaLogic.GetOne(1);
                OrdenActual.FechaEntrada = DateTime.Now;
                OrdenActual.FechaSalida = dtpFechaSalida.MaxDate;
                OrdenActual.Estado = Orden.Estados.Pendiente;
                OrdenActual.Prioridad = (Business.Entities.Orden.Prioridades)Enum.Parse(typeof(Business.Entities.Orden.Prioridades), cmbPrioridad.SelectedItem.ToString());
                AsignarPrioridadItems();
                OrdenActual.ItemsPedidos = _itemsServicio;

            }
            if (Modos == ModoForm.Modificacion)
            {
                OrdenActual.ItemsPedidos = _itemsServicio;

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

        

        #region -------Cliente--------

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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmCliente.ShowDialog();
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
            try
            {

                if (listItemsServicio.SelectedItems.Count > 0)
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
                    if (_itemDelete.Estado == OrdenServicioTipoPrenda.Estados.Pendiente)
                    {
                        Precio precioActual = _itemDelete.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                        delegate (Precio p)
                        {
                            return p.FechaDesde < DateTime.Today;
                        });
                        _total -= precioActual.Valor;
                        this.txtPrecioTotal.Text = _total.ToString();
                        _itemsServicio.Remove(_itemDelete);
                        listItemsServicio.Items.Remove(listItemsServicio.SelectedItems[0]);
                    }
                    else 
                    {
                        Exception r = new Exception("El item que quiere eliminar ya fue atendido o se encuentra en proceso de atencion");
                        throw r;
                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "ItemServicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarItems() 
        {
            listItemsServicio.Items.Clear();
            foreach (OrdenServicioTipoPrenda i in _itemsServicio)
            {
                Precio precioActual = i.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde < DateTime.Today;
                    });
                ListViewItem item = new ListViewItem((listItemsServicio.Items.Count + 1).ToString());
                item.SubItems.Add(i.ServicioTipoPrenda.Servicio.Descripcion);
                item.SubItems.Add(i.ServicioTipoPrenda.TipoPrenda.Descripcion);
                item.SubItems.Add(precioActual.Valor.ToString());
                item.SubItems.Add(i.Estado.ToString());
                listItemsServicio.Items.Add(item);
                _total += precioActual.Valor;
                this.txtPrecioTotal.Text = _total.ToString();
            }
        }

        public void AsignarPrioridadItems() 
        {
            foreach (OrdenServicioTipoPrenda o in _itemsServicio) 
            {
                if ((Business.Entities.Orden.Prioridades)Enum.Parse(typeof(Business.Entities.Orden.Prioridades), cmbPrioridad.SelectedItem.ToString()) == Orden.Prioridades.Alta)
                {
                    o.Prioridad = OrdenServicioTipoPrenda.Prioridades.Alta;
                }
                else 
                {
                    o.Prioridad =(OrdenServicioTipoPrenda.Prioridades)o.ServicioTipoPrenda.Prioridad;
                }
            }
        }

        private void btnAgregarItemOrden_Click(object sender, EventArgs e)
        {
            try
            { 
                ServicioTipoPrenda servicioTp = _servicioTipoPrendaLogic.GetOne((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrenda.SelectedValue);
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
            //try
            //{
                if (true)
                {
                    MapearADatos();
                    _ordenLogic.Save(OrdenActual);
                    Close();
                }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public virtual void Eliminar()
        {
            try
            {
                if (OrdenActual.Estado == Orden.Estados.Pendiente)
                {
                    _ordenLogic.Delete(OrdenActual.NroOrden);
                }
                else
                {
                    Exception r = new Exception("La orden que quiere eliminar ya esta finalizada o se encuentra en proceso de atencion");
                    throw r;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
