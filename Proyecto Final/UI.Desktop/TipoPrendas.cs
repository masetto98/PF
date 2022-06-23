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
    public partial class TipoPrendas : ApplicationForm
    {
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        private readonly LavanderiaContext _context;

        public TipoPrendas(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            ListarTipoPrendas();
        }

        private void ListarTipoPrendas() 
        {
            listTipoPrendas.Items.Clear();
            List<TipoPrenda> tiposPrenda = _tipoPrendaLogic.GetAll();
            if (tiposPrenda is not null) 
            {
                foreach (TipoPrenda tp in tiposPrenda) 
                {
                    ListViewItem item = new ListViewItem(tp.IdTipoPrenda.ToString());
                    item.SubItems.Add(tp.Descripcion);
                    listTipoPrendas.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TipoPrendaDesktop frmTipoPrenda = new TipoPrendaDesktop(ModoForm.Alta, _context);
            frmTipoPrenda.ShowDialog();
            ListarTipoPrendas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listTipoPrendas.SelectedItems.Count > 0)
            {
                int idTipoPrenda = Int32.Parse(listTipoPrendas.SelectedItems[0].Text);
                TipoPrendaDesktop frmTipoPrenda = new TipoPrendaDesktop(idTipoPrenda,ModoForm.Modificacion, _context);
                frmTipoPrenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarTipoPrendas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listTipoPrendas.SelectedItems.Count > 0)
            {
                int idTipoPrenda = Int32.Parse(listTipoPrendas.SelectedItems[0].Text);
                TipoPrendaDesktop frmTipoPrenda = new TipoPrendaDesktop(idTipoPrenda, ModoForm.Baja, _context);
                frmTipoPrenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarTipoPrendas();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (listTipoPrendas.SelectedItems.Count > 0)
            {

            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listTipoPrendas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listTipoPrendas.Columns[e.ColumnIndex].Width;
        }
    }
}
