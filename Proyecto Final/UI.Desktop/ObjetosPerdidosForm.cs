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
    public partial class ObjetosPerdidosForm : ApplicationForm
    {
        private readonly LavanderiaContext _context;
        private readonly ClienteLogic _clienteLogic;
        private readonly OrdenLogic _ordenLogic;
        private readonly MaquinaLogic _maquinaLogic;
        public Cliente ClienteActual;
        public int _clienteAnterior;
        public int _clienteSiguiente;
        public Orden OrdenActual;

        public ObjetosPerdidosForm(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
        }
        #region ------- CLIENTE -------

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarCliente();
            if (ClienteActual is not null)
            {
                ListarOrdenes();
            }

        }

        private void cargarCliente()
        {
            this.txtNombreApellidoRazonSocial.Text = "";
            try
            {
                ClienteActual = _clienteLogic.GetOneConCuit(this.txtCuit.Text);
                if (ClienteActual == null)
                {
                    Exception e = new Exception("No existe cliente para el cuit ingresado.");
                    throw e;
                }
                if (ClienteActual.Nombre != "" && ClienteActual.Apellido != "" && ClienteActual.RazonSocial == "") 
                {
                    this.txtNombreApellidoRazonSocial.Text = String.Concat(ClienteActual.Nombre, " ", ClienteActual.Apellido);
                }
                if (ClienteActual.Nombre != "" && ClienteActual.Apellido != "" && ClienteActual.RazonSocial != "") 
                {
                    this.txtNombreApellidoRazonSocial.Text = String.Concat(ClienteActual.Nombre, " ", ClienteActual.Apellido," / ",ClienteActual.RazonSocial);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void ListarOrdenes() 
        {
            listOrdenesCliente.Items.Clear();
            List<Orden> ordenesCliente = ClienteActual.Ordenes;
            foreach (Orden o in ordenesCliente) 
            {
                ListViewItem item = new ListViewItem(o.NroOrden.ToString());
                item.SubItems.Add(o.FechaEntrada.Date.ToString("d"));
                listOrdenesCliente.Items.Add(item);
            }
        }

        private void ListarItemsOrden(int nroOrden) 
        {
            listItemsPedidos.Items.Clear();
            OrdenActual = _ordenLogic.GetOne(nroOrden);
            if (OrdenActual is not null)
            {
                List<OrdenServicioTipoPrenda> itemsOrden = OrdenActual.ItemsPedidos;
                foreach (OrdenServicioTipoPrenda ostp in itemsOrden)
                {
                    ListViewItem item = new ListViewItem(ostp.ServicioTipoPrenda.Servicio.Descripcion);
                    item.SubItems.Add(ostp.ServicioTipoPrenda.TipoPrenda.Descripcion);
                    item.SubItems.Add(ostp.OrdenItem.ToString());
                    item.SubItems.Add(ostp.Estado.ToString());
                    listItemsPedidos.Items.Add(item);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerItems_Click(object sender, EventArgs e)
        {
            listMaquinasItems.Items.Clear();
            listItemsPedidos.Items.Clear();
            LimpiarItems();
            if (this.txtNroOrden.Text.Length > 0)
            {
                ListarItemsOrden(Int32.Parse(this.txtNroOrden.Text));
            }
            else if(this.txtNroOrden.Text == "" && ClienteActual is null)
            {
                MessageBox.Show("Debe ingresar un número de orden o buscar un cliente a través de su cuit para poder observar los detalles", "Orden",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (ClienteActual is not null)
            {
                if (listOrdenesCliente.SelectedItems.Count > 0)
                {
                    ListarItemsOrden(Int32.Parse(listOrdenesCliente.SelectedItems[0].Text));
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una orden en la lista \"Ordenes del cliente\" para poder observar los detalles", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnVerServiciosRealizados_Click(object sender, EventArgs e)
        {
            listMaquinasItems.Items.Clear();
            LimpiarItems();
            try
            {
                if (OrdenActual.ItemsPedidos is not null)
                {
                    OrdenServicioTipoPrenda ostpActual = OrdenActual.ItemsPedidos.Find(delegate (OrdenServicioTipoPrenda ostp)
                    {
                        return
                                   ostp.ServicioTipoPrenda.Servicio.Descripcion == this.listItemsPedidos.SelectedItems[0].Text &&
                                   ostp.ServicioTipoPrenda.TipoPrenda.Descripcion == this.listItemsPedidos.SelectedItems[0].SubItems[1].Text &&
                                   ostp.OrdenItem == Int32.Parse(this.listItemsPedidos.SelectedItems[0].SubItems[2].Text);
                    });
                    if (ostpActual.MaquinaOrdenServicioTipoPrenda is not null)
                    {

                        foreach (MaquinaOrdenServicioTipoPrenda mi in ostpActual.MaquinaOrdenServicioTipoPrenda)
                        {
                            ListViewItem mir = new ListViewItem(mi.Maquina.Descripcion);
                            mir.SubItems.Add(mi.TiempoInicioServicio.ToString("O"));
                            listMaquinasItems.Items.Add(mir);
                        }
                    }
                    else if (ostpActual.MaquinaOrdenServicioTipoPrenda is null)
                    {
                        MessageBox.Show("Debe seleccionar un item en la lista \"Items de la orden\" para poder observar los detalles", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Debe ingresar un número de orden o buscar un cliente a través de su cuit para poder observar los detalles", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnTrazarPedidos_Click(object sender, EventArgs e)
        {
            LimpiarItems();
            if (listMaquinasItems.SelectedItems.Count > 0)
            {
                Maquina maquinaActual = _maquinaLogic.GetAll().Find(delegate (Maquina m)
                {
                    return m.Descripcion == this.listMaquinasItems.SelectedItems[0].Text;
                });
                List<MaquinaOrdenServicioTipoPrenda> itemsAtendidos = maquinaActual.itemsAtendidos;
                itemsAtendidos.Sort((x,y) => x.TiempoInicioServicio.CompareTo(y.TiempoInicioServicio));
                if (maquinaActual is not null) 
                {
                    MaquinaOrdenServicioTipoPrenda itemAnterior = maquinaActual.itemsAtendidos.FindLast(delegate (MaquinaOrdenServicioTipoPrenda mostp)
                     {
                         return mostp.TiempoInicioServicio < DateTime.Parse(listMaquinasItems.SelectedItems[0].SubItems[1].Text);
                     });
                    if (itemAnterior is not null)
                    {
                        this.txtNroOrdenAnterior.Text = itemAnterior.NroOrden.ToString();
                        this.txtServicioTipoPrendaAnterior.Text = String.Concat(itemAnterior.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion, " - ", itemAnterior.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        this.txtOrdenItemAnterior.Text = itemAnterior.OrdenItem.ToString();
                        this.txtEstado.Text = itemAnterior.OrdenServicioTipoPrenda.Estado.ToString();
                        //this.txtCuitClienteAnterior.Text = itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Cuit;
                        //this.txtIdEmpleadoAnterior.Text = itemAnterior.Empleado.IdEmpleado.ToString();
                        this.txtNombreApellidoEmpleadoAnterior.Text = String.Concat(itemAnterior.Empleado.Nombre, " ", itemAnterior.Empleado.Apellido);
                        _clienteAnterior = itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.IdCliente;
                        //if (itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre != "" && itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido != "" && itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.RazonSocial == "")
                        //{
                        //    this.txtNombreApellidoRazonSocialAnterior.Text = String.Concat(itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre, " ", itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido);
                        //}
                        //else if (itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre != "" && itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido != "" && itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.RazonSocial != "")
                        //{
                        //    this.txtNombreApellidoRazonSocialAnterior.Text = String.Concat(itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre, " ", itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido, " / ", itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.RazonSocial);
                        //}
                        //this.txtTelefonoAnterior.Text = itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Telefono;
                        //this.txtDireccionAnterior.Text = itemAnterior.OrdenServicioTipoPrenda.Orden.Cliente.Direccion;
                        //this.txtIdAnterior.Text = itemAnterior.OrdenServicioTipoPrenda.Orden.IdCliente.ToString();
                    }
                    MaquinaOrdenServicioTipoPrenda itemPosterior = maquinaActual.itemsAtendidos.Find(delegate (MaquinaOrdenServicioTipoPrenda mostp)
                    {
                        return mostp.TiempoInicioServicio > DateTime.Parse(listMaquinasItems.SelectedItems[0].SubItems[1].Text) ;
                    });
                    if (itemPosterior is not null)
                    {
                        this.txtNroOrdenSiguiente.Text = itemPosterior.NroOrden.ToString();
                        this.txtServicioTipoPrendaSiguiente.Text = String.Concat(itemPosterior.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.Descripcion, " - ", itemPosterior.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.Descripcion);
                        this.txtOrdenItemSiguiente.Text = itemPosterior.OrdenItem.ToString();
                        this.txtEstadoSiguiente.Text = itemPosterior.OrdenServicioTipoPrenda.Estado.ToString();
                        //this.txtIDEmpleadoSiguiente.Text = itemPosterior.Empleado.IdEmpleado.ToString();
                        this.txtNombreApellidoEmpleadoSiguiente.Text = String.Concat(itemPosterior.Empleado.Nombre, " ", itemPosterior.Empleado.Apellido);
                        _clienteSiguiente = itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.IdCliente;
                        //this.txtCuitClienteSiguiente.Text = itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Cuit;
                        //if (itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre != "" && itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido != "" && itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.RazonSocial == "")
                        //{
                        //    this.txtNombreApellidoRazonSocialSiguiente.Text = String.Concat(itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre, " ", itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido);
                        //}
                        //else if (itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre != "" && itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido != "" && itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.RazonSocial != "")
                        //{
                        //    this.txtNombreApellidoRazonSocialSiguiente.Text = String.Concat(itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Nombre, " ", itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Apellido, " / ", itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.RazonSocial);
                        //}
                        //this.txtTelefonoSiguiente.Text = itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Telefono;
                        //this.txtDireccionSiguiente.Text = itemPosterior.OrdenServicioTipoPrenda.Orden.Cliente.Direccion;
                        //this.txtIdSiguiente.Text = itemPosterior.OrdenServicioTipoPrenda.Orden.IdCliente.ToString();
                    }
                }

                



            }
            else
            {
                MessageBox.Show("Debe seleccionar una máquina en la lista \"Máquinas utilizadas\" para poder trazar los items", "Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void LimpiarItems() 
        {   //Item anterior
            this.txtNroOrdenAnterior.Text = "";
            this.txtServicioTipoPrendaAnterior.Text = "";
            this.txtOrdenItemAnterior.Text = "";
            this.txtEstado.Text = "";
            //this.txtIdEmpleadoAnterior.Text = "";
            this.txtNombreApellidoEmpleadoAnterior.Text = "";
            //this.txtCuitClienteAnterior.Text = "";
            //this.txtNombreApellidoRazonSocialAnterior.Text = "";
            //this.txtTelefonoAnterior.Text = "";
            //this.txtDireccionAnterior.Text = "";
            //this.txtIdAnterior.Text = "";

            //Item Siguiente
            this.txtNroOrdenSiguiente.Text = "";
            this.txtServicioTipoPrendaSiguiente.Text = "";
            this.txtOrdenItemSiguiente.Text = "";
            this.txtEstadoSiguiente.Text = "";
            //this.txtIDEmpleadoSiguiente.Text = "";
            this.txtNombreApellidoEmpleadoSiguiente.Text = "";
            //this.txtCuitClienteSiguiente.Text = "";
            //this.txtNombreApellidoRazonSocialSiguiente.Text = "";
            //this.txtTelefonoSiguiente.Text = "";
            //this.txtDireccionSiguiente.Text = "";
            //this.txtIdSiguiente.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listOrdenesCliente_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listOrdenesCliente.Columns[e.ColumnIndex].Width;
        }

        private void listItemsPedidos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listItemsPedidos.Columns[e.ColumnIndex].Width;
        }

        private void listMaquinasItems_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listMaquinasItems.Columns[e.ColumnIndex].Width;
        }

        private void btnDatosClienteAnterior_Click(object sender, EventArgs e)
        {
            if (_clienteAnterior != 0)
            {

                ClienteDesktop frmCliente = new ClienteDesktop(_clienteAnterior, ApplicationForm.ModoForm.Consulta, _context);
                frmCliente.ShowDialog();
            }
            else { MessageBox.Show("Item no encontrado", "Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnDatosClienteSiguiente_Click(object sender, EventArgs e)
        {
            if (_clienteSiguiente != 0)
            {
                ClienteDesktop frmCliente = new ClienteDesktop(_clienteSiguiente, ApplicationForm.ModoForm.Consulta, _context);
                frmCliente.ShowDialog();
            }
            else { MessageBox.Show("Item no encontrado", "Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
