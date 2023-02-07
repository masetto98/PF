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
using FluentValidation.Results;

namespace UI.Desktop
{
    public partial class GastoDesktop : ApplicationForm
    {
        public Gasto GastoActual;
        private GastoLogic _gastoLogic;

        public GastoDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _gastoLogic = new GastoLogic(new GastoAdapter(context));
            this.cmbTipoGasto.DataSource = Enum.GetNames(typeof(Gasto.TiposGasto));

        }

        public GastoDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
        }

        public GastoDesktop(int idGasto, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                GastoActual = _gastoLogic.GetOne(idGasto);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void MapearDeDatos()
        {
            this.txtId.Text = GastoActual.IdGasto.ToString();
            this.cmbTipoGasto.SelectedIndex= cmbTipoGasto.FindStringExact(Enum.GetName(GastoActual.TipoGasto));
            this.txtDescripcion.Text = GastoActual.Descripcion;
            this.dtpFechaRealizacion.Value = GastoActual.FechaRealizado;
            this.txtImporte.Text = GastoActual.Importe.ToString();
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    
                    break;
                case ModoForm.Modificacion:
                    this.txtId.Enabled = false;
                    this.dtpFechaRealizacion.Enabled = false;
                    break;
                case ModoForm.Baja:
                    this.cmbTipoGasto.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    this.dtpFechaRealizacion.Enabled = false;
                    this.txtImporte.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.cmbTipoGasto.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    this.dtpFechaRealizacion.Enabled = false;
                    this.txtImporte.Enabled = false;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                GastoActual = new Gasto();
                GastoActual.TipoGasto= (Gasto.TiposGasto)Enum.Parse(typeof(Gasto.TiposGasto), cmbTipoGasto.SelectedItem.ToString());
                GastoActual.Descripcion = this.txtDescripcion.Text;
                GastoActual.FechaRealizado = DateTime.Now;
                GastoActual.Importe = Double.Parse(this.txtImporte.Text);
                GastoActual.Empleado = Singleton.getInstance().EmpleadoLogged;
            }
            if (Modos == ModoForm.Modificacion)
            {
                GastoActual.TipoGasto = (Gasto.TiposGasto)Enum.Parse(typeof(Gasto.TiposGasto), cmbTipoGasto.SelectedItem.ToString());
                GastoActual.Descripcion = this.txtDescripcion.Text;
                GastoActual.FechaRealizado = this.dtpFechaRealizacion.Value;
                GastoActual.Importe = Double.Parse(this.txtImporte.Text);
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    GastoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    GastoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override bool Validar()
        {
            ValidationResult result = new GastoValidator().Validate(GastoActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion,"Gasto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                //Validaciones.ValidarNumeroEnteroDecimal(this.txtImporte.Text);
                if (Validar())
                {
                    _gastoLogic.Save(GastoActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (MessageBox.Show($"¿Está seguro que desea modificar el gasto?", "Gasto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el gasto?", "Gasto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        public virtual void Eliminar()
        {
            try
            {
                _gastoLogic.Delete(GastoActual.IdGasto);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
