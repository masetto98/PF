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
using FastReport.DataVisualization.Charting;

namespace UI.Desktop
{
    public partial class Caja : ApplicationForm
    {
        private readonly OrdenLogic _ordenLogic;
        private readonly GastoLogic _gastoLogic;
        private readonly FacturaLogic _facturaLogic;



        public Caja(LavanderiaContext context)
        {
            InitializeComponent();
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _gastoLogic = new GastoLogic(new GastoAdapter(context));
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            Singleton.getInstance().ListActual = this.listOrdenes;
            Singleton.getInstance().ListAlternativa = this.listGastos;
            Singleton.getInstance().ModuloActual = "Caja";
            this.dtpFecha.Value = DateTime.Today;
            this.dtpFechaHasta.Value = DateTime.Today;
            ActualizarInformacion();
            chartGastos.BackColor = Color.Transparent;
            chartIngresos.BackColor = Color.Transparent;
            chartGastos.ChartAreas[0].BackColor = Color.Transparent;
            chartIngresos.ChartAreas[0].BackColor = Color.Transparent;
            
        }
        private void CargarSeriesGrafico()
        {
            if(dtpFechaHasta.Value.Date != DateTime.Now.Date)
            {
                if (dtpFecha.Value.Date != DateTime.Now.Date)
                {
                    string[] tiposgasto = Enum.GetNames(typeof(Gasto.TiposGasto));
                    chartGastos.Series["Gastos"].Points.Clear();
                    for (int x = 0; x < tiposgasto.Length; x++)
                    {
                        List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date && g.FechaRealizado.Date <= dtpFechaHasta.Value.Date && g.TipoGasto.ToString() == tiposgasto[x]; });
                        double gastos = 0;
                        if (gastosHoy is not null)
                        {
                            foreach (Gasto g in gastosHoy)
                            {
                                gastos += g.Importe;

                            }
                        }
                        chartGastos.Series["Gastos"].Points.Add(gastos);
                        chartGastos.Series["Gastos"].Points[x].AxisLabel = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].LegendText = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].Label = gastos.ToString();
                    }


                    List<Factura> facturasHoy = _facturaLogic.GetAll().FindAll(delegate (Factura f) { return f.FechaFactura.Date <= this.dtpFechaHasta.Value.Date && f.FechaFactura.Date <= this.dtpFechaHasta.Value.Date && f.Pagos is not null; });
                    
