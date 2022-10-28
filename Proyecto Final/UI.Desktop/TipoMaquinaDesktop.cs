using Business.Entities;
using Business.Logic;
using Data.Database;
using FluentValidation.Results;
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
    public partial class TipoMaquinaDesktop : ApplicationForm
    {
        private readonly TiposMaquinaLogic _tiposMaquinaLogic;
        public TiposMaquina TipoMaquinaActual { get; set; }
        public TipoMaquinaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _tiposMaquinaLogic = new TiposMaquinaLogic(new TiposMaquinaAdapter(context));
        }
        public TipoMaquinaDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            
        }

        public TipoMaquinaDesktop(int idTipoMaquina, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
              
                TipoMaquinaActual = _tiposMaquinaLogic.GetOne(idTipoMaquina);
                MapearDeDatos();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Tipo de Máquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public override void MapearDeDatos()
        {

            this.txtID.Text = TipoMaquinaActual.IdTipoMaquina.ToString();
            this.txtDescripcion.Text = TipoMaquinaActual.Descripcion;
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
                    this.txtID.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.txtID.Enabled = false;
                    this.txtDescripcion.Enabled = false;
                    break;
            }
        }
        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                TipoMaquinaActual = new TiposMaquina();
                TipoMaquinaActual.Descripcion = this.txtDescripcion.Text;
            }
            if (Modos == ModoForm.Modificacion)
            {
                TipoMaquinaActual.Descripcion = this.txtDescripcion.Text;
                
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    TipoMaquinaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    TipoMaquinaActual.State = BusinessEntity.States.Modified;
                    break;
            }

        }
        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (Validar())
                {
                    _tiposMaquinaLogic.Save(TipoMaquinaActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Tipo de Máquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (MessageBox.Show($"¿Está seguro que desea modificar el Tipo de Máquina {TipoMaquinaActual.Descripcion}?", "Tipo de Máquina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        GuardarCambios();
                    }
                    break;
                case ModoForm.Baja:
                    if (MessageBox.Show($"¿Está seguro que desea eliminar el Tipo de Máquina {TipoMaquinaActual.Descripcion}?", "Tipo de Máquina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Eliminar();
                        Close();
                    }
                    break;
                case ModoForm.Consulta:
                    Close();
                    break;

            }
        }
        public override bool Validar()
        {
            ValidationResult result = new TipoMaquinaValidator().Validate(TipoMaquinaActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion, "Tipo de Máquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public virtual void Eliminar()
        {
            try
            {
                _tiposMaquinaLogic.Delete(TipoMaquinaActual.IdTipoMaquina);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Tipo de Máquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
