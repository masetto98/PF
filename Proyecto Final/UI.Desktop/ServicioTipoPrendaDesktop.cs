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
using Data.Database;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ServicioTipoPrendaDesktop : ApplicationForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        
        public ServicioTipoPrenda ServicioTipoPrendaActual { set; get; }
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        private readonly ServicioLogic _servicioLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;

        public ServicioTipoPrendaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _servicioTipoPrendaLogic = new ServicioTipoPrendaLogic(new ServicioTipoPrendaAdapter(context));
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public ServicioTipoPrendaDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                List<Servicio> servicios = _servicioLogic.GetAll();
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbTipoPrendas.DataSource = tipoPrendas;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ServicioTipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ServicioTipoPrendaDesktop(int idServicio,int IdTipoPrenda, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetOne(idServicio,IdTipoPrenda);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtHoras.Text = ServicioTipoPrendaActual.TiempoRequerido.Hours.ToString();
            this.txtMinutos.Text = ServicioTipoPrendaActual.TiempoRequerido.Minutes.ToString();

            try
            {
                Servicio ServicioActual = _servicioLogic.GetOne(ServicioTipoPrendaActual.IdServicio);
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
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                ServicioTipoPrendaActual = new ServicioTipoPrenda();
                ServicioTipoPrendaActual.IdServicio = (int)this.cmbServicios.SelectedValue;
                ServicioTipoPrendaActual.IdTipoPrenda = (int)this.cmbTipoPrendas.SelectedValue;
                ServicioTipoPrendaActual.TiempoRequerido = new TimeSpan(Int32.Parse(this.txtHoras.Text), Int32.Parse(this.txtMinutos.Text),00);
            }
            if (Modos == ModoForm.Modificacion)
            {
                ServicioTipoPrendaActual.IdServicio = (int)this.cmbServicios.SelectedValue;
                ServicioTipoPrendaActual.IdTipoPrenda = (int)this.cmbTipoPrendas.SelectedValue;
                ServicioTipoPrendaActual.TiempoRequerido = new TimeSpan(Int32.Parse(this.txtHoras.Text), Int32.Parse(this.txtMinutos.Text), 00);
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    ServicioTipoPrendaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
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
                    _servicioTipoPrendaLogic.Save(ServicioTipoPrendaActual);
                    Close();
                }
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void Eliminar()
        {
            try
            {
                _servicioTipoPrendaLogic.Delete(ServicioTipoPrendaActual.IdServicio,ServicioTipoPrendaActual.IdTipoPrenda);
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
