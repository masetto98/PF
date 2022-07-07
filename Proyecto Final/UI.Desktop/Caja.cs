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
    public partial class Caja : ApplicationForm
    {
        private readonly OrdenLogic _ordenLogic;
        private readonly GastoLogic _gastoLogic;



        public Caja(LavanderiaContext context)
        {
            InitializeComponent();
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _gastoLogic = new GastoLogic(new GastoAdapter(context));
            this.dtpFecha.Value = DateTime.Today;
            ActualizarInformacion();
        }

        private void ActualizarInformacion() 
        {
            ListarOrdenes();
            ListarGastos();
            //SaldoAnterior();
            IngresosDelDia();
            GastosDelDia();
            double ingresos = Double.Parse(this.lblIngresosDia.Text.Remove(0, 2));
            double gastos = Double.Parse(this.lblSalidasDia.Text.Remove(0, 2));
            double balance = ingresos - gastos;
            this.lblBalanceHoy.Text = String.Concat("$ ", balance.ToString());
        }

        private void ListarOrdenes() 
        {
            List<Orden> ordenes = _ordenLogic.GetAll().FindAll(delegate (Orden o)
            { return o.FechaSalida.Date == this.dtpFecha.Value.Date; });
            if (ordenes is not null) 
            {
                listOrdenes.Items.Clear();
                foreach (Orden o in ordenes) 
                {
                    ListViewItem item = new ListViewItem(o.NroFactura.ToString());
                    item.SubItems.Add(o.FechaSalida.Date.ToString("yyyy-MM-dd"));
                    listOrdenes.Items.Add(item);
                }
            }
        }

        private void ListarGastos() 
        {
            listGastos.Items.Clear();
            List<Gasto> gastos = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date == this.dtpFecha.Value.Date; });
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
            List<Orden> ordenesHoy= _ordenLogic.GetAll().FindAll(delegate (Orden o) { return o.FechaSalida.Date == this.dtpFecha.Value.Date;});
            if (ordenesHoy is not null)
            {
                foreach (Orden o in ordenesHoy)
                {
                    if (o.Factura is not null && o.Factura.Pagos is not null)
                    {
                        foreach (Pago p in o.Factura.Pagos)
                        {
                            ingresosHoy += p.Importe;
                        }
                    }
                }
                this.lblIngresosDia.Text = String.Concat("$ ", ingresosHoy.ToString());
            }
        }

        private void GastosDelDia() 
        {
            double gastos = 0.0;
            List<Gasto> gastosHoy = _gastoLogic.GetAll().FindAll(delegate (Gasto g) { return g.FechaRealizado.Date == this.dtpFecha.Value.Date; });
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
    }
}
