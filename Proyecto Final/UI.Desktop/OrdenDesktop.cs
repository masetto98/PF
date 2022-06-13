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
                FacturaActual = new Factura();
                FacturaActual.FechaFactura = DateTime.Now;
                //FacturaActual.Importe = null;
                if (txtSeniaOrden.Text != "")
                {
                    PagoActual = new Pago();
                    PagoActual.FechaPago = DateTime.Now;
                    PagoActual.FormaPago = (Pago.FormasPago)Enum.Parse(typeof(Business.Entities.Pago.FormasPago), "Seña");
                    PagoActual.Importe = double.Parse(txtSeniaOrden.Text);
                    FacturaActual.Pagos = new List<Pago>();
                    FacturaActual.Pagos.Add(PagoActual);
                }
                
                OrdenActual.Factura = FacturaActual;
                //_facturaLogic.GetOne(1);
                OrdenActual.FechaEntrada = DateTime.Now;
                //OrdenActual.FechaSalida = (DateTime)dtpFechaSalida.MaxDate;
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
        /*
        private void txtCuit_Leave(object sender, EventArgs e)
        {
            cargarCliente();
        }*/

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
        private void AgregarItem(Business.Entities.ServicioTipoPrenda servicioTipoPrenda) 
        {
            OrdenServicioTipoPrenda itemActual = new OrdenServicioTipoPrenda();
            itemActual.ServicioTipoPrenda = servicioTipoPrenda;
            itemActual.Estado = OrdenServicioTipoPrenda.Estados.Pendiente;
            itemActual.OrdenItem = ContarItems(servicioTipoPrenda.IdServicio,servicioTipoPrenda.IdTipoPrenda);
            itemActual.Prioridad = (OrdenServicioTipoPrenda.Prioridades)servicioTipoPrenda.Prioridad;
            itemActual.FechaCambioPrioridad = DateTime.Now;
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
                        return p.FechaDesde <= DateTime.Today;
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
                Business.Entities.ServicioTipoPrenda servicioTp = _servicioTipoPrendaLogic.GetOne((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrenda.SelectedValue);
                if (servicioTp == null)
                {
                    Exception r = new Exception("Error al recuperar el servicio tipo prenda.");
                    throw r;
                }
                else 
                {
                    AgregarItem(servicioTp);
                    Precio precioActual = servicioTp.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde <= DateTime.Today;
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
                        PrintComprobante();
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        GuardarCambios();
                    };
                    break;
                case ModoForm.Baja:
                    {
                        Eliminar();
                        Close();
                    }
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
                        if(OrdenActual.Factura.Pagos.Count > 0)
                        {
                            comprobanteorden = comprobanteorden.Replace("@Seña", OrdenActual.Factura.Pagos[0].Importe.ToString());
                        }
                        else
                        {
                            comprobanteorden = comprobanteorden.Replace("@Seña", "0");
                        }
                        /*Table pdfTable = new Table(4);
                            pdfTable.SetPadding(3);
                            pdfTable.SetWidth(UnitValue.CreatePercentValue(100));
                            pdfTable.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        */


                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                PdfWriter writer = new PdfWriter(stream);
                                PdfDocument pdf = new PdfDocument(writer);
                                pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4);
                            //document.SetMargins(10f, 20f, 20f, 10f);
                            //Paragraph p = new Paragraph();
                            //p.SetTextAlignment(TextAlignment.CENTER);
                            //p.Add($"Reporte de {Singleton.getInstance().ModuloActual} \n");
                            //p.SetBold();
                            //p.SetUnderline();
                            //p.SetFontSize(18);
                            using (StringReader sr = new StringReader(comprobanteorden))
                            {
                                Document document =  HtmlConverter.ConvertToDocument(comprobanteorden, writer);
                                document.Close();
                            }
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
            
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
