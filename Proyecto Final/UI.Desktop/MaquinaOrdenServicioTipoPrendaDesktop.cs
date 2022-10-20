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
            ListarEstadoMaquinas();
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
                txtNroOrden.Enabled = false;
                txtOrdenItem.Enabled = false;
                txtServicio.Enabled = false;
                txtTipoPrenda.Enabled = false;
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
                    if (OrdenServicioTipoPrendaActual.Orden.Estado == Orden.Estados.Pendiente)
                    {
                        OrdenServicioTipoPrendaActual.Orden.Estado = Orden.Estados.Procesando;
                    }
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

        private void ListarEstadoMaquinas()
        {
            List<Maquina> maquinas = _maquinaLogic.GetAll();
            listEstadoMaquinas.Items.Clear();
            foreach (Maquina m in maquinas)
            {
                List<MaquinaOrdenServicioTipoPrenda> ordenesAtendidas = m.itemsAtendidos;
                if (m.itemsAtendidos is null) { ordenesAtendidas = new List<MaquinaOrdenServicioTipoPrenda>(); }
                MaquinaOrdenServicioTipoPrenda? itemEnAtencion = ordenesAtendidas.Find(delegate (MaquinaOrdenServicioTipoPrenda item)
                {
                    return item.TiempoFinServicio == DateTime.MinValue;
                });
                if (itemEnAtencion is null)
                {
                    ListViewItem estadoMaquina = new ListViewItem(m.Descripcion);
                    estadoMaquina.SubItems.Add("Disponible");
                    listEstadoMaquinas.Items.Add(estadoMaquina);

                }
                else
                {
                    ListViewItem estadoMaquina = new ListViewItem(m.Descripcion);
                    estadoMaquina.SubItems.Add("En servicio");
                    listEstadoMaquinas.Items.Add(estadoMaquina);
                }
            }
        }


        public override void GuardarCambios()
        {
            try
            {
                if (ValidarEstadoMaquina())
                {
                    MapearADatos();
                    ModificarStock();
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
                        if (ValidarMismaMaquina() == false)
                        {
                            //ModificarStock();
                            GuardarCambios();
                        }
                        else 
                        {
                            if (MessageBox.Show("Este trabajo ya ha pasado por ésta maquina ¿Quieres realizarlo nuevamente?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                            {
                                //ModificarStock();
                                GuardarCambios();
                            }

                        }
                    };
                    break;
                case ModoForm.Modificacion:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea modificar?", "Iniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (OrdenServicioTipoPrendaActual.MaquinaOrdenServicioTipoPrenda.Count > 0)
                            {
                                GuardarCambios();
                            }
                            else
                            {
                                ModificarStock();
                            }
                        }
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
        private bool ComprobarExistencia()
        {
            List<InsumoServicioTipoPrenda> insumosItem = OrdenServicioTipoPrendaActual.ServicioTipoPrenda.InsumoServicioTipoPrenda;
            bool ok = true;
            foreach (InsumoServicioTipoPrenda ins in insumosItem)
            {
                double stockAnterior = ins.Insumo.Stock;
                double consumoActual = ins.Cantidad;
                if (stockAnterior < consumoActual)
                {
                    ok = false;
                }
            }
            return ok;
        }
        /*
        private void ModificarStock()
        {
            List<InsumoServicioTipoPrenda> insumosItem = OrdenServicioTipoPrendaActual.ServicioTipoPrenda.InsumoServicioTipoPrenda;
            if (ComprobarExistencia())
            {
                foreach (InsumoServicioTipoPrenda ins in insumosItem)
                {
                    double stockAnterior = ins.Insumo.Stock;
                    double consumoActual = ins.Cantidad;
                    ins.Insumo.Stock = stockAnterior - consumoActual;
                    ins.Insumo.State = BusinessEntity.States.Modified;
                    _insumoLogic.Save(ins.Insumo);
                }
                GuardarCambios();
            }
            else if (MessageBox.Show($"¡Atención! El consumo actual de uno o varios insumos supera la existencia disponible ¿Desea continuar igualmente?", "Consumo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (InsumoServicioTipoPrenda ins in insumosItem)
                {
                    double stockAnterior = ins.Insumo.Stock;
                    double consumoActual = ins.Cantidad;
                    ins.Insumo.Stock = stockAnterior - consumoActual;
                    ins.Insumo.State = BusinessEntity.States.Modified;
                    _insumoLogic.Save(ins.Insumo);
                }
                GuardarCambios();
            }
            else
            {
                this.Dispose();
            }
        }*/

        private void ModificarStock()
        {
            List<InsumoServicioTipoPrenda> consumosActuales = OrdenServicioTipoPrendaActual.ServicioTipoPrenda.InsumoServicioTipoPrenda
                .FindAll(delegate (InsumoServicioTipoPrenda istp) { return istp.IdTipoMaquina == TrabajoActual.Maquina.IdTipoMaquina; });
            TrabajoActual.Consumos = new List<Consumo>();
            if (ComprobarExistencia())
            {
                
                foreach (InsumoServicioTipoPrenda istp in consumosActuales)
                {
                    istp.Insumo.Stock -= istp.Cantidad;
                    istp.Insumo.State = BusinessEntity.States.Modified;
                    Consumo consumo = new Consumo();
                    consumo.Insumo = istp.Insumo;
                    consumo.Cantidad = istp.Cantidad;
                    consumo.UnidadMedida = (int) istp.Insumo.UnidadMedida;
                    TrabajoActual.Consumos.Add(consumo);
                    _insumoLogic.Save(istp.Insumo);
                }
                
            }
            else if (MessageBox.Show($"¡Atención! El consumo actual de uno o varios insumos supera la existencia disponible ¿Desea continuar igualmente?", "Consumo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (InsumoServicioTipoPrenda istp in consumosActuales)
                {
                    istp.Insumo.Stock -= istp.Cantidad;
                    istp.Insumo.State = BusinessEntity.States.Modified;
                    Consumo consumo = new Consumo();
                    consumo.Insumo = istp.Insumo;
                    consumo.Cantidad = istp.Cantidad;
                    consumo.UnidadMedida = (int)istp.Insumo.UnidadMedida;
                    TrabajoActual.Consumos.Add(consumo);
                    _insumoLogic.Save(istp.Insumo);
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private bool ValidarMismaMaquina() 
        {
            Maquina  maquinaSelected= _maquinaLogic.GetOne((int)this.cmbMaquinas.SelectedValue);
            MaquinaOrdenServicioTipoPrenda maquinasItem = OrdenServicioTipoPrendaActual.MaquinaOrdenServicioTipoPrenda.Find(delegate (MaquinaOrdenServicioTipoPrenda m)
            {
                return m.Maquina.IdMaquina == maquinaSelected.IdMaquina;
            });
            if (maquinasItem is null) { return false; }
            else { return true; }

        }

        private void listEstadoMaquinas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listEstadoMaquinas.Columns[e.ColumnIndex].Width;
        }
    }
}
