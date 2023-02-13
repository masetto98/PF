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
using Data.Database;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ServicioTipoPrendaDesktop : ApplicationForm
    {

        public Business.Entities.ServicioTipoPrenda ServicioTipoPrendaActual { set; get; }
        public Insumo InsumoActual { set; get;}
        public Precio PrecioActual { set; get;}
        public List<InsumoServicioTipoPrenda> _consumosActuales;
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        private readonly ServicioLogic _servicioLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        private readonly InsumoLogic _insumoLogic;
        private readonly TiposMaquinaLogic _tiposMaquinaLogic;
        
        public List<String> _unidadesMedida;

        public ServicioTipoPrendaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _servicioTipoPrendaLogic = new ServicioTipoPrendaLogic(new ServicioTipoPrendaAdapter(context));
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            _tiposMaquinaLogic = new TiposMaquinaLogic(new TiposMaquinaAdapter(context));
            _consumosActuales = new List<InsumoServicioTipoPrenda>();
            _unidadesMedida = new List<string>();

        }

        public ServicioTipoPrendaDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                this.cmbServicios.DataSource = _servicioLogic.GetAll();
                this.cmbTipoPrendas.DataSource = _tipoPrendaLogic.GetAll();
                this.cmbInsumos.DataSource = _insumoLogic.GetAll();
                this.cmbTiposMaquina.DataSource = _tiposMaquinaLogic.GetAll();
                this.cmbInsumos.SelectedItem = null;
                this.cmbTiposMaquina.SelectedItem = null;
                this.cmbServicios.SelectedItem = null;
                this.cmbTipoPrendas.SelectedItem = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ServicioTipoPrendaDesktop(int idServicio,int IdTipoPrenda, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            this.cmbServicios.DataSource = _servicioLogic.GetAll();
            this.cmbTipoPrendas.DataSource = _tipoPrendaLogic.GetAll();
            this.cmbInsumos.DataSource = _insumoLogic.GetAll();
            this.cmbTiposMaquina.DataSource = _tiposMaquinaLogic.GetAll();
            this.cmbInsumos.SelectedItem = null;
            this.cmbTiposMaquina.SelectedItem = null;
            try
            {
                ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetOne(idServicio,IdTipoPrenda);
                PrecioActual = ServicioTipoPrendaActual.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde <= DateTime.Now;
                    });
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            try
            {
                this.txtPrecio.Text = PrecioActual.Valor.ToString();
                if (ServicioTipoPrendaActual.InsumoServicioTipoPrenda is not null)
                {
                    foreach(InsumoServicioTipoPrenda istp in ServicioTipoPrendaActual.InsumoServicioTipoPrenda) 
                    {
                        _consumosActuales.Add(istp);
                    }
                    //_consumosActuales = ServicioTipoPrendaActual.InsumoServicioTipoPrenda;
                    ListarConsumos();
                }
                List<Servicio> servicios = _servicioLogic.GetAll();
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbTipoPrendas.DataSource = tipoPrendas;
                this.cmbServicios.SelectedIndex = cmbServicios.FindStringExact(ServicioTipoPrendaActual.Servicio.Descripcion);
                this.cmbTipoPrendas.SelectedIndex = cmbTipoPrendas.FindStringExact(ServicioTipoPrendaActual.TipoPrenda.Descripcion);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrendas.Enabled = false;
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrendas.Enabled = false;
                    this.txtPrecio.Enabled = false;
                    this.btnAgregarConsumo.Enabled = false;
                    this.btnEliminarConsumo.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrendas.Enabled = false;
                    this.txtPrecio.Enabled = false;
                    this.btnAgregarConsumo.Enabled = false;
                    this.btnEliminarConsumo.Enabled = false;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                Business.Entities.ServicioTipoPrenda stpBorrada = _servicioTipoPrendaLogic.GetOneSinBorrado((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrendas.SelectedValue);
                if (stpBorrada is null)
                {
                    ServicioTipoPrendaActual = new Business.Entities.ServicioTipoPrenda();
                    Precio precioActual = new Precio();
                    ServicioTipoPrendaActual.Servicio = _servicioLogic.GetOne((int)this.cmbServicios.SelectedValue);
                    ServicioTipoPrendaActual.TipoPrenda = _tipoPrendaLogic.GetOne((int)this.cmbTipoPrendas.SelectedValue);
                    precioActual.Valor = double.Parse(this.txtPrecio.Text);
                    precioActual.FechaDesde = DateTime.Now;
                    ServicioTipoPrendaActual.HistoricoPrecios = new List<Precio>();
                    ServicioTipoPrendaActual.HistoricoPrecios.Add(precioActual);
                    ServicioTipoPrendaActual.InsumoServicioTipoPrenda = _consumosActuales;
                }
                else 
                {
                    ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetOneSinBorrado((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrendas.SelectedValue);
                    ServicioTipoPrendaActual.Borrado = false;
                    Precio precioActual = new Precio();
                    precioActual.Valor = double.Parse(this.txtPrecio.Text);
                    precioActual.FechaDesde = DateTime.Now;
                    ServicioTipoPrendaActual.HistoricoPrecios = new List<Precio>();
                    foreach (Precio p in ServicioTipoPrendaActual.HistoricoPrecios) 
                    {
                        p.Borrado = false;
                        //ServicioTipoPrendaActual.HistoricoPrecios.Add(p); 
                    }
                    ServicioTipoPrendaActual.HistoricoPrecios.Add(precioActual);
                    ServicioTipoPrendaActual.InsumoServicioTipoPrenda = _consumosActuales;
                    ServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
                }
                
                
            }
            if (Modos == ModoForm.Modificacion)
            {
                this.cmbServicios.FindStringExact(ServicioTipoPrendaActual.Servicio.Descripcion);
                this.cmbServicios.FindStringExact(ServicioTipoPrendaActual.TipoPrenda.Descripcion);
                this.cmbServicios.Enabled = false;
                this.cmbTipoPrendas.Enabled = false;
                if (PrecioActual.Valor != double.Parse(this.txtPrecio.Text)) 
                {
                    Precio nuevoPrecio = new Precio();
                    nuevoPrecio.Valor = double.Parse(this.txtPrecio.Text);
                    nuevoPrecio.FechaDesde = DateTime.Now;
                    ServicioTipoPrendaActual.HistoricoPrecios.Add(nuevoPrecio);
                }
                ServicioTipoPrendaActual.InsumoServicioTipoPrenda = _consumosActuales;
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    if (ServicioTipoPrendaActual.State == BusinessEntity.States.Deleted)
                    {
                        ServicioTipoPrendaActual.State = BusinessEntity.States.New;
                    }
                    break;
                case ModoForm.Modificacion:
                    ServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        /*
        private void QuitarBorrado(int idServicio,int idTipoPrenda) 
        {
            ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetOneSinBorrado(idServicio, idTipoPrenda);
            if (ServicioTipoPrendaActual is not null) 
            {
                ServicioTipoPrendaActual.Borrado = false;
                Precio precioActual = new Precio();
                precioActual.FechaDesde = DateTime.Today;
                precioActual.Valor = Double.Parse(txtPrecio.Text);
                ServicioTipoPrendaActual.HistoricoPrecios.Add(precioActual);
                ServicioTipoPrendaActual.State= ServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
                ServicioTipoPrendaActual.InsumoServicioTipoPrenda = _consumosActuales;
            }
        }*/

        public override void GuardarCambios()
        {
            try
            {
                if (this.cmbServicios.SelectedValue is not null && this.cmbTipoPrendas.SelectedValue is not null)
                {
                    
                    Validaciones.ValidarNumeroEnteroDecimal(this.txtPrecio.Text);
                    //Business.Entities.ServicioTipoPrenda stpBorrada = _servicioTipoPrendaLogic.GetOneSinBorrado((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrendas.SelectedValue);
                    MapearADatos();/*
                    if (stpBorrada is not null)
                    { 
                        ServicioTipoPrendaActual.Borrado = false;
                        ServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
                        foreach (Precio p in stpBorrada.HistoricoPrecios) {ServicioTipoPrendaActual.HistoricoPrecios.Add(p);}
                    }*/
                    //Business.Entities.ServicioTipoPrenda stp = _servicioTipoPrendaLogic.GetOne((int)this.cmbServicios.SelectedValue,(int) this.cmbTipoPrendas.SelectedValue);
                    //if (stp is null && ServicioTipoPrendaActual.State== BusinessEntity.States.Modified)
                    //{
                        _servicioTipoPrendaLogic.Save(ServicioTipoPrendaActual);
                        //Close();
                        Dispose();
                    //}
                    //else 
                    //{
                    //    MessageBox.Show("El SERVICIO - TIPO PRENDA ya existe", "Servicio - Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un servicio para un tipo de prenda en su respectivo listado para poder continuar.", "Servicio - Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void Eliminar()
        {
            try
            {
                _servicioTipoPrendaLogic.Delete(ServicioTipoPrendaActual.IdServicio,ServicioTipoPrendaActual.IdTipoPrenda);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Close();
            Dispose();
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
                        if (MessageBox.Show($"¿Está seguro que desea modificar el servicio tipo prenda {ServicioTipoPrendaActual.Servicio.Descripcion}-{ServicioTipoPrendaActual.TipoPrenda.Descripcion}?", "Servicio Tipo Prenda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el servicio tipo prenda {ServicioTipoPrendaActual.Servicio.Descripcion}-{ServicioTipoPrendaActual.TipoPrenda.Descripcion}?", "Servicio Tipo Prenda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Eliminar();
                            //Close();
                            Dispose();
                        }
                    };
                    break;
                case ModoForm.Consulta:
                    //Close();
                    Dispose();
                    break;

            }
        }

        public void ListarConsumos() 
        {
            if (_consumosActuales is not null)           
            {
                listConsumos.Items.Clear();
                foreach (InsumoServicioTipoPrenda o in _consumosActuales)
                {
                    ListViewItem item = new ListViewItem((listConsumos.Items.Count + 1).ToString());
                    item.SubItems.Add(o.Insumo.Descripcion.ToString());
                    item.SubItems.Add(o.Cantidad.ToString());
                    item.SubItems.Add(o.Insumo.UnidadMedida.ToString());
                    item.SubItems.Add(o.TipoMaquina.Descripcion);
                    listConsumos.Items.Add(item);
                }
            }
        }
        #region ------ CONSUMOS -------
        private void btnAgregarConsumo_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.cmbServicios.SelectedValue is not null && this.cmbTipoPrendas.SelectedValue is not null)
                {
                    if(cmbTiposMaquina.SelectedValue is not null && cmbUnidadMedida is not null)
                    {
                        InsumoServicioTipoPrenda consumoActual = new InsumoServicioTipoPrenda();
                        consumoActual.ServicioTipoPrenda = _servicioTipoPrendaLogic.GetOne((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrendas.SelectedValue);
                        consumoActual.Insumo = InsumoActual;
                        Validaciones.ValidarNumeroEnteroDecimal(this.txtCantidad.Text);
                        consumoActual.Cantidad = ConvertirUnidadesConsumo(Int32.Parse(this.txtCantidad.Text), _unidadesMedida[this.cmbUnidadMedida.SelectedIndex]);
                        consumoActual.FechaDesde = DateTime.Now;
                        consumoActual.TipoMaquina = _tiposMaquinaLogic.GetOne((int)this.cmbTiposMaquina.SelectedValue);
                        if (ValidarExistencia())
                        {
                            _consumosActuales.Add(consumoActual);
                        }
                        ListarConsumos();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una unidad de medida y un tipo de máquina en su respectivo listado para poder agregar un consumo.", "Servicio - Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un servicio para un tipo de prenda en su respectivo listado para poder agregar un consumo.", "Servicio - Tipo Prenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception f) 
            {
                MessageBox.Show(f.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarExistencia() 
        {   InsumoServicioTipoPrenda insumo = _consumosActuales.Find(delegate (InsumoServicioTipoPrenda istp)
            {
                return istp.Insumo.IdInsumo == InsumoActual.IdInsumo && istp.IdTipoMaquina == (int)this.cmbTiposMaquina.SelectedValue;
            });
            if (insumo is not null)
            {
                MessageBox.Show("El insumo seleccionado ya se encuentra incluido, si desea modificarlo entoces debe eliminarlo y agregarlo con los nuevos valores","Consumo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
            
        }
        #region ------- UNIDADES DE MEDIDA -------
        private List<String> SetearMedidas(int unidad, List<string> unidadesMedida)
        {

            unidadesMedida.Clear();
            if (unidad == 1)
            {
                unidadesMedida.Add("Litros(1L/1000Cm3/1000ml");
                unidadesMedida.Add("Mililitros / Cm3");
                return unidadesMedida;
            }
            if (unidad == 2)
            {
                unidadesMedida.Add("Kilogramos(1Kg / 1000gr)");
                unidadesMedida.Add("Gramos(gr)");
                return unidadesMedida;
            }
            if (unidad == 3)
            {
                unidadesMedida.Add("Unidades");
                return unidadesMedida;
            }
            return null;
        }

        private double ConvertirUnidadesConsumo(double _cantidad, string unidadSelect)
        {

            if (unidadSelect == "Mililitros / Cm3" || unidadSelect == "Gramos(gr)")
            {
                return _cantidad / 1000;
            }
            else
            {
                return _cantidad;
            }
        }
        #endregion

        private void btnEliminarConsumo_Click(object sender, EventArgs e)
        {
            if (listConsumos.SelectedItems.Count > 0)
            {
                var _itemDelete = _consumosActuales.Find(
                    delegate (InsumoServicioTipoPrenda item)
                    {
                        return item.Insumo.Descripcion == listConsumos.SelectedItems[0].SubItems[1].Text;
                    }
                );
                _consumosActuales.Remove(_itemDelete);
                listConsumos.Items.Remove(listConsumos.SelectedItems[0]);
                ListarConsumos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la lista para poder eliminar un consumo.", "Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void cmbInsumos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InsumoActual = _insumoLogic.GetOne(Int32.Parse(this.cmbInsumos.SelectedValue.ToString()));
            List<string> unidadesMedida = new List<string>();
            _unidadesMedida = SetearMedidas((int)InsumoActual.UnidadMedida, unidadesMedida);
            this.cmbUnidadMedida.DataSource = _unidadesMedida;

        }
        #endregion

        private void listConsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listConsumos.Columns[e.ColumnIndex].Width;
        }
    }
}
