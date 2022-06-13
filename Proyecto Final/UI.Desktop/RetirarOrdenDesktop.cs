using Business.Entities;
using Business.Logic;
using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Html2pdf;
using iText.Pdfa;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.IO;
using iText.IO.Image;

namespace UI.Desktop
{
    public partial class RetirarOrdenDesktop : ApplicationForm
    {
        private readonly LavanderiaContext _context;
        public Orden OrdenActual { set; get; }
        public Factura FacturaActual { set; get; }
        public AtributosNegocio negocio { set; get; }
        private readonly AtributosNegocioLogic _atributosLogic;
        private readonly FacturaLogic _facturaLogic;
        private readonly OrdenLogic _ordenLogic;
        public List<OrdenServicioTipoPrenda> _itemsServicio;
        public double _total;
        public RetirarOrdenDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            _atributosLogic = new AtributosNegocioLogic(new AtributosNegocioAdapter(context));
            _itemsServicio = new List<OrdenServicioTipoPrenda>();
        }
        public RetirarOrdenDesktop(int nroOrden, ModoForm modo, LavanderiaContext context) : this(context)
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
            this.txtCuitRetiro.Text = OrdenActual.Cliente.Cuit.ToString();
            this.txtApellidoRetiro.Text = OrdenActual.Cliente.Apellido;
            this.txtNombreRetiro.Text = OrdenActual.Cliente.Nombre;
            this.txtRazonSocialRetiro.Text = OrdenActual.Cliente.RazonSocial;
            this.txtNroOrdenRetiro.Text = OrdenActual.NroOrden.ToString();
            this.txtEstadoRetiro.Text = OrdenActual.Estado.ToString();
            this.txtFechaEntradaRetiro.Text = OrdenActual.FechaEntrada.Date.ToString();
            try
            {
                _itemsServicio = OrdenActual.ItemsPedidos;
                ListarItems();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:


                    break;
                case ModoForm.Modificacion:
                    if (OrdenActual.Estado == Orden.Estados.Retirado)
                    {
                        this.btnRetirar.Enabled = false;
                    }
                    this.txtCuitRetiro.Enabled = false;
                    this.txtApellidoRetiro.Enabled = false;
                    this.txtNombreRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtFechaEntradaRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtNroOrdenRetiro.Enabled = false;
                    this.txtTotalFactura.Enabled = false;
                    this.txtRazonSocialRetiro.Enabled = false;
                    break;
                case ModoForm.Baja:

                    break;
                case ModoForm.Consulta:

                    this.txtCuitRetiro.Enabled = false;
                    this.txtApellidoRetiro.Enabled = false;
                    this.txtNombreRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtFechaEntradaRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtNroOrdenRetiro.Enabled = false;
                    this.txtTotalFactura.Enabled = false;
                    this.txtRazonSocialRetiro.Enabled = false;
                    ;
                    break;
            }
        }
        public void ListarItems()
        {
            listItemsRetiro.Items.Clear();
            foreach (OrdenServicioTipoPrenda i in _itemsServicio)
            {
                Precio precioActual = i.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde <= DateTime.Today;
                    });
                ListViewItem item = new ListViewItem(i.ServicioTipoPrenda.Servicio.Descripcion);
                item.SubItems.Add(i.ServicioTipoPrenda.TipoPrenda.Descripcion);
                item.SubItems.Add(i.Estado.ToString());
                item.SubItems.Add(precioActual.Valor.ToString());
                listItemsRetiro.Items.Add(item);
                _total += precioActual.Valor;
                this.txtTotalFactura.Text = _total.ToString();
            }
        }

        private void btnPagoRetirar_Click(object sender, EventArgs e)
        {
            FacturaActual = _facturaLogic.GetOne(OrdenActual.NroFactura);
            if (FacturaActual.Pagos.Count > 0)
            {
                PagoDesktop frmPago = new PagoDesktop(OrdenActual, ApplicationForm.ModoForm.Modificacion, _context);
                frmPago.ShowDialog();
            }
            else
            {
                PagoDesktop frmPago = new PagoDesktop(OrdenActual, ApplicationForm.ModoForm.Alta, _context);
                frmPago.ShowDialog();
            }
            this.txtEstadoRetiro.Text = OrdenActual.Estado.ToString();
            if (this.OrdenActual.Estado == Orden.Estados.Pagado)
            {
                this.btnRetirar.Enabled = true;
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (OrdenActual.Estado == Orden.Estados.Pagado)
            {
                OrdenActual.Estado = Orden.Estados.Retirado;
                OrdenActual.FechaSalida = DateTime.Now;
                OrdenActual.State = BusinessEntity.States.Modified;
                _ordenLogic.Save(OrdenActual);
                Close();

            }
            else if(MessageBox.Show("Aún no se han completado los pagos correspondientes ¿Desea continuar con el retiro de la orden?", "Retirar Orden", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OrdenActual.Estado = Orden.Estados.Retirado;
                OrdenActual.FechaSalida = DateTime.Now;
                OrdenActual.State = BusinessEntity.States.Modified;
                _ordenLogic.Save(OrdenActual);
                Close();
            }

        }

        private void btnCancelarRetiro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImpFactura_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = $"Factura - {OrdenActual.NroFactura} - {DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";
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
                        
                        negocio = _atributosLogic.GetOne(1);
                        string factura = Properties.Resources.factura3.ToString();
                        factura = factura.Replace("@nombrempresa", negocio.NombreEmpresa);
                        factura = factura.Replace("@direccionempresa", negocio.DireccionEmpresa);
                        factura = factura.Replace("@telempresa", negocio.TelEmpresa);
                        factura = factura.Replace("@redes", negocio.RedesEmpresa);
                        factura = factura.Replace("@nrofactura", OrdenActual.NroFactura.ToString());
                        factura = factura.Replace("@fechafactura", OrdenActual.Factura.FechaFactura.ToString("dd/MM/yyyy"));
                        factura = factura.Replace("@hsfactura", OrdenActual.Factura.FechaFactura.ToString("HH:mm:ss"));
                        factura = factura.Replace("@fechaentrada", OrdenActual.FechaEntrada.ToString("dd/MM/yyyy"));
                        factura = factura.Replace("@nrorden", OrdenActual.NroOrden.ToString());
                        factura = factura.Replace("@cuit", OrdenActual.Cliente.Cuit);
                        factura = factura.Replace("@nombre", OrdenActual.Cliente.Apellido + "," + OrdenActual.Cliente.Nombre);
                        factura = factura.Replace("@direcli", OrdenActual.Cliente.Direccion);
                        factura = factura.Replace("@telcli", OrdenActual.Cliente.Telefono);
                        string items = string.Empty;
                        foreach (OrdenServicioTipoPrenda row in _itemsServicio)
                        {
                            items += "<tr>";
                            items += "<td align="+ "\"center\">" + row.OrdenItem + "</td>";
                            items += "<td align=" + "\"center\">" + row.ServicioTipoPrenda.Servicio.Descripcion + "</td>";
                            items += "<td align=" + "\"center\">" + row.ServicioTipoPrenda.TipoPrenda.Descripcion + "</td>";
                            items += "<td align=" + "\"center\">" + row.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                                                                                delegate (Precio p)
                                                                                {
                                                                                    return p.FechaDesde <= DateTime.Today;
                                                                                }).Valor.ToString() + "</td>";
                            items += "</tr>";
                        }
                        factura = factura.Replace("@items", items);
                        factura = factura.Replace("@totalitems", _total.ToString());
                        // falta condicion de si es null el listado de pagos pq falla con el count cuando no hay seña
                        double totalfactura;
                        FacturaActual = _facturaLogic.GetOne(OrdenActual.NroFactura);
                        if (FacturaActual.Pagos.Count > 0)
                            
                        {
                            factura = factura.Replace("@Seña", OrdenActual.Factura.Pagos[0].Importe.ToString());
                            totalfactura = _total - OrdenActual.Factura.Pagos[0].Importe;
                            factura = factura.Replace("@totalfact", totalfactura.ToString());
                        }
                        else
                        {
                            factura = factura.Replace("@Seña", "0");
                            totalfactura = _total;
                            factura = factura.Replace("@totalfact", totalfactura.ToString());
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
                            
                            //Paragraph p = new Paragraph();
                            //p.SetTextAlignment(TextAlignment.CENTER);
                            //p.Add($"Reporte de {Singleton.getInstance().ModuloActual} \n");
                            //p.SetBold();
                            //p.SetUnderline();
                            //p.SetFontSize(18);
                            using (StringReader sr = new StringReader(factura))
                            {
                                Document document = HtmlConverter.ConvertToDocument(factura, writer);
                                
                                ImageData imageData = ImageDataFactory.Create("D:\\Proyectos\\PF\\Proyecto Final\\UI.Desktop\\Resources\\logo_lavadero_elsol.png");
                                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(imageData);
                               // iText.Kernel.Geom.Rectangle pagesize = document.GetPdfDocument().GetDefaultPageSize().;
                                logo.ScaleToFit(300, 170);
                                //logo.SetRelativePosition(document.GetLeftMargin(), document.GetTopMargin() - 80,document.GetRightMargin(),document.GetBottomMargin());
                                float top = document.GetPdfDocument().GetDefaultPageSize().GetTop();
                                float dif = top - 170;
                                logo.SetFixedPosition(document.GetLeftMargin(), dif);
                                document.Add(logo);
                                document.Close();
                            }
                            stream.Close();
                        }

                        MessageBox.Show("La factura fue generada correctamente", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
