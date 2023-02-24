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
        private readonly ConsumoLogic _consumoLogic;
        public InsumoProveedor InsumoProveedorActual { set; get; }
        private readonly LavanderiaContext _context;
        public List<String> _unidadesMedida;

        public InsumoProveedorDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            _proveedorLogic = new ProveedorLogic(new ProveedorAdapter(context));
            _insumoProveedorLogic = new InsumoProveedorLogic(new InsumoProveedorAdapter(context));
            _consumoLogic = new ConsumoLogic(new ConsumoAdapter(context));
            _context = context;
            _unidadesMedida = new List<string>();

        }

        public InsumoProveedorDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            
            this.cbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
               
                List<Proveedor> proveedores = _proveedorLogic.GetAll();
                this.cbProveedores.DataSource = proveedores;
               
                //this.cbProveedores.SelectedIndex = 0;
                List<Insumo> insumos = _insumoLogic.GetAll();
                this.cbInsumos.DataSource = insumos;
               // this.cbInsumos.SelectedIndex = 0;
                
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
                        if (ValidarExistenciaInsProv())
                        {
                            GuardarCambios();
                            ModificarStock();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible agregar el nuevo ingreso debido a que no se han encontrado proveedores o insumos en el sistema." + "\n" + "Por favor, registre dichos elementos para poder continuar.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
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
                            ModificarStock();
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
            switch (Modos)
            {
                case ModoForm.Alta:
                    {
                        int IdInsumo = (int)this.cbInsumos.SelectedValue;
                        Insumo insumo = _insumoLogic.GetOne(IdInsumo);
                        double stockAnterior = insumo.Stock;
                        insumo.Stock = stockAnterior + InsumoProveedorActual.Cantidad;
                        insumo.State = BusinessEntity.States.Modified;
                        _insumoLogic.Save(insumo);
                    };
                    break;
                case ModoForm.Baja:
                    {
                        List<Consumo> consumos = _consumoLogic.GetAll().FindAll(
                            delegate (Consumo c)
                            {
                                return c.Insumo == InsumoProveedorActual.Insumo && c.FechaConsumo >= InsumoProveedorActual.FechaIngreso;
                            });
                        double consumoApartirDeIngreso = 0;
                        foreach(Consumo c in consumos)
                        {
                            consumoApartirDeIngreso += c.Cantidad;
                        }
                        double consumoIngreso = InsumoProveedorActual.Cantidad - consumoApartirDeIngreso;
                        Insumo insumo = InsumoProveedorActual.Insumo;
                        double stockAnterior = insumo.Stock;
                        insumo.Stock = stockAnterior - consumoIngreso;
                        insumo.State = BusinessEntity.States.Modified;
                        _insumoLogic.Save(insumo);

                    };
                    break;
                    

            }
            
        }
        private bool ValidarExistenciaInsProv()
        {
            List<Insumo> insumos = _insumoLogic.GetAll();
            List<Proveedor> prov = _proveedorLogic.GetAll();
            if(insumos.Count > 0 && prov.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void GuardarCambios()
        {
            try
            {
               
                    MapearADatos();
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
            if (frmProv.ShowDialog() == DialogResult.OK)
            {
                List<Proveedor> proveedores = _proveedorLogic.GetAll();
                this.cbProveedores.DataSource = proveedores;
            }
                
        }

        private void btnNewInsumoIngreso_Click(object sender, EventArgs e)
        {
            InsumoDesktop frmIns = new InsumoDesktop(ApplicationForm.ModoForm.Alta, _context);
            if (frmIns.ShowDialog() == DialogResult.OK)
            {
                List<Insumo> insumos = _insumoLogic.GetAll();
                this.cbInsumos.DataSource = insumos;
            }
        }
          
        private void cbInsumos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(this.cbInsumos.SelectedValue is not null)
            {
                Insumo insumoActual = _insumoLogic.GetOne(Int32.Parse(this.cbInsumos.SelectedValue.ToString()));
                List<string> unidadesMedida = new List<string>();
                _unidadesMedida = SetearMedidas((int)insumoActual.UnidadMedida, unidadesMedida);
                this.cmbUnidadMedida.DataSource = _unidadesMedida;
            }
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Validaciones.ValidarNumeroEnteroDecimal(txtCantidad.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCantidad.Text = "";
            }
           
        }
    }
}
