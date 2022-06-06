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
        private readonly LavanderiaContext _context;
        public Maquina MaquinaActual { get; set; }

        public Maquinas(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
            ListarMaquinas();
        }

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
            ListarMaquinas();

        }

        private void btnDetalles_Click(object sender, EventArgs e)
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
            ListarMantenimientos();
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
                        ListViewItem item = new ListViewItem(ma.FechaRealizado.ToString());
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
            }
            ListarMantenimientos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
