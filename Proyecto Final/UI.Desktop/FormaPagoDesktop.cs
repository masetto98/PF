using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class FormaPagoDesktop : ApplicationForm
    {
        Business.Entities.Pago.FormasPago _fp;
        public FormaPagoDesktop()
        {
            InitializeComponent();
            List<String> formasPago = new List<string>();
            foreach (string fp in Enum.GetNames(typeof(Business.Entities.Pago.FormasPago))) 
            {
                string palabra=fp;
                for (int i = 2; i < fp.Length; i++)
                {
                    //palabra = fp;
                    if (char.IsUpper(palabra[i]))
                    {
                        palabra = palabra.Insert(i," ");
                        i++;
                    } 
                }
                formasPago.Add(palabra);
            }
            //this.cbFormaPago.DataSource = Enum.GetNames(typeof(Business.Entities.Pago.FormasPago));
            this.cbFormaPago.DataSource = formasPago;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GetFormaPago();
            this.DialogResult = DialogResult.OK;
            Close();
        }
        public Business.Entities.Pago.FormasPago GetFormaPago()
        {
            Regex formaPago = new Regex(@"\s+");
             _fp = (Business.Entities.Pago.FormasPago)Enum.Parse(typeof(Business.Entities.Pago.FormasPago), formaPago.Replace(cbFormaPago.SelectedItem.ToString(), string.Empty));
            return _fp;
        }
    }
}
