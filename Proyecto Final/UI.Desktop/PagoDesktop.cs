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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PagoDesktop : ApplicationForm
    {
        private readonly LavanderiaContext _context;
        private readonly FacturaLogic _facturaLogic;
        private readonly OrdenLogic _ordenLogic;
        private readonly PagoLogic _pagoLogic;
        public List<Pago> _pagosFactura;
        public List<Pago> _pagosActuales;
        public Pago PagoActual { set; get; }
        public Orden OrdenActual { set; get; }
        public Factura FacturaActual { set; get; }
        public List<OrdenServicioTipoPrenda> _itemsServicio;
        public double _totalpagos;
        public double _totalApagar;
        public double _total;
        public PagoDesktop(LavanderiaContext context)
        {
            _context = context;
            InitializeComponent();
            _facturaLogic = new FacturaLogic(new FacturaAdapter(context));
            _pagoLogic = new PagoLogic(new PagoAdapter(context));
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _pagosFactura = new List<Pago>();
            _itemsServicio = new List<OrdenServicioTipoPrenda>();
            _pagosActuales = new List<Pago>();
            btnAgregarPago.Enabled = false;

        }

        public PagoDesktop(Orden ordenActual, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            OrdenActual = ordenActual;
            FacturaActual = _facturaLogic.GetOne(OrdenActual.NroFactura);
            if (FacturaActual.Importe == 0)
            {
                AsignarImporte();
            }
            try
            {
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AsignarImporte()
        {
            _itemsServicio = OrdenActual.ItemsPedidos;
            foreach (OrdenServicioTipoPrenda i in _itemsServicio)
            {
                Precio precioActual = i.ServicioTipoPrenda.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde <= DateTime.Now;
                    });
                _total += precioActual.Valor;
            }
            if (OrdenActual.Descuento != null)
            {
                if (OrdenActual.Descuento.Contains("%"))
                {
                    string desc = OrdenActual.Descuento.Substring(1, OrdenActual.Descuento.Length - 1);
                    _total *= (1 - (Double.Parse(desc) / 100.0));
                }
                else
                {
                    _total -= Int32.Parse(OrdenActual.Descuento);
                }
            }
            FacturaActual.Importe = _total;
        }
     /*   public PagoDesktop(int? nroFactura, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                FacturaActual = _facturaLogic.GetOne(nroFactura);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     */
        public override void MapearDeDatos()
        {

            this.txtNroFactura.Text = FacturaActual.NroFactura.ToString();
            this.cbFormaPago.DataSource = Enum.GetNames(typeof(Business.Entities.Pago.FormasPago));
            this.txtTotalFactura.Text = FacturaActual.Importe.ToString();
            if(OrdenActual.Senia == true)
            {
                this.txtSenia.Text = OrdenActual.Factura.Pagos[0].Importe.ToString();
                foreach(Pago p in FacturaActual.Pagos)
                {
                    _pagosActuales.Add(p);
                }
            }
            try
            {
             
                TotalAPagar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    if (this.txtApagar.Text == "0")
                    {
                        this.btnAgregarPago.Enabled = false;
                        this.btnAceptarPago.Enabled = false;
                        this.cbFormaPago.Enabled = false;
                        this.txtImportePago.Enabled = false;
                        this.btnSaldarDeuda.Enabled = false;
                    }
                    
                    this.txtNroFactura.Enabled = false;
                    this.txtTotalFactura.Enabled = false;
                    this.txtApagar.Enabled = false;
                    this.txtSenia.Enabled = false;
                    break;
                case ModoForm.Modificacion:
                    if(this.txtApagar.Text == "0")
                    {
                        this.btnAgregarPago.Enabled = false;
                        this.btnAceptarPago.Enabled = false;
                        this.cbFormaPago.Enabled = false;
                        this.txtImportePago.Enabled = false;
                        this.btnSaldarDeuda.Enabled = false;
                    }
                    
                    this.txtTotalFactura.Enabled = false;
                    this.txtApagar.Enabled = false;
                    this.txtNroFactura.Enabled = false;
                    this.txtSenia.Enabled = false;
                    break;
                case ModoForm.Baja:
                    
                    break;
                case ModoForm.Consulta:

                    break;
            }
        }
        public void TotalAPagar()
        {
            
            double pagosActual = TotalPagos();
            if (pagosActual != 0)
            {
                _totalApagar = FacturaActual.Importe - pagosActual;
                this.txtApagar.Text = _totalApagar.ToString();
                ListarPagos();
            }
            else
            {
                _totalApagar = FacturaActual.Importe;
                this.txtApagar.Text = _totalApagar.ToString();
            }
           
        }
        public double TotalPagos()
        {
            double totalpagos = 0;
            _pagosFactura = FacturaActual.Pagos;
            if (_pagosFactura != null)
            {
                if (_pagosActuales.Count > _pagosFactura.Count)
                {
                    foreach (Pago p in _pagosActuales)
                    {
                        totalpagos += p.Importe;
                    }
                    return totalpagos;
                }
                else
                {
                    foreach (Pago p in _pagosFactura)
                    {
                        totalpagos += p.Importe;
                    }
                    return totalpagos;
                }
            }
            else
            {
                return 0;
            }
        }
        public void ListarPagos()
        {
            if(_pagosActuales.Count > 0)
            {
                listPagos.Items.Clear();
                foreach (Pago p in _pagosActuales)
                {
                    ListViewItem item = new ListViewItem(FacturaActual.NroFactura.ToString());
                    item.SubItems.Add(p.FechaPago.ToString());
                    item.SubItems.Add(p.FormaPago.ToString());
                    item.SubItems.Add(p.Importe.ToString());
                    listPagos.Items.Add(item);
                }
            }
            else
            {
                _pagosFactura = FacturaActual.Pagos;
                listPagos.Items.Clear();
                foreach (Pago p in _pagosFactura)
                {
                    ListViewItem item = new ListViewItem(FacturaActual.NroFactura.ToString());
                    item.SubItems.Add(p.FechaPago.ToString());
                    item.SubItems.Add(p.FormaPago.ToString());
                    item.SubItems.Add(p.Importe.ToString());
                    listPagos.Items.Add(item);
                }
            }
            
            
        }
        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                PagoActual = new Pago();
                PagoActual.FechaPago = DateTime.Now;
                PagoActual.FormaPago = (Business.Entities.Pago.FormasPago)Enum.Parse(typeof(Business.Entities.Pago.FormasPago), cbFormaPago.SelectedItem.ToString());
                PagoActual.Importe = double.Parse(txtImportePago.Text);
                if (FacturaActual.FechaFactura.ToString("yyyy/MM/dd") == "0001/01/01")
                {
                    FacturaActual.FechaFactura = DateTime.Now;
                }
                
                FacturaActual.Pagos = new List<Pago>();
                _pagosActuales.Add(PagoActual);
                /*
                FacturaActual.Pagos.Add(PagoActual);
                OrdenActual.Factura = FacturaActual;
                */
            }
            if (Modos == ModoForm.Modificacion)
            {
                PagoActual = new Pago();
                PagoActual.FechaPago = DateTime.Now;
                PagoActual.FormaPago = (Business.Entities.Pago.FormasPago)Enum.Parse(typeof(Business.Entities.Pago.FormasPago), cbFormaPago.SelectedItem.ToString());
                PagoActual.Importe = double.Parse(txtImportePago.Text);
                _pagosActuales.Add(PagoActual);
                /*
                FacturaActual.Pagos.Add(PagoActual);
                OrdenActual.Factura = FacturaActual;
                */
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    FacturaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Modificacion:
                    FacturaActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
            try
            {
                if (true)
                    {
                        MapearADatos();
                        //_facturaLogic.Save(FacturaActual);
                        ListarPagos();
                    }
            }
            catch (Exception e)
            {
                 MessageBox.Show(e.Message, "Pagos-Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAceptarPago_Click(object sender, EventArgs e)
        {
            double totalActual = TotalPagos();
            if(totalActual == FacturaActual.Importe && OrdenActual.Estado != Orden.Estados.Retirado)
            {
                if (OrdenActual.Estado == Orden.Estados.Finalizado) { OrdenActual.Estado = Orden.Estados.Pagado;}
                
                OrdenActual.State = BusinessEntity.States.Modified;
                _ordenLogic.Save(OrdenActual);
            }
            FacturaActual.Pagos = _pagosActuales;
            FacturaActual.State = BusinessEntity.States.Modified;
            _facturaLogic.Save(FacturaActual);
            Close();
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            double pagoActual = double.Parse(this.txtImportePago.Text);
            double dif = FacturaActual.Importe - TotalPagos();
            if(pagoActual <= dif)
            {
                switch (Modos)
                {
                    case ModoForm.Alta:
                        {
                            if (MessageBox.Show($"¿Está seguro que desea agregar el nuevo pago?", "Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                GuardarCambios();
                                this.txtImportePago.Text = "";
                                TotalAPagar();
                                if (this.txtApagar.Text == "0")
                                {
                                    this.btnSaldarDeuda.Enabled = false;
                                }
                                
                            }
                            //ListarPagos();
                        };
                        break;
                    case ModoForm.Modificacion:
                        {
                            if (MessageBox.Show($"¿Está seguro que desea agregar el nuevo pago?", "Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                GuardarCambios();
                                this.txtImportePago.Text = "";
                                TotalAPagar();
                                if (this.txtApagar.Text == "0")
                                {
                                    this.btnSaldarDeuda.Enabled = false;
                                }
                            }
                            //ListarPagos();
                        };
                        break;
                    case ModoForm.Baja:
                        //Eliminar();
                        Close();
                        break;
                    case ModoForm.Consulta:
                        Close();
                        break;

                }
            }
            else
            {
                MessageBox.Show("El importe del pago ingresado supera el valor de la factura. Por favor, ingrese un importe valido.", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaldarDeuda_Click(object sender, EventArgs e)
        {
            double totalActual = TotalPagos();
            FormaPagoDesktop fp = new FormaPagoDesktop();
            if (fp.ShowDialog() == DialogResult.OK)
            {
                if (Modos == ModoForm.Alta)
                {
                    PagoActual = new Pago();
                    PagoActual.FechaPago = DateTime.Now;
                    PagoActual.FormaPago = fp.GetFormaPago();
                    PagoActual.Importe = FacturaActual.Importe - totalActual;
                    /*FacturaActual = new Factura();
                    FacturaActual.FechaFactura = DateTime.Now;*/
                    //FacturaActual.Pagos = new List<Pago>();
                    if (FacturaActual.FechaFactura.ToString("yyyy/MM/dd") == "0001/01/01")
                    {
                        FacturaActual.FechaFactura = DateTime.Now;
                    }
                    FacturaActual.Pagos.Add(PagoActual);
                    OrdenActual.Factura = FacturaActual;
                }
                if (Modos == ModoForm.Modificacion)
                {
                    PagoActual = new Pago();
                    PagoActual.FechaPago = DateTime.Now;
                    PagoActual.FormaPago = fp.GetFormaPago();
                    PagoActual.Importe = FacturaActual.Importe - totalActual;
                    FacturaActual.Pagos.Add(PagoActual);
                    OrdenActual.Factura = FacturaActual;
                }
                switch (Modos)
                {
                    case ModoForm.Alta:
                        FacturaActual.State = BusinessEntity.States.Modified;
                        this.cbFormaPago.Enabled = false;
                        this.txtImportePago.Enabled = false;
                        this.btnAgregarPago.Enabled = false;
                        break;
                    case ModoForm.Modificacion:
                        FacturaActual.State = BusinessEntity.States.Modified;
                        this.cbFormaPago.Enabled = false;
                        this.txtImportePago.Enabled = false;
                        this.btnAgregarPago.Enabled = false;
                        break;
                }
                ListarPagos();
                TotalAPagar();
            }
                
            
        }

        private void txtApagar_TextChanged(object sender, EventArgs e)
        {
            if(txtApagar.Text == "0")
            {
                btnSaldarDeuda.Enabled = false;
                btnAgregarPago.Enabled = false;
            }
        }
        public bool ValidarNumeroEnteroDecimal(string cantidad)
        {
            if (!Regex.IsMatch(cantidad, @"\d{1,7}(,\d{1,2})?"))
            {
                return false;
                //MessageBox.Show("El valor de seña ingresado no es un número. Por favor, ingrese un valor de seña válido.", "Seña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return true;
            }
        }
        private void txtImportePago_TextChanged(object sender, EventArgs e)
        {
            if (txtImportePago.Text != "" && double.Parse(txtImportePago.Text) != 0)
            {
                if (ValidarNumeroEnteroDecimal(txtImportePago.Text))
                {

                    btnAgregarPago.Enabled = true;

                }
                else
                {
                    MessageBox.Show("El importe de pago ingresado no es un número. Por favor, ingrese un importe válido.", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtImportePago.Text = "";
                }
            }
            else
            {
                btnAgregarPago.Enabled = false;
            }
            
            
        }

        private void listPagos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listPagos.Columns[e.ColumnIndex].Width;
        }


        /* SE QUITÓ LA FUNCIONALIDAD DE ELIMINAR PAGO
        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (FacturaActual.Pagos.Count > 0)
            {
                EliminarPago();
                //CalcularImporte();
            }
            else
            {
                MessageBox.Show("La factura debe contener por lo menos un pago", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void EliminarPago()
        {
            try
            {

                if (listPagos.SelectedItems.Count > 0)
                {
                    var _itemDelete = FacturaActual.Pagos.FindLast(
                        delegate (Pago item)
                        {
                            return
                                item.FechaPago.ToString("yyyy/MM/dd HH:mm:ss") == DateTime.Parse(this.listPagos.SelectedItems[0].SubItems[1].Text).ToString("yyyy/MM/dd HH:mm:ss")
                                ;
                        }
                    );
                    if(MessageBox.Show("¿Esta seguro que desea eliminar el pago seleccionado?", "Eliminar Pago", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _pagoLogic.Delete(_itemDelete.NroFactura, _itemDelete.FechaPago);
                        listPagos.Items.Remove(listPagos.SelectedItems[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un pago de la lista para eliminar", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "ItemServicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
    }
}
