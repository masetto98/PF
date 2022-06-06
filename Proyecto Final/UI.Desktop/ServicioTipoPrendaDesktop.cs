﻿using MaterialSkin;
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
        public List<InsumoServicioTipoPrenda> _consumos;
        private readonly ServicioTipoPrendaLogic _servicioTipoPrendaLogic;
        private readonly ServicioLogic _servicioLogic;
        private readonly TipoPrendaLogic _tipoPrendaLogic;
        private readonly InsumoLogic _insumoLogic;
        private readonly InsumoServicioTipoPrendaLogic _insumoServicioTipoPrendaLogic;
        public List<String> _unidadesMedida;

        public ServicioTipoPrendaDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _servicioTipoPrendaLogic = new ServicioTipoPrendaLogic(new ServicioTipoPrendaAdapter(context));
            _servicioLogic = new ServicioLogic(new ServicioAdapter(context));
            _tipoPrendaLogic = new TipoPrendaLogic(new TipoPrendaAdapter(context));
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
            _insumoServicioTipoPrendaLogic = new InsumoServicioTipoPrendaLogic(new InsumoServicioTipoPrendaAdapter(context));
            _consumos = new List<InsumoServicioTipoPrenda>();
            _unidadesMedida = new List<string>();

        }

        public ServicioTipoPrendaDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                List<Servicio> servicios = _servicioLogic.GetAll();
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                List<Insumo> insumos = _insumoLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbServicios.SelectedIndex = 0;
                this.cmbTipoPrendas.DataSource = tipoPrendas;
                this.cmbTipoPrendas.SelectedIndex = 0;
                this.cmbInsumos.DataSource = insumos;
                this.cmbInsumos.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Servicio-TipoPrenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ServicioTipoPrendaDesktop(int idServicio,int IdTipoPrenda, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            try
            {
                ServicioTipoPrendaActual = _servicioTipoPrendaLogic.GetOne(idServicio,IdTipoPrenda);
                PrecioActual = ServicioTipoPrendaActual.HistoricoPrecios.FindLast(
                    delegate (Precio p)
                    {
                        return p.FechaDesde <= DateTime.Today;
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
            this.nudHoras.Value = ServicioTipoPrendaActual.TiempoRequerido.Hours;
            this.nudMinutos.Value = ServicioTipoPrendaActual.TiempoRequerido.Minutes;
            //this.nudDias.Value = ServicioTipoPrendaActual.TiempoDemoraMax.Days;
            //this.nudHoras2.Value = ServicioTipoPrendaActual.TiempoDemoraMax.Hours;
            //this.nudMinutos2.Value = ServicioTipoPrendaActual.TiempoDemoraMax.Minutes;
            
            this.txtPrecio.Text = PrecioActual.Valor.ToString();
            try
            { 
                List<Servicio> servicios = _servicioLogic.GetAll();
                List<TipoPrenda> tipoPrendas = _tipoPrendaLogic.GetAll();
                this.cmbServicios.DataSource = servicios;
                this.cmbTipoPrendas.DataSource = tipoPrendas;
                this.cmbServicios.SelectedIndex = cmbServicios.FindStringExact(ServicioTipoPrendaActual.Servicio.Descripcion);
                this.cmbTipoPrendas.SelectedIndex = cmbTipoPrendas.FindStringExact(ServicioTipoPrendaActual.TipoPrenda.Descripcion);
                _consumos = ServicioTipoPrendaActual.InsumoServicioTipoPrenda;
                ListarConsumos();
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
                    this.nudHoras.Enabled = false;
                    this.nudMinutos.Enabled = false;
                    this.txtPrecio.Enabled = false;

                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    this.cmbServicios.Enabled = false;
                    this.cmbTipoPrendas.Enabled = false;
                    this.nudHoras.Enabled = false;
                    this.nudMinutos.Enabled = false;
                    ;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                ServicioTipoPrendaActual = new Business.Entities.ServicioTipoPrenda();
                Precio precioActual = new Precio();
                ServicioTipoPrendaActual.Servicio = _servicioLogic.GetOne((int)this.cmbServicios.SelectedValue);
                ServicioTipoPrendaActual.TipoPrenda = _tipoPrendaLogic.GetOne((int)this.cmbTipoPrendas.SelectedValue);
                ServicioTipoPrendaActual.TiempoRequerido = new TimeSpan(((int)this.nudHoras.Value),((int)this.nudMinutos.Value),00);
                ServicioTipoPrendaActual.TiempoDemoraMax = new TimeSpan((int)this.nudDias.Value,(int)this.nudHoras2.Value,(int)this.nudMinutos2.Value,00).ToString();
                precioActual.Valor = double.Parse(this.txtPrecio.Text);
                precioActual.FechaDesde = DateTime.Today;
                ServicioTipoPrendaActual.HistoricoPrecios = new List<Precio>();
                ServicioTipoPrendaActual.HistoricoPrecios.Add(precioActual);

            }
            if (Modos == ModoForm.Modificacion)
            {
                this.cmbServicios.FindStringExact(ServicioTipoPrendaActual.Servicio.Descripcion);
                this.cmbServicios.FindStringExact(ServicioTipoPrendaActual.TipoPrenda.Descripcion);
                this.cmbServicios.Enabled = false;
                this.cmbTipoPrendas.Enabled = false;
                ServicioTipoPrendaActual.TiempoRequerido = new TimeSpan(((int)this.nudHoras.Value), ((int)this.nudMinutos.Value), 00);
                ServicioTipoPrendaActual.TiempoDemoraMax = new TimeSpan((int)this.nudDias.Value, (int)this.nudHoras2.Value, (int)this.nudMinutos2.Value, 00).ToString();
                if (PrecioActual.Valor != double.Parse(this.txtPrecio.Text)) 
                {
                    Precio nuevoPrecio = new Precio();
                    nuevoPrecio.Valor = double.Parse(this.txtPrecio.Text);
                    nuevoPrecio.FechaDesde = DateTime.Today;
                    ServicioTipoPrendaActual.HistoricoPrecios.Add(nuevoPrecio);
                }
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    ServicioTipoPrendaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ServicioTipoPrendaActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            try
            {
                if (true)
                {
                    MapearADatos();
                    _servicioTipoPrendaLogic.Save(ServicioTipoPrendaActual);
                    Close();
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
            Close();
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

        public void ListarConsumos() 
        {
            if (_consumos is not null)
            {
                listConsumos.Items.Clear();
                foreach (InsumoServicioTipoPrenda o in _consumos)
                {
                    ListViewItem item = new ListViewItem((listConsumos.Items.Count + 1).ToString());
                    item.SubItems.Add(o.Insumo.Descripcion.ToString());
                    item.SubItems.Add(o.Cantidad.ToString());
                    item.SubItems.Add(o.Insumo.UnidadMedida.ToString());
                    listConsumos.Items.Add(item);
                }
            }
        }
        #region ------ CONSUMOS -------
        private void btnAgregarConsumo_Click(object sender, EventArgs e)
        {
            InsumoServicioTipoPrenda insumoServicioTipoPrenda = _insumoServicioTipoPrendaLogic.GetOne((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrendas.SelectedValue,(int) this.cmbInsumos.SelectedValue);
            if (insumoServicioTipoPrenda is null)
            {
                insumoServicioTipoPrenda = new InsumoServicioTipoPrenda();
                insumoServicioTipoPrenda.ServicioTipoPrenda = _servicioTipoPrendaLogic.GetOne((int)this.cmbServicios.SelectedValue, (int)this.cmbTipoPrendas.SelectedValue);
                
                insumoServicioTipoPrenda.Insumo = InsumoActual ;
                insumoServicioTipoPrenda.Cantidad = ConvertirUnidadesConsumo(Int32.Parse(this.txtCantidad.Text));
                _consumos.Add(insumoServicioTipoPrenda);
            }
            ListarConsumos();
        }
        #region ------- UNIDADES DE MEDIDA -------
        private void SetearMedidas(int unidad) 
        {
            
            _unidadesMedida.Clear();
            if (unidad == 1)
            {
                _unidadesMedida.Add("Litros(1L/1000Cm3/1000ml");
                _unidadesMedida.Add("Mililitros / Cm3");
            }
            if (unidad == 2)
            {
                _unidadesMedida.Add("Kilogramos(1Kg / 1000gr)");
                _unidadesMedida.Add("Gramos(gr)");
            }
            if (unidad == 3)
            {
                _unidadesMedida.Add("Unidades");
            }
        }

        private double ConvertirUnidadesConsumo(int _cantidad) 
        {
            string _medida = this.cmbUnidadMedida.SelectedItem.ToString();
            if (_medida == "Mililitros / Cm3" || _medida == "Gramos(gr)"){return (double)_cantidad/1000;}
            else{return _cantidad;}
        }
        #endregion

        private void btnEliminarConsumo_Click(object sender, EventArgs e)
        {
            if (listConsumos.SelectedItems.Count > 0)
            {
                var _itemDelete = _consumos.FindLast(
                    delegate (InsumoServicioTipoPrenda item)
                    {
                        return
                            item.ServicioTipoPrenda.Servicio.IdServicio == (int)this.cmbServicios.SelectedValue
                            &&
                            item.ServicioTipoPrenda.TipoPrenda.IdTipoPrenda == (int)this.cmbTipoPrendas.SelectedValue
                            &&
                            item.Insumo.IdInsumo == (int)this.cmbInsumos.SelectedValue;
                    }
                );
                _consumos.Remove(_itemDelete);
                listConsumos.Items.Remove(listConsumos.SelectedItems[0]);
                ListarConsumos();
            }
        
        }

        private void cmbInsumos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InsumoActual = _insumoLogic.GetOne(Int32.Parse(this.cmbInsumos.SelectedValue.ToString()));
            SetearMedidas((int)InsumoActual.UnidadMedida);
            this.cmbUnidadMedida.DataSource = _unidadesMedida;

        }
        #endregion
    }
}
