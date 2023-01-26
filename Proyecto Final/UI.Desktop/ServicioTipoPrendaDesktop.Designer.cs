﻿
namespace UI.Desktop
{
    partial class ServicioTipoPrendaDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbServicios = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbTipoPrendas = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cmbTiposMaquina = new MaterialSkin.Controls.MaterialComboBox();
            this.lblConsumo = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarConsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarConsumo = new MaterialSkin.Controls.MaterialButton();
            this.cmbUnidadMedida = new MaterialSkin.Controls.MaterialComboBox();
            this.listConsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnCantidad = new System.Windows.Forms.ColumnHeader();
            this.columnUnidad = new System.Windows.Forms.ColumnHeader();
            this.columnTipoMaquina = new System.Windows.Forms.ColumnHeader();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbInsumos = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbServicios
            // 
            this.cmbServicios.AutoResize = false;
            this.cmbServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbServicios.Depth = 0;
            this.cmbServicios.DisplayMember = "Descripcion";
            this.cmbServicios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbServicios.DropDownHeight = 174;
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.DropDownWidth = 121;
            this.cmbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Hint = "Servicio";
            this.cmbServicios.IntegralHeight = false;
            this.cmbServicios.ItemHeight = 43;
            this.cmbServicios.Location = new System.Drawing.Point(20, 92);
            this.cmbServicios.MaxDropDownItems = 4;
            this.cmbServicios.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(346, 49);
            this.cmbServicios.StartIndex = 0;
            this.cmbServicios.TabIndex = 2;
            this.cmbServicios.ValueMember = "IdServicio";
            // 
            // cmbTipoPrendas
            // 
            this.cmbTipoPrendas.AutoResize = false;
            this.cmbTipoPrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbTipoPrendas.Depth = 0;
            this.cmbTipoPrendas.DisplayMember = "Descripcion";
            this.cmbTipoPrendas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoPrendas.DropDownHeight = 174;
            this.cmbTipoPrendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrendas.DropDownWidth = 121;
            this.cmbTipoPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoPrendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipoPrendas.FormattingEnabled = true;
            this.cmbTipoPrendas.Hint = "Tipo de prenda";
            this.cmbTipoPrendas.IntegralHeight = false;
            this.cmbTipoPrendas.ItemHeight = 43;
            this.cmbTipoPrendas.Location = new System.Drawing.Point(378, 92);
            this.cmbTipoPrendas.MaxDropDownItems = 4;
            this.cmbTipoPrendas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoPrendas.Name = "cmbTipoPrendas";
            this.cmbTipoPrendas.Size = new System.Drawing.Size(340, 49);
            this.cmbTipoPrendas.StartIndex = 0;
            this.cmbTipoPrendas.TabIndex = 3;
            this.cmbTipoPrendas.ValueMember = "IdTipoPrenda";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(536, 519);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(630, 519);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPrecio.Hint = "Precio";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(20, 149);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(346, 50);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.Text = "";
            this.txtPrecio.TrailingIcon = null;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.cmbTiposMaquina);
            this.materialCard1.Controls.Add(this.lblConsumo);
            this.materialCard1.Controls.Add(this.btnEliminarConsumo);
            this.materialCard1.Controls.Add(this.btnAgregarConsumo);
            this.materialCard1.Controls.Add(this.cmbUnidadMedida);
            this.materialCard1.Controls.Add(this.listConsumos);
            this.materialCard1.Controls.Add(this.txtCantidad);
            this.materialCard1.Controls.Add(this.cmbInsumos);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(11, 206);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(715, 309);
            this.materialCard1.TabIndex = 16;
            // 
            // cmbTiposMaquina
            // 
            this.cmbTiposMaquina.AutoResize = false;
            this.cmbTiposMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbTiposMaquina.Depth = 0;
            this.cmbTiposMaquina.DisplayMember = "Descripcion";
            this.cmbTiposMaquina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTiposMaquina.DropDownHeight = 174;
            this.cmbTiposMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposMaquina.DropDownWidth = 121;
            this.cmbTiposMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTiposMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTiposMaquina.FormattingEnabled = true;
            this.cmbTiposMaquina.Hint = "Tipo Máquina";
            this.cmbTiposMaquina.IntegralHeight = false;
            this.cmbTiposMaquina.ItemHeight = 43;
            this.cmbTiposMaquina.Location = new System.Drawing.Point(532, 33);
            this.cmbTiposMaquina.MaxDropDownItems = 4;
            this.cmbTiposMaquina.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTiposMaquina.Name = "cmbTiposMaquina";
            this.cmbTiposMaquina.Size = new System.Drawing.Size(174, 49);
            this.cmbTiposMaquina.StartIndex = 0;
            this.cmbTiposMaquina.TabIndex = 7;
            this.cmbTiposMaquina.ValueMember = "IdTipoMaquina";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblConsumo.Depth = 0;
            this.lblConsumo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConsumo.Location = new System.Drawing.Point(13, 8);
            this.lblConsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(138, 19);
            this.lblConsumo.TabIndex = 6;
            this.lblConsumo.Text = "Agregar consumos:";
            // 
            // btnEliminarConsumo
            // 
            this.btnEliminarConsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarConsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarConsumo.Depth = 0;
            this.btnEliminarConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarConsumo.HighEmphasis = true;
            this.btnEliminarConsumo.Icon = null;
            this.btnEliminarConsumo.Location = new System.Drawing.Point(619, 137);
            this.btnEliminarConsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarConsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarConsumo.Name = "btnEliminarConsumo";
            this.btnEliminarConsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarConsumo.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarConsumo.TabIndex = 5;
            this.btnEliminarConsumo.Text = "Eliminar";
            this.btnEliminarConsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarConsumo.UseAccentColor = false;
            this.btnEliminarConsumo.UseVisualStyleBackColor = false;
            this.btnEliminarConsumo.Click += new System.EventHandler(this.btnEliminarConsumo_Click);
            // 
            // btnAgregarConsumo
            // 
            this.btnAgregarConsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarConsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarConsumo.Depth = 0;
            this.btnAgregarConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarConsumo.HighEmphasis = true;
            this.btnAgregarConsumo.Icon = null;
            this.btnAgregarConsumo.Location = new System.Drawing.Point(619, 89);
            this.btnAgregarConsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarConsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarConsumo.Name = "btnAgregarConsumo";
            this.btnAgregarConsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarConsumo.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarConsumo.TabIndex = 4;
            this.btnAgregarConsumo.Text = "Agregar";
            this.btnAgregarConsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarConsumo.UseAccentColor = false;
            this.btnAgregarConsumo.UseVisualStyleBackColor = false;
            this.btnAgregarConsumo.Click += new System.EventHandler(this.btnAgregarConsumo_Click);
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.AutoResize = false;
            this.cmbUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbUnidadMedida.Depth = 0;
            this.cmbUnidadMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUnidadMedida.DropDownHeight = 174;
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.DropDownWidth = 121;
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Hint = "Unidad de medida";
            this.cmbUnidadMedida.IntegralHeight = false;
            this.cmbUnidadMedida.ItemHeight = 43;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(318, 32);
            this.cmbUnidadMedida.MaxDropDownItems = 4;
            this.cmbUnidadMedida.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(208, 49);
            this.cmbUnidadMedida.StartIndex = 0;
            this.cmbUnidadMedida.TabIndex = 3;
            // 
            // listConsumos
            // 
            this.listConsumos.AutoSizeTable = false;
            this.listConsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listConsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listConsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnInsumo,
            this.columnCantidad,
            this.columnUnidad,
            this.columnTipoMaquina});
            this.listConsumos.Depth = 0;
            this.listConsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listConsumos.FullRowSelect = true;
            this.listConsumos.HideSelection = false;
            this.listConsumos.Location = new System.Drawing.Point(9, 88);
            this.listConsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listConsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listConsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listConsumos.Name = "listConsumos";
            this.listConsumos.OwnerDraw = true;
            this.listConsumos.Size = new System.Drawing.Size(592, 215);
            this.listConsumos.TabIndex = 2;
            this.listConsumos.UseCompatibleStateImageBehavior = false;
            this.listConsumos.View = System.Windows.Forms.View.Details;
            this.listConsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listConsumos_ColumnWidthChanging);
            // 
            // columnNro
            // 
            this.columnNro.Text = "Nro";
            this.columnNro.Width = 70;
            // 
            // columnInsumo
            // 
            this.columnInsumo.Text = "Insumo";
            this.columnInsumo.Width = 142;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.Width = 100;
            // 
            // columnUnidad
            // 
            this.columnUnidad.Text = "Unidad";
            this.columnUnidad.Width = 130;
            // 
            // columnTipoMaquina
            // 
            this.columnTipoMaquina.Text = "Tipo Maquina";
            this.columnTipoMaquina.Width = 150;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(219, 32);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(93, 50);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            // 
            // cmbInsumos
            // 
            this.cmbInsumos.AutoResize = false;
            this.cmbInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbInsumos.Depth = 0;
            this.cmbInsumos.DisplayMember = "Descripcion";
            this.cmbInsumos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbInsumos.DropDownHeight = 174;
            this.cmbInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsumos.DropDownWidth = 121;
            this.cmbInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbInsumos.FormattingEnabled = true;
            this.cmbInsumos.Hint = "Insumos";
            this.cmbInsumos.IntegralHeight = false;
            this.cmbInsumos.ItemHeight = 43;
            this.cmbInsumos.Location = new System.Drawing.Point(9, 33);
            this.cmbInsumos.MaxDropDownItems = 4;
            this.cmbInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbInsumos.Name = "cmbInsumos";
            this.cmbInsumos.Size = new System.Drawing.Size(204, 49);
            this.cmbInsumos.StartIndex = 0;
            this.cmbInsumos.TabIndex = 0;
            this.cmbInsumos.ValueMember = "IdInsumo";
            this.cmbInsumos.SelectionChangeCommitted += new System.EventHandler(this.cmbInsumos_SelectionChangeCommitted);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Prioridad";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(378, 150);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(281, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 17;
            this.materialComboBox1.Visible = false;
            // 
            // ServicioTipoPrendaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 564);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTipoPrendas);
            this.Controls.Add(this.cmbServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ServicioTipoPrendaDesktop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio Tipo Prenda";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cmbServicios;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoPrendas;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListView listConsumos;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialComboBox cmbInsumos;
        private MaterialSkin.Controls.MaterialButton btnEliminarConsumo;
        private MaterialSkin.Controls.MaterialButton btnAgregarConsumo;
        private MaterialSkin.Controls.MaterialComboBox cmbUnidadMedida;
        private System.Windows.Forms.ColumnHeader columnNro;
        private System.Windows.Forms.ColumnHeader columnInsumo;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private MaterialSkin.Controls.MaterialLabel lblConsumo;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.ColumnHeader columnUnidad;
        private MaterialSkin.Controls.MaterialComboBox cmbTiposMaquina;
        private System.Windows.Forms.ColumnHeader columnTipoMaquina;
    }
}