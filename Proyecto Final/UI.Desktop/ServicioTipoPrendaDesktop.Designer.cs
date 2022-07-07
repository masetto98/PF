
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
            this.lblConsumo = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarConsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarConsumo = new MaterialSkin.Controls.MaterialButton();
            this.cmbUnidadMedida = new MaterialSkin.Controls.MaterialComboBox();
            this.listConsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnCantidad = new System.Windows.Forms.ColumnHeader();
            this.columnUnidad = new System.Windows.Forms.ColumnHeader();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbInsumos = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.nudMinutos2 = new System.Windows.Forms.NumericUpDown();
            this.nudHoras2 = new System.Windows.Forms.NumericUpDown();
            this.lblMinutos2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoras2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPlazoMaximo = new MaterialSkin.Controls.MaterialLabel();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.lblDias = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
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
            this.cmbServicios.Size = new System.Drawing.Size(283, 49);
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
            this.cmbTipoPrendas.Location = new System.Drawing.Point(308, 92);
            this.cmbTipoPrendas.MaxDropDownItems = 4;
            this.cmbTipoPrendas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoPrendas.Name = "cmbTipoPrendas";
            this.cmbTipoPrendas.Size = new System.Drawing.Size(281, 49);
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
            this.btnAceptar.Location = new System.Drawing.Point(391, 543);
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
            this.btnCancelar.Location = new System.Drawing.Point(493, 543);
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
            this.lblTiempoRequerido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTiempoRequerido.Depth = 0;
            this.lblTiempoRequerido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTiempoRequerido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTiempoRequerido.Location = new System.Drawing.Point(20, 219);
            this.lblTiempoRequerido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTiempoRequerido.Name = "lblTiempoRequerido";
            this.lblTiempoRequerido.Size = new System.Drawing.Size(133, 19);
            this.lblTiempoRequerido.TabIndex = 6;
            this.lblTiempoRequerido.Text = "Tiempo requerido: ";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHoras.Depth = 0;
            this.lblHoras.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoras.Location = new System.Drawing.Point(159, 219);
            this.lblHoras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(47, 19);
            this.lblHoras.TabIndex = 8;
            this.lblHoras.Text = "Horas:";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblMinutos.Depth = 0;
            this.lblMinutos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMinutos.Location = new System.Drawing.Point(261, 219);
            this.lblMinutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(63, 19);
            this.lblMinutos.TabIndex = 12;
            this.lblMinutos.Text = "Minutos:";
            // 
            // nudHoras
            // 
            this.nudHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nudHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudHoras.Location = new System.Drawing.Point(212, 214);
            this.nudHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(43, 23);
            this.nudHoras.TabIndex = 13;
            // 
            // nudMinutos
            // 
            this.nudMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nudMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudMinutos.Location = new System.Drawing.Point(330, 214);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(44, 23);
            this.nudMinutos.TabIndex = 14;
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
            this.txtPrecio.Location = new System.Drawing.Point(71, 150);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(231, 50);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.Text = "";
            this.txtPrecio.TrailingIcon = null;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.lblConsumo);
            this.materialCard1.Controls.Add(this.btnEliminarConsumo);
            this.materialCard1.Controls.Add(this.btnAgregarConsumo);
            this.materialCard1.Controls.Add(this.cmbUnidadMedida);
            this.materialCard1.Controls.Add(this.listConsumos);
            this.materialCard1.Controls.Add(this.txtCantidad);
            this.materialCard1.Controls.Add(this.cmbInsumos);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 307);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(580, 224);
            this.materialCard1.TabIndex = 16;
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
            this.btnEliminarConsumo.Location = new System.Drawing.Point(482, 137);
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
            this.btnAgregarConsumo.Location = new System.Drawing.Point(482, 89);
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
            this.cmbUnidadMedida.Location = new System.Drawing.Point(329, 33);
            this.cmbUnidadMedida.MaxDropDownItems = 4;
            this.cmbUnidadMedida.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(241, 49);
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
            this.columnUnidad});
            this.listConsumos.Depth = 0;
            this.listConsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listConsumos.FullRowSelect = true;
            this.listConsumos.HideSelection = false;
            this.listConsumos.Location = new System.Drawing.Point(13, 89);
            this.listConsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listConsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listConsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listConsumos.Name = "listConsumos";
            this.listConsumos.OwnerDraw = true;
            this.listConsumos.Size = new System.Drawing.Size(462, 123);
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
            this.columnUnidad.Width = 150;
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
            this.txtCantidad.Location = new System.Drawing.Point(223, 32);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 50);
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
            this.cmbInsumos.Location = new System.Drawing.Point(13, 33);
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
            this.materialComboBox1.Location = new System.Drawing.Point(308, 150);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(281, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 17;
            this.materialComboBox1.Visible = false;
            // 
            // nudMinutos2
            // 
            this.nudMinutos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nudMinutos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudMinutos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudMinutos2.Location = new System.Drawing.Point(330, 272);
            this.nudMinutos2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos2.Name = "nudMinutos2";
            this.nudMinutos2.Size = new System.Drawing.Size(44, 23);
            this.nudMinutos2.TabIndex = 22;
            // 
            // nudHoras2
            // 
            this.nudHoras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nudHoras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudHoras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudHoras2.Location = new System.Drawing.Point(212, 272);
            this.nudHoras2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras2.Name = "nudHoras2";
            this.nudHoras2.Size = new System.Drawing.Size(43, 23);
            this.nudHoras2.TabIndex = 21;
            // 
            // lblMinutos2
            // 
            this.lblMinutos2.AutoSize = true;
            this.lblMinutos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblMinutos2.Depth = 0;
            this.lblMinutos2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinutos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMinutos2.Location = new System.Drawing.Point(261, 274);
            this.lblMinutos2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinutos2.Name = "lblMinutos2";
            this.lblMinutos2.Size = new System.Drawing.Size(63, 19);
            this.lblMinutos2.TabIndex = 20;
            this.lblMinutos2.Text = "Minutos:";
            // 
            // lblHoras2
            // 
            this.lblHoras2.AutoSize = true;
            this.lblHoras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHoras2.Depth = 0;
            this.lblHoras2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHoras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoras2.Location = new System.Drawing.Point(159, 274);
            this.lblHoras2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoras2.Name = "lblHoras2";
            this.lblHoras2.Size = new System.Drawing.Size(47, 19);
            this.lblHoras2.TabIndex = 19;
            this.lblHoras2.Text = "Horas:";
            // 
            // lblPlazoMaximo
            // 
            this.lblPlazoMaximo.AutoSize = true;
            this.lblPlazoMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblPlazoMaximo.Depth = 0;
            this.lblPlazoMaximo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlazoMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlazoMaximo.Location = new System.Drawing.Point(20, 250);
            this.lblPlazoMaximo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlazoMaximo.Name = "lblPlazoMaximo";
            this.lblPlazoMaximo.Size = new System.Drawing.Size(346, 19);
            this.lblPlazoMaximo.TabIndex = 18;
            this.lblPlazoMaximo.Text = "Plazo máximo de espera para atender el servicio:";
            // 
            // nudDias
            // 
            this.nudDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nudDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudDias.Location = new System.Drawing.Point(106, 272);
            this.nudDias.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(43, 23);
            this.nudDias.TabIndex = 24;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDias.Depth = 0;
            this.lblDias.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDias.Location = new System.Drawing.Point(63, 274);
            this.lblDias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(37, 19);
            this.lblDias.TabIndex = 23;
            this.lblDias.Text = "Días:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 167);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Precio:";
            // 
            // ServicioTipoPrendaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 590);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.nudMinutos2);
            this.Controls.Add(this.nudHoras2);
            this.Controls.Add(this.lblMinutos2);
            this.Controls.Add(this.lblHoras2);
            this.Controls.Add(this.lblPlazoMaximo);
            this.Controls.Add(this.materialComboBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ServicioTipoPrendaDesktop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio Tipo Prenda";
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
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
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.NumericUpDown nudMinutos2;
        private System.Windows.Forms.NumericUpDown nudHoras2;
        private MaterialSkin.Controls.MaterialLabel lblMinutos2;
        private MaterialSkin.Controls.MaterialLabel lblHoras2;
        private MaterialSkin.Controls.MaterialLabel lblPlazoMaximo;
        private System.Windows.Forms.NumericUpDown nudDias;
        private MaterialSkin.Controls.MaterialLabel lblDias;
        private System.Windows.Forms.ColumnHeader columnUnidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}