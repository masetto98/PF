using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class OrdenDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Orden OrdenActual { set; get; }
        public List<OrdenServicioTipoPrenda>? _itemsServicio;
        private readonly OrdenLogic _ordenLogic;
        private readonly ClienteLogic _clienteLogic;
        private readonly ServicioLogic _servicioLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        public OrdenDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            _servicioTipoPrendaLogic = new ServicioTipoPrendaLogic(new ServicioTipoPrendaAdapter(context));
            listItemsServicio.Items.Clear();
            _itemsServicio = new List<OrdenServicioTipoPrenda>();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public OrdenDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                List<Servicio> cursos = _servicioLogic.GetAll();
                this.cmbServicios.DataSource = cursos;
                this.cmbServicios.SelectedIndex = 0;
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbTipoPrenda.DataSource = tipoPrendas;
                this.cmbTipoPrenda.SelectedIndex = 0;
                this.cmbEstado.DataSource = Enum.GetNames(typeof(Business.Entities.Orden.Estados));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public OrdenDesktop(int nroOrden, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                OrdenActual = _ordenLogic.GetOne(nroOrden);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*public override void MapearDeDatos()
        {
            this.txtIdCliente.Text = OrdenActual.IdCliente.ToString();
            this.cmbEstado.SelectedIndex = cmbEstado.FindStringExact(Enum.GetName(OrdenActual.Estado));
            this.dtpFechaIngreso.Value = OrdenActual.FechaEntrada.Date;
            this.txtTiempoFinalizacionEstimado.Text = OrdenActual.TiempofinalizacionEstimado.Hours.ToString() + " : " + OrdenActual.TiempofinalizacionEstimado.Minutes.ToString();
            this.txtTiempoFinalizacionReal.Text = OrdenActual.TiempoFinalizacionReal.Hours.ToString() + " : " + OrdenActual.TiempoFinalizacionReal.Minutes.ToString();
            this.dtpFechaSalida.Value = OrdenActual.FechaSalida.Date;
            try
            {
                Servicio ServicioActual = _servicioLogic.GetOne(OrdenActual.);
                TipoPrenda TipoPrendaActual = _tipoPrendaLogic.GetOne(ServicioTipoPrendaActual.IdTipoPrenda);
                List<Servicio> servicios = _servicioLogic.GetAll();
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbTipoPrendas.DataSource = tipoPrendas;
                this.cmbServicios.SelectedIndex = cmbServicios.FindStringExact(ServicioActual.Descripcion);
                this.cmbTipoPrendas.SelectedIndex = cmbTipoPrendas.FindStringExact(TipoPrendaActual.Descripcion);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrendas.Enabled = false;
                    this.txtHoras.Enabled = false;
                    this.txtMinutos.Enabled = false;

                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrendas.Enabled = false;
                    this.txtHoras.Enabled = false;
                    this.txtMinutos.Enabled = false;
                    ;
                    break;
            }
        }*/

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                OrdenActual = new Orden();
                OrdenActual.IdCliente = Int32.Parse(this.txtIdCliente.Text);
                //OrdenActual.IdEmpleado = ; Deberia ser asignado el empleado que se encuentra logueado
                OrdenActual.FechaEntrada = DateTime.Today;
                OrdenActual.Estado = Orden.Estados.Pendiente;
                OrdenActual.ItemsPedidos.AddRange(_itemsServicio);
            }
            if (Modos == ModoForm.Modificacion)
            {
                //ServicioTipoPrendaActual.IdServicio = (int)this.cmbServicios.SelectedValue;
                //ServicioTipoPrendaActual.IdTipoPrenda = (int)this.cmbTipoPrendas.SelectedValue;
                //ServicioTipoPrendaActual.TiempoRequerido = new TimeSpan(Int32.Parse(this.txtHoras.Text), Int32.Parse(this.txtMinutos.Text), 00);
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    //ServicioTipoPrendaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    //ServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void Eliminar()
        {
            try
            {
                _ordenLogic.Delete(OrdenActual.NroOrden);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarPersona()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            try
            {
                Cliente cli = _clienteLogic.GetOneConCuit(this.txtCuit.Text);
                if (cli == null)
                {
                    Exception e = new Exception("No existe cliente para el cuit ingresado.");
                    throw e;
                }
                this.txtNombre.Text = cli.Nombre;
                this.txtApellido.Text = cli.Apellido;
                this.txtIdCliente.Text = cli.IdCliente.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AgregarItem(int idServicio,int idTipoPrenda) 
        {
            OrdenServicioTipoPrenda itemActual = new OrdenServicioTipoPrenda();
            itemActual.IdServicio = idServicio + 1;
            itemActual.IdTipoPrenda = idTipoPrenda + 1;
            itemActual.Estado = OrdenServicioTipoPrenda.Estados.Pendiente;
            itemActual.OrdenItem = ContarItems(idServicio+1,idTipoPrenda+1);
            //itemActual.NroOrden = OrdenActual.NroOrden;
            _itemsServicio.Add(itemActual);
        }

        private int ContarItems(int idServicio, int idTipoPrenda) 
        {
            int _cont = 0;
            if( _itemsServicio is null)
            {
                return 1;
            }
            else {
                foreach (OrdenServicioTipoPrenda item in _itemsServicio)
                {
                    if (item.IdServicio == idServicio && item.IdTipoPrenda == idTipoPrenda)
                    {
                        _cont += 1;
                    }
                }
                return _cont;
            }
            
        }

        private void EliminarItem() 
        {
            if (listItemsServicio.SelectedItems.Count > 0)
            {
                listItemsServicio.Items.Remove(listItemsServicio.SelectedItems[0]);
                int _index = listItemsServicio.Items.IndexOf(listItemsServicio.SelectedItems[0]);
                _itemsServicio.RemoveAt(_index+1);
            }
        }


        private void txtCuit_Leave(object sender, EventArgs e)
        {
            cargarPersona();
        }

        private void btnAgregarItemOrden_Click(object sender, EventArgs e)
        {
            try 
            {
                int idServicio = ((int)this.cmbServicios.SelectedIndex) + 1;
                int idTipoPrenda = ((int)this.cmbTipoPrenda.SelectedIndex)+ 1;
                ServicioTipoPrenda itemOrden = _servicioTipoPrendaLogic.GetOne(idServicio, idTipoPrenda);
                if (itemOrden == null)
                {
                    Exception r = new Exception("No existe el servicio ingresado.");
                    throw r;
                }
                else 
                {
                    AgregarItem((int)this.cmbServicios.SelectedIndex, (int)this.cmbTipoPrenda.SelectedIndex);
                    ListViewItem item = new ListViewItem((listItemsServicio.Items.Count+1).ToString());
                    item.SubItems.Add(this.cmbServicios.SelectedText);
                    item.SubItems.Add(this.cmbTipoPrenda.SelectedText);
                    listItemsServicio.Items.Add(item);
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "ItemServicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void GuardarCambios()
        {
            try
            {
                if (true)
                {
                    MapearADatos();
                    _ordenLogic.Save(OrdenActual);
                    Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modos)
            {
                case ModoForm.Alta:
                    {
                        GuardarCambios();
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        GuardarCambios();
                    };
                    break;
                case ModoForm.Baja:
                    Eliminar();
                    Close();
                    break;
                case ModoForm.Consulta:
                    Close();
                    break;

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarItem();

        }
    }
}
