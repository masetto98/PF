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
    public partial class TipoPrendaDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public TipoPrenda TipoPrendaActual { set; get; }
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        public TipoPrendaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public TipoPrendaDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
        }
        // Este es el constructor cuando se edita o elimina algo, ya que tiene 3 args
        public TipoPrendaDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                TipoPrendaActual = _tipoPrendaLogic.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void MapearDeDatos()
        {
            this.txtIDTipoPrenda.Text = this.TipoPrendaActual.IdTipoPrenda.ToString();
            this.txtDescTipoPrenda.Text = this.TipoPrendaActual.Descripcion;
            

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
                    this.txtIDTipoPrenda.Enabled = false;
                    this.txtDescTipoPrenda.Enabled = false;
                    
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
                TipoPrendaActual = new TipoPrenda();
                TipoPrendaActual.Descripcion = this.txtDescTipoPrenda.Text;
                
            }
            if (Modos == ModoForm.Modificacion)
            {
                TipoPrendaActual.Descripcion = this.txtDescTipoPrenda.Text;
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    TipoPrendaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    TipoPrendaActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
            //            try
            //            {
            MapearADatos();
            _tipoPrendaLogic.Save(TipoPrendaActual);
            Close();

            //            }
            /*            catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            */
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
        public virtual void Eliminar()
        {
            try
            {
                _tipoPrendaLogic.Delete(TipoPrendaActual.IdTipoPrenda);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
