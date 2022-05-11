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
using MaterialSkin;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace UI.Desktop
{
    public partial class frmLogin2 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly UsuarioLogic _usuarioLogic;
        private readonly EmpleadoLogic _empleadoLogic;
        public frmLogin2 (LavanderiaContext context)
        {
            InitializeComponent();
            _usuarioLogic = new UsuarioLogic(new UsuarioAdapter(context));
            _empleadoLogic = new EmpleadoLogic(new EmpleadoAdapter(context));


            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usr = _usuarioLogic.Login(this.txtNombreUsuario.Text.ToLower(), this.txtContrasenia.Text.ToLower());
                if (usr != null)
                {
                    if (usr.Habilitado == true)
                    {
                        Singleton.setInstance(_empleadoLogic.GetOne(usr.IdEmpleado), usr);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Usuario no habilitado, contactese con su administrador", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario incorrecto", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
