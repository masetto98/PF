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
    public partial class TipoPrendaDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        public TipoPrenda TipoPrendaActual { set; get; }

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
            this.txtID.Enabled = false;
        }

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
            this.txtID.Text = this.TipoPrendaActual.IdTipoPrenda.ToString();
            this.txtDescripcion.Text = this.TipoPrendaActual.Descripcion;
            
            try
            {
                
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
                    this.txtDescripcion.Enabled = false;
                    
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.txtDescripcion.Enabled = false;
                    ;
                    break;
            }
        }


        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                TipoPrendaActual = new TipoPrenda();
                TipoPrendaActual.Descripcion = this.txtDescripcion.Text;
                
                
            }
            if (Modos == ModoForm.Modificacion)
            {
                TipoPrendaActual.Descripcion = this.txtDescripcion.Text;
                
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
            //try
            //{
                MapearADatos();
                _tipoPrendaLogic.Save(TipoPrendaActual);
                Close();
                /*if (true)
                {
                    _tipoPrendaLogic.Save(TipoPrendaActual);
                    Close();
                    
                }*/
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /*public override bool Validar()
        {
            ValidationResult result = new MateriaValidator().Validate(MateriaActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion);
                return false;
            }
            return true;
        }*/

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
    }
}
