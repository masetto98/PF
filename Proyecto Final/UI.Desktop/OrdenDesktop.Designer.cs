
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
            this.lblIdCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaEntrada = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellido = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblTiempoEntregaEstimado = new MaterialSkin.Controls.MaterialLabel();
            this.lblTiempoEntregaReal = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.listItemsServicio = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnServicio = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPrenda = new System.Windows.Forms.ColumnHeader();
            this.lblServicios = new MaterialSkin.Controls.MaterialLabel();
            this.cmbServicios = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAgregarItemOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTipoPrenda = new MaterialSkin.Controls.MaterialLabel();
            this.cmbTipoPrenda = new MaterialSkin.Controls.MaterialComboBox();
            this.lblItemsOrden = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaSalida = new MaterialSkin.Controls.MaterialLabel();
            this.txtTiempoFinalizacionReal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTiempoFinalizacionEstimado = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblIdCliente.Depth = 0;
            this.lblIdCliente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIdCliente.Location = new System.Drawing.Point(767, 107);
            this.lblIdCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(70, 19);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "Id Cliente:";
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFechaEntrada.Depth = 0;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFechaEntrada.Location = new System.Drawing.Point(21, 167);
            this.lblFechaEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(125, 19);
            this.lblFechaEntrada.TabIndex = 1;
            this.lblFechaEntrada.Text = "Fecha de ingreso:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNombre.Location = new System.Drawing.Point(251, 107);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblApellido.Depth = 0;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblApellido.Location = new System.Drawing.Point(512, 107);
            this.lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 19);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.AnimateReadOnly = false;
            this.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCliente.Depth = 0;
            this.txtIdCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIdCliente.LeadingIcon = null;
            this.txtIdCliente.Location = new System.Drawing.Point(843, 76);
            this.txtIdCliente.MaxLength = 50;
            this.txtIdCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdCliente.Multiline = false;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(53, 50);
            this.txtIdCliente.TabIndex = 4;
            this.txtIdCliente.Text = "";
            this.txtIdCliente.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(328, 76);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 50);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(580, 76);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 50);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaIngreso.Location = new System.Drawing.Point(161, 162);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(277, 24);
            this.dtpFechaIngreso.TabIndex = 7;
            // 
            // lblTiempoEntregaEstimado
            // 
            this.lblTiempoEntregaEstimado.AutoSize = true;
            this.lblTiempoEntregaEstimado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTiempoEntregaEstimado.Depth = 0;
            this.lblTiempoEntregaEstimado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTiempoEntregaEstimado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTiempoEntregaEstimado.Location = new System.Drawing.Point(456, 228);
            this.lblTiempoEntregaEstimado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTiempoEntregaEstimado.Name = "lblTiempoEntregaEstimado";
            this.lblTiempoEntregaEstimado.Size = new System.Drawing.Size(205, 19);
            this.lblTiempoEntregaEstimado.TabIndex = 8;
            this.lblTiempoEntregaEstimado.Text = "Tiempo de finalizacion real : ";
            // 
            // lblTiempoEntregaReal
            // 
            this.lblTiempoEntregaReal.AutoSize = true;
            this.lblTiempoEntregaReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTiempoEntregaReal.Depth = 0;
            this.lblTiempoEntregaReal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTiempoEntregaReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTiempoEntregaReal.Location = new System.Drawing.Point(456, 167);
            this.lblTiempoEntregaReal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTiempoEntregaReal.Name = "lblTiempoEntregaReal";
            this.lblTiempoEntregaReal.Size = new System.Drawing.Size(245, 19);
            this.lblTiempoEntregaReal.TabIndex = 9;
            this.lblTiempoEntregaReal.Text = "Tiempo de finalizacion estimado : ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEstado.Location = new System.Drawing.Point(22, 291);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 19);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFechaSalida.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaSalida.Location = new System.Drawing.Point(161, 223);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(277, 24);
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
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Location = new System.Drawing.Point(161, 261);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(224, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 13;
            // 
            // listItemsServicio
            // 
            this.listItemsServicio.AutoSizeTable = false;
            this.listItemsServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listItemsServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listItemsServicio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnServicio,
            this.columnTipoPrenda});
            this.listItemsServicio.Depth = 0;
            this.listItemsServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listItemsServicio.FullRowSelect = true;
            this.listItemsServicio.HideSelection = false;
            this.listItemsServicio.Location = new System.Drawing.Point(42, 431);
            this.listItemsServicio.MinimumSize = new System.Drawing.Size(200, 100);
            this.listItemsServicio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listItemsServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.listItemsServicio.Name = "listItemsServicio";
            this.listItemsServicio.OwnerDraw = true;
            this.listItemsServicio.Size = new System.Drawing.Size(729, 191);
            this.listItemsServicio.TabIndex = 14;
            this.listItemsServicio.UseCompatibleStateImageBehavior = false;
            this.listItemsServicio.View = System.Windows.Forms.View.Details;
            // 
            // columnNro
            // 
            this.columnNro.Text = "Nro Item";
            this.columnNro.Width = 100;
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 100;
            // 
            // columnTipoPrenda
            // 
            this.columnTipoPrenda.Text = "Tipo de Prenda";
            this.columnTipoPrenda.Width = 150;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblServicios.Depth = 0;
            this.lblServicios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblServicios.Location = new System.Drawing.Point(42, 403);
            this.lblServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(69, 19);
            this.lblServicios.TabIndex = 15;
            this.lblServicios.Text = "Servicios:";
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
            this.cmbServicios.IntegralHeight = false;
            this.cmbServicios.ItemHeight = 43;
            this.cmbServicios.Location = new System.Drawing.Point(117, 373);
            this.cmbServicios.MaxDropDownItems = 4;
            this.cmbServicios.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(204, 49);
            this.cmbServicios.StartIndex = 0;
            this.cmbServicios.TabIndex = 16;
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
            this.btnAgregarItemOrden.Location = new System.Drawing.Point(683, 379);
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
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(788, 586);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(683, 679);
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
            this.btnCancelar.Location = new System.Drawing.Point(788, 679);
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
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCuit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCuit.Location = new System.Drawing.Point(22, 107);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(39, 17);
            this.lblCuit.TabIndex = 21;
            this.lblCuit.Text = "Cuit: ";
            // 
            // txtCuit
            // 
            this.txtCuit.AnimateReadOnly = false;
            this.txtCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuit.Depth = 0;
            this.txtCuit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCuit.LeadingIcon = null;
            this.txtCuit.Location = new System.Drawing.Point(67, 76);
            this.txtCuit.MaxLength = 50;
            this.txtCuit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuit.Multiline = false;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(160, 50);
            this.txtCuit.TabIndex = 22;
            this.txtCuit.Text = "";
            this.txtCuit.TrailingIcon = null;
            this.txtCuit.Leave += new System.EventHandler(this.txtCuit_Leave);
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTipoPrenda.Depth = 0;
            this.lblTipoPrenda.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTipoPrenda.Location = new System.Drawing.Point(343, 396);
            this.lblTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(95, 19);
            this.lblTipoPrenda.TabIndex = 23;
            this.lblTipoPrenda.Text = "Tipo Prenda: ";
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
            this.cmbTipoPrenda.IntegralHeight = false;
            this.cmbTipoPrenda.ItemHeight = 43;
            this.cmbTipoPrenda.Location = new System.Drawing.Point(441, 373);
            this.cmbTipoPrenda.MaxDropDownItems = 4;
            this.cmbTipoPrenda.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoPrenda.Name = "cmbTipoPrenda";
            this.cmbTipoPrenda.Size = new System.Drawing.Size(220, 49);
            this.cmbTipoPrenda.StartIndex = 0;
            this.cmbTipoPrenda.TabIndex = 24;
            // 
            // lblItemsOrden
            // 
            this.lblItemsOrden.AutoSize = true;
            this.lblItemsOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblItemsOrden.Depth = 0;
            this.lblItemsOrden.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblItemsOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblItemsOrden.Location = new System.Drawing.Point(21, 336);
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
            this.lblFechaSalida.Location = new System.Drawing.Point(22, 228);
            this.lblFechaSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(120, 19);
            this.lblFechaSalida.TabIndex = 26;
            this.lblFechaSalida.Text = "Fecha de salida: ";
            // 
            // txtTiempoFinalizacionReal
            // 
            this.txtTiempoFinalizacionReal.AnimateReadOnly = false;
            this.txtTiempoFinalizacionReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTiempoFinalizacionReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempoFinalizacionReal.Depth = 0;
            this.txtTiempoFinalizacionReal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempoFinalizacionReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTiempoFinalizacionReal.LeadingIcon = null;
            this.txtTiempoFinalizacionReal.Location = new System.Drawing.Point(707, 197);
            this.txtTiempoFinalizacionReal.MaxLength = 50;
            this.txtTiempoFinalizacionReal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempoFinalizacionReal.Multiline = false;
            this.txtTiempoFinalizacionReal.Name = "txtTiempoFinalizacionReal";
            this.txtTiempoFinalizacionReal.Size = new System.Drawing.Size(189, 50);
            this.txtTiempoFinalizacionReal.TabIndex = 27;
            this.txtTiempoFinalizacionReal.Text = "";
            this.txtTiempoFinalizacionReal.TrailingIcon = null;
            // 
            // txtTiempoFinalizacionEstimado
            // 
            this.txtTiempoFinalizacionEstimado.AnimateReadOnly = false;
            this.txtTiempoFinalizacionEstimado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTiempoFinalizacionEstimado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempoFinalizacionEstimado.Depth = 0;
            this.txtTiempoFinalizacionEstimado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempoFinalizacionEstimado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTiempoFinalizacionEstimado.LeadingIcon = null;
            this.txtTiempoFinalizacionEstimado.Location = new System.Drawing.Point(707, 141);
            this.txtTiempoFinalizacionEstimado.MaxLength = 50;
            this.txtTiempoFinalizacionEstimado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempoFinalizacionEstimado.Multiline = false;
            this.txtTiempoFinalizacionEstimado.Name = "txtTiempoFinalizacionEstimado";
            this.txtTiempoFinalizacionEstimado.Size = new System.Drawing.Size(189, 50);
            this.txtTiempoFinalizacionEstimado.TabIndex = 28;
            this.txtTiempoFinalizacionEstimado.Text = "";
            this.txtTiempoFinalizacionEstimado.TrailingIcon = null;
            // 
            // OrdenDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 724);
            this.Controls.Add(this.txtTiempoFinalizacionEstimado);
            this.Controls.Add(this.txtTiempoFinalizacionReal);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblItemsOrden);
            this.Controls.Add(this.cmbTipoPrenda);
            this.Controls.Add(this.lblTipoPrenda);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarItemOrden);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.listItemsServicio);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTiempoEntregaReal);
            this.Controls.Add(this.lblTiempoEntregaEstimado);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaEntrada);
            this.Controls.Add(this.lblIdCliente);
            this.Name = "OrdenDesktop";
            this.Text = "Nueva Orden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdCliente;
        private MaterialSkin.Controls.MaterialLabel lblFechaEntrada;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialTextBox txtIdCliente;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblTiempoEntregaEstimado;
        private MaterialSkin.Controls.MaterialLabel lblTiempoEntregaReal;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private MaterialSkin.Controls.MaterialComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialListView listItemsServicio;
        private MaterialSkin.Controls.MaterialLabel lblServicios;
        private MaterialSkin.Controls.MaterialComboBox cmbServicios;
        private MaterialSkin.Controls.MaterialButton btnAgregarItemOrden;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private System.Windows.Forms.Label lblCuit;
        private MaterialSkin.Controls.MaterialTextBox txtCuit;
        private System.Windows.Forms.ColumnHeader columnNro;
        private System.Windows.Forms.ColumnHeader columnServicio;
        private MaterialSkin.Controls.MaterialLabel lblTipoPrenda;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoPrenda;
        private System.Windows.Forms.ColumnHeader columnTipoPrenda;
        private MaterialSkin.Controls.MaterialLabel lblItemsOrden;
        private MaterialSkin.Controls.MaterialLabel lblFechaSalida;
        private MaterialSkin.Controls.MaterialTextBox txtTiempoFinalizacionReal;
        private MaterialSkin.Controls.MaterialTextBox txtTiempoFinalizacionEstimado;
    }
}