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
    public partial class Empleados : ApplicationForm
    {
        private readonly EmpleadoLogic _empleadoLogic;
        private readonly LavanderiaContext _context;

        public Empleados(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
            ListarEmpleados();
        }

        private void ListarEmpleados() 
        {
            listEmpleados.Items.Clear();
            List<Empleado> empleadosActuales = _empleadoLogic.GetAll();
            if (empleadosActuales is not null) 
            {
                foreach (Empleado e in empleadosActuales) 
                {
                    ListViewItem item = new ListViewItem(e.IdEmpleado.ToString());
                    item.SubItems.Add(e.Cuit);
                    item.SubItems.Add(e.Nombre);
                    item.SubItems.Add(e.Apellido);
                    listEmpleados.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoDesktop frmEmpleado = new EmpleadoDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmEmpleado.ShowDialog();
            ListarEmpleados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listEmpleados.SelectedItems.Count > 0) 
            {
                int idEmpleado = Int32.Parse(listEmpleados.SelectedItems[0].Text);
                EmpleadoDesktop frmEmpleado = new EmpleadoDesktop(idEmpleado,ApplicationForm.ModoForm.Modificacion, _context) ;
                frmEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarEmpleados();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listEmpleados.SelectedItems.Count > 0)
            {
                int idEmpleado = Int32.Parse(listEmpleados.SelectedItems[0].Text);
                EmpleadoDesktop frmEmpleado = new EmpleadoDesktop(idEmpleado, ApplicationForm.ModoForm.Baja, _context);
                frmEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarEmpleados();

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.lblOrdenesAtendidas.Text = " - ";
            this.lblOrdenesRegistradas.Text = " - ";
            if (listEmpleados.SelectedItems.Count > 0) 
            {
                Empleado empleadoActual = _empleadoLogic.GetOne(Int32.Parse(listEmpleados.SelectedItems[0].Text));
                if (empleadoActual is not null)
                {
                    if (empleadoActual.OrdenesAtendidas is not null)
                    {
                        this.lblOrdenesAtendidas.Text = empleadoActual.OrdenesAtendidas.Count.ToString();
                    }
                    if (empleadoActual.OrdenesRegistradas is not null)
                    {
                        this.lblOrdenesRegistradas.Text = empleadoActual.OrdenesRegistradas.Count.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder observar los detalles", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listEmpleados_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listEmpleados.Columns[e.ColumnIndex].Width;
        }
    }
}
