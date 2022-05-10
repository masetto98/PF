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
    public partial class InsumoDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Insumo InsumoActual { set; get; }
        private readonly InsumoLogic _insumoLogic;
        public InsumoDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public InsumoDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
        }
        // Este es el constructor cuando se edita o elimina algo, ya que tiene 3 args
        public InsumoDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                InsumoActual = _insumoLogic.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAceptarInsumo_Click(object sender, EventArgs e)
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
        public override void MapearDeDatos()
        {
            this.txtIDInsumo.Text = this.InsumoActual.IdInsumo.ToString();
            this.txtDescInsumo.Text = this.InsumoActual.Descripcion;
            this.txtExistenciaInsumo.Text = this.InsumoActual.Stock.ToString();
            
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnAceptarInsumo.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptarInsumo.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptarInsumo.Text = "Eliminar";
                    this.txtIDInsumo.Enabled = false;
                    this.txtDescInsumo.Enabled = false;
                    this.txtExistenciaInsumo.Enabled = false;
                    
                    break;
                case ModoForm.Consulta:
                    /*this.btnAceptar.Text = "Aceptar";
                    this.cbMateria.Enabled = false;
                    this.cbComision.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    this.nudAnoCalendario.Enabled = false;
                    this.nudCupo.Enabled = false;*/
                    break;
            }
        }
        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                InsumoActual = new Insumo();
                InsumoActual.Descripcion = this.txtDescInsumo.Text;
                InsumoActual.Stock = Int32.Parse(this.txtExistenciaInsumo.Text);
                
            }
            if (Modos == ModoForm.Modificacion)
            {
                InsumoActual.Descripcion = this.txtDescInsumo.Text;
                InsumoActual.Stock = Int32.Parse(this.txtExistenciaInsumo.Text);
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    InsumoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    InsumoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
            //            try
            //            {
            MapearADatos();
            _insumoLogic.Save(InsumoActual);
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
                _insumoLogic.Delete(InsumoActual.IdInsumo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
