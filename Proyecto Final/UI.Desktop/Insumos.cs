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

namespace UI.Desktop
{
    public partial class Insumos : ApplicationForm
    {
        private InsumoLogic _insumoLogic;
        private MaquinaOrdenServicioTipoPrendaLogic _maquinaOrdenServicioTipoPrendaLogic;
        private Insumo insumoActual;
        private LavanderiaContext _context;
        //private InsumoServicioTipoPrenda consumoActual;
        public Insumos(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            _maquinaOrdenServicioTipoPrendaLogic = new MaquinaOrdenServicioTipoPrendaLogic(new MaquinaOrdenServicioTipoPrendaAdapter(context));
            ListarStock();
            chartInsumos2.BackColor = Color.Transparent;
            chartInsumos2.ChartAreas[0].BackColor = Color.Transparent;
            chartInsumos2.Legends[0].BackColor = Color.Transparent;
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
                    item.SubItems.Add(i.PuntoPedido.ToString());
                    item.SubItems.Add(i.Stock.ToString("N2"));
                    listInsumos.Items.Add(item);
                }
            }
        }
        /*
        private void CargarSerieGrafico()
        {
            chartInsumos.Series["Usostp"].Points.Clear();
            double cantTotal = 0;
            double cantXservicioTipoPrenda = 0;
            if (listInsumos.SelectedItems.Count > 0)
            {

                if (insumoActual is not null)
                {
                    cantTotal = CalcularTotalUso(insumoActual.InsumoServicioTipoPrenda);
                    foreach (InsumoServicioTipoPrenda istp in insumoActual.InsumoServicioTipoPrenda)
                    {
                        cantXservicioTipoPrenda = CalcularUsoServicioTipoPrenda(istp);
                        double mostrar = Math.Round((cantXservicioTipoPrenda / cantTotal) * 100, 2);
                        chartInsumos.Series["Usostp"].Points.AddXY(istp.ServicioTipoPrenda.Servicio.Descripcion + "\n" + istp.ServicioTipoPrenda.TipoPrenda.Descripcion + "\n" + mostrar.ToString() + "%", cantXservicioTipoPrenda / cantTotal);
                        chartInsumos.Series["Usostp"].IsValueShownAsLabel = false;
                        chartInsumos.Series["Usostp"].IsXValueIndexed = false;
                        


                    }
                }
            }
        }

        */
        private void CargarSerieGrafico2()
        {
            chartInsumos2.Series["consumo"].Points.Clear();
            double cantTotal = 0;
            if (listInsumos.SelectedItems.Count > 0)
            {
                if (insumoActual is not null)
                {
                    cantTotal = calcularTotalConsumo();
                    foreach (InsumoServicioTipoPrenda istp in insumoActual.InsumoServicioTipoPrenda)
                    {
                        double cantXstp = 0;
                        List<Consumo> consumosFiltro = insumoActual.Consumos.FindAll(
                            delegate (Consumo c)
                            {
                                return c.MaquinaOrdenServicioTipoPrenda.OrdenServicioTipoPrenda.ServicioTipoPrenda == istp.ServicioTipoPrenda;
                            });
                        cantXstp = calcularCantXStp(consumosFiltro);
                        double mostrar = Math.Round((cantXstp / cantTotal) * 100, 2);
                        chartInsumos2.Series["consumo"].Points.AddXY(istp.ServicioTipoPrenda.Servicio.Descripcion + "\n" + istp.ServicioTipoPrenda.TipoPrenda.Descripcion + "\n" + mostrar.ToString() + "%", cantXstp / cantTotal);
                        chartInsumos2.Series["consumo"].IsValueShownAsLabel = true;
                    }
                }
            }
        }
        private double calcularTotalConsumo()
        {
            double _cantidadTotal = 0;
            if (insumoActual.Consumos is not null && insumoActual.Consumos.Count > 0)
            {
                foreach (Consumo c in insumoActual.Consumos)
                {
                    if (c.FechaConsumo.Date >= this.dtpFechaInicio.Value.Date && c.FechaConsumo.Date <= this.dtpFechaHasta.Value.Date)
                    {
                        _cantidadTotal += c.Cantidad;
                    }
                }

            }
            return _cantidadTotal;
        }
        private double calcularCantXStp(List<Consumo> consumosFiltro)
        {
            double cant = 0;
            foreach(Consumo c in consumosFiltro)
            {
                if (c.FechaConsumo.Date >= this.dtpFechaInicio.Value.Date && c.FechaConsumo.Date <= this.dtpFechaHasta.Value.Date)
                {
                    cant += c.Cantidad;
                }
                    
            }
            return cant;
        }
        /*
        private double CalcularTotalUso(List<InsumoServicioTipoPrenda> istps)
        {
            double cantTotal = 0;
            foreach(InsumoServicioTipoPrenda istp in istps)
            {
                List<MaquinaOrdenServicioTipoPrenda> mostp = _maquinaOrdenServicioTipoPrendaLogic.GetAll().FindAll(
                delegate (MaquinaOrdenServicioTipoPrenda mostp)
                {
                    return mostp.OrdenServicioTipoPrenda.ServicioTipoPrenda == istp.ServicioTipoPrenda;
                });
                cantTotal += mostp.Count;
            }
            return cantTotal;
        }
        private double CalcularUsoServicioTipoPrenda(InsumoServicioTipoPrenda istp)
        {
            List<MaquinaOrdenServicioTipoPrenda> mostp = _maquinaOrdenServicioTipoPrendaLogic.GetAll().FindAll(
                delegate (MaquinaOrdenServicioTipoPrenda mostp)
                {
                    return mostp.OrdenServicioTipoPrenda.ServicioTipoPrenda == istp.ServicioTipoPrenda;
                });
            return mostp.Count;
        }
        */
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (listConsumos.Items.Count > 0)
            {
            ListarConsumos();
            this.dtpFechaInicio.Value = DateTime.Today.AddYears(-10);
            this.dtpFechaHasta.Value = DateTime.Today;
            CargarSerieGrafico2();
                CalcularEstadisticasInsumos(this.dtpFechaInicio.MinDate, this.dtpFechaHasta.Value);
            }
            else { MessageBox.Show("Seleccione un insumo y haga click en detalles", "Insumos", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ListarConsumos()
        {
               listConsumos.Items.Clear();
            //if (listInsumos.SelectedItems.Count > 0)
            //{
                insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
                if (insumoActual is not null)
                {
                    foreach (InsumoServicioTipoPrenda istp in insumoActual.InsumoServicioTipoPrenda)
                    {
                        ListViewItem item = new ListViewItem(istp.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(istp.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        //item.SubItems.Add(istp.FechaDesde.ToString());
                        item.SubItems.Add(istp.Cantidad.ToString());
                        listConsumos.Items.Add(item);
                    }
                }
                //else
                //{
                //    MessageBox.Show("Seleccione un insumo y haga click en detalles", "Insumos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            //}
            
        }

        private void listInsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listInsumos.Columns[e.ColumnIndex].Width;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarIns_Click(object sender, EventArgs e)
        {
            InsumoDesktop frmInsumoDesktop = new InsumoDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmInsumoDesktop.ShowDialog();
            ListarStock();
        }

        private void btnEditarIns_Click(object sender, EventArgs e)
        {

            if (listInsumos.SelectedItems.Count > 0)
            {
                int idInsumo = Int32.Parse(listInsumos.SelectedItems[0].Text);
                InsumoDesktop frmInsumoDesktop = new InsumoDesktop(idInsumo, ApplicationForm.ModoForm.Modificacion, _context);
                frmInsumoDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarStock();
        }

        private void btnEliminarIns_Click(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                int idInsumo = Int32.Parse(listInsumos.SelectedItems[0].Text);
                InsumoDesktop frmInsumoDesktop = new InsumoDesktop(idInsumo, ApplicationForm.ModoForm.Baja, _context);
                frmInsumoDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarStock();
        }

        private void txtBuscarInsumos_TextChanged(object sender, EventArgs e)
        {
            listInsumos.Items.Clear();
            List<Insumo> insumos = _insumoLogic.GetAll();
            if (insumos.Count > 0)
            {
                foreach (Insumo i in insumos)
                {
                    if (i.IdInsumo.ToString().ToLower().Contains(this.txtBuscarInsumos.Text.ToLower()) || i.Descripcion.ToLower().Contains(this.txtBuscarInsumos.Text.ToLower())) 
                    {
                        ListViewItem item = new ListViewItem(i.IdInsumo.ToString());
                        item.SubItems.Add(i.Descripcion);
                        listInsumos.Items.Add(item);
                    }
                }
            }

        }

        
        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularEstadisticasInsumos(this.dtpFechaInicio.Value.Date,this.dtpFechaHasta.Value.Date);
            CargarSerieGrafico2();
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            CalcularEstadisticasInsumos(this.dtpFechaInicio.Value.Date, this.dtpFechaHasta.Value.Date);
            CargarSerieGrafico2();
        }

        private void CalcularEstadisticasInsumos(DateTime fechaIni,DateTime fechaHasta) 
        {
            this.lblCantidadInsumoIngresada.Text = "-";
            this.lblInsumosUtilizados.Text = "-";
            double _cantidadUtilizada = 0.0;
            double _cantidadIngresada = 0.0;
            if (insumoActual is not null)
            {
                if (insumoActual.Consumos is not null && insumoActual.Consumos.Count > 0)
                {
                    foreach (Consumo c in insumoActual.Consumos)
                    {
                        if (c.FechaConsumo.Date >= fechaIni.Date && c.FechaConsumo.Date <= fechaHasta.Date)
                        {
                            _cantidadUtilizada += c.Cantidad;
                        }
                    }
                    this.lblInsumosUtilizados.Text = String.Concat(_cantidadUtilizada.ToString("N3"), " ", insumoActual.UnidadMedida.ToString());
                }
                if (insumoActual.InsumosProveedores is not null && insumoActual.InsumosProveedores.Count > 0)
                {
                    foreach (InsumoProveedor ip in insumoActual.InsumosProveedores)
                    {
                        if (ip.FechaIngreso.Date >= fechaIni.Date && ip.FechaIngreso.Date <= fechaHasta.Date)
                        {
                            _cantidadIngresada += ip.Cantidad;
                        }
                    }
                    this.lblCantidadInsumoIngresada.Text = String.Concat(_cantidadIngresada.ToString("N3"), " ", insumoActual.UnidadMedida.ToString());
                }
            }
            //else { MessageBox.Show("Seleccione un insumo y haga click en detalles", "Insumos", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listConsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listConsumos.Columns[e.ColumnIndex].Width;
        }
    }
}
