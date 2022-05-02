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
    public partial class EmpleadoDesktop : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Empleado EmpleadoActual { set; get; }
        private readonly EmpleadoLogic _empleadoLogic;


        public EmpleadoDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));
            this.cbTipoEmpleado.DataSource = Enum.GetNames(typeof(Business.Entities.Empleado.TiposEmpleado));
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EmpleadoActual = new Empleado();
            EmpleadoActual.Cuit = this.txtCuit.Text;
            EmpleadoActual.Nombre = this.txtNombre.Text;
            EmpleadoActual.Apellido = this.txtApellido.Text;
            EmpleadoActual.Telefono = this.txtTelefono.Text;
            EmpleadoActual.Email = this.txtEmail.Text;
            EmpleadoActual.Direccion = this.txtDireccion.Text;
            EmpleadoActual.FechaInicio = this.dtpFechaInicio.Value.Date;
            EmpleadoActual.TipoEmpleado = (Business.Entities.Empleado.TiposEmpleado)Enum.Parse(typeof(Business.Entities.Empleado.TiposEmpleado), cbTipoEmpleado.SelectedItem.ToString());
            EmpleadoActual.State = BusinessEntity.States.New;
            _empleadoLogic.Save(EmpleadoActual);
            this.Close();

        }
    }
}
