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
    public partial class Maquinas : ApplicationForm
    {
        private readonly MaquinaLogic _maquinaLogic;
        private readonly TiposMaquinaLogic _tiposMaquinaLogic;
        private readonly LavanderiaContext _context;
        public Maquina MaquinaActual { get; set; }

        public Maquinas(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
            _tiposMaquinaLogic = new TiposMaquinaLogic(new TiposMaquinaAdapter(context));
            //ListarMaquinas();
            ListarTiposMaquinas();
        }

        private void ListarTiposMaquinas() 
        {
            listTiposMaquina.Items.Clear();
            List<TiposMaquina> tiposMaquinas = _tiposMaquinaLogic.GetAll();
            if (tiposMaquinas is not null)
            {
                foreach (TiposMaquina m in tiposMaquinas)
                {
                    ListViewItem item = new ListViewItem(m.IdTipoMaquina.ToString());
                    item.SubItems.Add(m.Descripcion);
                    listTiposMaquina.Items.Add(item);
                }
            }
        }

        private void listTiposMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarMaquinas();
        }

        private void listMaquinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listMantenimientos.Items.Clear();
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaActual = _maquinaLogic.GetOne(idMaquina);
                if (MaquinaActual.itemsAtendidos is not null)
                {
                    this.lblOrdenesAtendidas.Text = MaquinaActual.itemsAtendidos.Count.ToString();
                }
                if (MaquinaActual.Mantenimientos is not null)
                {
                    this.lblMantenimientosRealizados.Text = MaquinaActual.Mantenimientos.Count.ToString();

                }

            }
            //else
            //{
            //    MessageBox.Show("Debe seleccionar una fila en la lista para poder observar los detalles", "Máquina Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            ListarMantenimientos();

        }
        /*
        private void ListarMaquinas() 
        {
            listMaquinas.Items.Clear();
            List<Maquina> maquinas = _maquinaLogic.GetAll();
            if (maquinas is not null) 
            {
                foreach (Maquina m in maquinas) 
                {
                    ListViewItem item = new ListViewItem(m.IdMaquina.ToString());
                    item.SubItems.Add(m.Descripcion);
                    listMaquinas.Items.Add(item);
                }
            }
        }*/

        private void ListarMaquinas() 
        {
            listMaquinas.Items.Clear();
            if (listTiposMaquina.SelectedItems.Count > 0)
            {
                TiposMaquina tipoMaquinaActual = _tiposMaquinaLogic.GetOne(Int32.Parse(listTiposMaquina.SelectedItems[0].Text));
                if (tipoMaquinaActual is not null && tipoMaquinaActual.Maquinas is not null)
                {
                    foreach (Maquina m in tipoMaquinaActual.Maquinas)
                    {
                        ListViewItem item = new ListViewItem(m.IdMaquina.ToString());
                        item.SubItems.Add(m.Descripcion);
                        listMaquinas.Items.Add(item);
                    }
                }
            }
        }

        private void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            MaquinaDesktop frmMaquinaDesktop = new MaquinaDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmMaquinaDesktop.ShowDialog();
            ListarMaquinas();
        }

        private void btnEditarMaquina_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0) 
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaDesktop frmMaquinaDesktop = new MaquinaDesktop(idMaquina,ApplicationForm.ModoForm.Modificacion, _context);
                frmMaquinaDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMaquinas();
        }

        private void btnEliminarMaquina_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaDesktop frmMaquinaDesktop = new MaquinaDesktop(idMaquina, ApplicationForm.ModoForm.Baja, _context);
                frmMaquinaDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMaquinas();

        }
        
        private void btnDetalles_Click(object sender, EventArgs e)
        {/*
            listMantenimientos.Items.Clear();
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaActual = _maquinaLogic.GetOne(idMaquina);
                if (MaquinaActual.itemsAtendidos is not null) 
                {
                    this.lblOrdenesAtendidas.Text = MaquinaActual.itemsAtendidos.Count.ToString();
                }
                if (MaquinaActual.Mantenimientos is not null) 
                {
                    this.lblMantenimientosRealizados.Text = MaquinaActual.Mantenimientos.Count.ToString();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder observar los detalles", "Máquina Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();*/
        }

        public void ListarMantenimientos() 
        {
            listMantenimientos.Items.Clear();
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaActual = _maquinaLogic.GetOne(idMaquina);
                if (MaquinaActual.Mantenimientos is not null)
                {
                    foreach (Mantenimiento ma in MaquinaActual.Mantenimientos)
                    {
                        ListViewItem item = new ListViewItem(ma.FechaRealizado.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                        item.SubItems.Add(ma.Descripcion);
                        item.SubItems.Add(ma.Costo.ToString());
                        listMantenimientos.Items.Add(item);
                    }
                }
            }

        }

        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MantenimientoDesktop frmMantenimientoDesktop = new MantenimientoDesktop(idMaquina,ApplicationForm.ModoForm.Alta,_context);
                frmMantenimientoDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista de \"Máquinas\" para poder agregar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();
        }

        private void btnEditarMantenimiento_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                if (listMantenimientos.SelectedItems.Count > 0)
                {
                    int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                    DateTime fechaRealizacion = DateTime.Parse(listMantenimientos.SelectedItems[0].Text);
                    MantenimientoDesktop frmMantenimientoDesktop = new MantenimientoDesktop(idMaquina,fechaRealizacion, ApplicationForm.ModoForm.Modificacion, _context);
                    frmMantenimientoDesktop.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila en la lista para poder editar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista de \"Máquinas\" para poder editar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();

        }

        private void btnEliminarMantenimiento_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                if (listMantenimientos.SelectedItems.Count > 0)
                {
                    int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                    DateTime fechaRealizacion = DateTime.Parse(listMantenimientos.SelectedItems[0].Text);
                    MantenimientoDesktop frmMantenimientoDesktop = new MantenimientoDesktop(idMaquina, fechaRealizacion, ApplicationForm.ModoForm.Baja, _context);
                    frmMantenimientoDesktop.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista de \"Máquinas\" para poder eliminar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listMaquinas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listMaquinas.Columns[e.ColumnIndex].Width;
        }

        private void listMantenimientos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listMantenimientos.Columns[e.ColumnIndex].Width;
        }

        
    }
}
