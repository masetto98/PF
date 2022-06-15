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
    public partial class Proveedores : ApplicationForm
    {
        private readonly ProveedorLogic _proveedorLogic;
        private readonly LavanderiaContext _context;
        
        public Proveedores(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _proveedorLogic = new ProveedorLogic(new ProveedorAdapter(context));
            ListarProveedores();
        }

        private void ListarProveedores()
        {
            listProveedores.Items.Clear();
            List<Proveedor> proveedores = _proveedorLogic.GetAll();
            if (proveedores is not null || proveedores.Count > 0) 
            {
                foreach (Proveedor p in proveedores) 
                {
                    ListViewItem item = new ListViewItem(p.IdProveedor.ToString());
                    item.SubItems.Add(p.Cuit);
                    item.SubItems.Add(p.RazonSocial);
                    item.SubItems.Add(p.Telefono);
                    item.SubItems.Add(p.Email);
                    item.SubItems.Add(p.Direccion);
                    listProveedores.Items.Add(item);
                }
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            ProveedorDesktop frmProveedor = new ProveedorDesktop(ModoForm.Alta,_context);
            frmProveedor.ShowDialog();
            ListarProveedores();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (listProveedores.SelectedItems.Count > 0) 
            {
                int IdProveedor = Int32.Parse(listProveedores.SelectedItems[0].Text);
                ProveedorDesktop frmProveedor = new ProveedorDesktop(IdProveedor,ModoForm.Modificacion,_context);
                frmProveedor.ShowDialog();
            }
            ListarProveedores();

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (listProveedores.SelectedItems.Count > 0)
            {
                int IdProveedor = Int32.Parse(listProveedores.SelectedItems[0].Text);
                ProveedorDesktop frmProveedor = new ProveedorDesktop(IdProveedor, ModoForm.Baja, _context);
                frmProveedor.ShowDialog();
            }
            ListarProveedores();

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            ListarIngresos();


        }

        private void ListarIngresos() 
        {
            listIngresosInsumos.Items.Clear();
            if (listProveedores.SelectedItems.Count > 0)
            {
                int idProveedor = Int32.Parse(listProveedores.SelectedItems[0].Text);
                Proveedor proveedorActual = _proveedorLogic.GetOne(idProveedor);
                if (proveedorActual.InsumosProveedor is not null)
                {
                    foreach (InsumoProveedor ip in proveedorActual.InsumosProveedor)
                    {
                        ListViewItem item = new ListViewItem(ip.Insumo.Descripcion);
                        item.SubItems.Add(ip.FechaIngreso.ToString());
                        item.SubItems.Add(ip.Cantidad.ToString());
                        listIngresosInsumos.Items.Add(item);
                    }
                    this.lblCantidadIngresos.Text = proveedorActual.InsumosProveedor.Count.ToString();
                }
            }
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            InsumoProveedorDesktop frmIngresoInsumo = new InsumoProveedorDesktop(ModoForm.Alta, _context);
            frmIngresoInsumo.ShowDialog();
            ListarIngresos();
        }

        private void btnEditarIngreso_Click(object sender, EventArgs e)
        {
            if (listIngresosInsumos.SelectedItems.Count > 0)
            {
                int idProveedor = Int32.Parse(listProveedores.SelectedItems[0].Text);
                Proveedor proveedorActual = _proveedorLogic.GetOne(idProveedor);
                InsumoProveedor ipActual = proveedorActual.InsumosProveedor.Find(delegate (InsumoProveedor ip)
                {
                    return ip.Insumo.Descripcion == listIngresosInsumos.SelectedItems[0].Text &&
                           ip.FechaIngreso == DateTime.Parse(listIngresosInsumos.SelectedItems[0].SubItems[1].Text);
                });
                InsumoProveedorDesktop frmIngresoInsumo = new InsumoProveedorDesktop(ipActual.IdProveedor,ipActual.IdInsumo,ipActual.FechaIngreso,ModoForm.Modificacion, _context);
                frmIngresoInsumo.ShowDialog();
            }
            ListarIngresos();

        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (listIngresosInsumos.SelectedItems.Count > 0)
            {
                int idProveedor = Int32.Parse(listProveedores.SelectedItems[0].Text);
                Proveedor proveedorActual = _proveedorLogic.GetOne(idProveedor);
                InsumoProveedor ipActual = proveedorActual.InsumosProveedor.Find(delegate (InsumoProveedor ip)
                {
                    return ip.Insumo.Descripcion == listIngresosInsumos.SelectedItems[0].Text &&
                           ip.FechaIngreso == DateTime.Parse(listIngresosInsumos.SelectedItems[0].SubItems[1].Text);
                });
                InsumoProveedorDesktop frmIngresoInsumo = new InsumoProveedorDesktop(ipActual.IdProveedor, ipActual.IdInsumo, ipActual.FechaIngreso, ModoForm.Baja, _context);
                frmIngresoInsumo.ShowDialog();
            }
            ListarIngresos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {   
            List<Proveedor> proveedoresBusqueda = _proveedorLogic.GetAll().FindAll(delegate (Proveedor p)
            {
                return p.IdProveedor.ToString().StartsWith(this.txtBuscar.Text) ||
                       p.RazonSocial.StartsWith(this.txtBuscar.Text) ||
                       p.Telefono.StartsWith(this.txtBuscar.Text) ||
                       p.Direccion.StartsWith(this.txtBuscar.Text) ||
                       p.Email.StartsWith(this.txtBuscar.Text) ||
                       p.Cuit.StartsWith(this.txtBuscar.Text);
            });
            if (proveedoresBusqueda.Count > 0) 
            {
                listProveedores.Items.Clear();
                foreach(Proveedor p in proveedoresBusqueda)
                {
                    ListViewItem item = new ListViewItem(p.IdProveedor.ToString());
                    item.SubItems.Add(p.Cuit);
                    item.SubItems.Add(p.RazonSocial);
                    item.SubItems.Add(p.Telefono);
                    item.SubItems.Add(p.Email);
                    item.SubItems.Add(p.Direccion);
                    listProveedores.Items.Add(item);
                }
            }
            if (this.txtBuscar.Text == "") { ListarProveedores(); }
        }
    }

    
}
