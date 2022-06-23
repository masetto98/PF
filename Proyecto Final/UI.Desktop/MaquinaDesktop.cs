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
    public partial class MaquinaDesktop : ApplicationForm
    {
        private readonly MaquinaLogic _maquinaLogic;
        public Maquina MaquinaActual { get; set; }

        public MaquinaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
        }

        public MaquinaDesktop(ModoForm modo, LavanderiaContext context) : this(context) 
        {
            Modos = modo;
        }

        public MaquinaDesktop(int idMaquina,ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try 
            {
                MaquinaActual = _maquinaLogic.GetOne(idMaquina);
                MapearDeDatos();

            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Maquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = MaquinaActual.IdMaquina.ToString();
            this.txtDescripcion.Text = MaquinaActual.Descripcion;
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
                MaquinaActual = new Maquina();
                MaquinaActual.Descripcion = this.txtDescripcion.Text;
            }
            if (Modos == ModoForm.Modificacion)
            {
                MaquinaActual.Descripcion = this.txtDescripcion.Text;
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    MaquinaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    MaquinaActual.State = BusinessEntity.States.Modified;
                    break;
            }

        }

        public override bool Validar()
        {
            ValidationResult result = new MaquinaValidator().Validate(MaquinaActual);
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
                if (Validar())
                {
                    _maquinaLogic.Save(MaquinaActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Maquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (MessageBox.Show($"¿Está seguro que desea modificar la máquina {MaquinaActual.Descripcion}?", "Máquina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        GuardarCambios();
                    }
                    break;
                case ModoForm.Baja:
                    if (MessageBox.Show($"¿Está seguro que desea eliminar la máquina {MaquinaActual.Descripcion}?", "Máquina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        public virtual void Eliminar()
        {
            try
            {
                _maquinaLogic.Delete(MaquinaActual.IdMaquina);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Maquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
