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
using MaterialSkin;
using MaterialSkin.Controls;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.IO;

namespace UI.Desktop
{
    public partial class ReporteDeudas : ApplicationForm
    {
        
        public Cliente ClienteActual { set; get; }
        public List<Cliente> clientes;
        public List<Orden> ordenes;
        public Factura facturaOrd;
        public List<Orden> ordenesDeuda;
        private readonly OrdenLogic _ordenLogic;
        private readonly ClienteLogic _clienteLogic;
        private readonly LavanderiaContext _context;
        public Cliente clienteActual;
        public double montoTotal;
        public ReporteDeudas(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            ordenes = _ordenLogic.GetAll();
            listarOrdenesCliente();
            Singleton.getInstance().ListActual = this.listOrdenesCliente;
            Singleton.getInstance().ModuloActual = "Deudas Clientes";
            
        }
        public ReporteDeudas(int IDCliente, LavanderiaContext context) : this(context)
        {
           
            listarOrdenesCliente();
            

        }
        public void OrdenesDeuda()
        {
            ordenesDeuda = ordenes.FindAll(
                delegate (Orden or)
                {
                    double pagos = 0;
                    if (or.Factura.Pagos is not null)
                    {
                        foreach (Pago p in or.Factura.Pagos)
                        {
                            pagos += p.Importe;
                        }
                    };
                    return or.Estado == Orden.Estados.Retirado && or.Factura.Pagos.Count <= 1 && or.Factura.Importe > pagos;
                });
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
        public void listarOrdenesCliente()
        {
            double montoTotal1=0;
            OrdenesDeuda();
            listOrdenesCliente.Items.Clear();
            foreach (Orden oc in ordenesDeuda)
            {
                ListViewItem item = new ListViewItem(oc.Cliente.Nombre + " " + oc.Cliente.Apellido);
                item.SubItems.Add(oc.NroOrden.ToString());
                item.SubItems.Add(oc.FechaSalida.ToString());
                item.SubItems.Add(oc.NroFactura.ToString());
                item.SubItems.Add(oc.Factura.Importe.ToString());
                double pagos = CalcularPagosOrden(oc);
                item.SubItems.Add(pagos.ToString());
                double deudas = oc.Factura.Importe - pagos;
                item.SubItems.Add(deudas.ToString());
                montoTotal1 += deudas;
                listOrdenesCliente.Items.Add(item);
            }
            montoTotal = montoTotal1;
        }

        private void btnReporteDeudas_Click(object sender, EventArgs e)
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
                            Table pdfTable = new Table(Singleton.getInstance().ListActual.Columns.Count);
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
                                foreach (ListViewItem.ListViewSubItem cell in row.SubItems)
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
                                Paragraph fecha = new Paragraph();
                                fecha.SetTextAlignment(TextAlignment.LEFT);
                                fecha.Add($"Fecha de emisión: {DateTime.Now} \n");
                                fecha.SetFontSize(9);
                                document.Add(fecha);
                                if(this.txtBuscar.Text != "")
                                {
                                    Paragraph cliente = new Paragraph();
                                    cliente.SetTextAlignment(TextAlignment.LEFT);
                                    cliente.Add($"Cliente: {clienteActual.Nombre}, {clienteActual.Apellido} \n");
                                    cliente.SetBold();
                                    cliente.SetFontSize(12);
                                    document.Add(cliente);
                                }
                                document.Add(pdfTable);
                                Paragraph Total = new Paragraph();
                                Total.SetTextAlignment(TextAlignment.RIGHT);
                                Total.Add($"Deuda Total: {montoTotal} \n");
                                Total.SetBold();
                                Total.SetUnderline();
                                Total.SetFontSize(12);
                                document.Add(Total);
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

        private void dtpFiltroDeuda_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaFiltro = dtpFiltroDeuda.Value;
            string fechaFiltro2 = fechaFiltro.ToString("yyyy/MM/dd");
            List<Orden> ordenesFiltro = ordenesDeuda.FindAll(
                delegate (Orden or)
                {
                    string fechaSalida = or.FechaSalida.ToString("yyyy/MM/dd");
                    return DateTime.Parse(fechaSalida) >= DateTime.Parse(fechaFiltro2);
                });
            listOrdenesCliente.Items.Clear();
            foreach (Orden oc in ordenesFiltro)
            {
                if(oc.Cliente.RazonSocial == "")
                {
                    ListViewItem item = new ListViewItem(oc.Cliente.Nombre + "-" + oc.Cliente.Apellido);
                    item.SubItems.Add(oc.NroOrden.ToString());
                    item.SubItems.Add(oc.FechaSalida.ToString());
                    if (oc.Factura is not null)
                    {
                        item.SubItems.Add(oc.NroFactura.ToString());
                        item.SubItems.Add(oc.Factura.Importe.ToString());
                        double pagos = CalcularPagosOrden(oc);
                        item.SubItems.Add(pagos.ToString());
                        double deudas = oc.Factura.Importe - pagos;
                        item.SubItems.Add(deudas.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("-");
                        item.SubItems.Add("-");
                        double pagos = CalcularPagosOrden(oc);
                        item.SubItems.Add(pagos.ToString());
                        item.SubItems.Add("Sin importe");
                    }
                    listOrdenesCliente.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(oc.Cliente.RazonSocial);
                    item.SubItems.Add(oc.NroOrden.ToString());
                    item.SubItems.Add(oc.FechaSalida.ToString());
                    if (oc.Factura is not null)
                    {
                        item.SubItems.Add(oc.NroFactura.ToString());
                        item.SubItems.Add(oc.Factura.Importe.ToString());
                        double pagos = CalcularPagosOrden(oc);
                        item.SubItems.Add(pagos.ToString());
                        double deudas = oc.Factura.Importe - pagos;
                        item.SubItems.Add(deudas.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("-");
                        item.SubItems.Add("-");
                        double pagos = CalcularPagosOrden(oc);
                        item.SubItems.Add(pagos.ToString());
                        item.SubItems.Add("Sin importe");
                    }
                    listOrdenesCliente.Items.Add(item);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listarOrdenesCliente();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            listOrdenesCliente.Items.Clear();
            double montoTotal2=0;
            foreach(Orden oc in ordenesDeuda)
            {
                if(oc.Cliente.Nombre.ToLower().Contains(this.txtBuscar.Text.ToLower()) || oc.Cliente.Apellido.ToLower().Contains(this.txtBuscar.Text.ToLower()))
                {
                    ListViewItem item = new ListViewItem(oc.Cliente.Nombre + " " + oc.Cliente.Apellido);
                    item.SubItems.Add(oc.NroOrden.ToString());
                    item.SubItems.Add(oc.FechaSalida.ToString());
                    item.SubItems.Add(oc.NroFactura.ToString());
                    item.SubItems.Add(oc.Factura.Importe.ToString());
                    double pagos = CalcularPagosOrden(oc);
                    item.SubItems.Add(pagos.ToString());
                    double deudas = oc.Factura.Importe - pagos;
                    item.SubItems.Add(deudas.ToString());
                    listOrdenesCliente.Items.Add(item);
                    clienteActual = oc.Cliente;
                    montoTotal2 += deudas;
                }
                else if(oc.Cliente.Cuit == this.txtBuscar.Text)
                {
                    ListViewItem item = new ListViewItem(oc.Cliente.Nombre + " " + oc.Cliente.Apellido);
                    item.SubItems.Add(oc.NroOrden.ToString());
                    item.SubItems.Add(oc.FechaSalida.ToString());
                    item.SubItems.Add(oc.NroFactura.ToString());
                    item.SubItems.Add(oc.Factura.Importe.ToString());
                    double pagos = CalcularPagosOrden(oc);
                    item.SubItems.Add(pagos.ToString());
                    double deudas = oc.Factura.Importe - pagos;
                    item.SubItems.Add(deudas.ToString());
                    listOrdenesCliente.Items.Add(item);
                    clienteActual = oc.Cliente;
                    montoTotal2 += deudas;
                }
            }
            montoTotal = montoTotal2;

            /*
            List<Orden> ordenesCliente = ordenesDeuda.FindAll(
                delegate (Orden or)
                {
                    return or.Cliente.Nombre.Contains(this.txtBuscar.Text) || or.Cliente.Apellido.Contains(this.txtBuscar.Text) || or.Cliente.Cuit.Contains(this.txtBuscar.Text);
                });
            listOrdenesCliente.Items.Clear();
            foreach (Orden oc in ordenesCliente)
            {
                if (oc.Cliente.RazonSocial == "")
                {
                    ListViewItem item = new ListViewItem(oc.Cliente.Nombre + "-" + oc.Cliente.Apellido);
                    item.SubItems.Add(oc.NroOrden.ToString());
                    item.SubItems.Add(oc.FechaSalida.ToString());
                    if (oc.Factura is not null)
                    {
                        item.SubItems.Add(oc.NroFactura.ToString());
                        item.SubItems.Add(oc.Factura.Importe.ToString());
                        double pagos = CalcularPagosOrden(oc);
                        item.SubItems.Add(pagos.ToString());
                        double deudas = oc.Factura.Importe - pagos;
                        item.SubItems.Add(deudas.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("-");
                        item.SubItems.Add("-");
                        double pagos = CalcularPagosOrden(oc);
                        item.SubItems.Add(pagos.ToString());
                        item.SubItems.Add("Sin importe");
                    }
                    listOrdenesCliente.Items.Add(item);
                }
            }
            */
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listOrdenesCliente_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listOrdenesCliente.Columns[e.ColumnIndex].Width;
        }
    }
}
