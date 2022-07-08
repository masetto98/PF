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
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.IO;

namespace UI.Desktop
{
    public partial class Caja : ApplicationForm
    {
        private readonly OrdenLogic _ordenLogic;
        private readonly GastoLogic _gastoLogic;



        public Caja(LavanderiaContext context)
        {
            InitializeComponent();
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _gastoLogic = new GastoLogic(new GastoAdapter(context));
            Singleton.getInstance().ListActual = this.listOrdenes;
            Singleton.getInstance().ListAlternativa = this.listGastos;
            Singleton.getInstance().ModuloActual = "Caja";
            this.dtpFecha.Value = DateTime.Today;
            ActualizarInformacion();
        }

        private void ActualizarInformacion() 
        {
            ListarOrdenes();
            ListarGastos();
            //SaldoAnterior();
            IngresosDelDia();
            GastosDelDia();
            double ingresos = Double.Parse(this.lblIngresosDia.Text.Remove(0, 2));
            double gastos = Double.Parse(this.lblSalidasDia.Text.Remove(0, 2));
            double balance = ingresos - gastos;
            this.lblBalanceHoy.Text = String.Concat("$ ", balance.ToString());
        }

        private void ListarOrdenes() 
        {
            List<Orden> ordenes = _ordenLogic.GetAll().FindAll(delegate (Orden o)
            { return o.FechaSalida.Date == this.dtpFecha.Value.Date; });
            if (ordenes is not null) 
            {
                listOrdenes.Items.Clear();
                foreach (Orden o in ordenes) 
                {
                    double ingresos = 0;
                    if (o.Factura is not null && o.Factura.Pagos is not null) 
                    {
                        foreach (Pago p in o.Factura.Pagos) 
                        {
                            if (p.FechaPago.Date == this.dtpFecha.Value.Date) 
                            {
                                ingresos += p.Importe;
                            }
                        }
                    }
                    ListViewItem item = new ListViewItem(o.NroFactura.ToString());
                    item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(ingresos.ToString());
                    listOrdenes.Items.Add(item);
                }
            }
        }

        private void ListarGastos() 
        {
            listGastos.Items.Clear();
            List<Gasto> gastos = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date == this.dtpFecha.Value.Date; });
            if (gastos is not null)
            {
                foreach (Gasto g in gastos)
                {
                    ListViewItem item = new ListViewItem(g.TipoGasto.ToString());
                    item.SubItems.Add(g.Descripcion);
                    item.SubItems.Add(g.FechaRealizado.ToString());
                    item.SubItems.Add(g.Importe.ToString());
                    listGastos.Items.Add(item);
                }
            }
        }
        /*
        private void SaldoAnterior() 
        {
            double cajaUltimoDia = 0.0;
            DateTime FechaUltimaActividad = DateTime.MinValue;
            Orden ultimaOrden = _ordenLogic.GetAll().FindLast(delegate (Orden o) { return o.FechaSalida>this.dtpFecha.Value.Date;});
            Gasto ultimoGasto = _gastoLogic.GetAll().FindLast(delegate (Gasto g) { return g.FechaRealizado > this.dtpFecha.Value.Date; });
            if (ultimoGasto is null ||ultimaOrden.FechaSalida.Date >= ultimoGasto.FechaRealizado.Date) { FechaUltimaActividad = ultimaOrden.FechaSalida.Date; }
            else if (ultimaOrden is null ||ultimaOrden.FechaSalida.Date < ultimoGasto.FechaRealizado.Date) { FechaUltimaActividad = ultimoGasto.FechaRealizado.Date; }
            else { MessageBox.Show("No existen Ingresos o Gastos en esa fecha","Caja",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            if (FechaUltimaActividad != DateTime.MinValue ) 
            {
                List<Orden> ordenesUltimoDia = _ordenLogic.GetAll().FindAll(delegate (Orden o) { return o.FechaSalida == FechaUltimaActividad; });
                foreach (Orden o in ordenesUltimoDia) 
                {
                    if (o.Factura is not null && o.Factura.Pagos is not null) 
                    {
                        foreach (Pago p in o.Factura.Pagos) 
                        {
                            cajaUltimoDia += p.Importe;
                        }
                    }
                }
                List<Gasto> gastosUltimoDia = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado == FechaUltimaActividad; });
                if (gastosUltimoDia is not null) 
                {
                    foreach (Gasto g in gastosUltimoDia) 
                    {
                        cajaUltimoDia += g.Importe;
                    }
                }
                this.lblSaldoAnterior.Text = String.Concat("$ ",cajaUltimoDia.ToString());
            }
        }*/

        private void IngresosDelDia() 
        {
            double ingresosHoy = 0.0;
            List<Orden> ordenesHoy= _ordenLogic.GetAll().FindAll(delegate (Orden o) { return o.FechaSalida.Date == this.dtpFecha.Value.Date;});
            if (ordenesHoy is not null)
            {
                foreach (Orden o in ordenesHoy)
                {
                    if (o.Factura is not null && o.Factura.Pagos is not null)
                    {
                        foreach (Pago p in o.Factura.Pagos)
                        {
                            if (p.FechaPago.Date == this.dtpFecha.Value.Date)
                            {
                                ingresosHoy += p.Importe;
                            }
                        }
                    }
                }
                this.lblIngresosDia.Text = String.Concat("$ ", ingresosHoy.ToString());
            }
        }

        private void GastosDelDia() 
        {
            double gastos = 0.0;
            List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date == this.dtpFecha.Value.Date; });
            if (gastosHoy is not null) 
            {
                foreach (Gasto g in gastosHoy)
                {
                    gastos += g.Importe;
                }
                this.lblSalidasDia.Text = String.Concat("$ ", gastos.ToString());
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarInformacion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listOrdenes_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listOrdenes.Columns[e.ColumnIndex].Width;
        }

        private void listGastos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listGastos.Columns[e.ColumnIndex].Width;
        }

        private void btnReporteCaja_Click(object sender, EventArgs e)
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
                            float[] pointColumnWidths = { 150F, 150F };
                            Table tablacaja = new Table(pointColumnWidths);
                            tablacaja.SetPadding(3);
                            tablacaja.SetWidth(UnitValue.CreatePercentValue(100));
                            tablacaja.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                            tablacaja.AddCell("Total Ingresos");
                            tablacaja.AddCell(this.lblIngresosDia.Text);
                            tablacaja.AddCell("Total Gastos");
                            tablacaja.AddCell(this.lblSalidasDia.Text);
                            tablacaja.AddCell("Balance Total");
                            tablacaja.AddCell(this.lblBalanceHoy.Text);
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
                            Table pdfTable2 = new Table(Singleton.getInstance().ListAlternativa.Columns.Count);
                            pdfTable2.SetPadding(3);
                            pdfTable2.SetWidth(UnitValue.CreatePercentValue(100));
                            pdfTable2.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                            foreach (ColumnHeader column in Singleton.getInstance().ListAlternativa.Columns)
                            {

                                Cell cell = new Cell().Add(new Paragraph(column.Text).SetBold());
                                cell.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                                cell.SetTextAlignment(TextAlignment.CENTER);
                                pdfTable2.AddCell(cell);

                            }

                            foreach (ListViewItem row in Singleton.getInstance().ListAlternativa.Items)
                            {
                                foreach (ListViewItem.ListViewSubItem cell in row.SubItems)
                                {
                                    pdfTable2.AddCell(cell.Text);
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
                                document.Add(tablacaja);
                                document.Add(pdfTable);
                                document.Add(pdfTable2);
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
    }
}
