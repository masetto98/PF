using Business.Entities;
using Business.Logic;
using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class RetirarOrdenDesktop : ApplicationForm
    {
        private readonly LavanderiaContext _context;
        public Orden OrdenActual { set; get; }
        public Factura FacturaActual { set; get; }
        private readonly FacturaLogic _facturaLogic;
        private readonly OrdenLogic _ordenLogic;
        public List<OrdenServicioTipoPrenda> _itemsServicio;
        public double _total;
        public RetirarOrdenDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            _itemsServicio = new List<OrdenServicioTipoPrenda>();
        }
        public RetirarOrdenDesktop(int nroOrden, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                OrdenActual = _ordenLogic.GetOne(nroOrden);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void MapearDeDatos()
        {
            this.txtCuitRetiro.Text = OrdenActual.Cliente.Cuit.ToString();
            this.txtApellidoRetiro.Text = OrdenActual.Cliente.Apellido;
            this.txtNombreRetiro.Text = OrdenActual.Cliente.Nombre;
            this.txtRazonSocialRetiro.Text = OrdenActual.Cliente.RazonSocial;
            this.txtNroOrdenRetiro.Text = OrdenActual.NroOrden.ToString();
            this.txtEstadoRetiro.Text = OrdenActual.Estado.ToString();
            this.txtFechaEntradaRetiro.Text = OrdenActual.FechaEntrada.Date.ToString();
            try
            {
                _itemsServicio = OrdenActual.ItemsPedidos;
                ListarItems();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    

                    break;
                case ModoForm.Modificacion:
                    if(OrdenActual.Estado != Orden.Estados.Pagado)
                    {
                        this.btnRetirar.Enabled = false;
                    }
                    this.txtCuitRetiro.Enabled = false;
                    this.txtApellidoRetiro.Enabled = false;
                    this.txtNombreRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtFechaEntradaRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtNroOrdenRetiro.Enabled = false;
                    this.txtTotalFactura.Enabled = false;
                    this.txtRazonSocialRetiro.Enabled = false;
                    break;
                case ModoForm.Baja:
                    
                    break;
                case ModoForm.Consulta:
                    
                    this.txtCuitRetiro.Enabled = false;
                    this.txtApellidoRetiro.Enabled = false;
                    this.txtNombreRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtFechaEntradaRetiro.Enabled = false;
                    this.txtEstadoRetiro.Enabled = false;
                    this.txtNroOrdenRetiro.Enabled = false;
                    this.txtTotalFactura.Enabled = false;
                    this.txtRazonSocialRetiro.Enabled = false;
                    ;
                    break;
            }
        }
        public void ListarItems()
        {
            listItemsRetiro.Items.Clear();
            foreach (OrdenServicioTipoPrenda i in _itemsServicio)
            {
                Precio precioActual = i.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde <= DateTime.Today;
                    });
                ListViewItem item = new ListViewItem(i.ServicioTipoPrenda.Servicio.Descripcion);
                item.SubItems.Add(i.ServicioTipoPrenda.TipoPrenda.Descripcion);
                item.SubItems.Add(i.Estado.ToString());
                item.SubItems.Add(precioActual.Valor.ToString());
                listItemsRetiro.Items.Add(item);
                _total += precioActual.Valor;
                this.txtTotalFactura.Text = _total.ToString();
            }
        }

        private void btnPagoRetirar_Click(object sender, EventArgs e)
        {
            FacturaActual = _facturaLogic.GetOne(OrdenActual.NroFactura);
            if(FacturaActual.Pagos.Count > 0)
            {
                PagoDesktop frmPago = new PagoDesktop(OrdenActual, ApplicationForm.ModoForm.Modificacion, _context);
                frmPago.ShowDialog();
            }
            else
            {
                PagoDesktop frmPago = new PagoDesktop(OrdenActual, ApplicationForm.ModoForm.Alta, _context);
                frmPago.ShowDialog();
            }
            this.txtEstadoRetiro.Text = OrdenActual.Estado.ToString();
            if(this.OrdenActual.Estado == Orden.Estados.Pagado)
            {
                this.btnRetirar.Enabled = true;
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if(OrdenActual.Estado == Orden.Estados.Pagado)
            {
                OrdenActual.Estado = Orden.Estados.Retirado;
                OrdenActual.FechaSalida = DateTime.Now;
                OrdenActual.State = BusinessEntity.States.Modified;
                _ordenLogic.Save(OrdenActual);
               
            }
            Close();
        }

        private void btnCancelarRetiro_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
