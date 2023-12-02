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
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.IO;

namespace UI.Desktop
{
    public partial class ReporteEnvioDomicilio : ApplicationForm
    {
        private OrdenLogic _ordenLogic;
        private LavanderiaContext _context;
        public double montoTotal;
        public List<Orden> ordenes;
        
        public ReporteEnvioDomicilio(LavanderiaContext context)
        {
            _context = context;
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            InitializeComponent();
            montoTotal = 0;
            ListarOrdenes();
            Singleton.getInstance().ListActual = this.listOrd;
            Singleton.getInstance().ModuloActual = "Envios a domicilio pendientes";
        }
        private void ListarOrdenes()
        {
            listOrd.Items.Clear();
            ordenes = _ordenLogic.GetAll().FindAll(
                delegate (Orden c)
                {
                   return c.EntregaDomicilio == Orden.EntregasDomicilio.Si && c.FechaSalida.Date.ToString() == "1/1/0001 00:00:00" && c.FechaHoraEntregaIngresada.Date <= DateTime.Now.Date;
                });
           


            if (ordenes is not null)
            {
                foreach (Orden o in ordenes)
                {
                    ListViewItem item = new ListViewItem();
                    if (o.Cliente.RazonSocial == "")
                    {
                        item.Text = item.Name = o.Cliente.Nombre + " " + o.Cliente.Apellido;

                    }
                    else
                    {
                        item.Text = o.Cliente.RazonSocial;
                    }
                    item.SubItems.Add(o.NroOrden.ToString());
                    item.SubItems.Add(o.FechaHoraEntregaIngresada.ToString("dd/MM/yyyy HH:mm:ss"));
                    string items = "";
                    int index = 1;
                    foreach(OrdenServicioTipoPrenda ostp in o.ItemsPedidos)
                    {
                        items += index + "-" + ostp.ServicioTipoPrenda.Servicio.Descripcion +" "+ ostp.ServicioTipoPrenda.TipoPrenda.Descripcion + "\n ";
                        index += 1;
                    }
                    item.SubItems.Add(items);
                    item.SubItems.Add(o.Cliente.Direccion.ToString());
                    item.SubItems.Add(o.Cliente.Telefono.ToString());
                    double deudas = 0;
                    double pagos = CalcularPagosOrden(o);
                    if (o.Factura.Importe == 0)
                    {
                        double importe = CalcularImporteOrden(o);
                       // item.SubItems.Add("$" + importe.ToString());
                        deudas = importe - pagos;
                        

                    }
                    else
                    {
                        //item.SubItems.Add("$" + o.Factura.Importe.ToString());
                        deudas = o.Factura.Importe - pagos;
                        
                    }
                    if(deudas != 0)
                    {
                        item.SubItems.Add("$" + deudas.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("Pagado");
                    }
                    // item.SubItems.Add("$" + pagos.ToString());
                    //item.SubItems.Add("$" + deudas.ToString());
                    // montoTotal1 += deudas;
                    listOrd.Items.Add(item);
                    
                    
                }
            }
            //SetListViewColumnSizes(listOrd, -2);
            //listOrd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listOrd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
           // montoTotal = montoTotal1;
        }
        // Set the listView's column sizes to the same value.
        private void SetListViewColumnSizes(ListView lvw, int width)
        {
            foreach (ColumnHeader col in lvw.Columns)
                col.Width = width;
        }
        private double CalcularImporteOrden(Orden ordenActual)
        {
            double importe = 0;
            if (ordenActual.Estado == Orden.Estados.Pagado || ordenActual.Factura.FechaFactura != DateTime.MinValue)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReporteGastos_Click(object sender, EventArgs e)
        {
            if (Singleton.getInstance().ListActual != null && Singleton.getInstance().ListActual.Items.Count > 0)
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

                                document.Add(pdfTable);
                                
                                document.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Reporte exportado exitosamente", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message,"Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros para exportar", "Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        private void listGastos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
        //    e.Cancel = true;
        //    e.NewWidth = listOrd.Columns[e.ColumnIndex].Width;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
