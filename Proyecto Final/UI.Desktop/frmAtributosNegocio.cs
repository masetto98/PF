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
    public partial class frmAtributosNegocio : ApplicationForm
    {
        private AtributosNegocioLogic _atributosNegocioLogic;
        private LavanderiaContext _context;
        public AtributosNegocio AtributosNegocioActual;

        public frmAtributosNegocio(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _atributosNegocioLogic = new AtributosNegocioLogic(new AtributosNegocioAdapter(context));
        }

        public frmAtributosNegocio(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            
        }
        
        public frmAtributosNegocio(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                AtributosNegocioActual = _atributosNegocioLogic.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atributos del negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtNombreNegocio.Text = AtributosNegocioActual.NombreEmpresa;
            this.txtDireccion.Text = AtributosNegocioActual.DireccionEmpresa;
            this.txtTelefono.Text = AtributosNegocioActual.TelEmpresa;
            this.txtRedes.Text = AtributosNegocioActual.RedesEmpresa;
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atributos del negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    //this.btnAceptar.Text = "Eliminar";
                    //this.txtDescripcion.Enabled = false;

                    break;
                case ModoForm.Consulta:
                    //this.btnAceptar.Text = "Aceptar";
                    //this.txtDescripcion.Enabled = false;
                    ;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                AtributosNegocioActual = new AtributosNegocio();
                AtributosNegocioActual.NombreEmpresa= this.txtNombreNegocio.Text;
                AtributosNegocioActual.DireccionEmpresa = this.txtDireccion.Text;
                AtributosNegocioActual.TelEmpresa = this.txtTelefono.Text;
                AtributosNegocioActual.RedesEmpresa = this.txtRedes.Text;
            }
            if (Modos == ModoForm.Modificacion)
            {
                AtributosNegocioActual.NombreEmpresa = this.txtNombreNegocio.Text;
                AtributosNegocioActual.DireccionEmpresa = this.txtDireccion.Text;
                AtributosNegocioActual.TelEmpresa = this.txtTelefono.Text;
                AtributosNegocioActual.RedesEmpresa = this.txtRedes.Text;

            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    AtributosNegocioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    AtributosNegocioActual.State = BusinessEntity.States.Modified;
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
                    _atributosNegocioLogic.Save(AtributosNegocioActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atributos del negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            ValidationResult result = new AtributosNegocioValidator().Validate(AtributosNegocioActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion, "Atributos Negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
                    {
                        //if (MessageBox.Show($"¿Está seguro que desea eliminar el servicio {ServicioActual.Descripcion}?", "Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        //{
                        //    Eliminar();
                        //    Close();
                        //}
                    };
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
