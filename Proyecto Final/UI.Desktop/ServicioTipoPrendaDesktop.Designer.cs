
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
            this.lblTiempoRequerido = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoras = new MaterialSkin.Controls.MaterialLabel();
            this.lblMinutos = new MaterialSkin.Controls.MaterialLabel();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cmbInsumos = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.listConsumos = new MaterialSkin.Controls.MaterialListView();
            this.cmbUnidadMedida = new MaterialSkin.Controls.MaterialComboBox();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnCantidad = new System.Windows.Forms.ColumnHeader();
            this.btnAgregarConsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarConsumo = new MaterialSkin.Controls.MaterialButton();
            this.lblConsumo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbServicios
            // 
            this.cmbServicios.AutoResize = false;
            this.cmbServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbServicios.Depth = 0;
            this.cmbServicios.DisplayMember = "Descripcion";
            this.cmbServicios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbServicios.DropDownHeight = 174;
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.DropDownWidth = 121;
            this.cmbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Hint = "Servicio";
            this.cmbServicios.IntegralHeight = false;
            this.cmbServicios.ItemHeight = 43;
            this.cmbServicios.Location = new System.Drawing.Point(24, 97);
            this.cmbServicios.MaxDropDownItems = 4;
            this.cmbServicios.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(236, 49);
            this.cmbServicios.StartIndex = 0;
            this.cmbServicios.TabIndex = 2;
            this.cmbServicios.ValueMember = "IdServicio";
            // 
            // cmbTipoPrendas
            // 
            this.cmbTipoPrendas.AutoResize = false;
            this.cmbTipoPrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbTipoPrendas.Depth = 0;
            this.cmbTipoPrendas.DisplayMember = "Descripcion";
            this.cmbTipoPrendas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoPrendas.DropDownHeight = 174;
            this.cmbTipoPrendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrendas.DropDownWidth = 121;
            this.cmbTipoPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoPrendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoPrendas.FormattingEnabled = true;
            this.cmbTipoPrendas.Hint = "Tipo de prenda";
            this.cmbTipoPrendas.IntegralHeight = false;
            this.cmbTipoPrendas.ItemHeight = 43;
            this.cmbTipoPrendas.Location = new System.Drawing.Point(269, 97);
            this.cmbTipoPrendas.MaxDropDownItems = 4;
            this.cmbTipoPrendas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoPrendas.Name = "cmbTipoPrendas";
            this.cmbTipoPrendas.Size = new System.Drawing.Size(264, 49);
            this.cmbTipoPrendas.StartIndex = 0;
            this.cmbTipoPrendas.TabIndex = 3;
            this.cmbTipoPrendas.ValueMember = "IdTipoPrenda";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(340, 492);
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
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(434, 492);
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
            // lblTiempoRequerido
            // 
            this.lblTiempoRequerido.AutoSize = true;
            this.lblTiempoRequerido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTiempoRequerido.Depth = 0;
            this.lblTiempoRequerido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTiempoRequerido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTiempoRequerido.Location = new System.Drawing.Point(24, 170);
            this.lblTiempoRequerido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTiempoRequerido.Name = "lblTiempoRequerido";
            this.lblTiempoRequerido.Size = new System.Drawing.Size(133, 19);
            this.lblTiempoRequerido.TabIndex = 6;
            this.lblTiempoRequerido.Text = "Tiempo requerido: ";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblHoras.Depth = 0;
            this.lblHoras.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHoras.Location = new System.Drawing.Point(163, 170);
            this.lblHoras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(47, 19);
            this.lblHoras.TabIndex = 8;
            this.lblHoras.Text = "Horas:";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMinutos.Depth = 0;
            this.lblMinutos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMinutos.Location = new System.Drawing.Point(265, 170);
            this.lblMinutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(63, 19);
            this.lblMinutos.TabIndex = 12;
            this.lblMinutos.Text = "Minutos:";
            // 
            // nudHoras
            // 
            this.nudHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nudHoras.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudHoras.Location = new System.Drawing.Point(216, 168);
            this.nudHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(43, 24);
            this.nudHoras.TabIndex = 13;
            // 
            // nudMinutos
            // 
            this.nudMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nudMinutos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudMinutos.Location = new System.Drawing.Point(324, 168);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(44, 24);
            this.nudMinutos.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPrecio.Hint = "Precio";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(24, 201);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(172, 50);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.Text = "";
            this.txtPrecio.TrailingIcon = null;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.lblConsumo);
            this.materialCard1.Controls.Add(this.btnEliminarConsumo);
            this.materialCard1.Controls.Add(this.btnAgregarConsumo);
            this.materialCard1.Controls.Add(this.cmbUnidadMedida);
            this.materialCard1.Controls.Add(this.listConsumos);
            this.materialCard1.Controls.Add(this.txtCantidad);
            this.materialCard1.Controls.Add(this.cmbInsumos);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Location = new System.Drawing.Point(11, 258);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(519, 229);
            this.materialCard1.TabIndex = 16;
            // 
            // cmbInsumos
            // 
            this.cmbInsumos.AutoResize = false;
            this.cmbInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbInsumos.Depth = 0;
            this.cmbInsumos.DisplayMember = "IdConsumo";
            this.cmbInsumos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbInsumos.DropDownHeight = 174;
            this.cmbInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsumos.DropDownWidth = 121;
            this.cmbInsumos.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbInsumos.FormattingEnabled = true;
            this.cmbInsumos.IntegralHeight = false;
            this.cmbInsumos.ItemHeight = 43;
            this.cmbInsumos.Location = new System.Drawing.Point(13, 33);
            this.cmbInsumos.MaxDropDownItems = 4;
            this.cmbInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbInsumos.Name = "cmbInsumos";
            this.cmbInsumos.Size = new System.Drawing.Size(217, 49);
            this.cmbInsumos.StartIndex = 0;
            this.cmbInsumos.TabIndex = 0;
            this.cmbInsumos.ValueMember = "Descripcion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(239, 34);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 50);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            // 
            // listConsumos
            // 
            this.listConsumos.AutoSizeTable = false;
            this.listConsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listConsumos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listConsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnInsumo,
            this.columnCantidad});
            this.listConsumos.Depth = 0;
            this.listConsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listConsumos.FullRowSelect = true;
            this.listConsumos.HideSelection = false;
            this.listConsumos.Location = new System.Drawing.Point(13, 89);
            this.listConsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listConsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listConsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listConsumos.Name = "listConsumos";
            this.listConsumos.OwnerDraw = true;
            this.listConsumos.Size = new System.Drawing.Size(311, 123);
            this.listConsumos.TabIndex = 2;
            this.listConsumos.UseCompatibleStateImageBehavior = false;
            this.listConsumos.View = System.Windows.Forms.View.Details;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.AutoResize = false;
            this.cmbUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbUnidadMedida.Depth = 0;
            this.cmbUnidadMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUnidadMedida.DropDownHeight = 174;
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.DropDownWidth = 121;
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.IntegralHeight = false;
            this.cmbUnidadMedida.ItemHeight = 43;
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "Litros(1L/1000Cm3/1000ml)",
            "Mililitros/Cm3",
            "Kilogramos(1Kg/1000gr)",
            "Gramos(gr)"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(346, 34);
            this.cmbUnidadMedida.MaxDropDownItems = 4;
            this.cmbUnidadMedida.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(137, 49);
            this.cmbUnidadMedida.StartIndex = 0;
            this.cmbUnidadMedida.TabIndex = 3;
            // 
            // columnNro
            // 
            this.columnNro.Text = "Nro";
            // 
            // columnInsumo
            // 
            this.columnInsumo.Text = "Insumo";
            this.columnInsumo.Width = 150;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.Width = 100;
            // 
            // btnAgregarConsumo
            // 
            this.btnAgregarConsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarConsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarConsumo.Depth = 0;
            this.btnAgregarConsumo.HighEmphasis = true;
            this.btnAgregarConsumo.Icon = null;
            this.btnAgregarConsumo.Location = new System.Drawing.Point(331, 91);
            this.btnAgregarConsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarConsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarConsumo.Name = "btnAgregarConsumo";
            this.btnAgregarConsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarConsumo.Size = new System.Drawing.Size(163, 36);
            this.btnAgregarConsumo.TabIndex = 4;
            this.btnAgregarConsumo.Text = "Agregar Consumo";
            this.btnAgregarConsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarConsumo.UseAccentColor = false;
            this.btnAgregarConsumo.UseVisualStyleBackColor = true;
            this.btnAgregarConsumo.Click += new System.EventHandler(this.btnAgregarConsumo_Click);
            // 
            // btnEliminarConsumo
            // 
            this.btnEliminarConsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarConsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarConsumo.Depth = 0;
            this.btnEliminarConsumo.HighEmphasis = true;
            this.btnEliminarConsumo.Icon = null;
            this.btnEliminarConsumo.Location = new System.Drawing.Point(331, 137);
            this.btnEliminarConsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarConsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarConsumo.Name = "btnEliminarConsumo";
            this.btnEliminarConsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarConsumo.Size = new System.Drawing.Size(164, 36);
            this.btnEliminarConsumo.TabIndex = 5;
            this.btnEliminarConsumo.Text = "Eliminar Consumo";
            this.btnEliminarConsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarConsumo.UseAccentColor = false;
            this.btnEliminarConsumo.UseVisualStyleBackColor = true;
            this.btnEliminarConsumo.Click += new System.EventHandler(this.btnEliminarConsumo_Click);
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Depth = 0;
            this.lblConsumo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConsumo.Location = new System.Drawing.Point(13, 8);
            this.lblConsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(138, 19);
            this.lblConsumo.TabIndex = 6;
            this.lblConsumo.Text = "Agregar consumos:";
            // 
            // ServicioTipoPrendaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 537);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblTiempoRequerido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTipoPrendas);
            this.Controls.Add(this.cmbServicios);
            this.Name = "ServicioTipoPrendaDesktop";
            this.Text = "Nuevo Servicio-TipoPrenda";
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel lblTiempoRequerido;
        private MaterialSkin.Controls.MaterialLabel lblHoras;
        private MaterialSkin.Controls.MaterialLabel lblMinutos;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.NumericUpDown nudMinutos;
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
    }
}