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
            
            CargarSeriesGrafico();
        }
        
        private void CargarSeriesGrafico()
        {
            List<Empleado> empleados = _empleadoLogic.GetAll().FindAll(
                delegate(Empleado em)
                {
                    return em.TipoEmpleado == Empleado.TiposEmpleado.Usuario;
                });
            chartEmpleados.ChartAreas[0].BackColor = Color.Transparent;
            chartEmpleados.Legends[0].BackColor = Color.Transparent;
            if(empleados.Count > 0)
            {
                Series serie = chartEmpleados.Series.Add("Ordenes Registradas");
                Series serie2 = chartEmpleados.Series.Add("Trabajos Atendidos");
                foreach (Empleado ep in empleados)
                {
                    if(ep.OrdenesRegistradas is not null)
                    {
                        double cantOrdenesReg = 0;
                        double cantOrdenesTotalReg = 0;
                        cantOrdenesReg = ep.OrdenesRegistradas.Count;
                        cantOrdenesTotalReg = CalcularOrdRegTotal(empleados);
                        double mostrar = Math.Round((cantOrdenesReg / cantOrdenesTotalReg) * 100, 2);
                        chartEmpleados.Series["Ordenes Registradas"].Points.AddXY(ep.Nombre + "\n" + ep.Apellido, mostrar);
                        chartEmpleados.Series["Ordenes Registradas"].IsValueShownAsLabel = true;
                        double cantOrdenesAten = 0;
                        double cantOrdenesTotalAten = 0;
                        cantOrdenesAten = ep.OrdenesAtendidas.Count;
                        cantOrdenesTotalAten = CalcularOrdAtenTotal(empleados);
                        double mostrar2 = Math.Round((cantOrdenesAten / cantOrdenesTotalAten) * 100, 2);
                        chartEmpleados.Series["Trabajos Atendidos"].Points.AddXY(ep.Nombre + "\n" + ep.Apellido, mostrar2);
                        chartEmpleados.Series["Trabajos Atendidos"].IsValueShownAsLabel = true;
                    }
                }
                serie.IsVisibleInLegend = true;
                serie2.IsVisibleInLegend = true;
            }
            
        }
        private double CalcularOrdAtenTotal(List<Empleado> empleados)
        {
            double cantOrdAtenTotal = 0;
            foreach(Empleado e in empleados)
            {
                if (e.OrdenesAtendidas is not null)
                {
                    cantOrdAtenTotal += e.OrdenesAtendidas.Count;
                }
            }
            return cantOrdAtenTotal;
        }
        private double CalcularOrdRegTotal(List<Empleado> empleados)
        {
            double cantOrdenRegTotal = 0;
            foreach(Empleado e in empleados)
            {
                if (e.OrdenesRegistradas is not null)
                {
                    cantOrdenRegTotal += e.OrdenesRegistradas.Count;
                }
            }
            return cantOrdenRegTotal;
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
