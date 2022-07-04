using Business.Entities;
using Business.Logic;
using Data.Database;
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
    public partial class ReporteCuentaCorriente : ApplicationForm
    {
        private LavanderiaContext _context;
        private OrdenLogic _ordenLogic;
        public List<Orden> ordenesCliente;
        private ClienteLogic _clienteLogic;
        public Cliente clienteActual;
        public ReporteCuentaCorriente(LavanderiaContext context)
        {
            _context = context;
            InitializeComponent();
            _ordenLogic = new OrdenLogic(new OrdenAdapter(context));
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ID = this.txtBuscarCliente.Text;
            List<Cliente> clientes = _clienteLogic.GetAll();
            clienteActual = clientes.Find(
                delegate (Cliente c)
                {
                    return c.Cuit == ID || (c.Nombre.ToLower() == ID && c.Apellido.ToLower() == ID);
                });
            if(clienteActual is not null)
            {
                ordenesCliente = clienteActual.Ordenes;
                ListarOrdenesCliente();
            }
            else
            {
                MessageBox.Show("No se ha podido encontrar el cliente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListarOrdenesCliente()
        {
            /*
            List<Orden> ordenesAdeudadas = ordenesCliente.FindAll(
                delegate (Orden or)
                {
                    return or.
                });
            */
            listOrdenesCliente.Items.Clear();
        }
    }
}
