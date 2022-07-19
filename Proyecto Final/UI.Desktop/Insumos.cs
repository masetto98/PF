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
        private Insumo insumoActual;
        private LavanderiaContext _context;
        private InsumoServicioTipoPrenda consumoActual;
        public Insumos(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
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
            ListarConsumos();
        }
        private void ListarConsumos()
        {
            listConsumos.Items.Clear();
            if (listInsumos.SelectedItems.Count > 0)
            {
                insumoActual = _insumoLogic.GetOne(Int32.Parse(listInsumos.SelectedItems[0].Text));
                if (insumoActual is not null)
                {
                    foreach (InsumoServicioTipoPrenda istp in insumoActual.InsumoServicioTipoPrenda)
                    {
                        ListViewItem item = new ListViewItem(istp.ServicioTipoPrenda.Servicio.Descripcion);
                        item.SubItems.Add(istp.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        item.SubItems.Add(istp.FechaDesde.ToString());
                        item.SubItems.Add(istp.Cantidad.ToString());
                        listConsumos.Items.Add(item);
                    }
                }
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(listInsumos.SelectedItems.Count > 0)
            {
                if(listConsumos.SelectedItems.Count > 0)
                {
                    InsumoServicioTipoPrenda stpActual = insumoActual.InsumoServicioTipoPrenda.Find(
                           delegate (InsumoServicioTipoPrenda istp)
                           {
                               return istp.ServicioTipoPrenda.Servicio.Descripcion == listConsumos.SelectedItems[0].Text && istp.ServicioTipoPrenda.TipoPrenda.Descripcion == listConsumos.SelectedItems[0].SubItems[1].Text;
                           });
                    ServicioTipoPrendaDesktop frmConsumo = new ServicioTipoPrendaDesktop(stpActual.IdServicio, stpActual.IdTipoPrenda, ApplicationForm.ModoForm.Modificacion, _context);
                    frmConsumo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila en la lista Consumos para poder agregar", "Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista Insumos para poder agregar", "Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listInsumos.SelectedItems.Count > 0)
            {
                if (listConsumos.SelectedItems.Count > 0)
                {
                    InsumoServicioTipoPrenda stpActual = insumoActual.InsumoServicioTipoPrenda.Find(
                           delegate (InsumoServicioTipoPrenda istp)
                           {
                               return istp.ServicioTipoPrenda.Servicio.Descripcion == listConsumos.SelectedItems[0].Text && istp.ServicioTipoPrenda.TipoPrenda.Descripcion == listConsumos.SelectedItems[0].SubItems[1].Text;
                           });
                    ServicioTipoPrendaDesktop frmConsumo = new ServicioTipoPrendaDesktop(stpActual.IdServicio, stpActual.IdTipoPrenda, ApplicationForm.ModoForm.Modificacion, _context);
                    frmConsumo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila en la lista Consumos para poder agregar", "Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista Insumos para poder agregar", "Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
