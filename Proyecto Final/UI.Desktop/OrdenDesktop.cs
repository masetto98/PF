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
using iText.Kernel.Pdf;
using iText.Html2pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.IO;
using FluentValidation.Results;

namespace UI.Desktop
{
    public partial class OrdenDesktop : ApplicationForm
    {

        private readonly LavanderiaContext _context;
        public Orden OrdenActual { set; get; }
        public Pago PagoActual { set; get; }
        public Factura FacturaActual { set; get; }
        public List<Pago> _pagosFactura;
        public List<OrdenServicioTipoPrenda> _itemsServicio;
        private readonly OrdenLogic _ordenLogic;
        private readonly ClienteLogic _clienteLogic;
        private readonly ServicioLogic _servicioLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        private readonly FacturaLogic _facturaLogic;
        public double _total;

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

            this.txtNombreApellidoRazonSocial.Enabled = false;
            this.txtIdCliente.Enabled = false;
            this.cbFormaPago.Enabled = false;
            _total = 0;

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
                this.cmbEstado.DataSource = Enum.GetNames(typeof(Orden.Estados));
                this.cmbPrioridad.DataSource = Enum.GetNames(typeof(Orden.Prioridades));
                this.cmbPrioridad.SelectedIndex = 0;
                this.cmbEntregaDomicilio.DataSource= Enum.GetNames(typeof(Orden.EntregasDomicilio));
                this.cmbEntregaDomicilio.SelectedIndex = 0;
                this.txtDescuento.Enabled = false;
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
                this.cmbEstado.DataSource = Enum.GetNames(typeof(Business.Entities.Orden.Estados));
                this.cmbPrioridad.DataSource = Enum.GetNames(typeof(Business.Entities.Orden.Prioridades));
                this.cmbEntregaDomicilio.DataSource = Enum.GetNames(typeof(Orden.EntregasDomicilio));
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
            this.cmbEstado.SelectedIndex = cmbEstado.FindStringExact(Enum.GetName(OrdenActual.Estado));
            this.cmbPrioridad.SelectedIndex = cmbPrioridad.FindStringExact(Enum.GetName(OrdenActual.Prioridad));
            this.cmbEntregaDomicilio.SelectedIndex = cmbEntregaDomicilio.FindStringExact(Enum.GetName(OrdenActual.EntregaDomicilio));
            this.txtIdCliente.Text = OrdenActual.IdCliente.ToString();
            this.dtpFechaEntrega.Value = OrdenActual.FechaHoraEntregaIngresada.Date;
            this.nudHoraEntrega.Value = (decimal)OrdenActual.FechaHoraEntregaIngresada.Hour;
            if (OrdenActual.Cliente.Nombre != "" && OrdenActual.Cliente.Apellido != "" && OrdenActual.Cliente.RazonSocial == "")
            {
                this.txtNombreApellidoRazonSocial.Text = String.Concat(OrdenActual.Cliente.Nombre, " ", OrdenActual.Cliente.Apellido);
            }
            if (OrdenActual.Cliente.Nombre != "" && OrdenActual.Cliente.Apellido != "" && OrdenActual.Cliente.RazonSocial != "")
            {
                this.txtNombreApellidoRazonSocial.Text = String.Concat(OrdenActual.Cliente.Nombre, " ", OrdenActual.Cliente.Apellido, " / ", OrdenActual.Cliente.RazonSocial);
            }
            this.txtCuit.Text = OrdenActual.Cliente.Cuit;
            this.txtDireccion.Text = OrdenActual.Cliente.Direccion;
            this.dtpFechaIngreso.Value = OrdenActual.FechaEntrada.Date;
            //this.txtTiempoFinalizacionEstimado.Text = OrdenActual.TiempofinalizacionEstimado.Hours.ToString() + " : " + OrdenActual.TiempofinalizacionEstimado.Minutes.ToString();

