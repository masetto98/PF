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
using FluentValidation.Results;

namespace UI.Desktop
{
    public partial class InsumoProveedorDesktop : ApplicationForm
    {
        private readonly ProveedorLogic _proveedorLogic;
        private readonly InsumoLogic _insumoLogic;
        private readonly InsumoProveedorLogic _insumoProveedorLogic;
        public InsumoProveedor InsumoProveedorActual { set; get; }
        private readonly LavanderiaContext _context;
        public List<String> _unidadesMedida;

        public InsumoProveedorDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            _proveedorLogic = new ProveedorLogic(new ProveedorAdapter(context));
            _insumoProveedorLogic = new InsumoProveedorLogic(new InsumoProveedorAdapter(context));
            _context = context;
            _unidadesMedida = new List<string>();

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
                MessageBox.Show(e.Message, "Ingreso de insumos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public InsumoProveedorDesktop(int idProveedor,int idInsumo,DateTime fechaIngreso, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                InsumoProveedorActual = _insumoProveedorLogic.GetOne(idProveedor,idInsumo,fechaIngreso);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ingreso de insumos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.cbProveedores.Text = this.InsumoProveedorActual.Proveedor.RazonSocial;
            this.cbInsumos.Text = InsumoProveedorActual.Insumo.Descripcion;
            this.dtpFechaIngreso.Value = InsumoProveedorActual.FechaIngreso;
            this.txtCantidad.Text = InsumoProveedorActual.Cantidad.ToString();
            this.cmbUnidadMedida.Text = InsumoProveedorActual.Insumo.UnidadMedida.ToString();
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
                    
                    this.btnAceptarIngreso.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptarIngreso.Text = "Eliminar";
                    this.cbProveedores.Enabled = false;
                    this.cbInsumos.Enabled = false;
                    this.dtpFechaIngreso.Enabled = false;
                    this.txtCantidad.Enabled = false;
                    this.cmbUnidadMedida.Enabled = false;
                    this.btnAceptarIngreso.Enabled = true;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptarIngreso.Text = "Aceptar";
                    this.cbProveedores.Enabled = false;
                    this.cbInsumos.Enabled = false;
                    this.dtpFechaIngreso.Enabled = false;
                    this.txtCantidad.Enabled = false;
                    this.cmbUnidadMedida.Enabled = false;
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
                    InsumoProveedorActual.FechaIngreso = DateTime.Now;
                    InsumoProveedorActual.Cantidad = ConvertirUnidadesConsumo(double.Parse(this.txtCantidad.Text),_unidadesMedida[this.cmbUnidadMedida.SelectedIndex]);
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
                MessageBox.Show(e.Message, "Ingreso de insumos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<String> SetearMedidas(int unidad, List<string> unidadesMedida)
        {
            
            unidadesMedida.Clear();
            if (unidad == 1)
            {
                unidadesMedida.Add("Litros(1L/1000Cm3/1000ml");
                unidadesMedida.Add("Mililitros / Cm3");
                return unidadesMedida;
            }
            if (unidad == 2)
            {
                unidadesMedida.Add("Kilogramos(1Kg / 1000gr)");
                unidadesMedida.Add("Gramos(gr)");
                return unidadesMedida;
            }
            if (unidad == 3)
            {
                unidadesMedida.Add("Unidades");
                return unidadesMedida;
            }
            return null;
        }

        private double ConvertirUnidadesConsumo(double _cantidad,string unidadSelect)
        {

            if (unidadSelect == "Mililitros / Cm3" || unidadSelect == "Gramos(gr)")
            {
                return _cantidad / 1000;
            }
            else
            {
                return _cantidad;
            }
        }

        
        
        public virtual void Eliminar()
        {
            try
            {
                _insumoProveedorLogic.Delete(InsumoProveedorActual.IdInsumo,InsumoProveedorActual.IdProveedor,InsumoProveedorActual.FechaIngreso);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ingreso de insumos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            switch (Modos)
            {
                case ModoForm.Alta:
                    {
                        GuardarCambios();
                        ModificarStock();
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea modificar el ingreso?", "Ingreso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el ingreso?", "Ingreso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Eliminar();
                            Close();
                        }
                    };
                    break;
                case ModoForm.Consulta:
                    Close();
                    break;
            }
        }

        private void ModificarStock() 
        {
            int IdInsumo = (int)this.cbInsumos.SelectedValue;
            Insumo insumo = _insumoLogic.GetOne(IdInsumo);
            double stockAnterior = insumo.Stock;
            insumo.Stock = stockAnterior + InsumoProveedorActual.Cantidad;
            insumo.State = BusinessEntity.States.Modified;
            _insumoLogic.Save(insumo);
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                Validaciones.ValidarNumeroEnteroDecimal(this.txtCantidad.Text);
                _insumoProveedorLogic.Save(InsumoProveedorActual);
                Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ingreso de insumos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Insumo insumoActual = _insumoLogic.GetOne(Int32.Parse(this.cbInsumos.SelectedValue.ToString()));
            List<string> unidadesMedida = new List<string>();
            _unidadesMedida = SetearMedidas((int)insumoActual.UnidadMedida, unidadesMedida);
            this.cmbUnidadMedida.DataSource = _unidadesMedida;
        }
    }
}
