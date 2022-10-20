﻿using Business.Entities;
using Business.Logic;
using Data.Database;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;

namespace UI.Desktop
{
    public partial class InsumoDesktop : ApplicationForm
    {
        
        public Insumo InsumoActual { set; get; }
        private readonly InsumoLogic _insumoLogic;
        public InsumoDesktop(LavanderiaContext context)
        {
            InitializeComponent();
            _insumoLogic = new InsumoLogic(new InsumoAdapter(context));
        }

        public InsumoDesktop(ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            this.cmbUnidadMedida.DataSource= Enum.GetNames(typeof(Business.Entities.Insumo.Medidas));
        }

        
        public InsumoDesktop(int ID, ModoForm modo, LavanderiaContext context) : this(context)
        {
            Modos = modo;
            this.cmbUnidadMedida.DataSource = Enum.GetNames(typeof(Business.Entities.Insumo.Medidas));
            try
            {
                InsumoActual = _insumoLogic.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            this.txtIDInsumo.Text = this.InsumoActual.IdInsumo.ToString();
            this.txtDescInsumo.Text = this.InsumoActual.Descripcion;
            this.txtExistenciaInsumo.Text = this.InsumoActual.Stock.ToString();
            this.cmbUnidadMedida.SelectedIndex = this.cmbUnidadMedida.FindStringExact(Enum.GetName(InsumoActual.UnidadMedida));
            
            switch (this.Modos)
            {
                case ModoForm.Alta:
                    this.btnAceptarInsumo.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptarInsumo.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptarInsumo.Text = "Eliminar";
                    this.txtIDInsumo.Enabled = false;
                    this.txtDescInsumo.Enabled = false;
                    this.txtExistenciaInsumo.Enabled = false;
                    this.cmbUnidadMedida.Enabled = false;
                    break;
                case ModoForm.Consulta:
                    this.btnAceptarInsumo.Text = "Aceptar";
                    this.txtDescInsumo.Enabled = false;
                    this.txtExistenciaInsumo.Enabled = false;
                    this.cmbUnidadMedida.Enabled = false;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modos == ModoForm.Alta)
            {
                InsumoActual = new Insumo();
                InsumoActual.Descripcion = this.txtDescInsumo.Text;
                InsumoActual.Stock = Double.Parse(this.txtExistenciaInsumo.Text);
                InsumoActual.UnidadMedida = (Business.Entities.Insumo.Medidas)Enum.Parse(typeof(Business.Entities.Insumo.Medidas), cmbUnidadMedida.SelectedItem.ToString());
                
            }
            if (Modos == ModoForm.Modificacion)
            {
                InsumoActual.Descripcion = this.txtDescInsumo.Text;
                InsumoActual.Stock = Double.Parse(this.txtExistenciaInsumo.Text);
                InsumoActual.UnidadMedida = (Business.Entities.Insumo.Medidas)Enum.Parse(typeof(Business.Entities.Insumo.Medidas), cmbUnidadMedida.SelectedItem.ToString());
            }
            switch (Modos)
            {
                case ModoForm.Alta:
                    InsumoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    InsumoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override bool Validar()
        {
            ValidationResult result = new InsumoValidator().Validate(InsumoActual);
            if (!result.IsValid)
            {
                string notificacion = string.Join(Environment.NewLine, result.Errors);
                MessageBox.Show(notificacion,"Insumo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (Validar())
                {
                    _insumoLogic.Save(InsumoActual);
                    Close();
                }
            }
            catch (Exception e)
            {
              MessageBox.Show("Alguno de los datos ingresados no son válidos. Por favor, ingrese datos válidos para poder continuar.", "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public virtual void Eliminar()
        {
            try
            {
                _insumoLogic.Delete(InsumoActual.IdInsumo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarInsumo_Click(object sender, EventArgs e)
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
                        if (MessageBox.Show($"¿Está seguro que desea modificar el insumo {InsumoActual.Descripcion}?", "Insumo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            GuardarCambios();
                        }
                    };
                    break;
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el insumo - {InsumoActual.Descripcion}?", "Insumo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Eliminar();
                            Close();
                        }
                    };
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

        private void txtExistenciaInsumo_TextChanged(object sender, EventArgs e)
        {
            if(this.txtExistenciaInsumo.Text.Contains("-"))
            {
                MessageBox.Show("La cantidad de existencia ingresada no es válida. Por favor, vuelva a ingresar una cantidad válida para continuar.","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
