
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
            this.txtTiempoFinalizacionEstimado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreApellidoRazonSocial = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtPrecioTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPrioridad = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFechaEntrada.Depth = 0;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFechaEntrada.Location = new System.Drawing.Point(16, 231);
            this.lblFechaEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(125, 19);
            this.lblFechaEntrada.TabIndex = 1;
            this.lblFechaEntrada.Text = "Fecha de ingreso:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.AnimateReadOnly = false;
            this.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCliente.Depth = 0;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIdCliente.Hint = "Id";
            this.txtIdCliente.LeadingIcon = null;
            this.txtIdCliente.Location = new System.Drawing.Point(16, 160);
            this.txtIdCliente.MaxLength = 50;
            this.txtIdCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdCliente.Multiline = false;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(135, 50);
            this.txtIdCliente.TabIndex = 4;
            this.txtIdCliente.Text = "";
            this.txtIdCliente.TrailingIcon = null;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(147, 225);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(128, 24);
            this.dtpFechaIngreso.TabIndex = 12;
            this.dtpFechaIngreso.Value = new System.DateTime(2022, 6, 5, 14, 19, 15, 0);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFechaSalida.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(407, 226);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(117, 24);
            this.dtpFechaSalida.TabIndex = 12;
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoResize = false;
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbEstado.Depth = 0;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownHeight = 174;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownWidth = 121;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Hint = "Estado";
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Location = new System.Drawing.Point(16, 267);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(206, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 13;
            // 
            // listItemsServicio
            // 
            this.listItemsServicio.AutoSizeTable = false;
            this.listItemsServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listItemsServicio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnServicio,
            this.columnTipoPrenda,
            this.columnPrecio,
            this.columnEstado});
            this.listItemsServicio.Depth = 0;
            this.listItemsServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listItemsServicio.FullRowSelect = true;
            this.listItemsServicio.HideSelection = false;
            this.listItemsServicio.Location = new System.Drawing.Point(10, 83);
            this.listItemsServicio.MinimumSize = new System.Drawing.Size(200, 100);
            this.listItemsServicio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listItemsServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.listItemsServicio.Name = "listItemsServicio";
            this.listItemsServicio.OwnerDraw = true;
            this.listItemsServicio.Size = new System.Drawing.Size(607, 135);
            this.listItemsServicio.TabIndex = 14;
            this.listItemsServicio.UseCompatibleStateImageBehavior = false;
            this.listItemsServicio.View = System.Windows.Forms.View.Details;
            // 
            // columnNro
            // 
            this.columnNro.Text = "Nro";
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 150;
            // 
            // columnTipoPrenda
            // 
            this.columnTipoPrenda.Text = "Tipo de Prenda";
            this.columnTipoPrenda.Width = 150;
            // 
            // columnPrecio
            // 
            this.columnPrecio.Text = "Precio";
            this.columnPrecio.Width = 100;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 106;
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
            this.cmbServicios.Hint = "Servicios";
            this.cmbServicios.IntegralHeight = false;
            this.cmbServicios.ItemHeight = 43;
            this.cmbServicios.Location = new System.Drawing.Point(10, 28);
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
            this.btnAgregarItemOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarItemOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarItemOrden.Depth = 0;
            this.btnAgregarItemOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarItemOrden.HighEmphasis = true;
            this.btnAgregarItemOrden.Icon = null;
            this.btnAgregarItemOrden.Location = new System.Drawing.Point(433, 35);
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
            this.btnEliminarItemOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarItemOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarItemOrden.Depth = 0;
            this.btnEliminarItemOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarItemOrden.HighEmphasis = true;
            this.btnEliminarItemOrden.Icon = null;
            this.btnEliminarItemOrden.Location = new System.Drawing.Point(529, 35);
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
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(451, 622);
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
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(545, 622);
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
            this.txtCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuit.Depth = 0;
            this.txtCuit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCuit.Hint = "Cuit";
            this.txtCuit.LeadingIcon = null;
            this.txtCuit.Location = new System.Drawing.Point(16, 104);
            this.txtCuit.MaxLength = 50;
            this.txtCuit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuit.Multiline = false;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(199, 50);
            this.txtCuit.TabIndex = 22;
            this.txtCuit.Text = "";
            this.txtCuit.TrailingIcon = null;
            // 
            // cmbTipoPrenda
            // 
            this.cmbTipoPrenda.AutoResize = false;
            this.cmbTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbTipoPrenda.Depth = 0;
            this.cmbTipoPrenda.DisplayMember = "Descripcion";
            this.cmbTipoPrenda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoPrenda.DropDownHeight = 174;
            this.cmbTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrenda.DropDownWidth = 121;
            this.cmbTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoPrenda.FormattingEnabled = true;
            this.cmbTipoPrenda.Hint = "Tipo de Prenda";
            this.cmbTipoPrenda.IntegralHeight = false;
            this.cmbTipoPrenda.ItemHeight = 43;
            this.cmbTipoPrenda.Location = new System.Drawing.Point(222, 28);
            this.cmbTipoPrenda.MaxDropDownItems = 4;
            this.cmbTipoPrenda.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoPrenda.Name = "cmbTipoPrenda";
            this.cmbTipoPrenda.Size = new System.Drawing.Size(204, 49);
            this.cmbTipoPrenda.StartIndex = 0;
            this.cmbTipoPrenda.TabIndex = 24;
            this.cmbTipoPrenda.ValueMember = "IdTipoPrenda";
            // 
            // lblItemsOrden
            // 
            this.lblItemsOrden.AutoSize = true;
            this.lblItemsOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblItemsOrden.Depth = 0;
            this.lblItemsOrden.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblItemsOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblItemsOrden.Location = new System.Drawing.Point(10, 6);
            this.lblItemsOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemsOrden.Name = "lblItemsOrden";
            this.lblItemsOrden.Size = new System.Drawing.Size(141, 19);
            this.lblItemsOrden.TabIndex = 25;
            this.lblItemsOrden.Text = "Trabajos a realizar: ";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFechaSalida.Depth = 0;
            this.lblFechaSalida.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFechaSalida.Location = new System.Drawing.Point(281, 231);
            this.lblFechaSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(120, 19);
            this.lblFechaSalida.TabIndex = 26;
            this.lblFechaSalida.Text = "Fecha de salida: ";
            // 
            // txtTiempoFinalizacionEstimado
            // 
            this.txtTiempoFinalizacionEstimado.AnimateReadOnly = false;
            this.txtTiempoFinalizacionEstimado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTiempoFinalizacionEstimado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempoFinalizacionEstimado.Depth = 0;
            this.txtTiempoFinalizacionEstimado.Enabled = false;
            this.txtTiempoFinalizacionEstimado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempoFinalizacionEstimado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTiempoFinalizacionEstimado.Hint = "Tiempo estimado";
            this.txtTiempoFinalizacionEstimado.LeadingIcon = null;
            this.txtTiempoFinalizacionEstimado.Location = new System.Drawing.Point(415, 266);
            this.txtTiempoFinalizacionEstimado.MaxLength = 50;
            this.txtTiempoFinalizacionEstimado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempoFinalizacionEstimado.Multiline = false;
            this.txtTiempoFinalizacionEstimado.Name = "txtTiempoFinalizacionEstimado";
            this.txtTiempoFinalizacionEstimado.Size = new System.Drawing.Size(225, 50);
            this.txtTiempoFinalizacionEstimado.TabIndex = 28;
            this.txtTiempoFinalizacionEstimado.Text = "";
            this.txtTiempoFinalizacionEstimado.TrailingIcon = null;
            // 
            // txtNombreApellidoRazonSocial
            // 
            this.txtNombreApellidoRazonSocial.AnimateReadOnly = false;
            this.txtNombreApellidoRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNombreApellidoRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreApellidoRazonSocial.Depth = 0;
            this.txtNombreApellidoRazonSocial.Enabled = false;
            this.txtNombreApellidoRazonSocial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreApellidoRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombreApellidoRazonSocial.Hint = "Nombre y Apellido / Razón Social";
            this.txtNombreApellidoRazonSocial.LeadingIcon = null;
            this.txtNombreApellidoRazonSocial.Location = new System.Drawing.Point(221, 104);
            this.txtNombreApellidoRazonSocial.MaxLength = 50;
            this.txtNombreApellidoRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreApellidoRazonSocial.Multiline = false;
            this.txtNombreApellidoRazonSocial.Name = "txtNombreApellidoRazonSocial";
            this.txtNombreApellidoRazonSocial.Size = new System.Drawing.Size(324, 50);
            this.txtNombreApellidoRazonSocial.TabIndex = 29;
            this.txtNombreApellidoRazonSocial.Text = "";
            this.txtNombreApellidoRazonSocial.TrailingIcon = null;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarCliente.Depth = 0;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarCliente.HighEmphasis = true;
            this.btnAgregarCliente.Icon = null;
            this.btnAgregarCliente.Location = new System.Drawing.Point(552, 174);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarCliente.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarCliente.TabIndex = 30;
            this.btnAgregarCliente.Text = "Agregar ";
            this.btnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarCliente.UseAccentColor = false;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard1.Controls.Add(this.lblItemsOrden);
            this.materialCard1.Controls.Add(this.cmbServicios);
            this.materialCard1.Controls.Add(this.cmbTipoPrenda);
            this.materialCard1.Controls.Add(this.btnAgregarItemOrden);
            this.materialCard1.Controls.Add(this.btnEliminarItemOrden);
            this.materialCard1.Controls.Add(this.listItemsServicio);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Location = new System.Drawing.Point(16, 323);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(624, 233);
            this.materialCard1.TabIndex = 31;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.AnimateReadOnly = false;
            this.txtPrecioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioTotal.Depth = 0;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPrecioTotal.Hint = "Total";
            this.txtPrecioTotal.LeadingIcon = null;
            this.txtPrecioTotal.Location = new System.Drawing.Point(451, 563);
            this.txtPrecioTotal.MaxLength = 50;
            this.txtPrecioTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioTotal.Multiline = false;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(189, 50);
            this.txtPrecioTotal.TabIndex = 32;
            this.txtPrecioTotal.Text = "";
            this.txtPrecioTotal.TrailingIcon = null;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(390, 581);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 19);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "TOTAL:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.AutoResize = false;
            this.cmbPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbPrioridad.Depth = 0;
            this.cmbPrioridad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPrioridad.DropDownHeight = 174;
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.DropDownWidth = 121;
            this.cmbPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Hint = "Prioridad";
            this.cmbPrioridad.IntegralHeight = false;
            this.cmbPrioridad.ItemHeight = 43;
            this.cmbPrioridad.Location = new System.Drawing.Point(228, 267);
            this.cmbPrioridad.MaxDropDownItems = 4;
            this.cmbPrioridad.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(181, 49);
            this.cmbPrioridad.StartIndex = 0;
            this.cmbPrioridad.TabIndex = 34;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(157, 160);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(388, 50);
            this.txtDireccion.TabIndex = 35;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(552, 104);
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
            // OrdenDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 674);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreApellidoRazonSocial);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtTiempoFinalizacionEstimado);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblFechaEntrada);
            this.Name = "OrdenDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox txtTiempoFinalizacionEstimado;
        private MaterialSkin.Controls.MaterialTextBox txtNombreApellidoRazonSocial;
        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private System.Windows.Forms.ColumnHeader columnPrecio;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialComboBox cmbPrioridad;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
    }
}