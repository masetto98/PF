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
using MaterialSkin.Controls;

namespace UI.Desktop
{
    public partial class ApplicationForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public ApplicationForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }
        public ModoForm _modos;
        public ModoForm Modos { get { return _modos; } set { _modos = value; } }
        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual void GuardarCambios() { }
        public virtual bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        { MessageBox.Show(mensaje, titulo, botones, icono); }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        { this.Notificar(this.Text, mensaje, botones, icono); }
        public void CambiarColor(bool yesno)
        {
            if (yesno)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            
        }
        private void ApplicationForm_Load(object sender, EventArgs e) {}
    }


}
