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
    public partial class FormaPagoDesktop : ApplicationForm
    {
        Business.Entities.Pago.FormasPago _fp;
        public FormaPagoDesktop()
        {
            InitializeComponent();
            this.cbFormaPago.DataSource = Enum.GetNames(typeof(Business.Entities.Pago.FormasPago));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GetFormaPago();
            Close();
        }
        public Business.Entities.Pago.FormasPago GetFormaPago()
        {
             _fp = (Business.Entities.Pago.FormasPago)Enum.Parse(typeof(Business.Entities.Pago.FormasPago), cbFormaPago.SelectedItem.ToString());
            return _fp;
        }
    }
}
