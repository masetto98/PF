
namespace UI.Desktop
{
    partial class Clientes
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
            this.listClientes = new MaterialSkin.Controls.MaterialListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnCuit = new System.Windows.Forms.ColumnHeader();
            this.columnNombre = new System.Windows.Forms.ColumnHeader();
            this.columnApellido = new System.Windows.Forms.ColumnHeader();
            this.columnRazonSocial = new System.Windows.Forms.ColumnHeader();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblOrdenesRealizadas = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.listOrdenes = new MaterialSkin.Controls.MaterialListView();
            this.columnNroOrden = new System.Windows.Forms.ColumnHeader();
            this.columnFechaEntrada = new System.Windows.Forms.ColumnHeader();
            this.columnValor = new System.Windows.Forms.ColumnHeader();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnVerOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.listPagos = new MaterialSkin.Controls.MaterialListView();
            this.columnFecha = new System.Windows.Forms.ColumnHeader();
            this.columnImporte = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPago = new System.Windows.Forms.ColumnHeader();
            this.btnPagos = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBuscar = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listClientes
            // 
            this.listClientes.AutoSizeTable = false;
            this.listClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnCuit,
            this.columnNombre,
            this.columnApellido,
            this.columnRazonSocial});
            this.listClientes.Depth = 0;
            this.listClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listClientes.FullRowSelect = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(16, 133);
            this.listClientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listClientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listClientes.Name = "listClientes";
            this.listClientes.OwnerDraw = true;
            this.listClientes.Size = new System.Drawing.Size(511, 406);
            this.listClientes.TabIndex = 0;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            this.listClientes.DoubleClick += new System.EventHandler(this.listClientes_DoubleClick);
            this.listClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listClientes_MouseClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnCuit
            // 
            this.columnCuit.Text = "Cuit";
            this.columnCuit.Width = 100;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 100;
            // 
            // columnApellido
            // 
            this.columnApellido.Text = "Apellido";
            this.columnApellido.Width = 100;
            // 
            // columnRazonSocial
            // 
            this.columnRazonSocial.Text = "Razón Social";
            this.columnRazonSocial.Width = 150;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditar.Location = new System.Drawing.Point(139, 88);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(99, 36);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminar.Location = new System.Drawing.Point(246, 88);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(116, 36);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregar.Location = new System.Drawing.Point(16, 88);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(115, 36);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDetalles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetalles.Depth = 0;
            this.btnDetalles.Enabled = false;
            this.btnDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetalles.HighEmphasis = true;
            this.btnDetalles.Icon = null;
            this.btnDetalles.Location = new System.Drawing.Point(544, 133);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(91, 36);
            this.btnDetalles.TabIndex = 12;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblOrdenesRealizadas);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(944, 88);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(351, 134);
            this.materialCard1.TabIndex = 13;
            // 
            // lblOrdenesRealizadas
            // 
            this.lblOrdenesRealizadas.AutoSize = true;
            this.lblOrdenesRealizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblOrdenesRealizadas.Depth = 0;
            this.lblOrdenesRealizadas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOrdenesRealizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrdenesRealizadas.Location = new System.Drawing.Point(156, 38);
            this.lblOrdenesRealizadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenesRealizadas.Name = "lblOrdenesRealizadas";
            this.lblOrdenesRealizadas.Size = new System.Drawing.Size(5, 19);
            this.lblOrdenesRealizadas.TabIndex = 2;
            this.lblOrdenesRealizadas.Text = "-";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 39);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(140, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Ordenes realizadas:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Estadisticas";
            // 
            // listOrdenes
            // 
            this.listOrdenes.AutoSizeTable = false;
            this.listOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNroOrden,
            this.columnFechaEntrada,
            this.columnValor});
            this.listOrdenes.Depth = 0;
            this.listOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenes.FullRowSelect = true;
            this.listOrdenes.HideSelection = false;
            this.listOrdenes.Location = new System.Drawing.Point(544, 197);
            this.listOrdenes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.OwnerDraw = true;
            this.listOrdenes.Size = new System.Drawing.Size(392, 295);
            this.listOrdenes.TabIndex = 14;
            this.listOrdenes.UseCompatibleStateImageBehavior = false;
            this.listOrdenes.View = System.Windows.Forms.View.Details;
            this.listOrdenes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listOrdenes_MouseClick);
            // 
            // columnNroOrden
            // 
            this.columnNroOrden.Text = "N° Orden";
            this.columnNroOrden.Width = 100;
            // 
            // columnFechaEntrada
            // 
            this.columnFechaEntrada.Text = "FechaEntrada";
            this.columnFechaEntrada.Width = 190;
            // 
            // columnValor
            // 
            this.columnValor.Text = "Valor";
            this.columnValor.Width = 100;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(546, 175);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Ordenes";
            // 
            // btnVerOrden
            // 
            this.btnVerOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVerOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerOrden.Depth = 0;
            this.btnVerOrden.Enabled = false;
            this.btnVerOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerOrden.HighEmphasis = true;
            this.btnVerOrden.Icon = null;
            this.btnVerOrden.Location = new System.Drawing.Point(837, 503);
            this.btnVerOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerOrden.Name = "btnVerOrden";
            this.btnVerOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerOrden.Size = new System.Drawing.Size(100, 36);
            this.btnVerOrden.TabIndex = 16;
            this.btnVerOrden.Text = "Ver Orden";
            this.btnVerOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerOrden.UseAccentColor = false;
            this.btnVerOrden.UseVisualStyleBackColor = false;
            this.btnVerOrden.Click += new System.EventHandler(this.btnVerOrden_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.HighEmphasis = true;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(1218, 548);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // listPagos
            // 
            this.listPagos.AutoSizeTable = false;
            this.listPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFecha,
            this.columnImporte,
            this.columnTipoPago});
            this.listPagos.Depth = 0;
            this.listPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listPagos.FullRowSelect = true;
            this.listPagos.HideSelection = false;
            this.listPagos.Location = new System.Drawing.Point(944, 298);
            this.listPagos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listPagos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listPagos.MouseState = MaterialSkin.MouseState.OUT;
            this.listPagos.Name = "listPagos";
            this.listPagos.OwnerDraw = true;
            this.listPagos.Size = new System.Drawing.Size(351, 241);
            this.listPagos.TabIndex = 18;
            this.listPagos.UseCompatibleStateImageBehavior = false;
            this.listPagos.View = System.Windows.Forms.View.Details;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.Width = 150;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Importe";
            this.columnImporte.Width = 100;
            // 
            // columnTipoPago
            // 
            this.columnTipoPago.Text = "Tipo";
            this.columnTipoPago.Width = 100;
            // 
            // btnPagos
            // 
            this.btnPagos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPagos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPagos.Depth = 0;
            this.btnPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPagos.HighEmphasis = true;
            this.btnPagos.Icon = null;
            this.btnPagos.Location = new System.Drawing.Point(944, 231);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPagos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPagos.Size = new System.Drawing.Size(100, 36);
            this.btnPagos.TabIndex = 19;
            this.btnPagos.Text = "Ver Pagos";
            this.btnPagos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPagos.UseAccentColor = false;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(944, 273);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(128, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Pagos de la orden";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(16, 558);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(58, 19);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Buscar: ";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoResize = false;
            this.cmbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbBuscar.Depth = 0;
            this.cmbBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBuscar.DropDownHeight = 174;
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.DropDownWidth = 121;
            this.cmbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.IntegralHeight = false;
            this.cmbBuscar.ItemHeight = 43;
            this.cmbBuscar.Location = new System.Drawing.Point(81, 546);
            this.cmbBuscar.MaxDropDownItems = 4;
            this.cmbBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(170, 49);
            this.cmbBuscar.StartIndex = 0;
            this.cmbBuscar.TabIndex = 22;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscar.Hint = "Buscar";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(257, 546);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(270, 50);
            this.txtBuscar.TabIndex = 23;
            this.txtBuscar.Text = "";
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 682);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.listPagos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerOrden);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.listOrdenes);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listClientes;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnCuit;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnApellido;
        private System.Windows.Forms.ColumnHeader columnRazonSocial;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView listOrdenes;
        private System.Windows.Forms.ColumnHeader columnNroOrden;
        private System.Windows.Forms.ColumnHeader columnFechaEntrada;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnVerOrden;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialLabel lblOrdenesRealizadas;
        private MaterialSkin.Controls.MaterialListView listPagos;
        private MaterialSkin.Controls.MaterialButton btnPagos;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private System.Windows.Forms.ColumnHeader columnTipoPago;
        private System.Windows.Forms.ColumnHeader columnValor;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cmbBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
    }
}