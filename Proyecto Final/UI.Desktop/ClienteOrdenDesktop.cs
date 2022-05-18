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
    public partial class ClienteOrdenDesktop : ApplicationForm
    {
        public Cliente ClienteActual { set; get; }
        private readonly ClienteLogic _clienteLogic;
        private readonly LavanderiaContext _context;
        public ClienteOrdenDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _clienteLogic = new ClienteLogic(new ClienteAdapter(context));
        }
        public ClienteOrdenDesktop(int IDCliente, LavanderiaContext context) : this(context)
        {
            ClienteActual = _clienteLogic.GetOrdenesCliente(IDCliente);
            this.Text = $"Ordenes del cliente: {ClienteActual.Nombre} , {ClienteActual.Apellido}";
            listarOrdenesCliente();
            

        }

        public void listarOrdenesCliente()
        {
            List<Orden> ordenesCli = ClienteActual.Ordenes;
            listOrdenesCliente.Items.Clear();
            foreach (Orden oc in ordenesCli)
            {
                ListViewItem item = new ListViewItem(oc.NroOrden.ToString());
                item.SubItems.Add(oc.Estado.ToString());
                item.SubItems.Add(oc.FechaEntrada.ToString());
                item.SubItems.Add(oc.FechaSalida.ToString());
                item.SubItems.Add(oc.TiempoFinalizacionReal.ToString());
                listOrdenesCliente.Items.Add(item);
            }
        }
    }
}
