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
        private readonly TiposMaquinaLogic _tiposMaquinaLogic;
        public Maquina MaquinaActual { get; set; }
        

        public MaquinaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
            _tiposMaquinaLogic = new TiposMaquinaLogic(new TiposMaquinaAdapter(context));
        }

        public MaquinaDesktop(ModoForm modo, LavanderiaContext context) : this(context) 
        {
            Modos = modo;
            this.cmbTiposMaquina.DataSource = _tiposMaquinaLogic.GetAll();
        }

        public MaquinaDesktop(int idMaquina,ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try 
            {
                this.cmbTiposMaquina.DataSource = _tiposMaquinaLogic.GetAll();
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
            this.cmbTiposMaquina.SelectedIndex = cmbTiposMaquina.FindStringExact(MaquinaActual.TipoMaquina.Descripcion);
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
                MaquinaActual.TipoMaquina = _tiposMaquinaLogic.GetOne((int)this.cmbTiposMaquina.SelectedValue);
               
            }
            if (Modos == ModoForm.Modificacion)
            {
                MaquinaActual.Descripcion = this.txtDescripcion.Text;
                this.cmbTiposMaquina.FindStringExact(MaquinaActual.TipoMaquina.Descripcion);
                MaquinaActual.TipoMaquina = _tiposMaquinaLogic.GetOne((int)this.cmbTiposMaquina.SelectedValue);
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
                MessageBox.Show(notificacion,"Máquina",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidarExistenciaTipoMaquina()
        {
            List<TiposMaquina> tpm = _tiposMaquinaLogic.GetAll();
            if(tpm.Count > 0)
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
                if (ValidarExistenciaTipoMaquina())
                {
                    MapearADatos();
                    if (Validar())
                    {
                        _maquinaLogic.Save(MaquinaActual);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("No fue posible agregar una nueva máquina debido a que no se han encontrado tipos de máquinas registrados."+"\n"+"Por favor, registre el/los tipos de máquinas para poder continuar.", "Maquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
