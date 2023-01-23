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
using FastReport.DataVisualization.Charting;

namespace UI.Desktop
{
    public partial class Servicios : ApplicationForm
    {
        private readonly ServicioLogic _servicioLogic;
        private readonly LavanderiaContext _context;
        public Servicio servicioActual;
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        public Series serieActual;
        public List<Series> listSeries;

        public Servicios(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
            _servicioTipoPrendaLogic = new ServicioTipoPrendaLogic(new ServicioTipoPrendaAdapter(context));
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            ListarServicios();
            CargarSeriesGrafico();
            chartServicios.BackColor = Color.Transparent;
            chartServicios.ChartAreas[0].BackColor = Color.Transparent;
            chartServicios.Legends[0].BackColor = Color.Transparent;
        }
        private void CargarSeriesGrafico()
        {
            
            List<TipoPrenda> tiposPrenda = _tipoPrendaLogic.GetAll();
            if(tiposPrenda.Count > 0)
            {
                foreach (TipoPrenda tp in tiposPrenda)
                {
                    Series serie = chartServicios.Series.Add(tp.Descripcion);
                }
            }
           
            List<Servicio> servicios = _servicioLogic.GetAll();
            if(servicios.Count > 0)
            {
                foreach (Servicio s in servicios)
                {
                    double cantXprenda = 0;
                    List<Business.Entities.ServicioTipoPrenda> items = _servicioTipoPrendaLogic.GetAll().FindAll(delegate (Business.Entities.ServicioTipoPrenda item)
                    {
                        return item.Servicio == s;
                    });
                    foreach (Business.Entities.ServicioTipoPrenda item in items)
                    {
                        cantXprenda = CalcularCantxPrenda(item);
                        double cantTotal = CalcularTotalxServicio(items);
                        double mostrar = Math.Round((cantXprenda / cantTotal) * 100, 2);
                        chartServicios.Series[item.TipoPrenda.Descripcion].Points.AddXY(s.Descripcion, mostrar);
                        chartServicios.Series[item.TipoPrenda.Descripcion].IsValueShownAsLabel = true;
                    }
                }
            }
            
           
            /*
            List<Servicio> servicios = _servicioLogic.GetAll();
            List<Business.Entities.ServicioTipoPrenda> stp = _servicioTipoPrendaLogic.GetAll();
            List<Series> seriesActuales = new List<Series>();

            foreach (Servicio s in servicios)
            {
                double cantXprenda = 0;
                List<Business.Entities.ServicioTipoPrenda> items = stp.FindAll(delegate (Business.Entities.ServicioTipoPrenda item)
                {
                    return item.Servicio == s;
                });
                if(ValidarExistencia() || chartServicios.Series.Count <= 0)
                foreach (Business.Entities.ServicioTipoPrenda item in items)
                {
                        Series serie = chartServicios.Series.Add(item.TipoPrenda.Descripcion);
                        cantXprenda = CalcularCantxPrenda(item);
                        double cantTotal = CalcularTotalxServicio(items);
                        double mostrar = Math.Round((cantXprenda / cantTotal) * 100, 2);
                        serie.Points.Add(mostrar);
                        serie.LegendText = item.TipoPrenda.Descripcion;
                        seriesActuales.Add(serie);
                        
                }
                listSeries = seriesActuales;
            }
            */
        }
        private void filtroFechaSerie()
        {
            
                List<TipoPrenda> tiposPrenda = _tipoPrendaLogic.GetAll();
                if (tiposPrenda.Count > 0)
                {
                    if(chartServicios.Series.Count > 0)
                    {
                        foreach (TipoPrenda tp in tiposPrenda)
                        {
                            chartServicios.Series[tp.Descripcion].Points.Clear();
                        }
                       
                    }
                    else
                    {
                        foreach (TipoPrenda tp in tiposPrenda)
                        {
                            Series serie = chartServicios.Series.Add(tp.Descripcion);
                        }
                    }
                    
                }

                List<Servicio> servicios = _servicioLogic.GetAll();
                if (servicios.Count > 0)
                {
                    foreach (Servicio s in servicios)
                    {
                        double cantXprenda = 0;
                        List<Business.Entities.ServicioTipoPrenda> items = _servicioTipoPrendaLogic.GetAll().FindAll(delegate (Business.Entities.ServicioTipoPrenda item)
                        {
                            return item.Servicio == s;
                        });
                        foreach (Business.Entities.ServicioTipoPrenda item in items)
                        {
                            cantXprenda = CalcularCantxPrendaFiltro(item);
                            double cantTotal = CalcularTotalxServicioFiltro(items);
                            double mostrar = Math.Round((cantXprenda / cantTotal) * 100, 2);
                            chartServicios.Series[item.TipoPrenda.Descripcion].Points.AddXY(s.Descripcion, mostrar);
                            chartServicios.Series[item.TipoPrenda.Descripcion].IsValueShownAsLabel = true;
                        }
                    }
                }
            
            
        }
        private bool ValidarExistencia()
        {
                bool ok = true;
                if (ok)
                {
                    foreach (Series s in listSeries)
                    {
                        if (!chartServicios.Series.Contains(s))
                        {
                            ok = false;
                        }
                    }
                }
                return ok;
            
        }
        private double CalcularTotalxServicio(List<Business.Entities.ServicioTipoPrenda> items)
        {
            double cantTotal = 0;
            foreach(Business.Entities.ServicioTipoPrenda item in items)
            {
                cantTotal += item.ItemsPedidos.Count;
            }
            return cantTotal;
        }
        private double CalcularTotalxServicioFiltro(List<Business.Entities.ServicioTipoPrenda> items)
        {
            if (dtpServicioHasta.Value.Date != DateTime.Now.Date)
            {
                if (dtpServicioDesde.Value.Date != DateTime.Now.Date)
                {
                    double cantTotal = 0;
                    foreach (Business.Entities.ServicioTipoPrenda item in items)
                    {
                        List<OrdenServicioTipoPrenda> itemsFiltro = item.ItemsPedidos.FindAll(delegate (OrdenServicioTipoPrenda item)
                        {
                            return item.Orden.FechaEntrada.Date >= dtpServicioDesde.Value.Date && item.Orden.FechaEntrada.Date <= dtpServicioHasta.Value.Date;
                        });
                        cantTotal += itemsFiltro.Count;
                    }
                    return cantTotal;
                    
                }
                else
                {
                    double cantTotal = 0;
                    foreach (Business.Entities.ServicioTipoPrenda item in items)
                    {
                        List<OrdenServicioTipoPrenda> itemsFiltro = item.ItemsPedidos.FindAll(delegate (OrdenServicioTipoPrenda item)
                        {
                            return item.Orden.FechaEntrada.Date <= dtpServicioHasta.Value.Date;
                        });
                        cantTotal += itemsFiltro.Count;
                    }
                    return cantTotal;
                }
            }
            else
            {
                double cantTotal = 0;
                foreach (Business.Entities.ServicioTipoPrenda item in items)
                {
                    List<OrdenServicioTipoPrenda> itemsFiltro = item.ItemsPedidos.FindAll(delegate (OrdenServicioTipoPrenda item)
                    {
                        return item.Orden.FechaEntrada.Date >= dtpServicioDesde.Value.Date ;
                    });
                    cantTotal += itemsFiltro.Count;
                }
                return cantTotal;
            }
            
        }
        private double CalcularCantxPrenda(Business.Entities.ServicioTipoPrenda item)
        {
            return item.ItemsPedidos.Count;
        }
        private double CalcularCantxPrendaFiltro(Business.Entities.ServicioTipoPrenda item)
        {
            if (dtpServicioHasta.Value.Date != DateTime.Now.Date)
            {
                if (dtpServicioDesde.Value.Date != DateTime.Now.Date)
                {
                    List<OrdenServicioTipoPrenda> itemsPedidosfiltro = item.ItemsPedidos.FindAll(delegate (OrdenServicioTipoPrenda elem)
                    {
                        return elem.Orden.FechaEntrada.Date >= dtpServicioDesde.Value.Date && elem.Orden.FechaEntrada.Date <= dtpServicioHasta.Value.Date;
                    });
                    return itemsPedidosfiltro.Count;
                }
                else
                {
                    List<OrdenServicioTipoPrenda> itemsPedidosfiltro = item.ItemsPedidos.FindAll(delegate (OrdenServicioTipoPrenda elem)
                    {
                        return elem.Orden.FechaEntrada.Date <= dtpServicioHasta.Value.Date;
                    });
                    return itemsPedidosfiltro.Count;
                }
            }
            else
            {
                List<OrdenServicioTipoPrenda> itemsPedidosfiltro = item.ItemsPedidos.FindAll(delegate (OrdenServicioTipoPrenda elem)
                {
                    return elem.Orden.FechaEntrada.Date >= dtpServicioDesde.Value.Date;
                });
                return itemsPedidosfiltro.Count;
            }

        }
        private void ListarServicios() 
        {
            listServicios.Items.Clear();
            List<Servicio> servicios = _servicioLogic.GetAll();
            if (servicios is not null) 
            {
                foreach (Servicio s in servicios) 
                {
                    ListViewItem item = new ListViewItem(s.IdServicio.ToString());
                    item.SubItems.Add(s.Descripcion);
                    listServicios.Items.Add(item);
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ServicioDesktop frmServicio = new ServicioDesktop(ModoForm.Alta, _context);
            frmServicio.ShowDialog();
            ListarServicios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listServicios.SelectedItems.Count > 0) 
            {
                int idServicio = Int32.Parse(listServicios.SelectedItems[0].Text);
                ServicioDesktop frmServicio = new ServicioDesktop(idServicio,ModoForm.Modificacion, _context);
                frmServicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarServicios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listServicios.SelectedItems.Count > 0)
            {
                int idServicio = Int32.Parse(listServicios.SelectedItems[0].Text);
                ServicioDesktop frmServicio = new ServicioDesktop(idServicio, ModoForm.Baja, _context);
                frmServicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarServicios();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listServicios_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listServicios.Columns[e.ColumnIndex].Width;
        }


        private void dtpServicioDesde_ValueChanged(object sender, EventArgs e)
        {
            filtroFechaSerie();
        }

        private void dtpServicioHasta_ValueChanged(object sender, EventArgs e)
        {
            filtroFechaSerie();
        }
    }
}
