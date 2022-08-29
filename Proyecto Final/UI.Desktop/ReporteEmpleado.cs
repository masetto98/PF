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
    public partial class ReporteEmpleado : ApplicationForm
    {
        private readonly EmpleadoLogic _empleadoLogic;
        private readonly OrdenLogic _ordenLogic;
        public Empleado empleadoActual;
        public LavanderiaContext _context;
        public List<Orden> ordenesRegistradas;
        public List<MaquinaOrdenServicioTipoPrenda> ordenesAtendidas;
        public double cantTotalReg;
        public double cantTotalAten;
        public double cantTotalItemsReg;

        public ReporteEmpleado(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _empleadoLogic = new EmpleadoLogic(new Data.Database.EmpleadoAdapter(context));
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            Singleton.getInstance().ListActual = this.listRegistradas;
            Singleton.getInstance().ListAlternativa = this.listAtendidas;
            Singleton.getInstance().ModuloActual = "Empleados";
            CargarEmpleados();
        }
        private void CargarEmpleados()
        {
            List<Empleado> empleados = _empleadoLogic.GetAll();
            listEmpleados.Items.Clear();
            foreach(Empleado e in empleados)
            {
                ListViewItem item = new ListViewItem(e.IdEmpleado.ToString());
                item.SubItems.Add(e.Nombre + " " + e.Apellido);
                listEmpleados.Items.Add(item);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CargarAtendidas()
        {
            double cantidadTotalAten = 0;
            listAtendidas.Items.Clear();
            foreach(MaquinaOrdenServicioTipoPrenda aten in ordenesAtendidas)
            {
                ListViewItem item = new ListViewItem(aten.NroOrden.ToString());
                item.SubItems.Add(aten.Maquina.Descripcion);
                item.SubItems.Add(aten.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion + " "+ aten.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                item.SubItems.Add(aten.TiempoInicioServicio.ToString());
                item.SubItems.Add(aten.TiempoFinServicio.ToString());
                cantidadTotalAten += 1;
                listAtendidas.Items.Add(item);
            }
            cantTotalAten = cantidadTotalAten;
        }
        private void CargarRegistradas()
        {
            double cantidadTotalReg = 0;
            double cantidadTotalItemsReg = 0;
            listRegistradas.Items.Clear();
            foreach (Orden or in ordenesRegistradas)
            {
                ListViewItem item = new ListViewItem(or.NroOrden.ToString());
                item.SubItems.Add(or.FechaEntrada.ToString());
                item.SubItems.Add(or.Cliente.Apellido+", "+or.Cliente.Nombre);
                item.SubItems.Add(or.ItemsPedidos.Count.ToString());
                cantidadTotalItemsReg += or.ItemsPedidos.Count;
                cantidadTotalReg += 1;
                listRegistradas.Items.Add(item);
            }
            cantTotalReg = cantidadTotalReg;
            cantTotalItemsReg = cantidadTotalItemsReg;
        }
        private void BuscarEmpleado()
        {
            int ID = Int32.Parse(listEmpleados.SelectedItems[0].Text);
            empleadoActual = _empleadoLogic.GetOne(ID);
        }
        private void CargarListas()
        {
            if (dtpFechaDesde.Value.Date != DateTime.Now.Date)
            {
                if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
                {
                    ordenesRegistradas = empleadoActual.OrdenesRegistradas.FindAll(
                        delegate (Orden or) {
                            return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date && or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                        });
                    ordenesAtendidas = empleadoActual.OrdenesAtendidas.FindAll(
                        delegate (MaquinaOrdenServicioTipoPrenda maq) {
                            return maq.TiempoFinServicio.Date >= dtpFechaDesde.Value.Date && maq.TiempoInicioServicio.Date <= dtpFechaHasta.Value.Date;
                        });
                    CargarRegistradas();
                    CargarAtendidas();
                }
                else
                {
                    ordenesRegistradas = empleadoActual.OrdenesRegistradas.FindAll(
                        delegate (Orden or) {
                            return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date;
                        });
                    ordenesAtendidas = empleadoActual.OrdenesAtendidas.FindAll(
                        delegate (MaquinaOrdenServicioTipoPrenda maq) {
                            return maq.TiempoFinServicio.Date >= dtpFechaDesde.Value.Date;
                        });
                    CargarRegistradas();
                    CargarAtendidas();
                }
            }
            else
            {
                if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
                {
                    ordenesRegistradas = empleadoActual.OrdenesRegistradas.FindAll(
                        delegate (Orden or) {
                            return or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                        });
                    ordenesAtendidas = empleadoActual.OrdenesAtendidas.FindAll(
                        delegate (MaquinaOrdenServicioTipoPrenda maq) {
                            return maq.TiempoFinServicio.Date <= dtpFechaHasta.Value.Date;
                        });
                    CargarAtendidas();
                    CargarRegistradas();
                }
                else
                {
                    ordenesRegistradas = empleadoActual.OrdenesRegistradas;
                    ordenesAtendidas = empleadoActual.OrdenesAtendidas;
                    CargarRegistradas();
                    CargarAtendidas();
                }
            }

        }
       

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if(listEmpleados.SelectedItems.Count > 0)
            {
                BuscarEmpleado();
                CargarListas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la lista para poder observar los detalles", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
            {
                ordenesRegistradas = empleadoActual.OrdenesRegistradas.FindAll(
                    delegate (Orden or) {
                        return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date && or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                    });
                ordenesAtendidas = empleadoActual.OrdenesAtendidas.FindAll(
                    delegate (MaquinaOrdenServicioTipoPrenda maq) {
                        return maq.TiempoFinServicio.Date >= dtpFechaDesde.Value.Date && maq.TiempoInicioServicio.Date <= dtpFechaHasta.Value.Date;
                    });
                CargarRegistradas();
                CargarAtendidas();
            }
            else
            {
                ordenesRegistradas = empleadoActual.OrdenesRegistradas.FindAll(
                    delegate (Orden or) {
                        return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date;
                    });
                ordenesAtendidas = empleadoActual.OrdenesAtendidas.FindAll(
                    delegate (MaquinaOrdenServicioTipoPrenda maq) {
                        return maq.TiempoFinServicio.Date >= dtpFechaDesde.Value.Date;
                    });
                CargarRegistradas();
                CargarAtendidas();
            }
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value.Date != DateTime.Now.Date)
            {

                ordenesRegistradas = empleadoActual.OrdenesRegistradas.FindAll(
                    delegate (Orden or)
                    {
                        return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date && or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                    });
                ordenesAtendidas = empleadoActual.OrdenesAtendidas.FindAll(
                    delegate (MaquinaOrdenServicioTipoPrenda maq)
                    {
                        return maq.TiempoFinServicio.Date >= dtpFechaDesde.Value.Date && maq.TiempoInicioServicio.Date <= dtpFechaHasta.Value.Date;
                    });
                CargarRegistradas();
                CargarAtendidas();

            }
            else
            {
                ordenesRegistradas = empleadoActual.OrdenesRegistradas.FindAll(
                        delegate (Orden or) {
                            return or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                        });
                ordenesAtendidas = empleadoActual.OrdenesAtendidas.FindAll(
                    delegate (MaquinaOrdenServicioTipoPrenda maq) {
                        return maq.TiempoFinServicio.Date <= dtpFechaHasta.Value.Date;
                    });
                CargarAtendidas();
                CargarRegistradas();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (Singleton.getInstance().ListActual != null && listEmpleados.SelectedItems.Count > 0)
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
                            Cell totalingresos = new Cell().Add(new Paragraph("Total Registradas").SetBold());
                            totalingresos.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            totalingresos.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(totalingresos);
                            tablacaja.AddCell(cantTotalReg.ToString());
                            Cell totalgastos = new Cell().Add(new Paragraph("Total Atendidos").SetBold());
                            totalgastos.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            totalgastos.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(totalgastos);
                            tablacaja.AddCell(cantTotalAten.ToString());
                            Cell balancetotal = new Cell().Add(new Paragraph("Proporción de Items Atendidos sobre los Registrados").SetBold());
                            balancetotal.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                            balancetotal.SetTextAlignment(TextAlignment.CENTER);
                            tablacaja.AddCell(balancetotal);
                            double balance = Math.Round((cantTotalAten / cantTotalItemsReg) * 100, 2); 
                            tablacaja.AddCell(balance.ToString()+"%");
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
                                Paragraph empleado = new Paragraph();
                                empleado.SetTextAlignment(TextAlignment.LEFT);
                                empleado.Add($"Empleado: {empleadoActual.Apellido +", "+empleadoActual.Nombre} \n");
                                empleado.SetFontSize(12);
                                empleado.SetBold();
                                document.Add(empleado);
                                if (dtpFechaDesde.Value.ToString("yyyy/MM/dd") != DateTime.Now.ToString("yyyy/MM/dd"))
                                {
                                    Paragraph fechaDesde = new Paragraph();
                                    fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                    fechaDesde.Add($"El Reporte abarca desde: {dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")} - hasta: {dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")}\n");
                                    fechaDesde.SetFontSize(9);
                                    document.Add(fechaDesde);
                                }
                                Paragraph ordenesretiradas = new Paragraph();
                                ordenesretiradas.SetTextAlignment(TextAlignment.LEFT);
                                ordenesretiradas.Add($"Ordenes Registradas: \n");
                                ordenesretiradas.SetFontSize(12);
                                ordenesretiradas.SetBold();
                                document.Add(ordenesretiradas);
                                document.Add(pdfTable);
                                Paragraph gastos = new Paragraph();
                                gastos.SetTextAlignment(TextAlignment.LEFT);
                                gastos.Add($"Trabajos atendidos: \n");
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
    }
}
