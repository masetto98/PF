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
        public List<Orden> ordenesDeudaCliente;
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
            //ordenes = _ordenLogic.GetAll();
            ListarClientes();
            listarOrdenesCliente();
            Singleton.getInstance().ListActual = this.listOrdenesCliente;
            Singleton.getInstance().ModuloActual = "Deudas Clientes";
            
        }
        private void ListarClientes()
        {
            List<Cliente> clientes = _clienteLogic.GetAll();
            listClientes.Items.Clear();
            foreach (Cliente c in clientes)
            {
                ListViewItem item = new ListViewItem(c.Cuit);
                item.SubItems.Add(c.Nombre + " " + c.Apellido + "/" + c.RazonSocial);
                listClientes.Items.Add(item);

            }
        }
        public List<Orden> OrdenesDeuda()
        {
             ordenesDeuda = _ordenLogic.GetAll().FindAll(
                delegate (Orden or)
                {
                    if(or.Factura.Importe != 0)
                    {
                        double pagos = 0;
                        if (or.Factura.Pagos is not null)
                        {
                            foreach (Pago p in or.Factura.Pagos)
                            {
                                pagos += p.Importe;
                            }
                        };
                        return or.Factura.Importe > pagos;
                    }
                    else
                    {
                        double pagos = 0;
                        if (or.Factura.Pagos is not null)
                        {
                            foreach (Pago p in or.Factura.Pagos)
                            {
                                pagos += p.Importe;
                            }
                        };
                        double importeF = CalcularImporteOrden(or);
                        return importeF > pagos;
                    }
                });
             return ordenesDeuda;
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
        
        
        public void listarOrdenesCliente()
        {
            double montoTotal1=0;
            List<Orden> ordenesDeuda = OrdenesDeuda();
            listOrdenesCliente.Items.Clear();
            foreach (Orden oc in ordenesDeuda)
            {
                ListViewItem item = new ListViewItem();
                if(oc.Cliente.RazonSocial == "")
                {
                    item.Text = item.Name = oc.Cliente.Nombre + " " + oc.Cliente.Apellido;

                }
                else
                {
                    item.Text = oc.Cliente.RazonSocial;
                }
                item.SubItems.Add(oc.NroOrden.ToString());
                item.SubItems.Add(oc.FechaEntrada.ToString("dd/MM/yyyy HH:ss:mm"));
                string fecha = oc.FechaSalida.Date.ToString();
                if (oc.FechaSalida.Date.ToString() == "1/1/0001 00:00:00")
                {
                    item.SubItems.Add("No retirada");
                }
                else
                {
                    item.SubItems.Add(oc.FechaSalida.ToString());
                }
               
                
                double deudas = 0;
                double pagos = CalcularPagosOrden(oc);
                if (oc.Factura.Importe == 0)
                {
                    double importe = CalcularImporteOrden(oc);
                    item.SubItems.Add("$"+importe.ToString());
                    deudas = importe - pagos;

                }
                else
                {
                    item.SubItems.Add("$" + oc.Factura.Importe.ToString());
                    deudas = oc.Factura.Importe - pagos;
                }
                
                item.SubItems.Add("$" + pagos.ToString());
                item.SubItems.Add("$" + deudas.ToString());
                montoTotal1 += deudas;
                listOrdenesCliente.Items.Add(item);
            }
            montoTotal = montoTotal1;
        }
        
       
        private void btnReporteDeudas_Click(object sender, EventArgs e)
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
                                    fecha.Add($"Fecha y hora de emisión: {DateTime.Now} \n");
                                    fecha.SetFontSize(9);
                                    document.Add(fecha);
                                    if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
                                    {
                                        if(dtpFechaDesde.Value.Date != DateTime.Now.Date)
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
                                    else if(dtpFechaDesde.Value.Date != DateTime.Now.Date)
                                    {
                                        Paragraph fechaDesde = new Paragraph();
                                        fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                        fechaDesde.Add($"El Reporte abarca desde: {dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")}\n");
                                        fechaDesde.SetFontSize(9);
                                        document.Add(fechaDesde);
                                    }
                                    if (clienteActual is not null)
                                    {
                                        Paragraph cliente = new Paragraph();
                                        cliente.SetTextAlignment(TextAlignment.LEFT);
                                        if(clienteActual.RazonSocial == "")
                                        {
                                            cliente.Add($"Cliente: {clienteActual.Nombre}, {clienteActual.Apellido} \n");
                                        }
                                        else
                                        {
                                            if(clienteActual.Nombre != "" && clienteActual.Apellido != "")
                                            {
                                                cliente.Add($"Cliente: {clienteActual.Nombre}, {clienteActual.Apellido} / {clienteActual.RazonSocial} \n");
                                            }
                                            else
                                            {
                                                cliente.Add($"Cliente: {clienteActual.RazonSocial} \n");
                                            }
                                        
                                        }
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

                                MessageBox.Show("Reporte exportado exitosamente", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                    MessageBox.Show("No hay registros para exportar", "Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                
        }

    

        private void listarClientesFiltrados(List<Cliente> clientes)
        {
            listClientes.Items.Clear();
            foreach(Cliente c in clientes)
            {
                ListViewItem item = new ListViewItem(c.Cuit);
                item.SubItems.Add(c.Nombre + " " + c.Apellido + "/" + c.RazonSocial);
                listClientes.Items.Add(item);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> clientes = _clienteLogic.GetAll().FindAll(
                delegate (Cliente c)
                {
                    string cuit = c.Cuit;
                    string cliente = String.Concat(c.Nombre, " ", c.Apellido, " / ", c.RazonSocial);
                    return c.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()) || c.Apellido.ToLower().Contains(txtBuscar.Text.ToLower()) || c.Cuit.ToLower().Contains(txtBuscar.Text.ToLower());
                });
            if(clientes.Count > 0)
            {
                listarClientesFiltrados(clientes);
            }
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

        
        private void listarOrdenesFiltradas(List<Orden> ordenesFiltro)
        {
            double montoTotal1 = 0;
            listOrdenesCliente.Items.Clear();
            foreach (Orden oc in ordenesFiltro)
            {
                ListViewItem item = new ListViewItem();
                if (oc.Cliente.RazonSocial == "")
                {
                    item.Text = item.Name = oc.Cliente.Nombre + " " + oc.Cliente.Apellido;

                }
                else
                {
                    item.Text = oc.Cliente.RazonSocial;
                }
                item.SubItems.Add(oc.NroOrden.ToString());
                item.SubItems.Add(oc.FechaEntrada.ToString("dd/MM/yyyy HH:ss:mm"));
                string fecha = oc.FechaSalida.Date.ToString();
                if (oc.FechaSalida.Date.ToString() == "1/1/0001 00:00:00")
                {
                    item.SubItems.Add("No retirada");
                }
                else
                {
                    item.SubItems.Add(oc.FechaSalida.ToString());
                }
                double deudas = 0;
                double pagos = CalcularPagosOrden(oc);
                if (oc.Factura.Importe == 0)
                {
                    double importe = CalcularImporteOrden(oc);
                    item.SubItems.Add("$" + importe.ToString());
                    deudas = importe - pagos;

                }
                else
                {
                    item.SubItems.Add("$" + oc.Factura.Importe.ToString());
                    deudas = oc.Factura.Importe - pagos;
                }

                item.SubItems.Add("$" + pagos.ToString());
                item.SubItems.Add("$" + deudas.ToString());
                montoTotal1 += deudas;
                listOrdenesCliente.Items.Add(item);
            }
            montoTotal = montoTotal1;
        }
        private void filtroFecha()
        {
           
                    List<Orden> ordenesFiltro = ordenesDeuda.FindAll(
                        delegate (Orden or)
                        {
                            return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date && or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                        });
                    if (ordenesFiltro.Count > 0)
                    {
                        listarOrdenesFiltradas(ordenesFiltro);
                    }
                
        }
        
        private void filtroFechaCliente()
        {
            if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
            {
                if (dtpFechaDesde.Value.Date != DateTime.Now.Date)
                {
                    List<Orden> ordenesFiltro = ordenesDeudaCliente.FindAll(
                        delegate (Orden or)
                        {
                            return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date && or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                        });
                    if (ordenesFiltro.Count > 0)
                    {
                        listarOrdenesFiltradas(ordenesFiltro);
                    }
                }
                else
                {
                    List<Orden> ordenesFiltro = ordenesDeudaCliente.FindAll(
                       delegate (Orden or)
                       {

                           return or.FechaEntrada.Date <= dtpFechaHasta.Value.Date;
                       });
                    if (ordenesFiltro.Count > 0)
                    {
                        listarOrdenesFiltradas(ordenesFiltro);

                    }
                }
            }
            else
            {
                List<Orden> ordenesFiltro = ordenesDeudaCliente.FindAll(
                       delegate (Orden or)
                       {

                           return or.FechaEntrada.Date >= dtpFechaDesde.Value.Date;
                       });
                if (ordenesFiltro.Count > 0)
                {

                    listarOrdenesFiltradas(ordenesFiltro);
                }
            }
        }
      
        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if(listClientes.SelectedItems.Count > 0 && clienteActual is not null)
            {
                filtroFechaCliente();
            }
            else
            {
                filtroFecha();
            }
           

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (listClientes.SelectedItems.Count > 0 && clienteActual is not null)
            {
                filtroFechaCliente();
            }
            else
            {
                filtroFecha();
            }
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listClientes.SelectedItems.Count > 0)
            {
                Cliente ClienteSelect = _clienteLogic.GetOneConCuit(listClientes.SelectedItems[0].Text);
                if (ClienteSelect is not null)
                {
                    List<Orden> ordenesFiltro = new List<Orden>();
                    foreach (Orden oc in ordenesDeuda)
                    {
                        if (oc.Cliente == ClienteSelect)
                        {
                            ordenesFiltro.Add(oc);
                        }
                    }
                    listarOrdenesFiltradas(ordenesFiltro);
                    ordenesDeudaCliente = ordenesFiltro;
                    clienteActual = ClienteSelect;
                }
            }
            else
            {
                listarOrdenesCliente();
            }
               
        }
    }


}
