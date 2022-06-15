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
    public partial class MantenimientoDesktop : ApplicationForm
    {
        private readonly MantenimientoLogic _mantenimientoLogic;
        private readonly MaquinaLogic _maquinaLogic;
        private readonly LavanderiaContext _context;
        public Maquina MaquinaActual { get; set; }
        public Mantenimiento MantenimientoActual { get; set; }

        public MantenimientoDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
            _mantenimientoLogic = new MantenimientoLogic(new MantenimientoAdapter(context));

        }
        public MantenimientoDesktop(int idMaquina,ModoForm modo, LavanderiaContext context):this(context)
        {
            Modos = modo;
            MaquinaActual = _maquinaLogic.GetOne(idMaquina);

        }

        public MantenimientoDesktop(int idMaquina,DateTime fechaMantenimiento,ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                MantenimientoActual = _mantenimientoLogic.GetOne(idMaquina, fechaMantenimiento);
                MapearDeDatos();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.dtpFechaRealizacion.Value = MantenimientoActual.FechaRealizado;
            this.txtDescripcion.Text = MantenimientoActual.Descripcion;
            this.txtCosto.Text = MantenimientoActual.Costo.ToString();
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
                    this.dtpFechaRealizacion.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    this.txtCosto.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.dtpFechaRealizacion.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    this.txtCosto.Enabled = false;
                    break;
            }

        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                MantenimientoActual = new Mantenimiento();
                MantenimientoActual.FechaRealizado = this.dtpFechaRealizacion.Value;
                MantenimientoActual.Descripcion = this.txtDescripcion.Text;
                MantenimientoActual.Costo = double.Parse(this.txtCosto.Text);
                MantenimientoActual.Maquina = MaquinaActual;
            }
            if (Modos == ModoForm.Modificacion)
            {
                MantenimientoActual.FechaRealizado = this.dtpFechaRealizacion.Value;
                MantenimientoActual.Descripcion = this.txtDescripcion.Text;
                MantenimientoActual.Costo = double.Parse(this.txtCosto.Text);
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    MantenimientoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    MantenimientoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override bool Validar()
        {
            ValidationResult result = new MantenimientoValidator().Validate(MantenimientoActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion);
                return false;
            }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                
                MapearADatos();
                Validaciones.ValidarNumeroEnteroDecimal(this.txtCosto.Text);
                if (Validar())
                {
                    _mantenimientoLogic.Save(MantenimientoActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void Eliminar()
        {
            try
            {
                _mantenimientoLogic.Delete(MantenimientoActual.IdMaquina,MantenimientoActual.FechaRealizado);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modos)
            {
                case ModoForm.Alta:
                    {
                        GuardarCambios();
                        Close();
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        GuardarCambios();
                        Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
