using Business.Entities;
using Business.Logic;
using Data.Database;
using MaterialSkin;
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
    public partial class InsumoProveedorDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly ProveedorLogic _proveedorLogic;
        private readonly InsumoLogic _insumoLogic;
        private readonly InsumoProveedorLogic _insumoProveedorLogic;
        public InsumoProveedor InsumoProveedorActual { set; get; }
        private LavanderiaContext _context;
        public List<String> _unidadesMedida;

        public InsumoProveedorDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            _proveedorLogic = new ProveedorLogic(new ProveedorAdapter(context));
            _insumoProveedorLogic = new InsumoProveedorLogic(new InsumoProveedorAdapter(context));
            _context = context;
            _unidadesMedida = new List<string>();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public InsumoProveedorDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            // No te deja hacer nada hasta que no introduzcas un legajo válido, como en usuario
            this.cbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                // Cargo los cursos para mostrarlos en el combobox
                List<Proveedor> proveedores = _proveedorLogic.GetAll();
                this.cbProveedores.DataSource = proveedores;
                // selecciono el curso de la posicion 0 como para seleccionar algo
                this.cbProveedores.SelectedIndex = 0;
                List<Insumo> insumos = _insumoLogic.GetAll();
                this.cbInsumos.DataSource = insumos;
                this.cbInsumos.SelectedIndex = 0;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Insumos Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public InsumoProveedorDesktop(int idInsumo,int idProveedor,DateTime fechaIngreso, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                InsumoProveedorActual = _insumoProveedorLogic.GetOne(idInsumo,idProveedor,fechaIngreso);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void MapearDeDatos()
        {
            this.cbProveedores.Text = this.InsumoProveedorActual.Proveedor.RazonSocial;
            this.cbInsumos.Text = InsumoProveedorActual.Insumo.Descripcion;
            this.dtpFechaIngreso.Value = InsumoProveedorActual.FechaIngreso;
            this.txtCantidad.Text = InsumoProveedorActual.Cantidad.ToString();
            // Tengo que cargar los cursos por si quiero seleccionar otro
            // Y seleccionar el actual
            try
            {
                List<Proveedor> proveedores = _proveedorLogic.GetAll();
                this.cbProveedores.DataSource = proveedores;
                this.cbProveedores.SelectedIndex = cbProveedores.FindStringExact(InsumoProveedorActual.Proveedor.RazonSocial);
                List<Insumo> insumos = _insumoLogic.GetAll();
                this.cbInsumos.DataSource = insumos;
                this.cbInsumos.SelectedIndex = cbInsumos.FindStringExact(InsumoProveedorActual.Insumo.Descripcion);

                
            }
            catch (Exception e)
            {
                this.btnAceptarIngreso.Enabled = false;
                MessageBox.Show(e.Message, "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnAceptarIngreso.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptarIngreso.Enabled = false;
                    this.btnAceptarIngreso.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptarIngreso.Text = "Eliminar";
                    this.cbProveedores.Enabled = false;
                    this.cbInsumos.Enabled = false;
                    this.dtpFechaIngreso.Enabled = false;
                    this.txtCantidad.Enabled = false;
                    this.btnAceptarIngreso.Enabled = true;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptarIngreso.Text = "Aceptar";
                    break;
            }
        }
        public override void MapearADatos()
        {
            try
            {
                if (Modos == ModoForm.Alta)
                {
                    InsumoProveedorActual = new InsumoProveedor();
                    InsumoProveedorActual.IdInsumo = (int)this.cbInsumos.SelectedValue;
                    InsumoProveedorActual.IdProveedor = (int)this.cbProveedores.SelectedValue;
                    InsumoProveedorActual.FechaIngreso = this.dtpFechaIngreso.Value;
                    InsumoProveedorActual.Cantidad = ConvertirUnidadesConsumo(Int32.Parse(this.txtCantidad.Text));
                }
                
                switch (Modos)
                {
                    case ModoForm.Alta:
                        InsumoProveedorActual.State = BusinessEntity.States.New;
                        break;
                    case ModoForm.Modificacion:
                        InsumoProveedorActual.State = BusinessEntity.States.Modified;
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetearMedidas(int unidad)
        {

            _unidadesMedida.Clear();
            if (unidad == 1)
            {
                
                _unidadesMedida.Add("Litros(1L/1000Cm3/1000ml");
                _unidadesMedida.Add("Mililitros / Cm3");
            }
            if (unidad == 2)
            {
                
                _unidadesMedida.Add("Kilogramos(1Kg / 1000gr)");
                _unidadesMedida.Add("Gramos(gr)");

            }
        }

        private double ConvertirUnidadesConsumo(int _cantidad)
        {

            if (this.cmbUnidadMedida.SelectedText == "Mililitros/Cm3" || this.cmbUnidadMedida.SelectedText == "Gramos(gr)")
            {
                return _cantidad / 1000;
            }
            else
            {
                return _cantidad;
            }
        }

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            switch (Modos)
            {
                case ModoForm.Alta:
                    {
                        GuardarCambios();
                        int IdInsumo = (int)this.cbInsumos.SelectedValue;
                        Insumo insumo = _insumoLogic.GetOne(IdInsumo);
                        insumo.Stock += Int32.Parse(this.txtCantidad.Text);
                        insumo.State = BusinessEntity.States.Modified;
                        _insumoLogic.Save(insumo);
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
        public override void GuardarCambios()
        {
            //            try
            //            {
            MapearADatos();
            _insumoProveedorLogic.Save(InsumoProveedorActual);
            Close();

            //            }
            /*            catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            */
        }
        public virtual void Eliminar()
        {
            try
            {
                _insumoProveedorLogic.Delete(InsumoProveedorActual.IdInsumo,InsumoProveedorActual.IdProveedor,InsumoProveedorActual.FechaIngreso);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewProvIngreso_Click(object sender, EventArgs e)
        {
            ProveedorDesktop frmProv = new ProveedorDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmProv.ShowDialog();
        }

        private void btnNewInsumoIngreso_Click(object sender, EventArgs e)
        {
            InsumoDesktop frmIns = new InsumoDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmIns.ShowDialog();
        }
          
        private void cbInsumos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Insumo insumoActual = _insumoLogic.GetOne((int)this.cbInsumos.SelectedValue);
            int unity = (int)insumoActual.UnidadMedida;
            SetearMedidas(unity);
            this.cmbUnidadMedida.DataSource = _unidadesMedida;

        }
        /*
        private void cbInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumo insumoActual = _insumoLogic.GetOne((int)this.cbInsumos.SelectedValue);
            SetearMedidas((int)insumoActual.UnidadMedida);
            this.cmbUnidadMedida.DataSource = _unidadesMedida;
        }/*

        /*private void cbInsumos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int IDInsumo = (int)this.cbInsumos.SelectedValue;
            Insumo insumo = _insumoLogic.GetOne(IDInsumo);
            this.txtUnidadMedidaIngreso.Text = insumo.UnidadMedida.ToString();
        }*/
    }
}