                    if (facturasHoy is not null)
                    {
                        List<Factura> facturasOrd = facturasHoy.OrderBy(x => x.FechaFactura.Date).ToList();
                        chartIngresos.Series["Ingresos"].Points.Clear();
                        foreach (Factura f in facturasOrd)
                        {
                            double ingresosHoy = 0;
                            if (f.Pagos.Count > 1)
                            {
                                for (int x = 0; x < f.Pagos.Count; x++)
                                {
                                    if (f.Pagos[x].FechaPago.Date >= this.dtpFecha.Value.Date && f.Pagos[x].FechaPago.Date <= this.dtpFechaHasta.Value.Date)
                                    {
                                        if (x != (f.Pagos.Count - 1))
                                        {
                                            if (f.Pagos[x].FechaPago.Date == f.Pagos[x + 1].FechaPago.Date)
                                            {
                                                ingresosHoy += f.Pagos[x].Importe;
                                                ingresosHoy += f.Pagos[x + 1].Importe;
                                                x += 1;
                                            }
                                            else
                                            {
                                                chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[x].FechaPago.Date, f.Pagos[x].Importe);
                                            }
                                        }
                                        else
                                        {
                                            ingresosHoy += f.Pagos[x].Importe;
                                            chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[x].FechaPago.Date, ingresosHoy);

                                        }

                                    }
                                }
                            }
                            else
                            {
                                if (f.Pagos.Count!=0 && f.Pagos[0].FechaPago.Date >= this.dtpFecha.Value.Date && f.Pagos[0].FechaPago.Date <= this.dtpFechaHasta.Value.Date)
                                {
                                    chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[0].FechaPago.Date, f.Pagos[0].Importe);
                                }
                            }
                        }

                    }
                }
                else
                {
                    string[] tiposgasto = Enum.GetNames(typeof(Gasto.TiposGasto));
                    chartGastos.Series["Gastos"].Points.Clear();
                    for (int x = 0; x < tiposgasto.Length; x++)
                    {
                        List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date <= dtpFechaHasta.Value.Date && g.TipoGasto.ToString() == tiposgasto[x]; });
                        double gastos = 0;
                        if (gastosHoy is not null)
                        {
                            foreach (Gasto g in gastosHoy)
                            {
                                gastos += g.Importe;

                            }
                        }
                        chartGastos.Series["Gastos"].Points.Add(gastos);
                        chartGastos.Series["Gastos"].Points[x].AxisLabel = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].LegendText = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].Label = gastos.ToString();
                    }

                    List<Factura> facturasHoy = _facturaLogic.GetAll().FindAll(delegate (Factura f) { return f.FechaFactura.Date <= this.dtpFechaHasta.Value.Date && f.Pagos is not null; });
                    if (facturasHoy is not null)
                    {
                        List<Factura> facturasOrd = facturasHoy.OrderBy(x => x.FechaFactura.Date).ToList();
                        chartIngresos.Series["Ingresos"].Points.Clear();
                        foreach (Factura f in facturasOrd)
                        {
                            double ingresosHoy = 0;
                            if (f.Pagos is not null && f.Pagos.Count > 1)
                            {
                                for (int x = 0; x < f.Pagos.Count; x++)
                                {
                                    if (f.Pagos[x].FechaPago.Date <= this.dtpFechaHasta.Value.Date)
                                    {
                                        if (x != (f.Pagos.Count - 1))
                                        {
                                            if (f.Pagos[x].FechaPago.Date == f.Pagos[x + 1].FechaPago.Date)
                                            {
                                                ingresosHoy += f.Pagos[x].Importe;
                                                ingresosHoy += f.Pagos[x + 1].Importe;
                                                x += 1;
                                            }
                                            else
                                            {
                                                chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[x].FechaPago.Date, f.Pagos[x].Importe);
                                            }
                                        }
                                        else
                                        {
                                            ingresosHoy += f.Pagos[x].Importe;
                                            chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[x].FechaPago.Date, ingresosHoy);

                                        }

                                    }
                                }
                            }
                            else
                            {
                                if (f.Pagos is not null && f.Pagos[0].FechaPago.Date <= this.dtpFechaHasta.Value.Date)
                                {
                                    chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[0].FechaPago.Date, f.Pagos[0].Importe);
                                }
                            }
                        }

                    }
                }
                
            }
            else
            {
                string[] tiposgasto = Enum.GetNames(typeof(Gasto.TiposGasto));
                chartGastos.Series["Gastos"].Points.Clear();
                for (int x = 0; x < tiposgasto.Length; x++)
                {
                    List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date && g.TipoGasto.ToString() == tiposgasto[x]; });
                    double gastos = 0;
                    if (gastosHoy is not null)
                    {
                        foreach (Gasto g in gastosHoy)
                        {
                            gastos += g.Importe;

                        }
                    }
                    chartGastos.Series["Gastos"].Points.Add(gastos);
                    chartGastos.Series["Gastos"].Points[x].AxisLabel = tiposgasto[x];
                    chartGastos.Series["Gastos"].Points[x].LegendText = tiposgasto[x];
                    chartGastos.Series["Gastos"].Points[x].Label = gastos.ToString();
                }
                List<Factura> facturasHoy = _facturaLogic.GetAll().FindAll(delegate (Factura f) { return f.FechaFactura.Date >= this.dtpFecha.Value.Date && f.Pagos is not null; });
                chartIngresos.Series["Ingresos"].Points.Clear();
                if (facturasHoy is not null && facturasHoy.Count > 0)
                {
                    List<Factura> facturasOrd = facturasHoy.OrderBy(x => x.FechaFactura.Date).ToList();
                    
                    foreach (Factura f in facturasOrd)
                    {
                        double ingresosHoy = 0;
                        if (f.Pagos is not null && f.Pagos.Count > 1)
                        {
                            for (int x = 0; x < f.Pagos.Count; x++)
                            {
                                if (f.Pagos[x].FechaPago.Date >= this.dtpFecha.Value.Date)
                                {
                                    if(x != (f.Pagos.Count - 1))
                                    {
                                        if (f.Pagos[x].FechaPago.Date == f.Pagos[x + 1].FechaPago.Date)
                                        {
                                            ingresosHoy += f.Pagos[x].Importe;
                                            ingresosHoy += f.Pagos[x + 1].Importe;
                                            x += 1;
                                        }
                                        else
                                        {
                                            chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[x].FechaPago.Date, f.Pagos[x].Importe);
                                        }
                                    }
                                    else
                                    {
                                        ingresosHoy += f.Pagos[x].Importe;
                                        chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[x].FechaPago.Date, ingresosHoy);

                                    }
                                    
                                }
                            }
                        }
                        else
                        {
                            if (f.Pagos[0].FechaPago.Date >= this.dtpFecha.Value.Date)
                            {
                                chartIngresos.Series["Ingresos"].Points.AddXY(f.Pagos[0].FechaPago.Date, f.Pagos[0].Importe);
                            }
                            
                        }
                    }

                }
            }
            
            
        }
        private void ActualizarInformacion() 
        {
            ListarOrdenes();
            ListarGastos();
            //SaldoAnterior();
            IngresosDelDia();
            GastosDelDia();
            CargarSeriesGrafico();
            double ingresos = Double.Parse(this.lblIngresosDia.Text.Remove(0, 2));
            double gastos = Double.Parse(this.lblSalidasDia.Text.Remove(0, 2));
            double balance = ingresos - gastos;
            this.lblBalanceHoy.Text = String.Concat("$ ", balance.ToString());
        }

        private void ListarOrdenes() 
        {
            List<Orden> ordenes = _ordenLogic.GetAll().FindAll(delegate (Orden o)
            { return o.FechaSalida.Date >= this.dtpFecha.Value.Date; });
            
            if (ordenes is not null) 
            {
                List<Orden> ordenesOr = ordenes.OrderBy(x => x.FechaSalida.Date).ToList();
                listOrdenes.Items.Clear();
                foreach (Orden o in ordenesOr) 
                {
                    double ingresos = 0;
                    if (o.Factura is not null && o.Factura.Pagos is not null) 
                    {
                        foreach (Pago p in o.Factura.Pagos) 
                        {
                            if (p.FechaPago.Date >= this.dtpFecha.Value.Date) 
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
            List<Gasto> gastos = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date; });
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
            List<Orden> ordenesHoy= _ordenLogic.GetAll().FindAll(delegate (Orden o) { return o.FechaSalida.Date >= this.dtpFecha.Value.Date;});
            if (ordenesHoy is not null)
            {
                foreach (Orden o in ordenesHoy)
                {
                    if (o.Factura is not null && o.Factura.Pagos is not null)
                    {
                        foreach (Pago p in o.Factura.Pagos)
                        {
                            if (p.FechaPago.Date >= this.dtpFecha.Value.Date)
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
            List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date; });
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
            if (Singleton.getInstance().ListActual != null && (listOrdenes.Items.Count > 0 || listGastos.Items.Count > 0))
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
                            tablacaja.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                            Cell totalingresos = new Cell().Add(new Paragraph("Total Ingresos").SetBold());
                            totalingresos.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            totalingresos.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(totalingresos);
                            tablacaja.AddCell(this.lblIngresosDia.Text);
                            Cell totalgastos = new Cell().Add(new Paragraph("Total Gastos").SetBold());
                            totalgastos.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            totalgastos.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(totalgastos);
                            tablacaja.AddCell(this.lblSalidasDia.Text);
                            Cell balancetotal = new Cell().Add(new Paragraph("Balance Total").SetBold());
                            balancetotal.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            balancetotal.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(balancetotal);
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
                                if (dtpFecha.Value.ToString("yyyy/MM/dd") != DateTime.Now.ToString("yyyy/MM/dd"))
                                {
                                    Paragraph fechaDesde = new Paragraph();
                                    fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                    fechaDesde.Add($"Caja desde: {dtpFecha.Value.Date} - hasta: {dtpFechaHasta.Value.Date}\n");
                                    fechaDesde.SetFontSize(9);
                                    document.Add(fechaDesde);
                                }
                                Paragraph ordenesretiradas = new Paragraph();
                                ordenesretiradas.SetTextAlignment(TextAlignment.LEFT);
                                ordenesretiradas.Add($"Ordenes retiradas: \n");
                                ordenesretiradas.SetFontSize(12);
                                ordenesretiradas.SetBold();
                                document.Add(ordenesretiradas);
                                document.Add(pdfTable);
                                Paragraph gastos = new Paragraph();
                                gastos.SetTextAlignment(TextAlignment.LEFT);
                                gastos.Add($"Gastos: \n");
                                gastos.SetFontSize(12);
                                gastos.SetBold();
                                document.Add(gastos);
                                document.Add(pdfTable2);
                                Paragraph resumen = new Paragraph();
                                resumen.SetTextAlignment(TextAlignment.LEFT);
                                resumen.Add($"Resumen: \n");
                                resumen.SetFontSize(12);
                                resumen.SetBold();
                                document.Add(resumen);
                                document.Add(tablacaja);
                                document.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Reporte exportado exitosamente", "Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
                MessageBox.Show("No hay registros para exportar", "Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFecha.Value.Date != DateTime.Now.Date)
            {
                CargarSeriesGrafico();
                List<Orden> ordenes = _ordenLogic.GetAll().FindAll(delegate (Orden o)
                { return o.FechaSalida.Date >= this.dtpFecha.Value.Date && o.FechaSalida.Date <= this.dtpFechaHasta.Value.Date; });
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
                                if (p.FechaPago.Date >= this.dtpFecha.Value.Date && p.FechaPago.Date <= this.dtpFechaHasta.Value.Date)
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

                listGastos.Items.Clear();
                List<Gasto> gastos = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date && g.FechaRealizado.Date <= this.dtpFechaHasta.Value.Date; });
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
                
                double ingresosHoy = 0.0;
                List<Orden> ordenesHoy = _ordenLogic.GetAll().FindAll(delegate (Orden o) { return o.FechaSalida.Date >= this.dtpFecha.Value.Date && o.FechaSalida.Date <= this.dtpFechaHasta.Value.Date; });
                if (ordenesHoy is not null)
                {
                    foreach (Orden o in ordenesHoy)
                    {
                        if (o.Factura is not null && o.Factura.Pagos is not null)
                        {
                            foreach (Pago p in o.Factura.Pagos)
                            {
                                if (p.FechaPago.Date >= this.dtpFecha.Value.Date && p.FechaPago.Date <= this.dtpFechaHasta.Value.Date)
                                {
                                    ingresosHoy += p.Importe;
                                }
                            }
                        }
                    }
                    this.lblIngresosDia.Text = String.Concat("$ ", ingresosHoy.ToString());
                }

                double gastos2 = 0.0;
                List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date && g.FechaRealizado <= this.dtpFechaHasta.Value.Date; });
                if (gastosHoy is not null)
                {
                    foreach (Gasto g in gastosHoy)
                    {
                        gastos2 += g.Importe;
                    }
                    this.lblSalidasDia.Text = String.Concat("$ ", gastos2.ToString());
                }
            }
            else
            {
                CargarSeriesGrafico();
                List<Orden> ordenes = _ordenLogic.GetAll().FindAll(delegate (Orden o)
                { return o.FechaSalida.Date <= this.dtpFechaHasta.Value.Date; });
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
                                if ( p.FechaPago.Date <= this.dtpFechaHasta.Value.Date)
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

                listGastos.Items.Clear();
                List<Gasto> gastos = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date <= this.dtpFechaHasta.Value.Date; });
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

                double ingresosHoy = 0.0;
                List<Orden> ordenesHoy = _ordenLogic.GetAll().FindAll(delegate (Orden o) { return o.FechaSalida.Date <= this.dtpFechaHasta.Value.Date; });
                if (ordenesHoy is not null)
                {
                    foreach (Orden o in ordenesHoy)
                    {
                        if (o.Factura is not null && o.Factura.Pagos is not null)
                        {
                            foreach (Pago p in o.Factura.Pagos)
                            {
                                if ( p.FechaPago.Date <= this.dtpFechaHasta.Value.Date)
                                {
                                    ingresosHoy += p.Importe;
                                }
                            }
                        }
                    }
                    this.lblIngresosDia.Text = String.Concat("$ ", ingresosHoy.ToString());
                }

                double gastos2 = 0.0;
                List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return  g.FechaRealizado <= this.dtpFechaHasta.Value.Date; });
                if (gastosHoy is not null)
                {
                    foreach (Gasto g in gastosHoy)
                    {
                        gastos2 += g.Importe;
                    }
                    this.lblSalidasDia.Text = String.Concat("$ ", gastos2.ToString());
                }
            }
        }
    }
}
