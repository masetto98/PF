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
    public partial class ReporteMovimientos : ApplicationForm
    {
        private LavanderiaContext _context;
        private OrdenLogic _ordenLogic;
        public List<Orden> ordenes;
        private InsumoLogic _insumoLogic;
        public Insumo insumoActual;
        public double _totalIngresos;
        public double _totalEgresos;
        public ReporteMovimientos(LavanderiaContext context)
        {
            _context = context;
            InitializeComponent();
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            Singleton.getInstance().ListActual = this.listIngresos;
            Singleton.getInstance().ListAlternativa = this.listEgresos;
            Singleton.getInstance().ModuloActual = "Movimientos de Insumo";
            ListarStock();
        }
        private void ListarStock()
        {
            listInsumos.Items.Clear();
            List<Insumo> insumos = _insumoLogic.GetAll();
            if (insumos.Count > 0)
            {
                foreach (Insumo i in insumos)
                {
                    ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                    item.SubItems.Add(i.Descripcion);
                    listInsumos.Items.Add(item);
                }
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if(listInsumos.SelectedItems.Count > 0)
            {
                ListarIngresos();
                ListarEgresos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un insumo en la lista para poder observar los detalles", "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListarIngresos()
        {
            insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
            double totalIngresos1 = 0;
            listIngresos.Items.Clear();
            foreach(InsumoProveedor ip in insumoActual.InsumosProveedores)
            {
                ListViewItem item = new ListViewItem(ip.Proveedor.RazonSocial);
                item.SubItems.Add(ip.FechaIngreso.ToString());
                item.SubItems.Add(ip.Cantidad.ToString()+ " "+ insumoActual.UnidadMedida);
                totalIngresos1 += ip.Cantidad;
                listIngresos.Items.Add(item);
            }
            _totalIngresos = totalIngresos1;
        }
        private void ListarEgresos()
        {
            List<Consumo> consumosInsumo = insumoActual.Consumos;
            double totalEgresos1 = 0;
            if (consumosInsumo is not null)
            {
                listEgresos.Items.Clear();
                foreach(Consumo c in consumosInsumo)
                {
                    ListViewItem item = new ListViewItem(c.MaquinaOrdenServicioTipoPrenda.NroOrden.ToString());
                    item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion + " " + c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.Maquina.Descripcion);
                    item.SubItems.Add(c.FechaConsumo.ToString());
                    item.SubItems.Add(c.Cantidad.ToString());
                    totalEgresos1 += c.Cantidad;
                    listEgresos.Items.Add(item);
                }
                _totalEgresos = totalEgresos1;
            }
            /*
            ordenes = _ordenLogic.GetAll().FindAll(
                delegate (Orden o)
                {
                    return o.Estado != Orden.Estados.Pendiente;
                });
            double totalEgresos1 = 0;
            if(ordenes is not null)
            {
                listEgresos.Items.Clear();
                foreach (Orden o in ordenes)
                {
                   foreach(OrdenServicioTipoPrenda items in o.ItemsPedidos)
                    {
                        
                        foreach(InsumoServicioTipoPrenda consumo in items.ServicioTipoPrenda.InsumoServicioTipoPrenda)
                        {
                            if(consumo.Insumo == insumoActual)
                            {
                                ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                                item.SubItems.Add(items.ServicioTipoPrenda.Servicio.Descripcion);
                                item.SubItems.Add(items.ServicioTipoPrenda.TipoPrenda.Descripcion);
                                item.SubItems.Add(consumo.Cantidad.ToString());
                                totalEgresos1 += consumo.Cantidad;
                                listEgresos.Items.Add(item);
                            }
                        }
                    }
                }
                _totalEgresos = totalEgresos1;
            }
            */
        }

       

        private void listInsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listInsumos.Columns[e.ColumnIndex].Width;
        }

        private void listEgresos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listEgresos.Columns[e.ColumnIndex].Width;
        }

        private void listIngresos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listIngresos.Columns[e.ColumnIndex].Width;
        }

       

        private void btnReporteMovimientos_Click(object sender, EventArgs e)
        {
            if (Singleton.getInstance().ListActual != null && listInsumos.SelectedItems.Count > 0)
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
                            tablacaja.AddCell(_totalIngresos.ToString());
                            Cell totalgastos = new Cell().Add(new Paragraph("Total Consumido").SetBold());
                            totalgastos.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            totalgastos.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(totalgastos);
                            tablacaja.AddCell(_totalEgresos.ToString());
                            Cell balancetotal = new Cell().Add(new Paragraph("Balance Total").SetBold());
                            balancetotal.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            balancetotal.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(balancetotal);
                            double balance = _totalIngresos - _totalEgresos;
                            tablacaja.AddCell(balance.ToString());
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
                                Paragraph insumo = new Paragraph();
                                insumo.SetTextAlignment(TextAlignment.LEFT);
                                insumo.Add($"Insumo: {insumoActual.Descripcion} \n");
                                insumo.SetFontSize(12);
                                insumo.SetBold();
                                document.Add(insumo);
                                if (dtpFechaDesde.Value.ToString("yyyy/MM/dd") != DateTime.Now.ToString("yyyy/MM/dd"))
                                {
                                    Paragraph fechaDesde = new Paragraph();
                                    fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                    fechaDesde.Add($"Movimientos desde: {dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")} - hasta: {dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")}\n");
                                    fechaDesde.SetFontSize(9);
                                    document.Add(fechaDesde);
                                }
                                Paragraph ordenesretiradas = new Paragraph();
                                ordenesretiradas.SetTextAlignment(TextAlignment.LEFT);
                                ordenesretiradas.Add($"Ingresos: \n");
                                ordenesretiradas.SetFontSize(12);
                                ordenesretiradas.SetBold();
                                document.Add(ordenesretiradas);
                                document.Add(pdfTable);
                                Paragraph gastos = new Paragraph();
                                gastos.SetTextAlignment(TextAlignment.LEFT);
                                gastos.Add($"Consumos: \n");
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
                double totalIngresos2 = 0;
                listIngresos.Items.Clear();
                foreach (InsumoProveedor ip in insumoActual.InsumosProveedores)
                {
                    if (ip.FechaIngreso.Date >= dtpFechaDesde.Value.Date)
                    {
                        ListViewItem item = new ListViewItem(ip.Proveedor.RazonSocial);
                        item.SubItems.Add(ip.FechaIngreso.ToString());
                        item.SubItems.Add(ip.Cantidad.ToString() + " " + insumoActual.UnidadMedida);
                        totalIngresos2 += ip.Cantidad;
                        listIngresos.Items.Add(item);
                    }
                }
                _totalIngresos = totalIngresos2;

                List<Consumo> consumosInsumo = insumoActual.Consumos;
                double totalEgresos2 = 0;
                if (consumosInsumo is not null)
                {
                    listEgresos.Items.Clear();
                    foreach (Consumo c in consumosInsumo)
                    {
                        if (c.FechaConsumo.Date >= dtpFechaDesde.Value.Date)
                        {
                            ListViewItem item = new ListViewItem(c.MaquinaOrdenServicioTipoPrenda.NroOrden.ToString());
                            item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion + " " + c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                            item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.Maquina.Descripcion);
                            item.SubItems.Add(c.FechaConsumo.ToString());
                            item.SubItems.Add(c.Cantidad.ToString());
                            totalEgresos2 += c.Cantidad;
                            listEgresos.Items.Add(item);
                        }
                    }
                    _totalEgresos = totalEgresos2;
                }
            }
            else
            {
                
                MessageBox.Show("Debe seleccionar un Insumo de la lista para poder continuar.", "Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFechaDesde.Value = DateTime.Today;
            }
            

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if(listInsumos.SelectedItems.Count > 0)
            {
                if (dtpFechaHasta.Value > dtpFechaDesde.Value)
                {
                    if (dtpFechaDesde.Value.Date != DateTime.Now.Date)
                    {
                        insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
                        double totalIngresos3 = 0;
                        listIngresos.Items.Clear();
                        foreach (InsumoProveedor ip in insumoActual.InsumosProveedores)
                        {
                            if (ip.FechaIngreso.Date >= dtpFechaDesde.Value.Date && ip.FechaIngreso.Date <= dtpFechaHasta.Value.Date)
                            {
                                ListViewItem item = new ListViewItem(ip.Proveedor.RazonSocial);
                                item.SubItems.Add(ip.FechaIngreso.ToString());
                                item.SubItems.Add(ip.Cantidad.ToString() + " " + insumoActual.UnidadMedida);
                                totalIngresos3 += ip.Cantidad;
                                listIngresos.Items.Add(item);
                            }
                        }
                        _totalIngresos = totalIngresos3;
                        List<Consumo> consumosInsumo = insumoActual.Consumos;
                        double totalEgresos3 = 0;
                        if (consumosInsumo is not null)
                        {
                            listEgresos.Items.Clear();
                            foreach (Consumo c in consumosInsumo)
                            {
                                if (c.FechaConsumo.Date >= dtpFechaDesde.Value.Date && c.FechaConsumo <= dtpFechaHasta.Value.Date)
                                {
                                    ListViewItem item = new ListViewItem(c.MaquinaOrdenServicioTipoPrenda.NroOrden.ToString());
                                    item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion + " " + c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                                    item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.Maquina.Descripcion);
                                    item.SubItems.Add(c.FechaConsumo.ToString());
                                    item.SubItems.Add(c.Cantidad.ToString());
                                    totalEgresos3 += c.Cantidad;
                                    listEgresos.Items.Add(item);
                                }
                            }
                            _totalEgresos = totalEgresos3;
                        }
                    }
                    else
                    {
                        insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
                        double totalIngresos4 = 0;
                        listIngresos.Items.Clear();
                        foreach (InsumoProveedor ip in insumoActual.InsumosProveedores)
                        {
                            if (ip.FechaIngreso.Date <= dtpFechaHasta.Value.Date)
                            {
                                ListViewItem item = new ListViewItem(ip.Proveedor.RazonSocial);
                                item.SubItems.Add(ip.FechaIngreso.ToString());
                                item.SubItems.Add(ip.Cantidad.ToString() + " " + insumoActual.UnidadMedida);
                                totalIngresos4 += ip.Cantidad;
                                listIngresos.Items.Add(item);
                            }
                        }
                        _totalIngresos = totalIngresos4;

                        List<Consumo> consumosInsumo = insumoActual.Consumos;
                        double totalEgresos4 = 0;
                        if (consumosInsumo is not null)
                        {
                            listEgresos.Items.Clear();
                            foreach (Consumo c in consumosInsumo)
                            {
                                if (c.FechaConsumo.Date <= dtpFechaHasta.Value.Date)
                                {
                                    ListViewItem item = new ListViewItem(c.MaquinaOrdenServicioTipoPrenda.NroOrden.ToString());
                                    item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion + " " + c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                                    item.SubItems.Add(c.MaquinaOrdenServicioTipoPrenda.Maquina.Descripcion);
                                    item.SubItems.Add(c.FechaConsumo.ToString());
                                    item.SubItems.Add(c.Cantidad.ToString());
                                    totalEgresos4 += c.Cantidad;
                                    listEgresos.Items.Add(item);
                                }
                            }
                            _totalEgresos = totalEgresos4;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La Fecha Hasta seleccionada no puede ser inferior a la Fecha Desde. Por favor, seleccione una fecha válida para continuar.", "Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                
                MessageBox.Show("Debe seleccionar un Insumo de la lista para poder continuar.", "Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFechaHasta.Value = DateTime.Today;
            }
            
        }
    }
}
