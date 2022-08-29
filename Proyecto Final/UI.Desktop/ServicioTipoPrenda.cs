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

namespace UI.Desktop
{
    public partial class ServicioTipoPrenda : ApplicationForm
    {
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        private readonly LavanderiaContext _context;
        public ServicioTipoPrenda servicioTipoPrendaActual;
        private readonly OrdenServicioTipoPrendaLogic _ordenItems;
        public ServicioTipoPrenda(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _servicioTipoPrendaLogic = new ServicioTipoPrendaLogic(new ServicioTipoPrendaAdapter(context));
            _ordenItems = new OrdenServicioTipoPrendaLogic(new OrdenServicioTipoPrendaAdapter(context));
            ListarServicioTipoPrenda();
            CargarSerieGrafico();
        }
        private void CargarSerieGrafico()
        {
            List<Business.Entities.ServicioTipoPrenda> stp = _servicioTipoPrendaLogic.GetAll();
            List<OrdenServicioTipoPrenda> ordenItems = _ordenItems.GetAll();
            double totalItems = ordenItems.Count;
            foreach (Business.Entities.ServicioTipoPrenda item in stp)
            {
                double cantxItem = 0;
                foreach (OrdenServicioTipoPrenda oi in ordenItems)
                {
                    if (oi.ServicioTipoPrenda == item)
                    {
                        cantxItem += 1;
                    }
                }
                double mostrar = Math.Round((cantxItem / totalItems) * 100, 2);
                chartItem.Series["Series1"].Points.AddXY(item.Servicio.Descripcion +" "+ item.TipoPrenda.Descripcion, mostrar);

            }
        }
        private void ListarServicioTipoPrenda() 
        {
            listServiciosTipoPrendas.Items.Clear();
            List<Business.Entities.ServicioTipoPrenda> serviciosTipoPrendas = _servicioTipoPrendaLogic.GetAll();
            if (serviciosTipoPrendas is not null) 
            {
                foreach (Business.Entities.ServicioTipoPrenda stp in serviciosTipoPrendas) 
                {
                    ListViewItem item = new ListViewItem(stp.Servicio.Descripcion);
                    item.SubItems.Add(stp.TipoPrenda.Descripcion);
                    listServiciosTipoPrendas.Items.Add(item);
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ServicioTipoPrendaDesktop frmServicioTipoPrenda = new ServicioTipoPrendaDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmServicioTipoPrenda.ShowDialog();
            ListarServicioTipoPrenda();
        }

        private void btnEditarServicioTipoPrenda_Click(object sender, EventArgs e)
        {
            if (listServiciosTipoPrendas.SelectedItems.Count > 0)
            {
                Business.Entities.ServicioTipoPrenda ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetAll().Find(delegate (Business.Entities.ServicioTipoPrenda stp) 
                {
                    return stp.Servicio.Descripcion == listServiciosTipoPrendas.SelectedItems[0].Text &&
                           stp.TipoPrenda.Descripcion == listServiciosTipoPrendas.SelectedItems[0].SubItems[1].Text;
                });
                ServicioTipoPrendaDesktop frmServicioTipoPrenda = new ServicioTipoPrendaDesktop(ServicioTipoPrendaActual.IdServicio, ServicioTipoPrendaActual.IdTipoPrenda,ApplicationForm.ModoForm.Modificacion, _context);
                frmServicioTipoPrenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Servicios Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarServicioTipoPrenda();
        }

        private void btnEliminarServicioTipoPrenda_Click(object sender, EventArgs e)
        {
            if (listServiciosTipoPrendas.SelectedItems.Count > 0)
            {
                Business.Entities.ServicioTipoPrenda ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetAll().Find(delegate (Business.Entities.ServicioTipoPrenda stp)
                {
                    return stp.Servicio.Descripcion == listServiciosTipoPrendas.SelectedItems[0].Text &&
                           stp.TipoPrenda.Descripcion == listServiciosTipoPrendas.SelectedItems[0].SubItems[1].Text;
                });
                ServicioTipoPrendaDesktop frmServicioTipoPrenda = new ServicioTipoPrendaDesktop(ServicioTipoPrendaActual.IdServicio, ServicioTipoPrendaActual.IdTipoPrenda, ApplicationForm.ModoForm.Baja, _context);
                frmServicioTipoPrenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Servicios Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarServicioTipoPrenda();

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            ResetLabels();
            if (listServiciosTipoPrendas.SelectedItems.Count > 0)
            {
                var stpActual = _servicioTipoPrendaLogic.GetAll().Find(delegate (Business.Entities.ServicioTipoPrenda stp)
                {
                    return stp.Servicio.Descripcion == listServiciosTipoPrendas.SelectedItems[0].Text &&
                           stp.TipoPrenda.Descripcion == listServiciosTipoPrendas.SelectedItems[0].SubItems[1].Text;
                });
                Business.Entities.ServicioTipoPrenda ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetOne(stpActual.IdServicio, stpActual.IdTipoPrenda);
                this.lblCantidadSolicitudes.Text = ServicioTipoPrendaActual.ItemsPedidos.Count.ToString();
                CalcularTiempoPromedio(ServicioTipoPrendaActual);
                CalcularIngresos(ServicioTipoPrendaActual);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para observar los detalles", "Servicios Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CalcularTiempoPromedio(Business.Entities.ServicioTipoPrenda stpActual) 
        {
            TimeSpan timepoTotal = new TimeSpan(0, 00, 00, 00);
            foreach (OrdenServicioTipoPrenda ostp in stpActual.ItemsPedidos) 
            {
                if (ostp.MaquinaOrdenServicioTipoPrenda is not null)
                {
                    foreach (MaquinaOrdenServicioTipoPrenda mostp in ostp.MaquinaOrdenServicioTipoPrenda)
                    {
                        timepoTotal = timepoTotal + (mostp.TiempoFinServicio - mostp.TiempoInicioServicio);

                    }
                }
                
            }
            double divisor = stpActual.ItemsPedidos.Count;
            if (divisor != 0)
            {
                this.lblTiempoPromedio.Text = timepoTotal.Divide(divisor).ToString(@"dd\:hh\:mm\:ss");
            }
        }

        private void CalcularIngresos(Business.Entities.ServicioTipoPrenda stpActual) 
        {
            double ingresosMes = 0.00;
            double ingresosHistorico = 0.00;
            foreach (OrdenServicioTipoPrenda ostp in stpActual.ItemsPedidos)
            {
                Precio precioActual = ostp.ServicioTipoPrenda.HistoricoPrecios.FindLast(delegate (Precio p)
                {
                    return p.FechaDesde <= ostp.Orden.FechaSalida;
                });
                if (ostp.Orden.FechaEntrada >= DateTime.Today.AddMonths(-1) && ostp.Estado == OrdenServicioTipoPrenda.Estados.Finalizado) 
                {
                    if (precioActual is not null)
                    {
                        ingresosMes += (double)precioActual.Valor;
                    }
                }
                if (precioActual is not null)
                {
                    ingresosHistorico += (double)precioActual.Valor;
                }
            }
            this.lblIngresosUtlimoMes.Text = ingresosMes.ToString();
            this.lblIngresoTotalObtenido.Text = ingresosHistorico.ToString();
        }
        private void ResetLabels() 
        {
            this.lblCantidadSolicitudes.Text = " - ";
            this.lblIngresosUtlimoMes.Text = " - ";
            this.lblIngresoTotalObtenido.Text = " - ";
            this.lblTiempoPromedio.Text = " - ";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listServiciosTipoPrendas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listServiciosTipoPrendas.Columns[e.ColumnIndex].Width;
        }
    }
}
