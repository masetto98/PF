﻿
namespace UI.Desktop
{
    partial class OrdenDesktop
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
            this.components = new System.ComponentModel.Container();
            this.lblFechaEntrada = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.listItemsServicio = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnServicio = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPrenda = new System.Windows.Forms.ColumnHeader();
            this.columnPrecio = new System.Windows.Forms.ColumnHeader();
            this.columnEstado = new System.Windows.Forms.ColumnHeader();
            this.cmbServicios = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAgregarItemOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarItemOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.txtCuit = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbTipoPrenda = new MaterialSkin.Controls.MaterialComboBox();
            this.lblItemsOrden = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaSalida = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreApellidoRazonSocial = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtPrecioTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.lblAPagar = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPrioridad = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.rbtnValor = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnPorcentaje = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.cbFormaPago = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSeniaOrden = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtObservaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.cmbEntregaDomicilio = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.nudHoraEntrega = new System.Windows.Forms.NumericUpDown();
            this.ayudaOrden = new System.Windows.Forms.ToolTip(this.components);
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.lblDescueto = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraEntrega)).BeginInit();
            this.materialCard5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblFechaEntrada.Depth = 0;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaEntrada.Location = new System.Drawing.Point(513, 92);
            this.lblFechaEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(125, 19);
            this.lblFechaEntrada.TabIndex = 1;
            this.lblFechaEntrada.Text = "Fecha de ingreso:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.AnimateReadOnly = false;
            this.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCliente.Depth = 0;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdCliente.Hint = "ID";
            this.txtIdCliente.LeadingIcon = null;
            this.txtIdCliente.Location = new System.Drawing.Point(9, 70);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIdCliente.MaxLength = 50;
            this.txtIdCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdCliente.Multiline = false;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(65, 50);
            this.txtIdCliente.TabIndex = 4;
            this.txtIdCliente.Text = "";
            this.txtIdCliente.TrailingIcon = null;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(651, 88);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(279, 23);
            this.dtpFechaIngreso.TabIndex = 12;
            this.dtpFechaIngreso.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpFechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaSalida.Enabled = false;
            this.dtpFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSalida.Location = new System.Drawing.Point(651, 144);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(279, 23);
            this.dtpFechaSalida.TabIndex = 12;
            this.dtpFechaSalida.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            this.dtpFechaSalida.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoResize = false;
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbEstado.Depth = 0;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownHeight = 174;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownWidth = 121;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Hint = "Estado";
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Location = new System.Drawing.Point(513, 225);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(235, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 13;
            // 
            // listItemsServicio
            // 
            this.listItemsServicio.AutoSizeTable = false;
            this.listItemsServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listItemsServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listItemsServicio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnServicio,
            this.columnTipoPrenda,
            this.columnPrecio,
            this.columnEstado});
            this.listItemsServicio.Depth = 0;
            this.listItemsServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listItemsServicio.FullRowSelect = true;
            this.listItemsServicio.HideSelection = false;
            this.listItemsServicio.Location = new System.Drawing.Point(9, 80);
            this.listItemsServicio.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listItemsServicio.MinimumSize = new System.Drawing.Size(200, 99);
            this.listItemsServicio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listItemsServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.listItemsServicio.MultiSelect = false;
            this.listItemsServicio.Name = "listItemsServicio";
            this.listItemsServicio.OwnerDraw = true;
            this.listItemsServicio.Size = new System.Drawing.Size(607, 135);
            this.listItemsServicio.TabIndex = 14;
            this.listItemsServicio.UseCompatibleStateImageBehavior = false;
            this.listItemsServicio.View = System.Windows.Forms.View.Details;
            this.listItemsServicio.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listItemsServicio_ColumnWidthChanging);
            // 
            // columnNro
            // 
            this.columnNro.Text = "Nro";
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 170;
            // 
            // columnTipoPrenda
            // 
            this.columnTipoPrenda.Text = "Tipo de Prenda";
            this.columnTipoPrenda.Width = 170;
            // 
            // columnPrecio
            // 
            this.columnPrecio.Text = "Precio";
            this.columnPrecio.Width = 100;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 107;
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
            this.cmbServicios.Hint = "Servicios";
            this.cmbServicios.IntegralHeight = false;
            this.cmbServicios.ItemHeight = 43;
            this.cmbServicios.Location = new System.Drawing.Point(10, 28);
            this.cmbServicios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbServicios.MaxDropDownItems = 4;
            this.cmbServicios.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(206, 49);
            this.cmbServicios.StartIndex = 0;
            this.cmbServicios.TabIndex = 16;
            this.cmbServicios.ValueMember = "IdServicio";
            // 
            // btnAgregarItemOrden
            // 
            this.btnAgregarItemOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarItemOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarItemOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarItemOrden.Depth = 0;
            this.btnAgregarItemOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarItemOrden.HighEmphasis = true;
            this.btnAgregarItemOrden.Icon = null;
            this.btnAgregarItemOrden.Location = new System.Drawing.Point(429, 36);
            this.btnAgregarItemOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarItemOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarItemOrden.Name = "btnAgregarItemOrden";
            this.btnAgregarItemOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarItemOrden.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarItemOrden.TabIndex = 17;
            this.btnAgregarItemOrden.Text = "Agregar";
            this.btnAgregarItemOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarItemOrden.UseAccentColor = false;
            this.btnAgregarItemOrden.UseVisualStyleBackColor = false;
            this.btnAgregarItemOrden.Click += new System.EventHandler(this.btnAgregarItemOrden_Click);
            // 
            // btnEliminarItemOrden
            // 
            this.btnEliminarItemOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarItemOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarItemOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarItemOrden.Depth = 0;
            this.btnEliminarItemOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarItemOrden.HighEmphasis = true;
            this.btnEliminarItemOrden.Icon = null;
            this.btnEliminarItemOrden.Location = new System.Drawing.Point(528, 36);
            this.btnEliminarItemOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarItemOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarItemOrden.Name = "btnEliminarItemOrden";
            this.btnEliminarItemOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarItemOrden.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarItemOrden.TabIndex = 18;
            this.btnEliminarItemOrden.Text = "Eliminar";
            this.btnEliminarItemOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarItemOrden.UseAccentColor = false;
            this.btnEliminarItemOrden.UseVisualStyleBackColor = false;
            this.btnEliminarItemOrden.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(749, 585);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 19;
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
            this.btnCancelar.Location = new System.Drawing.Point(843, 585);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.AnimateReadOnly = false;
            this.txtCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuit.Depth = 0;
            this.txtCuit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCuit.Hint = "Ingrese CUIT o DNI del Cliente";
            this.txtCuit.LeadingIcon = null;
            this.txtCuit.Location = new System.Drawing.Point(9, 10);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCuit.MaxLength = 50;
            this.txtCuit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuit.Multiline = false;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(237, 50);
            this.txtCuit.TabIndex = 22;
            this.txtCuit.Text = "";
            this.ayudaOrden.SetToolTip(this.txtCuit, "Recuerde no incluir espacios ni guiones al ingresar un CUIT.");
            this.txtCuit.TrailingIcon = null;
            // 
            // cmbTipoPrenda
            // 
            this.cmbTipoPrenda.AutoResize = false;
            this.cmbTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbTipoPrenda.Depth = 0;
            this.cmbTipoPrenda.DisplayMember = "Descripcion";
            this.cmbTipoPrenda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoPrenda.DropDownHeight = 174;
            this.cmbTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrenda.DropDownWidth = 121;
            this.cmbTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipoPrenda.FormattingEnabled = true;
            this.cmbTipoPrenda.Hint = "Tipos de Prenda";
            this.cmbTipoPrenda.IntegralHeight = false;
            this.cmbTipoPrenda.ItemHeight = 43;
            this.cmbTipoPrenda.Location = new System.Drawing.Point(222, 28);
            this.cmbTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbTipoPrenda.MaxDropDownItems = 4;
            this.cmbTipoPrenda.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoPrenda.Name = "cmbTipoPrenda";
            this.cmbTipoPrenda.Size = new System.Drawing.Size(199, 49);
            this.cmbTipoPrenda.StartIndex = 0;
            this.cmbTipoPrenda.TabIndex = 24;
            this.cmbTipoPrenda.ValueMember = "IdTipoPrenda";
            // 
            // lblItemsOrden
            // 
            this.lblItemsOrden.AutoSize = true;
            this.lblItemsOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblItemsOrden.Depth = 0;
            this.lblItemsOrden.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblItemsOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemsOrden.Location = new System.Drawing.Point(10, 6);
            this.lblItemsOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemsOrden.Name = "lblItemsOrden";
            this.lblItemsOrden.Size = new System.Drawing.Size(141, 19);
            this.lblItemsOrden.TabIndex = 25;
            this.lblItemsOrden.Text = "Trabajos a realizar: ";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblFechaSalida.Depth = 0;
            this.lblFechaSalida.Enabled = false;
            this.lblFechaSalida.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaSalida.Location = new System.Drawing.Point(513, 148);
            this.lblFechaSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(120, 19);
            this.lblFechaSalida.TabIndex = 26;
            this.lblFechaSalida.Text = "Fecha de salida: ";
            this.lblFechaSalida.Visible = false;
            // 
            // txtNombreApellidoRazonSocial
            // 
            this.txtNombreApellidoRazonSocial.AnimateReadOnly = false;
            this.txtNombreApellidoRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombreApellidoRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreApellidoRazonSocial.Depth = 0;
            this.txtNombreApellidoRazonSocial.Enabled = false;
            this.txtNombreApellidoRazonSocial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreApellidoRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreApellidoRazonSocial.Hint = "Nombre y Apellido / Razón Social";
            this.txtNombreApellidoRazonSocial.LeadingIcon = null;
            this.txtNombreApellidoRazonSocial.Location = new System.Drawing.Point(82, 70);
            this.txtNombreApellidoRazonSocial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombreApellidoRazonSocial.MaxLength = 50;
            this.txtNombreApellidoRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreApellidoRazonSocial.Multiline = false;
            this.txtNombreApellidoRazonSocial.Name = "txtNombreApellidoRazonSocial";
            this.txtNombreApellidoRazonSocial.Size = new System.Drawing.Size(317, 50);
            this.txtNombreApellidoRazonSocial.TabIndex = 29;
            this.txtNombreApellidoRazonSocial.Text = "";
            this.txtNombreApellidoRazonSocial.TrailingIcon = null;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.AutoSize = false;
            this.btnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarCliente.Depth = 0;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarCliente.HighEmphasis = true;
            this.btnAgregarCliente.Icon = null;
            this.btnAgregarCliente.Location = new System.Drawing.Point(407, 70);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarCliente.Size = new System.Drawing.Size(77, 50);
            this.btnAgregarCliente.TabIndex = 30;
            this.btnAgregarCliente.Text = "Nuevo Cliente";
            this.btnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarCliente.UseAccentColor = false;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblItemsOrden);
            this.materialCard1.Controls.Add(this.cmbServicios);
            this.materialCard1.Controls.Add(this.cmbTipoPrenda);
            this.materialCard1.Controls.Add(this.btnAgregarItemOrden);
            this.materialCard1.Controls.Add(this.btnEliminarItemOrden);
            this.materialCard1.Controls.Add(this.listItemsServicio);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(9, 279);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(629, 233);
            this.materialCard1.TabIndex = 31;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.AnimateReadOnly = false;
            this.txtPrecioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioTotal.Depth = 0;
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPrecioTotal.Hint = "Total";
            this.txtPrecioTotal.LeadingIcon = null;
            this.txtPrecioTotal.Location = new System.Drawing.Point(813, 527);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrecioTotal.MaxLength = 50;
            this.txtPrecioTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioTotal.Multiline = false;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(129, 50);
            this.txtPrecioTotal.TabIndex = 32;
            this.txtPrecioTotal.Text = "";
            this.txtPrecioTotal.TrailingIcon = null;
            // 
            // lblAPagar
            // 
            this.lblAPagar.AutoSize = true;
            this.lblAPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblAPagar.Depth = 0;
            this.lblAPagar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAPagar.Location = new System.Drawing.Point(745, 540);
            this.lblAPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPagar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAPagar.Name = "lblAPagar";
            this.lblAPagar.Size = new System.Drawing.Size(60, 19);
            this.lblAPagar.TabIndex = 33;
            this.lblAPagar.Text = "A pagar:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.AutoResize = false;
            this.cmbPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbPrioridad.Depth = 0;
            this.cmbPrioridad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPrioridad.DropDownHeight = 174;
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.DropDownWidth = 121;
            this.cmbPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Hint = "Prioridad";
            this.cmbPrioridad.IntegralHeight = false;
            this.cmbPrioridad.ItemHeight = 43;
            this.cmbPrioridad.Location = new System.Drawing.Point(513, 172);
            this.cmbPrioridad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbPrioridad.MaxDropDownItems = 4;
            this.cmbPrioridad.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(233, 49);
            this.cmbPrioridad.StartIndex = 0;
            this.cmbPrioridad.TabIndex = 34;
            this.ayudaOrden.SetToolTip(this.cmbPrioridad, "Si selecciona prioridad \"Alta\" los trabajos a realizar incluidos en la Orden\r\nse " +
        "mostrarán por encima de los trabajos con prioridad \"Estándar\" en\r\nel modulo Plan" +
        "ificación.");
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(9, 127);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(390, 50);
            this.txtDireccion.TabIndex = 35;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(253, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.rbtnValor);
            this.materialCard2.Controls.Add(this.rbtnPorcentaje);
            this.materialCard2.Controls.Add(this.txtDescuento);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(9, 525);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(222, 96);
            this.materialCard2.TabIndex = 35;
            // 
            // rbtnValor
            // 
            this.rbtnValor.AutoSize = true;
            this.rbtnValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rbtnValor.Depth = 0;
            this.rbtnValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtnValor.Location = new System.Drawing.Point(2, 58);
            this.rbtnValor.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnValor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnValor.Name = "rbtnValor";
            this.rbtnValor.Ripple = true;
            this.rbtnValor.Size = new System.Drawing.Size(72, 37);
            this.rbtnValor.TabIndex = 3;
            this.rbtnValor.TabStop = true;
            this.rbtnValor.Text = "Valor";
            this.rbtnValor.UseVisualStyleBackColor = false;
            this.rbtnValor.CheckedChanged += new System.EventHandler(this.rbtnValor_CheckedChanged);
            // 
            // rbtnPorcentaje
            // 
            this.rbtnPorcentaje.AutoSize = true;
            this.rbtnPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rbtnPorcentaje.Depth = 0;
            this.rbtnPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtnPorcentaje.Location = new System.Drawing.Point(2, 21);
            this.rbtnPorcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnPorcentaje.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnPorcentaje.Name = "rbtnPorcentaje";
            this.rbtnPorcentaje.Ripple = true;
            this.rbtnPorcentaje.Size = new System.Drawing.Size(110, 37);
            this.rbtnPorcentaje.TabIndex = 2;
            this.rbtnPorcentaje.TabStop = true;
            this.rbtnPorcentaje.Text = "Porcentaje";
            this.rbtnPorcentaje.UseVisualStyleBackColor = false;
            this.rbtnPorcentaje.CheckedChanged += new System.EventHandler(this.rbtnPorcentaje_CheckedChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescuento.Hint = "Ingresar";
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(128, 36);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescuento.MaxLength = 50;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(88, 50);
            this.txtDescuento.TabIndex = 1;
            this.txtDescuento.Text = "";
            this.ayudaOrden.SetToolTip(this.txtDescuento, "Si selecciona \"Porcentaje\" ingrese un valor entre 0 y 100.\r\nSi selecciona \"Valor\"" +
        " ingrese un valor entre 0 y el total de la orden.");
            this.txtDescuento.TrailingIcon = null;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(4, 2);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Descuento:";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.cbFormaPago);
            this.materialCard3.Controls.Add(this.txtSeniaOrden);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(243, 525);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(283, 96);
            this.materialCard3.TabIndex = 36;
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.AutoResize = false;
            this.cbFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbFormaPago.Depth = 0;
            this.cbFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFormaPago.DropDownHeight = 174;
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.DropDownWidth = 121;
            this.cbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Hint = "Forma de pago";
            this.cbFormaPago.IntegralHeight = false;
            this.cbFormaPago.ItemHeight = 43;
            this.cbFormaPago.Location = new System.Drawing.Point(114, 36);
            this.cbFormaPago.MaxDropDownItems = 4;
            this.cbFormaPago.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(163, 49);
            this.cbFormaPago.StartIndex = 0;
            this.cbFormaPago.TabIndex = 2;
            // 
            // txtSeniaOrden
            // 
            this.txtSeniaOrden.AnimateReadOnly = false;
            this.txtSeniaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSeniaOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeniaOrden.Depth = 0;
            this.txtSeniaOrden.Enabled = false;
            this.txtSeniaOrden.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSeniaOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSeniaOrden.Hint = "Ingresar";
            this.txtSeniaOrden.LeadingIcon = null;
            this.txtSeniaOrden.Location = new System.Drawing.Point(5, 36);
            this.txtSeniaOrden.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSeniaOrden.MaxLength = 50;
            this.txtSeniaOrden.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSeniaOrden.Multiline = false;
            this.txtSeniaOrden.Name = "txtSeniaOrden";
            this.txtSeniaOrden.Size = new System.Drawing.Size(102, 50);
            this.txtSeniaOrden.TabIndex = 1;
            this.txtSeniaOrden.Text = "";
            this.txtSeniaOrden.TrailingIcon = null;
            this.txtSeniaOrden.TextChanged += new System.EventHandler(this.txtSeniaOrden_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 2);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Seña(Anticipo):";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Depth = 0;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtObservaciones.Hint = "Observaciones";
            this.txtObservaciones.Location = new System.Drawing.Point(651, 308);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(291, 204);
            this.txtObservaciones.TabIndex = 37;
            this.txtObservaciones.Text = "";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.txtIdCliente);
            this.materialCard4.Controls.Add(this.txtNombreApellidoRazonSocial);
            this.materialCard4.Controls.Add(this.btnBuscar);
            this.materialCard4.Controls.Add(this.txtDireccion);
            this.materialCard4.Controls.Add(this.txtCuit);
            this.materialCard4.Controls.Add(this.btnAgregarCliente);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(9, 85);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(495, 188);
            this.materialCard4.TabIndex = 38;
            // 
            // cmbEntregaDomicilio
            // 
            this.cmbEntregaDomicilio.AutoResize = false;
            this.cmbEntregaDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbEntregaDomicilio.Depth = 0;
            this.cmbEntregaDomicilio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEntregaDomicilio.DropDownHeight = 174;
            this.cmbEntregaDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntregaDomicilio.DropDownWidth = 121;
            this.cmbEntregaDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEntregaDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEntregaDomicilio.FormattingEnabled = true;
            this.cmbEntregaDomicilio.Hint = "Entrega a Domicilio";
            this.cmbEntregaDomicilio.IntegralHeight = false;
            this.cmbEntregaDomicilio.ItemHeight = 43;
            this.cmbEntregaDomicilio.Location = new System.Drawing.Point(752, 172);
            this.cmbEntregaDomicilio.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbEntregaDomicilio.MaxDropDownItems = 4;
            this.cmbEntregaDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEntregaDomicilio.Name = "cmbEntregaDomicilio";
            this.cmbEntregaDomicilio.Size = new System.Drawing.Size(178, 49);
            this.cmbEntregaDomicilio.StartIndex = 0;
            this.cmbEntregaDomicilio.TabIndex = 39;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(651, 279);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 19);
            this.materialLabel3.TabIndex = 40;
            this.materialLabel3.Text = "Observaciones:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpFechaEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(651, 117);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(97, 23);
            this.dtpFechaEntrega.TabIndex = 41;
            this.dtpFechaEntrega.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            this.dtpFechaEntrega.ValueChanged += new System.EventHandler(this.dtpFechaEntrega_ValueChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(513, 120);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 19);
            this.materialLabel4.TabIndex = 42;
            this.materialLabel4.Text = "Fecha entrega:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(781, 120);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 19);
            this.materialLabel5.TabIndex = 43;
            this.materialLabel5.Text = "Hora entrega:";
            // 
            // nudHoraEntrega
            // 
            this.nudHoraEntrega.Location = new System.Drawing.Point(883, 117);
            this.nudHoraEntrega.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoraEntrega.Name = "nudHoraEntrega";
            this.nudHoraEntrega.Size = new System.Drawing.Size(47, 23);
            this.nudHoraEntrega.TabIndex = 44;
            // 
            // ayudaOrden
            // 
            this.ayudaOrden.AutomaticDelay = 0;
            this.ayudaOrden.AutoPopDelay = 4800;
            this.ayudaOrden.InitialDelay = 0;
            this.ayudaOrden.ReshowDelay = 96;
            this.ayudaOrden.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ayudaOrden.ToolTipTitle = "Ayuda";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.lblDescueto);
            this.materialCard5.Controls.Add(this.lblTotal);
            this.materialCard5.Controls.Add(this.materialLabel7);
            this.materialCard5.Controls.Add(this.materialLabel6);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(537, 525);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(197, 96);
            this.materialCard5.TabIndex = 45;
            // 
            // lblDescueto
            // 
            this.lblDescueto.AutoSize = true;
            this.lblDescueto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDescueto.Depth = 0;
            this.lblDescueto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescueto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescueto.Location = new System.Drawing.Point(96, 40);
            this.lblDescueto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescueto.Name = "lblDescueto";
            this.lblDescueto.Size = new System.Drawing.Size(5, 19);
            this.lblDescueto.TabIndex = 4;
            this.lblDescueto.Text = "-";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(96, 14);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(5, 19);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "-";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 40);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(80, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "Descuento:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Total:";
            // 
            // OrdenDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(952, 629);
            this.Controls.Add(this.materialCard5);
            this.Controls.Add(this.nudHoraEntrega);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cmbEntregaDomicilio);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblAPagar);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaEntrada);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "OrdenDesktop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraEntrega)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblFechaEntrada;
        private MaterialSkin.Controls.MaterialTextBox txtIdCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private MaterialSkin.Controls.MaterialComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialListView listItemsServicio;
        private MaterialSkin.Controls.MaterialComboBox cmbServicios;
        private MaterialSkin.Controls.MaterialButton btnAgregarItemOrden;
        private MaterialSkin.Controls.MaterialButton btnEliminarItemOrden;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txtCuit;
        private System.Windows.Forms.ColumnHeader columnNro;
        private System.Windows.Forms.ColumnHeader columnServicio;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoPrenda;
        private System.Windows.Forms.ColumnHeader columnTipoPrenda;
        private MaterialSkin.Controls.MaterialLabel lblItemsOrden;
        private MaterialSkin.Controls.MaterialLabel lblFechaSalida;
        private MaterialSkin.Controls.MaterialTextBox txtNombreApellidoRazonSocial;
        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private System.Windows.Forms.ColumnHeader columnPrecio;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioTotal;
        private MaterialSkin.Controls.MaterialLabel lblAPagar;
        private MaterialSkin.Controls.MaterialComboBox cmbPrioridad;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtSeniaOrden;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnValor;
        private MaterialSkin.Controls.MaterialRadioButton rbtnPorcentaje;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtObservaciones;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialComboBox cmbEntregaDomicilio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbFormaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.NumericUpDown nudHoraEntrega;
        private System.Windows.Forms.ToolTip ayudaOrden;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel lblDescueto;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}