            if (OrdenActual.FechaSalida != DateTime.MinValue) { this.dtpFechaSalida.Value = OrdenActual.FechaSalida.Date; }
            this.txtObservaciones.Text = OrdenActual.Observaciones;
            if (OrdenActual.Descuento != null)
            {
                if (OrdenActual.Descuento.StartsWith("%") == true)
                {
                    this.rbtnPorcentaje.Checked = true;
                    this.txtDescuento.Text = OrdenActual.Descuento.Remove(0, 1);
                }
                else if (Decimal.Parse(OrdenActual.Descuento) != 0)
                {
                    this.rbtnValor.Checked = true;
                    this.txtDescuento.Text = OrdenActual.Descuento;
                }
            }
            if (OrdenActual.Senia == true) { 
                Pago senia = OrdenActual.Factura.Pagos[0];
                if (senia is not null) 
                { 
                    this.txtSeniaOrden.Text = senia.Importe.ToString(); 
                    this.cbFormaPago.SelectedIndex = cbFormaPago.FindStringExact(Enum.GetName(OrdenActual.Factura.Pagos[0].FormaPago));
                } 
            }
            try
            {
                _itemsServicio = OrdenActual.ItemsPedidos;
                ListarItems();
                CalcularImporte();
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
                    this.txtDescuento.Enabled = false;
                    this.txtSeniaOrden.Enabled = false;
                    this.rbtnPorcentaje.Enabled = false;
                    this.rbtnValor.Enabled = false;
                    this.cmbEntregaDomicilio.Enabled = false;
                    this.cmbPrioridad.Enabled = false;
                    this.cmbEstado.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.btnAgregarItemOrden.Enabled = false;
                    this.btnEliminarItemOrden.Enabled = false;
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrenda.Enabled = false;
                    this.btnBuscar.Enabled = false;
                    this.btnAgregarCliente.Enabled = false;
                    ;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                OrdenActual = new Orden();
                if (this.txtIdCliente.Text == "") { MessageBox.Show("La orden debe tener un cliente", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { OrdenActual.Cliente = _clienteLogic.GetOne(Int32.Parse(this.txtIdCliente.Text)); }
                OrdenActual.Empleado = Singleton.getInstance().EmpleadoLogged;
                OrdenActual.Estado = Orden.Estados.Pendiente;
                OrdenActual.Prioridad = (Business.Entities.Orden.Prioridades)Enum.Parse(typeof(Business.Entities.Orden.Prioridades), cmbPrioridad.SelectedItem.ToString());
                OrdenActual.Observaciones = this.txtObservaciones.Text;
                OrdenActual.FechaEntrada = DateTime.Now;
                double HoraEntrega = ((double)nudHoraEntrega.Value);
                DateTime FechaHoraEntrega = dtpFechaEntrega.Value.Date;
                OrdenActual.FechaHoraEntregaIngresada = FechaHoraEntrega.AddHours(HoraEntrega);
                Descuento();
                OrdenActual.EntregaDomicilio= (Orden.EntregasDomicilio)Enum.Parse(typeof(Orden.EntregasDomicilio), cmbEntregaDomicilio.SelectedItem.ToString());
                FacturaActual = new Factura();
                if (txtSeniaOrden.Text != "")
                {
                    OrdenActual.Senia = true;
                    
                    FacturaActual.FechaFactura = DateTime.Now;
                    FacturaActual.Pagos = new List<Pago>();
                    PagoActual = new Pago();
                    PagoActual.FechaPago = DateTime.Now;
                    PagoActual.FormaPago = (Business.Entities.Pago.FormasPago)Enum.Parse(typeof(Business.Entities.Pago.FormasPago), cbFormaPago.SelectedItem.ToString()); ;
                    //PagoActual.FormaPago = (Pago.FormasPago)Enum.Parse(typeof(Business.Entities.Pago.FormasPago), "Seña");
                    PagoActual.Importe = double.Parse(txtSeniaOrden.Text);
                    FacturaActual.Pagos.Add(PagoActual);
                    
                }
                else
                {
                    
                    OrdenActual.Senia = false;
                }
                OrdenActual.Factura = FacturaActual;
                AsignarPrioridadItems();
                OrdenActual.ItemsPedidos = _itemsServicio;

            }
            if (Modos == ModoForm.Modificacion)
            {
                OrdenActual.Observaciones = this.txtObservaciones.Text;
                OrdenActual.EntregaDomicilio = (Orden.EntregasDomicilio)Enum.Parse(typeof(Orden.EntregasDomicilio), cmbEntregaDomicilio.SelectedItem.ToString());
                OrdenActual.Prioridad = (Business.Entities.Orden.Prioridades)Enum.Parse(typeof(Business.Entities.Orden.Prioridades), cmbPrioridad.SelectedItem.ToString());
                Descuento();
                AsignarPrioridadItems();
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

        private void rbtnPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            this.txtDescuento.Enabled = true;
            if (this.rbtnPorcentaje.Checked == true)
            {
                this.rbtnValor.Checked = false;
            }
            if (this.rbtnPorcentaje.Checked == true && this.txtDescuento.Text != "") 
            {
                CalcularImporte();
            }
        }

        private void rbtnValor_CheckedChanged(object sender, EventArgs e)
        {
            this.txtDescuento.Enabled = true;
            if (this.rbtnValor.Checked == true)
            {
                this.rbtnPorcentaje.Checked = false;
            }
            if (this.rbtnValor.Checked == true && this.txtDescuento.Text != "")
            {
                CalcularImporte();
            }
        }

        private void Descuento()
        {
            if (this.rbtnPorcentaje.Checked == true && this.txtDescuento.Text != "")
            {
                OrdenActual.Descuento = String.Concat("%", this.txtDescuento.Text);
            }
            else if (this.rbtnValor.Checked == true && this.txtDescuento.Text != "")
            {
                OrdenActual.Descuento = this.txtDescuento.Text;
            }
            else if (this.rbtnValor.Checked = false && this.rbtnValor.Checked == false && this.txtDescuento.Text == "")
            {
                OrdenActual.Descuento = "0";
            }
        }

        
        #region -------Cliente--------

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarCliente();
        }

        private void cargarCliente()
        {
            this.txtDireccion.Text = "";
            this.txtIdCliente.Text = "";
            this.txtNombreApellidoRazonSocial.Text = "";
            try
            {
                Cliente cli = _clienteLogic.GetOneConCuit(this.txtCuit.Text);
                if (cli == null)
                {
                   
                    Exception e = new Exception("No existe cliente para el cuit ingresado.");
                    throw e;
                    
                }
                if (cli.Nombre != "" && cli.Apellido != "" && cli.RazonSocial == "") 
                {
                    this.txtNombreApellidoRazonSocial.Text =String.Concat(cli.Nombre, " ",cli.Apellido);
                }
                if (cli.Nombre != "" && cli.Apellido != "" && cli.RazonSocial != "") 
                {
                    this.txtNombreApellidoRazonSocial.Text = String.Concat(cli.Nombre, " ", cli.Apellido, " / ",cli.RazonSocial);
                }
                this.txtIdCliente.Text = cli.IdCliente.ToString();
                this.txtDireccion.Text = cli.Direccion;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Cliente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ClienteDesktop frmCliente = new ClienteDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmCliente.ShowDialog();
        }
        #endregion

        #region ------- Items Orden -------

        public void ListarItems()
        {
            listItemsServicio.Items.Clear();

            if (OrdenActual is not null && OrdenActual.Estado == Orden.Estados.Pagado)
            {
                Pago pago = OrdenActual.Factura.Pagos.FindLast(delegate (Pago p) { return p.FechaPago <= DateTime.Now; });
                foreach (OrdenServicioTipoPrenda i in _itemsServicio)
                {
                    Precio precioActual = i.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                        delegate (Precio p)
                        {
                            return p.FechaDesde <= pago.FechaPago;
                        });
                    ListViewItem item = new ListViewItem((listItemsServicio.Items.Count + 1).ToString());
                    item.SubItems.Add(i.ServicioTipoPrenda.Servicio.Descripcion);
                    item.SubItems.Add(i.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    item.SubItems.Add(precioActual.Valor.ToString());
                    item.SubItems.Add(i.Estado.ToString());
                    listItemsServicio.Items.Add(item);
                }
            }
            else
            {
                foreach (OrdenServicioTipoPrenda i in _itemsServicio)
                {
                    Precio precioActual = i.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                        delegate (Precio p)
                        {
                            return p.FechaDesde <= DateTime.Now;
                        });
                    ListViewItem item = new ListViewItem((listItemsServicio.Items.Count + 1).ToString());
                    item.SubItems.Add(i.ServicioTipoPrenda.Servicio.Descripcion);
                    item.SubItems.Add(i.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    item.SubItems.Add(precioActual.Valor.ToString());
                    item.SubItems.Add(i.Estado.ToString());
                    listItemsServicio.Items.Add(item);
                }
            }
        }

        private void btnAgregarItemOrden_Click(object sender, EventArgs e)
        {
            try
            {
                Business.Entities.ServicioTipoPrenda servicioTp = _servicioTipoPrendaLogic.GetOne((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrenda.SelectedValue);
                if (servicioTp is null)
                {
                    MessageBox.Show("El servicio para el tipo de prenda seleccionado no es válido", "Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    /*
                    Exception r = new Exception("Error al recuperar el servicio tipo prenda.");
                    throw r;
                    */
                }
                else
                {
                    AgregarItem(servicioTp);
                    ListarItems();
                    CalcularImporte();
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "ItemServicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarItem(Business.Entities.ServicioTipoPrenda servicioTipoPrenda) 
        {
            OrdenServicioTipoPrenda itemActual = new OrdenServicioTipoPrenda();
            itemActual.ServicioTipoPrenda = servicioTipoPrenda;
            itemActual.Estado = OrdenServicioTipoPrenda.Estados.Pendiente;
            itemActual.OrdenItem = ContarItems(servicioTipoPrenda.IdServicio,servicioTipoPrenda.IdTipoPrenda);
            itemActual.Prioridad = (OrdenServicioTipoPrenda.Prioridades)servicioTipoPrenda.Prioridad;
            _itemsServicio.Add(itemActual);
        }

        private int ContarItems(int idServicio, int idTipoPrenda) 
        {
            if( _itemsServicio is null)
            {
                return 0;
            }
            else 
            {
                List<OrdenServicioTipoPrenda> items = _itemsServicio.FindAll(delegate (OrdenServicioTipoPrenda ostp)
                {
                    return ostp.ServicioTipoPrenda.IdServicio == idServicio && ostp.ServicioTipoPrenda.IdTipoPrenda == idTipoPrenda;
                });
                return items.Count;
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
                    o.Prioridad = OrdenServicioTipoPrenda.Prioridades.Estandar;
                }
            }
        }

        private void CalcularImporte()
        {
            _total = 0;
            if (OrdenActual is not null && OrdenActual.Estado == Orden.Estados.Pagado)
            {
                Pago pago = OrdenActual.Factura.Pagos.FindLast(delegate (Pago p) { return p.FechaPago <= DateTime.Now; });
                foreach (OrdenServicioTipoPrenda ostp in _itemsServicio)
                {
                    Precio pre = ostp.ServicioTipoPrenda.HistoricoPrecios.FindLast(delegate (Precio p)
                    {
                        return p.FechaDesde < pago.FechaPago;
                    });
                    _total += pre.Valor;
                }
            }
            else 
            {
                foreach (OrdenServicioTipoPrenda ostp in _itemsServicio)
                {
                    Precio precioActual = ostp.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                        delegate (Precio p)
                        {
                            return p.FechaDesde <= DateTime.Now;
                        });
                    _total += precioActual.Valor;
                }
            }
            if (this.rbtnPorcentaje.Checked == true && this.txtDescuento.Text != "")
            {
                if(Int32.Parse(this.txtDescuento.Text) > 0 && Int32.Parse(this.txtDescuento.Text) <= 100)
                {
                    _total *= (1 - (Double.Parse(this.txtDescuento.Text) / 100.0));
                }
                else
                {
                    MessageBox.Show("El porcentaje de descuento ingresado no se encuentra dentro del rango válido(0-100). Por favor, vuelva a ingresar un valor válido.", "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.rbtnValor.Checked == true && this.txtDescuento.Text != "")
            {
                if(double.Parse(this.txtDescuento.Text) <= _total)
                {
                    _total -= Int32.Parse(this.txtDescuento.Text);
                }
                else
                {
                    MessageBox.Show("El valor de descuento ingresado supera el monto de la Orden. Por favor, vuelva a ingresar un valor válido.", "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
            this.txtPrecioTotal.Text = _total.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_itemsServicio.Count > 1)
            {
                EliminarItem();
                CalcularImporte();
            }
            else 
            {
                MessageBox.Show("La orden debe contener por lo menos un servicio", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularImporte();
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
                        _itemsServicio.Remove(_itemDelete);
                        listItemsServicio.Items.Remove(listItemsServicio.SelectedItems[0]);
                    }
                    else
                    {
                        Exception r = new Exception("El item que quiere eliminar ya fue atendido o se encuentra en proceso de atención");
                        throw r;
                    }

                }
                else 
                {
                    MessageBox.Show("Seleccione un item de la lista para eliminar", "Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "ItemServicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public override bool Validar()
        {
            ValidationResult result = new OrdenValidator().Validate(OrdenActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion,"Orden",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {   
                if (this.txtDescuento.Text != "") 
                {
                    Validaciones.ValidarNumeroEnteroDecimal(this.txtDescuento.Text);

                }
                MapearADatos();
                if (Validar() && OrdenActual.Cliente is not null && OrdenActual.ItemsPedidos.Count > 0)
                {
                    _ordenLogic.Save(OrdenActual);
                    Close();
                }
                else 
                {
                    MessageBox.Show("La orden debe tener por lo menos un servicio requerido", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Exception r = new Exception("La orden que quiere eliminar ya esta finalizada o se encuentra en proceso de atención");
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
                        //PrintComprobante();
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea modificar la Orden?", "Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar la Orden - {OrdenActual.NroOrden}?", "Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Eliminar();
                            Close();
                        }
                    };
                    break;
                case ModoForm.Consulta:
                    Close();
                    break;
            }
        }
        
        public void PrintComprobante()
        {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Comprobante de lavado - {OrdenActual.NroOrden} - {DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";
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
                        negocio = negocioLogic.GetOne(1);
                        string comprobanteorden = Properties.Resources.comprobanteorden2.ToString();
                        comprobanteorden = comprobanteorden.Replace("@NombreLavanderia", negocio.NombreEmpresa);
                        comprobanteorden = comprobanteorden.Replace("@DireccionLav", negocio.DireccionEmpresa);
                        comprobanteorden = comprobanteorden.Replace("@TelLav", negocio.TelEmpresa);
                        comprobanteorden = comprobanteorden.Replace("@Redes", negocio.RedesEmpresa);
                        comprobanteorden = comprobanteorden.Replace("@NroOrden", OrdenActual.NroOrden.ToString());
                        comprobanteorden = comprobanteorden.Replace("@fechaentrada", OrdenActual.FechaEntrada.ToString());
                        comprobanteorden = comprobanteorden.Replace("@fecharetiro", OrdenActual.FechaSalida.ToString());
                        comprobanteorden = comprobanteorden.Replace("@cliente", OrdenActual.Cliente.Apellido + "," + OrdenActual.Cliente.Nombre);
                        comprobanteorden = comprobanteorden.Replace("@direccion", OrdenActual.Cliente.Direccion);
                        comprobanteorden = comprobanteorden.Replace("@telefono", OrdenActual.Cliente.Telefono);
                        comprobanteorden = comprobanteorden.Replace("@obs", OrdenActual.Observaciones);
                        if(OrdenActual.Descuento is not null)
                        {
                            comprobanteorden = comprobanteorden.Replace("@Desc", OrdenActual.Descuento);
                        }
                        else
                        {
                            comprobanteorden = comprobanteorden.Replace("@Desc", "0");
                        }

                        string items = string.Empty;
                        foreach (OrdenServicioTipoPrenda row in _itemsServicio)
                        {
                            items += "<tr>";
                            items += "<td align=" + "\"center\">" + row.OrdenItem + "</td>";
                            items += "<td align=" + "\"center\">" + row.ServicioTipoPrenda.Servicio.Descripcion + "</td>";
                            items += "<td align=" + "\"center\">" + row.ServicioTipoPrenda.TipoPrenda.Descripcion + "</td>";
                            items += "</tr>";
                        }
                        comprobanteorden = comprobanteorden.Replace("@items", items);
                        // falta condicion de si es null el listado de pagos pq falla con el count cuando no hay seña
                        if(OrdenActual.Factura is not null)
                        {
                            FacturaActual = _facturaLogic.GetOne(OrdenActual.NroFactura);
                            if (FacturaActual.Pagos.Count > 0)
                            {
                                comprobanteorden = comprobanteorden.Replace("@Seña", OrdenActual.Factura.Pagos[0].Importe.ToString());
                            }
                            else
                            {
                                comprobanteorden = comprobanteorden.Replace("@Seña", "0");
                            }
                        }
                        else
                        {
                            comprobanteorden = comprobanteorden.Replace("@Seña", "0");
                        }
                       


                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {

                            PdfWriter writer = new PdfWriter(stream);
                            PdfDocument pdf = new PdfDocument(writer);
                            pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4);
                            
                            using (StringReader sr = new StringReader(comprobanteorden))
                            {
                                Document document =  HtmlConverter.ConvertToDocument(comprobanteorden, writer);
                                document.Close();
                            }
                            stream.Close();
                        }

                            MessageBox.Show("Comprobante exportado exitosamente", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listItemsServicio_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {

            e.Cancel = true;
            e.NewWidth = listItemsServicio.Columns[e.ColumnIndex].Width;
        }

        private void txtSeniaOrden_TextChanged(object sender, EventArgs e)
        {
            if(this.txtSeniaOrden.Text != "" && double.Parse(this.txtSeniaOrden.Text) <= _total)
            {
                this.cbFormaPago.Enabled = true;
                this.cbFormaPago.DataSource = Enum.GetNames(typeof(Business.Entities.Pago.FormasPago));
            }
            else
            {
                MessageBox.Show("El valor de la seña ingresado es mayor al total de la Orden. Por favor, ingrese un valor válido para continuar.", "Senia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
