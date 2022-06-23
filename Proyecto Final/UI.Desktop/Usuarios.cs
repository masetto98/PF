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
    public partial class Usuarios : ApplicationForm
    {
        private readonly UsuarioLogic _usuarioLogic;
        private readonly LavanderiaContext _context;

        public Usuarios(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
            ListarUsuarios();
        }

        private void ListarUsuarios() 
        {
            listUsuarios.Items.Clear();
            List<Usuario> usuarios = _usuarioLogic.GetAll();
            if (usuarios is not null) 
            {
                foreach (Usuario u in usuarios) 
                {
                    ListViewItem item = new ListViewItem(u.IdUsuario.ToString());
                    item.SubItems.Add(u.NombreUsuario);
                    item.SubItems.Add(u.Empleado.Cuit);
                    item.SubItems.Add(u.Empleado.Nombre);
                    item.SubItems.Add(u.Empleado.Apellido);
                    item.SubItems.Add(u.Empleado.TipoEmpleado.ToString());
                    listUsuarios.Items.Add(item);
                }
            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            UsuarioDesktop frmUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmUsuario.ShowDialog();
            ListarUsuarios();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItems.Count > 0)
            {
                int idUsuario = Int32.Parse(listUsuarios.SelectedItems[0].Text);
                UsuarioDesktop frmUsuario = new UsuarioDesktop(idUsuario,ApplicationForm.ModoForm.Modificacion, _context);
                frmUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarUsuarios();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItems.Count > 0)
            {
                int idUsuario = Int32.Parse(listUsuarios.SelectedItems[0].Text);
                UsuarioDesktop frmUsuario = new UsuarioDesktop(idUsuario, ApplicationForm.ModoForm.Baja, _context);
                frmUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarUsuarios();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listUsuarios_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listUsuarios.Columns[e.ColumnIndex].Width;
        }
    }
}
