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
using FluentValidation.Results;

namespace UI.Desktop
{
    public partial class EmpleadoDesktop : ApplicationForm
    {
        
        public Empleado EmpleadoActual { set; get; }
        private readonly EmpleadoLogic _empleadoLogic;

        public EmpleadoDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
            this.cbTipoEmpleado.DataSource = Enum.GetNames(typeof(Empleado.TiposEmpleado));
            //this.cbTipoEmpleado.SelectedIndex = 2;
            
        }

        public EmpleadoDesktop(ModoForm modo, LavanderiaContext context):this(context)
        {
            Modos = modo;
        }

        public EmpleadoDesktop(int idEmpleado, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                EmpleadoActual = _empleadoLogic.GetOne(idEmpleado);
                MapearDeDatos();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = EmpleadoActual.IdEmpleado.ToString();
            this.txtCuit.Text= EmpleadoActual.Cuit ;
            this.txtNombre.Text = EmpleadoActual.Nombre;
            this.txtApellido.Text = EmpleadoActual.Apellido;
            this.txtTelefono.Text = EmpleadoActual.Telefono;
            this.txtEmail.Text = EmpleadoActual.Email;
            this.txtDireccion.Text = EmpleadoActual.Direccion;
            this.dtpFechaInicio.Value = EmpleadoActual.FechaInicio;
            this.cbTipoEmpleado.SelectedIndex = cbTipoEmpleado.FindStringExact(Enum.GetName(EmpleadoActual.TipoEmpleado));
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
                    this.txtCuit.Enabled = false;
                    this.txtNombre.Enabled = false;
                    this.txtApellido.Enabled = false;
                    this.txtTelefono.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.txtDireccion.Enabled = false;
                    this.dtpFechaInicio.Enabled = false;
                    this.cbTipoEmpleado.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.txtCuit.Enabled = false;
                    this.txtNombre.Enabled = false;
                    this.txtApellido.Enabled = false;
                    this.txtTelefono.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.txtDireccion.Enabled = false;
                    this.dtpFechaInicio.Enabled = false;
                    this.cbTipoEmpleado.Enabled = false;
                    break;
            }

        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                EmpleadoActual = new Empleado();
                EmpleadoActual.Cuit = this.txtCuit.Text;
                EmpleadoActual.Nombre = this.txtNombre.Text;
                EmpleadoActual.Apellido = this.txtApellido.Text;
                EmpleadoActual.Telefono = this.txtTelefono.Text;
                EmpleadoActual.Email = this.txtEmail.Text;
                EmpleadoActual.Direccion = this.txtDireccion.Text;
                EmpleadoActual.FechaInicio = this.dtpFechaInicio.Value.Date;
                EmpleadoActual.TipoEmpleado = (Empleado.TiposEmpleado)Enum.Parse(typeof(Empleado.TiposEmpleado), cbTipoEmpleado.SelectedItem.ToString());
            }
            if (Modos == ModoForm.Modificacion)
            {
                EmpleadoActual.Cuit = this.txtCuit.Text;
                EmpleadoActual.Nombre = this.txtNombre.Text;
                EmpleadoActual.Apellido = this.txtApellido.Text;
                EmpleadoActual.Telefono = this.txtTelefono.Text;
                EmpleadoActual.Email = this.txtEmail.Text;
                EmpleadoActual.Direccion = this.txtDireccion.Text;
                EmpleadoActual.FechaInicio = this.dtpFechaInicio.Value.Date;
                EmpleadoActual.TipoEmpleado = (Business.Entities.Empleado.TiposEmpleado)Enum.Parse(typeof(Business.Entities.Empleado.TiposEmpleado), cbTipoEmpleado.SelectedItem.ToString());
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    EmpleadoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    EmpleadoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }


        public override bool Validar()
        {
            ValidationResult result = new EmpleadoValidator().Validate(EmpleadoActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion,"Empleado",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    _empleadoLogic.Save(EmpleadoActual);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (MessageBox.Show($"¿Está seguro que desea modificar el empleado {EmpleadoActual.Nombre}-{EmpleadoActual.Apellido}?", "Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el empleado {EmpleadoActual.Nombre}-{EmpleadoActual.Apellido}?", "Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                _empleadoLogic.Delete(EmpleadoActual.IdEmpleado);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
