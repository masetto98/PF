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
    public partial class ReporteGastos : ApplicationForm
    {
        private GastoLogic _gastoLogic;
        private LavanderiaContext _context;
        public double montoTotal;
        public List<Gasto> gastos;
        public List<Gasto> gastosDesde;
        public List<Gasto> gastosHasta;
        public ReporteGastos(LavanderiaContext context)
        {
            _context = context;
            _gastoLogic = new GastoLogic(new GastoAdapter(context));
            InitializeComponent();
            montoTotal = 0;
            ListarGastos();
            Singleton.getInstance().ListActual = this.listGastos;
            Singleton.getInstance().ModuloActual = "Gastos";
        }
        private void ListarGastos()
        {
            listGastos.Items.Clear();
            gastos = _gastoLogic.GetAll();
            double montoTotal1 = 0;
            if (gastos is not null)
            {
                foreach (Gasto g in gastos)
                {
                    ListViewItem item = new ListViewItem(g.FechaRealizado.ToString());
                    item.SubItems.Add(g.TipoGasto.ToString());
                    item.SubItems.Add(g.Descripcion);
                    item.SubItems.Add(g.Importe.ToString());
                    listGastos.Items.Add(item);
                    montoTotal1 += g.Importe;
                }
            }
            montoTotal = montoTotal1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReporteGastos_Click(object sender, EventArgs e)
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
                                if(dtpFechaDesde.Value.ToString("yyyy/MM/dd") != DateTime.Now.ToString("yyyy/MM/dd"))
                                {
                                    Paragraph fechaDesde = new Paragraph();
                                    fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                    fechaDesde.Add($"Gastos desde: {dtpFechaDesde.Value} - hasta: {dtpFechaHasta.Value}\n");
                                    fechaDesde.SetFontSize(9);
                                    document.Add(fechaDesde);
                                }
                                
                                document.Add(pdfTable);
                                Paragraph Total = new Paragraph();
                                Total.SetTextAlignment(TextAlignment.RIGHT);
                                Total.Add($"Monto Total: {montoTotal} \n");
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

        private void dtpFechaDesde_CloseUp(object sender, EventArgs e)
        {
            double montoTotal2 = 0;
            DateTime fechaDesde = dtpFechaDesde.Value;
            string fechaDesde2 = fechaDesde.ToString("yyyy/MM/dd");
            gastosDesde = gastos.FindAll(
                delegate (Gasto g)
                {
                    string fechaRealizado = g.FechaRealizado.ToString("yyyy/MM/dd");
                    return DateTime.Parse(fechaRealizado) >= DateTime.Parse(fechaDesde2);
                });
            listGastos.Items.Clear();
            if (gastosDesde is not null)
            {
                foreach (Gasto g in gastosDesde)
                {
                    ListViewItem item = new ListViewItem(g.FechaRealizado.ToString());
                    item.SubItems.Add(g.TipoGasto.ToString());
                    item.SubItems.Add(g.Descripcion);
                    item.SubItems.Add(g.Importe.ToString());
                    listGastos.Items.Add(item);
                    montoTotal2 += g.Importe;
                }
            }
            montoTotal = montoTotal2;
        }

        private void dtpFechaHasta_CloseUp(object sender, EventArgs e)
        {
            double montoTotal3 = 0;
            DateTime fechaHasta = dtpFechaHasta.Value;
            string fechaHasta2 = fechaHasta.ToString("yyyy/MM/dd");
            if(gastosDesde is not null)
            {
              gastosHasta = gastosDesde.FindAll(
              delegate (Gasto g)
              {
                  string fechaRealizado = g.FechaRealizado.ToString("yyyy/MM/dd");
                  return DateTime.Parse(fechaRealizado) <= DateTime.Parse(fechaHasta2);
              });
            }
            else
            {
                gastosHasta = gastos.FindAll(
               delegate (Gasto g)
               {
                   string fechaRealizado = g.FechaRealizado.ToString("yyyy/MM/dd");
                   return DateTime.Parse(fechaRealizado) <= DateTime.Parse(fechaHasta2);
               });
            }
            listGastos.Items.Clear();
            if (gastosHasta is not null)
            {
                foreach (Gasto g in gastosHasta)
                {
                    ListViewItem item = new ListViewItem(g.FechaRealizado.ToString());
                    item.SubItems.Add(g.TipoGasto.ToString());
                    item.SubItems.Add(g.Descripcion);
                    item.SubItems.Add(g.Importe.ToString());
                    listGastos.Items.Add(item);
                    montoTotal3 += g.Importe;
                }
            }
            montoTotal = montoTotal3;
        }

        private void listGastos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listGastos.Columns[e.ColumnIndex].Width;
        }
    }
}
