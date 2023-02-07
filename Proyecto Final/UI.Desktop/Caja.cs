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
        private readonly PagoLogic _pagoLogic;

        public Caja(LavanderiaContext context)
        {
            InitializeComponent();
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _gastoLogic = new GastoLogic(new GastoAdapter(context));
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            _pagoLogic = new PagoLogic(new PagoAdapter(context));
            Singleton.getInstance().ListActual = this.listOrdenes;
            Singleton.getInstance().ListAlternativa = this.listGastos;
            Singleton.getInstance().ModuloActual = "Caja";
            //this.dtpFecha.Value = DateTime.Today;
            //this.dtpFechaHasta.Value = DateTime.Today;
            ActualizarInformacion();
            chartGastos.BackColor = Color.Transparent;
            chartIngresos.BackColor = Color.Transparent;
            chartGastos.ChartAreas[0].BackColor = Color.Transparent;
            chartIngresos.ChartAreas[0].BackColor = Color.Transparent;
            
        }
        /*
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
                        if (gastosHoy is not null && gastosHoy.Count > 0)
                        {
                            foreach (Gasto g in gastosHoy)
                            {
                                gastos += g.Importe;

                            }
                        
                        chartGastos.Series["Gastos"].Points.Add(gastos);
                        chartGastos.Series["Gastos"].Points[x].AxisLabel = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].LegendText = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].Label = gastos.ToString();
                        }
                    }


                    List<Factura> facturasHoy = _facturaLogic.GetAll().FindAll(delegate (Factura f) { return f.FechaFactura.Date <= this.dtpFechaHasta.Value.Date && f.FechaFactura.Date <= this.dtpFechaHasta.Value.Date && f.Pagos is not null; });
                    
                    if (facturasHoy is not null && facturasHoy.Count > 0)
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
                                if (f.Pagos is not null && f.Pagos.Count>0 && f.Pagos[0].FechaPago.Date <= this.dtpFechaHasta.Value.Date)
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
                    if (gastosHoy is not null && gastosHoy.Count > 0)
                    {
                        foreach (Gasto g in gastosHoy)
                        {
                            gastos += g.Importe;

                        }

                        chartGastos.Series["Gastos"].Points.Add(gastos);
                        chartGastos.Series["Gastos"].Points[x].AxisLabel = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].LegendText = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].Label = gastos.ToString();
                    }
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
        */
        private void CargarSeriesGrafico2()
        {
            if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
            {
                if (dtpFecha.Value.Date != DateTime.Now.Date)
                {
                    string[] tiposgasto = Enum.GetNames(typeof(Gasto.TiposGasto));
                    chartGastos.Series["Gastos"].Points.Clear();
                    for (int x = 0; x < tiposgasto.Length; x++)
                    {
                        List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date && g.FechaRealizado.Date <= dtpFechaHasta.Value.Date && g.TipoGasto.ToString() == tiposgasto[x]; });
                        double gastos = 0;
                        if (gastosHoy is not null && gastosHoy.Count > 0)
                        {
                            foreach (Gasto g in gastosHoy)
                            {
                                gastos += g.Importe;

                            }

                            chartGastos.Series["Gastos"].Points.Add(gastos);
                            chartGastos.Series["Gastos"].Points[x].AxisLabel = tiposgasto[x];
                            chartGastos.Series["Gastos"].Points[x].LegendText = tiposgasto[x];
                            chartGastos.Series["Gastos"].Points[x].Label = gastos.ToString();
                        }
                    }
                    List<Pago> pagosHoy = _pagoLogic.GetAll().FindAll(delegate (Pago p) { return p.FechaPago.Date >= this.dtpFecha.Value.Date && p.FechaPago.Date <= this.dtpFechaHasta.Value.Date; });
                    chartIngresos.Series["Ingresos"].Points.Clear();
                    if (pagosHoy is not null && pagosHoy.Count > 0)
                    {
                        List<Pago> pagosOrd = pagosHoy.OrderBy(x => x.FechaPago.Date).ToList();
                       
                        TimeSpan diferenciaFechas = dtpFechaHasta.Value.Date - dtpFecha.Value.Date;
                        if (diferenciaFechas.TotalDays != 0)
                        {
                            DateTime fechaInicial = dtpFecha.Value.Date;
                            for (int x = 1; x <= diferenciaFechas.TotalDays + 1; x++)
                            {
                                double ingresosHoy = 0;
                                foreach (Pago p in pagosOrd)
                                {
                                    if (p.FechaPago.Date == fechaInicial.Date)
                                    {
                                        ingresosHoy += p.Importe;
                                    }
                                }
                                if (ingresosHoy != 0)
                                {
                                    chartIngresos.Series["Ingresos"].Points.AddXY(fechaInicial.Date, ingresosHoy);
                                }
                                fechaInicial = fechaInicial.AddDays(1);

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

                    List<Pago> pagosHoy = _pagoLogic.GetAll().FindAll(delegate (Pago p) { return p.FechaPago.Date <= this.dtpFechaHasta.Value.Date; });
                    chartIngresos.Series["Ingresos"].Points.Clear();
                    if (pagosHoy is not null && pagosHoy.Count > 0)
                    {
                        List<Pago> pagosOrd = pagosHoy.OrderBy(x => x.FechaPago.Date).ToList();
                        
                        TimeSpan diferenciaFechas = dtpFechaHasta.Value.Date - pagosOrd[0].FechaPago.Date;
                        if (diferenciaFechas.TotalDays != 0)
                        {
                            DateTime fechaInicial = dtpFecha.Value.Date;
                            for (int x = 1; x <= diferenciaFechas.TotalDays + 1; x++)
                            {
                                double ingresosHoy = 0;
                                foreach (Pago p in pagosOrd)
                                {
                                    if (p.FechaPago.Date == fechaInicial.Date)
                                    {
                                        ingresosHoy += p.Importe;
                                    }
                                }
                                if (ingresosHoy != 0)
                                {
                                    chartIngresos.Series["Ingresos"].Points.AddXY(fechaInicial.Date, ingresosHoy);
                                }
                                fechaInicial = fechaInicial.AddDays(1);

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
                    if (gastosHoy is not null && gastosHoy.Count > 0)
                    {
                        foreach (Gasto g in gastosHoy)
                        {
                            gastos += g.Importe;

                        }

                        chartGastos.Series["Gastos"].Points.Add(gastos);
                        chartGastos.Series["Gastos"].Points[x].AxisLabel = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].LegendText = tiposgasto[x];
                        chartGastos.Series["Gastos"].Points[x].Label = gastos.ToString();
                    }
                }
                List<Pago> pagosHoy = _pagoLogic.GetAll().FindAll(delegate (Pago p) { return p.FechaPago.Date >= this.dtpFecha.Value.Date; });
                chartIngresos.Series["Ingresos"].Points.Clear();
                if (pagosHoy is not null && pagosHoy.Count > 0)
                {
                    List<Pago> pagosOrd = pagosHoy.OrderBy(x => x.FechaPago.Date).ToList();
                   
                    TimeSpan diferenciaFechas = DateTime.Now.Date - dtpFecha.Value.Date;
                    if (diferenciaFechas.TotalDays != 0)
                    {
                        DateTime fechaInicial = dtpFecha.Value.Date;
                        for (int x = 1; x <= diferenciaFechas.TotalDays + 1; x++)
                        {
                            double ingresosHoy = 0;
                            foreach (Pago p in pagosOrd)
                            {
                                if (p.FechaPago.Date == fechaInicial.Date)
                                {
                                    ingresosHoy += p.Importe;
                                }
                            }
                            if (ingresosHoy != 0)
                            {
                                chartIngresos.Series["Ingresos"].Points.AddXY(fechaInicial.Date, ingresosHoy);
                            }
                            fechaInicial = fechaInicial.AddDays(1);

                        }
                    }
                    else
                    {
                        DateTime fechaInicial = dtpFecha.Value.Date;
                        double ingresosHoy = 0;
                        foreach (Pago p in pagosOrd)
                        {
                            if (p.FechaPago.Date == fechaInicial.Date)
                            {
                                ingresosHoy += p.Importe;
                            }
                        }
                        if (ingresosHoy != 0)
                        {
                            chartIngresos.Series["Ingresos"].Points.AddXY(fechaInicial.Date, ingresosHoy);
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
            //IngresosDelDia();
            //GastosDelDia();
            CargarSeriesGrafico2();
            double ingresos = Double.Parse(this.lblIngresosDia.Text.Remove(0, 2));
            double gastos = Double.Parse(this.lblSalidasDia.Text.Remove(0, 2));
            double balance = ingresos - gastos;
            this.lblBalanceHoy.Text = String.Concat("$ ", balance.ToString());
        }

        private void ActualizarInformacionFiltro()
        {
            filtroFecha();
            ListarGastosFiltro();
            CargarSeriesGrafico2();
            double ingresos = Double.Parse(this.lblIngresosDia.Text.Remove(0, 2));
            double gastos = Double.Parse(this.lblSalidasDia.Text.Remove(0, 2));
            double balance = ingresos - gastos;
            this.lblBalanceHoy.Text = String.Concat("$ ", balance.ToString());
        }
        private void filtroFecha()
        {
            List<Orden> ordenes = _ordenLogic.GetAll();
            listOrdenes.Items.Clear();
            double ingresosTotal = 0;
            if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
            {
                if(dtpFecha.Value.Date != DateTime.Now.Date)
                {
                    foreach(Orden o in ordenes)
                    {
                        double ingresos = 0;
                        if(o.Factura.Pagos is not null && o.Factura.Pagos.Count > 0)
                        {
                            foreach(Pago p in o.Factura.Pagos)
                            {
                                if(p.FechaPago.Date >= dtpFecha.Value.Date && p.FechaPago.Date <= dtpFechaHasta.Value.Date)
                                {
                                    ingresos += p.Importe;
                                }
                            }
                        }
                        if(ingresos != 0)
                        {
                            ListViewItem item = new ListViewItem(o.NroFactura.ToString());
                            if (o.FechaSalida == DateTime.MinValue)
                            {
                                item.SubItems.Add("No retirado");
                            }
                            else
                            {
                                item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
                            }
                            item.SubItems.Add(ingresos.ToString());
                            listOrdenes.Items.Add(item);
                            ingresosTotal += ingresos;
                        }

                    }
                }
                else
                {
                    foreach (Orden o in ordenes)
                    {
                        double ingresos = 0;
                        if (o.Factura.Pagos is not null && o.Factura.Pagos.Count > 0)
                        {
                            foreach (Pago p in o.Factura.Pagos)
                            {
                                if (p.FechaPago.Date <= dtpFechaHasta.Value.Date)
                                {
                                    ingresos += p.Importe;
                                }
                            }
                        }
                        if (ingresos != 0)
                        {
                            ListViewItem item = new ListViewItem(o.NroFactura.ToString());
                            if (o.FechaSalida == DateTime.MinValue)
                            {
                                item.SubItems.Add("No retirado");
                            }
                            else
                            {
                                item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
                            }
                            item.SubItems.Add(ingresos.ToString());
                            listOrdenes.Items.Add(item);
                            ingresosTotal += ingresos;
                        }

                    }
                }
            }
            else
            {
                foreach (Orden o in ordenes)
                {
                    double ingresos = 0;
                    if (o.Factura.Pagos is not null && o.Factura.Pagos.Count > 0)
                    {
                        foreach (Pago p in o.Factura.Pagos)
                        {
                            if (p.FechaPago.Date >= dtpFecha.Value.Date)
                            {
                                ingresos += p.Importe;
                            }
                        }
                    }
                    if (ingresos != 0)
                    {
                        ListViewItem item = new ListViewItem(o.NroFactura.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No retirado");
                        }
                        else
                        {
                            item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
                        }
                        item.SubItems.Add(ingresos.ToString());
                        listOrdenes.Items.Add(item);
                        ingresosTotal += ingresos;
                    }

                }
            }
            this.lblIngresosDia.Text = String.Concat("$ ", ingresosTotal.ToString());
        }
       

        private void ListarOrdenes() 
        {
            List<Orden> ordenes = _ordenLogic.GetAll();
            
            if (ordenes is not null) 
            {
                List<Orden> ordenesOr = ordenes.OrderBy(x => x.FechaEntrada.Date).ToList();
                listOrdenes.Items.Clear();
                double ingresoTotal = 0;
                foreach (Orden o in ordenesOr) 
                {
                    double ingresos = 0;
                    if (o.Factura.Pagos is not null && o.Factura.Pagos.Count > 0) 
                    {
                        foreach (Pago p in o.Factura.Pagos) 
                        {
                            if (p.FechaPago.Date >= DateTime.Now.Date) 
                            {
                                ingresos += p.Importe;
                            }
                        }
                    }
                    if(ingresos != 0)
                    {
                        ListViewItem item = new ListViewItem(o.NroFactura.ToString());
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No retirado");
                        }
                        else
                        {
                            item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
                        }
                        item.SubItems.Add(ingresos.ToString());
                        listOrdenes.Items.Add(item);
                        ingresoTotal += ingresos;
                    }
                    
                }
                this.lblIngresosDia.Text = String.Concat("$ ", ingresoTotal.ToString());

            }
        }
        private void ListarGastosFiltro()
        {
            List<Gasto> gastosFiltro = new List<Gasto>();
            double gastoTotal = 0.0;
            listGastos.Items.Clear();
            if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
            {
                if(dtpFecha.Value.Date != DateTime.Now.Date)
                {
                    gastosFiltro = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date && g.FechaRealizado.Date <= dtpFechaHasta.Value.Date; });
                }
                else
                {
                    gastosFiltro = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date <= dtpFechaHasta.Value.Date; });
                }
            }
            else
            {
                gastosFiltro = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= this.dtpFecha.Value.Date; });
            }
            if (gastosFiltro.Count > 0)
            {
                foreach (Gasto g in gastosFiltro)
                {
                    ListViewItem item = new ListViewItem(g.TipoGasto.ToString());
                    item.SubItems.Add(g.Descripcion);
                    item.SubItems.Add(g.FechaRealizado.ToString());
                    item.SubItems.Add(g.Importe.ToString());
                    listGastos.Items.Add(item);
                    gastoTotal += g.Importe;
                }
                this.lblSalidasDia.Text = String.Concat("$ ", gastoTotal.ToString());
            }
        }
        private void ListarGastos() 
        {
            
            listGastos.Items.Clear();
            List<Gasto> gastos = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date >= DateTime.Now.Date; });
            if (gastos is not null)
            {
                double gastoTotal = 0.0;
                foreach (Gasto g in gastos)
                {
                    ListViewItem item = new ListViewItem(g.TipoGasto.ToString());
                    item.SubItems.Add(g.Descripcion);
                    item.SubItems.Add(g.FechaRealizado.ToString());
                    item.SubItems.Add(g.Importe.ToString());
                    listGastos.Items.Add(item);
                    gastoTotal += g.Importe;
                }
                this.lblSalidasDia.Text = String.Concat("$ ", gastoTotal.ToString());
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
        }

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
        */
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarInformacionFiltro();
           
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
                                if (dtpFechaHasta.Value.Date != DateTime.Now.Date)
                                {
                                    if (dtpFecha.Value.Date != DateTime.Now.Date)
                                    {
                                        Paragraph fechaDesde = new Paragraph();
                                        fechaDesde.SetTextAlignment(TextAlignment.CENTER);
                                        fechaDesde.Add($"El Reporte abarca desde: {dtpFecha.Value.Date.ToString("yyyy/MM/dd")} - hasta: {dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")}\n");
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
                                    fechaDesde.Add($"El Reporte abarca desde: {dtpFecha.Value.Date.ToString("yyyy/MM/dd")}\n");
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
                MessageBox.Show("No hay registros para exportar", "Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            ActualizarInformacionFiltro();
            /*
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
                        if (o.FechaSalida == DateTime.MinValue)
                        {
                            item.SubItems.Add("No retirado");
                        }
                        else
                        {
                            item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
                        }
                        //item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
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
            */
        }

       
    }
}
