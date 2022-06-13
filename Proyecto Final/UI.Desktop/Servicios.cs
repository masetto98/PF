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
    public partial class Servicios : ApplicationForm
    {
        private readonly ServicioLogic _servicioLogic;
        private readonly LavanderiaContext _context;

        public Servicios(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
            ListarServicios();
        }

        private void ListarServicios() 
        {
            listServicios.Items.Clear();
            List<Servicio> servicios = _servicioLogic.GetAll();
            if (servicios is not null) 
            {
                foreach (Servicio s in servicios) 
                {
                    ListViewItem item = new ListViewItem(s.IdServicio.ToString());
                    item.SubItems.Add(s.Descripcion);
                    listServicios.Items.Add(item);
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ServicioDesktop frmServicio = new ServicioDesktop(ModoForm.Alta, _context);
            frmServicio.ShowDialog();
            ListarServicios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listServicios.SelectedItems.Count > 0) 
            {
                int idServicio = Int32.Parse(listServicios.SelectedItems[0].Text);
                ServicioDesktop frmServicio = new ServicioDesktop(idServicio,ModoForm.Modificacion, _context);
                frmServicio.ShowDialog();
            }
            ListarServicios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listServicios.SelectedItems.Count > 0)
            {
                int idServicio = Int32.Parse(listServicios.SelectedItems[0].Text);
                ServicioDesktop frmServicio = new ServicioDesktop(idServicio, ModoForm.Baja, _context);
                frmServicio.ShowDialog();
            }
            ListarServicios();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
