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
    public partial class ServicioDesktop : ApplicationForm
    {
        private readonly ServicioLogic _servicioLogic;
        public Servicio ServicioActual { set; get; }

        public ServicioDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
        }

        public ServicioDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
        }

        public ServicioDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                ServicioActual = _servicioLogic.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ServicioActual.IdServicio.ToString();
            this.txtDescripcion.Text = this.ServicioActual.Descripcion;

            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ServicioActual = new Servicio();
                ServicioActual.Descripcion = this.txtDescripcion.Text;


            }
            if (Modos == ModoForm.Modificacion)
            {
                ServicioActual.Descripcion = this.txtDescripcion.Text;

            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    ServicioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ServicioActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }



        public override bool Validar()
        {
            ValidationResult result = new ServicioValidator().Validate(ServicioActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion,"Servicio",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                        
                        _servicioLogic.Save(ServicioActual);
                        Close();

                }
                    
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void Eliminar()
        {
            try
            {
                _servicioLogic.Delete(ServicioActual.IdServicio);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (MessageBox.Show($"¿Está seguro que desea modificar el servicio {ServicioActual.Descripcion}?", "Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el servicio {ServicioActual.Descripcion}?", "Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        
    }
}
