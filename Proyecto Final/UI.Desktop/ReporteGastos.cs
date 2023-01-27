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
                                if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
                                {
                                    if (dtpFechaDesde.Value.Date != DateTime.Now.Date)
                                    {
                                        Paragraph fechaDesde = new Paragraph();
                                        fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                        fechaDesde.Add($"El Reporte abarca desde: {dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")} - hasta: {dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")}\n");
                                        fechaDesde.SetFontSize(9);
                                        document.Add(fechaDesde);
                                    }
                                    else
                                    {
                                        Paragraph fechaDesde = new Paragraph();
                                        fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                        fechaDesde.Add($"El Reporte abarca hasta: {dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")}\n");
                                        fechaDesde.SetFontSize(9);
                                        document.Add(fechaDesde);
                                    }

                                }
                                else
                                {
                                    Paragraph fechaDesde = new Paragraph();
                                    fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                    fechaDesde.Add($"El Reporte abarca desde: {dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")}\n");
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
        private void listarGastosFiltro(List<Gasto> gastosFiltro)
        {
            double montoTotal2 = 0;
            listGastos.Items.Clear();
            if (gastosFiltro is not null)
            {
                foreach (Gasto g in gastosFiltro)
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

        private void listGastos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listGastos.Columns[e.ColumnIndex].Width;
        }
        private void filtroFecha()
        {
            List<Gasto> gastosFiltro = new List<Gasto>();
            if(dtpFechaHasta.Value.Date != DateTime.Now.Date)
            {
                if(dtpFechaDesde.Value.Date != DateTime.Now.Date)
                {
                    
                    gastosFiltro = gastos.FindAll(
                                    delegate (Gasto g)
                                    {
                                        return g.FechaRealizado.Date >= dtpFechaDesde.Value.Date && g.FechaRealizado.Date <= dtpFechaHasta.Value.Date;
                                    });
                    listarGastosFiltro(gastosFiltro);
                }
                else
                {
                    gastosFiltro = gastos.FindAll(
                                  delegate (Gasto g)
                                  {
                                      return g.FechaRealizado.Date <= dtpFechaHasta.Value.Date;
                                  });
                    listarGastosFiltro(gastosFiltro);
                }
            }
            else
            {
                gastosFiltro = gastos.FindAll(
                                  delegate (Gasto g)
                                  {
                                      return g.FechaRealizado.Date >= dtpFechaDesde.Value.Date;
                                  });
                listarGastosFiltro(gastosFiltro);
            }
        }
        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            filtroFecha();
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            filtroFecha();
            
        }
    }
}
