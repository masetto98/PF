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
using MaterialSkin;

namespace UI.Desktop
{
    public partial class MaquinaOrdenServicioTipoPrendaDesktop : ApplicationForm
    {
        private readonly MaquinaLogic _maquinaLogic;
        private readonly InsumoLogic _insumoLogic;
        private readonly OrdenServicioTipoPrendaLogic _ordenServicioTipoPrendaLogic;
        private readonly MaquinaOrdenServicioTipoPrendaLogic _maquinaOrdenServicioTipoPrendaLogic;
        public MaquinaOrdenServicioTipoPrenda TrabajoActual;
        public OrdenServicioTipoPrenda OrdenServicioTipoPrendaActual;
        public MaquinaOrdenServicioTipoPrendaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
            _maquinaOrdenServicioTipoPrendaLogic = new MaquinaOrdenServicioTipoPrendaLogic(new MaquinaOrdenServicioTipoPrendaAdapter(context));
            _ordenServicioTipoPrendaLogic = new OrdenServicioTipoPrendaLogic(new OrdenServicioTipoPrendaAdapter(context));
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
        }

        public MaquinaOrdenServicioTipoPrendaDesktop(int nroOrden,int idServicio ,int idTipoPrenda,int ordenItem, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            
            try
            {
                OrdenServicioTipoPrendaActual = _ordenServicioTipoPrendaLogic.GetOne(nroOrden, idServicio, idTipoPrenda, ordenItem);
                if (OrdenServicioTipoPrendaActual.MaquinaOrdenServicioTipoPrenda is null) 
                {
                    OrdenServicioTipoPrendaActual.MaquinaOrdenServicioTipoPrenda = new List<MaquinaOrdenServicioTipoPrenda>();
                }
                List<Maquina> maquinas = _maquinaLogic.GetAll();
                this.cmbMaquinas.DataSource = maquinas;
                this.txtNroOrden.Text = OrdenServicioTipoPrendaActual.NroOrden.ToString();
                this.txtOrdenItem.Text = OrdenServicioTipoPrendaActual.OrdenItem.ToString();
                this.txtServicio.Text = OrdenServicioTipoPrendaActual.ServicioTipoPrenda.Servicio.Descripcion;
                this.txtTipoPrenda.Text = OrdenServicioTipoPrendaActual.ServicioTipoPrenda.TipoPrenda.Descripcion;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atender Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MaquinaOrdenServicioTipoPrendaDesktop(int idMaquina, DateTime fechaInicioServicio, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                TrabajoActual = _maquinaOrdenServicioTipoPrendaLogic.GetOne(idMaquina,fechaInicioServicio);
                MapearDeDatos();
                this.cmbMaquinas.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atender Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtNroOrden.Text = TrabajoActual.NroOrden.ToString();
            this.txtOrdenItem.Text = TrabajoActual.OrdenItem.ToString();
            this.txtServicio.Text = TrabajoActual.OrdenServicioTipoPrenda.ServicioTipoPrenda.Servicio.ToString();
            this.txtTipoPrenda.Text = TrabajoActual.OrdenServicioTipoPrenda.ServicioTipoPrenda.TipoPrenda.ToString();

            try
            {
                List<Maquina> maquinas = _maquinaLogic.GetAll();
                this.cmbMaquinas.DataSource = maquinas;
                this.cmbMaquinas.SelectedIndex = cmbMaquinas.FindStringExact(TrabajoActual.Maquina.Descripcion);
            }
            catch (Exception e)
            {
                this.btnIniciar.Enabled = false;
                MessageBox.Show(e.Message, "Atender Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnIniciar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnIniciar.Enabled = false;
                    this.btnIniciar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnIniciar.Text = "Eliminar";
                    this.cmbMaquinas.Enabled = false;
                    this.btnIniciar.Enabled = true;
                    this.txtNroOrden.Enabled = false;
                    this.txtOrdenItem.Enabled = false;
                    this.txtServicio.Enabled = false;
                    this.txtTipoPrenda.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnIniciar.Text = "Aceptar";
                    this.cmbMaquinas.Enabled = false;
                    this.btnIniciar.Enabled = true;
                    this.txtNroOrden.Enabled = false;
                    this.txtOrdenItem.Enabled = false;
                    this.txtServicio.Enabled = false;
                    this.txtTipoPrenda.Enabled = false;
                    break;
            }
        }

        public override void MapearADatos()
        {
            try
            {
                if (Modos == ModoForm.Alta)
                {
                    TrabajoActual = new MaquinaOrdenServicioTipoPrenda();
                    TrabajoActual.Maquina = _maquinaLogic.GetOne((int)this.cmbMaquinas.SelectedValue);
                    TrabajoActual.TiempoInicioServicio = DateTime.Now;
                    TrabajoActual.OrdenServicioTipoPrenda = OrdenServicioTipoPrendaActual;
                    TrabajoActual.Empleado = Singleton.getInstance().EmpleadoLogged;
                    OrdenServicioTipoPrendaActual.MaquinaOrdenServicioTipoPrenda.Add(TrabajoActual);
                    OrdenServicioTipoPrendaActual.Estado = OrdenServicioTipoPrenda.Estados.Procesando;
                }
                if (Modos == ModoForm.Modificacion)
                {
                    TrabajoActual.TiempoFinServicio = DateTime.Now;
                    OrdenServicioTipoPrendaActual.MaquinaOrdenServicioTipoPrenda.Add(TrabajoActual);
                    OrdenServicioTipoPrendaActual.Estado = OrdenServicioTipoPrenda.Estados.Iniciado;
                }
                switch (Modos)
                {
                    case ModoForm.Alta:
                        OrdenServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
                        break;
                    case ModoForm.Modificacion:
                        TrabajoActual.State = BusinessEntity.States.Modified;
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atender Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarEstadoMaquina()
        {
            Maquina maquinaSelect = _maquinaLogic.GetOne((int)this.cmbMaquinas.SelectedValue);

            List<MaquinaOrdenServicioTipoPrenda> ordenesAtendidas = maquinaSelect.itemsAtendidos;
            MaquinaOrdenServicioTipoPrenda? itemEnAtencion = ordenesAtendidas.Find(delegate (MaquinaOrdenServicioTipoPrenda item)
            {
                return item.TiempoFinServicio == DateTime.MinValue;
            });
            if (itemEnAtencion is null || ordenesAtendidas is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void GuardarCambios()
        {
            try
            {
                if (ValidarEstadoMaquina())
                {
                    MapearADatos();
                    _ordenServicioTipoPrendaLogic.Save(OrdenServicioTipoPrendaActual);
                    Close();
                }
                else {
                    Exception r = new Exception("La maquina seleccionada se encuentra ocupada");
                    throw r;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atender Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void Eliminar()
        {
            try
            {
                _maquinaOrdenServicioTipoPrendaLogic.Delete(TrabajoActual.IdMaquina, TrabajoActual.TiempoInicioServicio);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atender Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            switch (Modos)
            {
                case ModoForm.Alta:
                    {
                        GuardarCambios();
                        ModificarStock();
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        GuardarCambios();
                    };
                    break;
                case ModoForm.Baja:
                    Eliminar();
                    Close();
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
        
        private void ModificarStock()
        {
            List<InsumoServicioTipoPrenda> insumosItem = OrdenServicioTipoPrendaActual.ServicioTipoPrenda.InsumoServicioTipoPrenda;
            
            foreach(InsumoServicioTipoPrenda ins in insumosItem)
            {
                InsumoServicioTipoPrenda actual = insumosItem.FindLast(
                    delegate (InsumoServicioTipoPrenda istp)
                    {
                        return istp.FechaDesde <= DateTime.Today;
                    });
                double stockAnterior = ins.Insumo.Stock;
                double consumoActual = actual.Cantidad;
                ins.Insumo.Stock = stockAnterior - consumoActual;
                ins.Insumo.State = BusinessEntity.States.Modified;
                _insumoLogic.Save(ins.Insumo);

            }
            
        
        }
        

    }
}
