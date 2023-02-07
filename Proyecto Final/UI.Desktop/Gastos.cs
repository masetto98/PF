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
    public partial class Gastos : ApplicationForm
    {
        private GastoLogic _gastoLogic;
        private LavanderiaContext _context;

        public Gastos(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _gastoLogic = new GastoLogic(new GastoAdapter(context));
            RellenarComboBox(listGastos, cmbFiltro);
            ListarGastos();
        }

        private void RellenarComboBox(ListView listActual, ComboBox cbActual)
        {
            List<string> columnas = new List<string>();
            foreach (ColumnHeader c in listActual.Columns)
            {
                columnas.Add(c.Text);
            }
            cbActual.DataSource = columnas;
        }

        private void ListarGastos() 
        {
            listGastos.Items.Clear();
            List<Gasto> gastos = _gastoLogic.GetAll();
            if (gastos is not null)
            {
                foreach (Gasto g in gastos)  
                {
                    ListViewItem item = new ListViewItem(g.IdGasto.ToString());
                    item.SubItems.Add(g.TipoGasto.ToString());
                    item.SubItems.Add(g.Descripcion);
                    item.SubItems.Add(g.FechaRealizado.ToString());
                    item.SubItems.Add(g.Importe.ToString());
                    item.SubItems.Add(String.Concat(g.IdEmpleado," - ",g.Empleado.Apellido, " ", g.Empleado.Nombre));
                    listGastos.Items.Add(item);
                }
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GastoDesktop frmGastoDesktop = new GastoDesktop(ModoForm.Alta, _context);
            frmGastoDesktop.ShowDialog();
            ListarGastos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listGastos.SelectedItems.Count > 0)
            {
                int idGasto = Int32.Parse(listGastos.SelectedItems[0].Text);
                GastoDesktop frmGastoDesktop = new GastoDesktop(idGasto,ModoForm.Modificacion, _context);
                frmGastoDesktop.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarGastos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listGastos.SelectedItems.Count > 0)
            {
                int idGasto = Int32.Parse(listGastos.SelectedItems[0].Text);
                GastoDesktop frmGastoDesktop = new GastoDesktop(idGasto, ModoForm.Baja, _context);
                frmGastoDesktop.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarGastos();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            listGastos.Items.Clear();
            List<Gasto> gastos = _gastoLogic.GetAll();
            if (this.cmbFiltro.SelectedItem.ToString() == "ID")
            {
                foreach (Gasto g in gastos)
                {
                    if (g.IdGasto.ToString().Contains(this.txtBuscar.Text))
                    {
                        ListViewItem item = new ListViewItem(g.IdGasto.ToString());
                        item.SubItems.Add(g.TipoGasto.ToString());
                        item.SubItems.Add(g.Descripcion);
                        item.SubItems.Add(g.FechaRealizado.ToString());
                        item.SubItems.Add(g.Importe.ToString());
                        item.SubItems.Add(String.Concat(g.IdEmpleado, " - ", g.Empleado.Apellido, " ", g.Empleado.Nombre));
                        listGastos.Items.Add(item);
                    }
                }
            }
            if (this.cmbFiltro.SelectedItem.ToString() == "Tipo Gasto")
            {
                foreach (Gasto g in gastos)
                {
                    if (g.TipoGasto.ToString().ToLower().Contains(this.txtBuscar.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(g.IdGasto.ToString());
                        item.SubItems.Add(g.TipoGasto.ToString());
                        item.SubItems.Add(g.Descripcion);
                        item.SubItems.Add(g.FechaRealizado.ToString());
                        item.SubItems.Add(g.Importe.ToString());
                        item.SubItems.Add(String.Concat(g.IdEmpleado, " - ", g.Empleado.Apellido, " ", g.Empleado.Nombre));
                        listGastos.Items.Add(item);
                    }
                }
            }
            if (this.cmbFiltro.SelectedItem.ToString() == "Descripción")
            {
                foreach (Gasto g in gastos)
                {
                    if (g.Descripcion.ToLower().Contains(this.txtBuscar.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(g.IdGasto.ToString());
                        item.SubItems.Add(g.TipoGasto.ToString());
                        item.SubItems.Add(g.Descripcion);
                        item.SubItems.Add(g.FechaRealizado.ToString());
                        item.SubItems.Add(g.Importe.ToString());
                        item.SubItems.Add(String.Concat(g.IdEmpleado, " - ", g.Empleado.Apellido, " ", g.Empleado.Nombre));
                        listGastos.Items.Add(item);
                    }
                }
            }
            if (this.cmbFiltro.SelectedItem.ToString() == "Fecha")
            {
                foreach (Gasto g in gastos)
                {
                    if (g.FechaRealizado.ToString().Contains(this.txtBuscar.Text))
                    {
                        ListViewItem item = new ListViewItem(g.IdGasto.ToString());
                        item.SubItems.Add(g.TipoGasto.ToString());
                        item.SubItems.Add(g.Descripcion);
                        item.SubItems.Add(g.FechaRealizado.ToString());
                        item.SubItems.Add(g.Importe.ToString());
                        item.SubItems.Add(String.Concat(g.IdEmpleado, " - ", g.Empleado.Apellido, " ", g.Empleado.Nombre));
                        listGastos.Items.Add(item);
                    }
                }
            }
            if (this.cmbFiltro.SelectedItem.ToString() == "Importe")
            {
                foreach (Gasto g in gastos)
                {
                    if (g.Importe.ToString().Contains(this.txtBuscar.Text))
                    {
                        ListViewItem item = new ListViewItem(g.IdGasto.ToString());
                        item.SubItems.Add(g.TipoGasto.ToString());
                        item.SubItems.Add(g.Descripcion);
                        item.SubItems.Add(g.FechaRealizado.ToString());
                        item.SubItems.Add(g.Importe.ToString());
                        item.SubItems.Add(String.Concat(g.IdEmpleado, " - ", g.Empleado.Apellido, " ", g.Empleado.Nombre));
                        listGastos.Items.Add(item);
                    }
                }
            }

            if (this.cmbFiltro.SelectedItem.ToString() == "Empleado")
            {
                foreach (Gasto g in gastos)
                {
                    if (String.Concat(g.IdEmpleado, " - ", g.Empleado.Apellido, " ", g.Empleado.Nombre).ToLower().Contains(this.txtBuscar.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(g.IdGasto.ToString());
                        item.SubItems.Add(g.TipoGasto.ToString());
                        item.SubItems.Add(g.Descripcion);
                        item.SubItems.Add(g.FechaRealizado.ToString());
                        item.SubItems.Add(g.Importe.ToString());
                        item.SubItems.Add(String.Concat(g.IdEmpleado, " - ", g.Empleado.Apellido, " ", g.Empleado.Nombre));
                        listGastos.Items.Add(item);
                    }
                }
            }
            if (this.txtBuscar.Text == "") { ListarGastos(); }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listGastos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listGastos.Columns[e.ColumnIndex].Width;
        }
    }
}
