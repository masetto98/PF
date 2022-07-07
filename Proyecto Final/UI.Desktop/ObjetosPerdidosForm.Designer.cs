
namespace UI.Desktop
{
    partial class ObjetosPerdidosForm
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
            this.txtCuit = new MaterialSkin.Controls.MaterialTextBox();
            this.listOrdenesCliente = new MaterialSkin.Controls.MaterialListView();
            this.ColumnOrden = new System.Windows.Forms.ColumnHeader();
            this.ColumnFecha = new System.Windows.Forms.ColumnHeader();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.listItemsPedidos = new MaterialSkin.Controls.MaterialListView();
            this.ColumnServicio = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPrenda = new System.Windows.Forms.ColumnHeader();
            this.columnItem = new System.Windows.Forms.ColumnHeader();
            this.columnEstado = new System.Windows.Forms.ColumnHeader();
            this.btnVerItems = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreApellidoEmpleadoAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIdEmpleadoAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreApellidoRazonSocialAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.txtServicioTipoPrendaAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccionAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefonoAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCuitClienteAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOrdenItemAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNroOrdenAnterior = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPedidoAnterior = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.txtNombreApellidoEmpleadoSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIDEmpleadoSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreApellidoRazonSocialSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtServicioTipoPrendaSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccionSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstadoSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefonoSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOrdenItemSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCuitClienteSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNroOrdenSiguiente = new MaterialSkin.Controls.MaterialTextBox();
            this.lblItemPosterior = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroOrden = new MaterialSkin.Controls.MaterialTextBox();
            this.btnTrazarPedidos = new MaterialSkin.Controls.MaterialButton();
            this.listMaquinasItems = new MaterialSkin.Controls.MaterialListView();
            this.columnMaquina = new System.Windows.Forms.ColumnHeader();
            this.columnFechaHora = new System.Windows.Forms.ColumnHeader();
            this.btnVerServiciosRealizados = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreApellidoRazonSocial = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.AnimateReadOnly = false;
            this.txtCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuit.Depth = 0;
            this.txtCuit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCuit.Hint = "Cuit";
            this.txtCuit.LeadingIcon = null;
            this.txtCuit.Location = new System.Drawing.Point(13, 84);
            this.txtCuit.MaxLength = 50;
            this.txtCuit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuit.Multiline = false;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(152, 50);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.Text = "";
            this.txtCuit.TrailingIcon = null;
            // 
            // listOrdenesCliente
            // 
            this.listOrdenesCliente.AutoSizeTable = false;
            this.listOrdenesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenesCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenesCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnOrden,
            this.ColumnFecha});
            this.listOrdenesCliente.Depth = 0;
            this.listOrdenesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenesCliente.FullRowSelect = true;
            this.listOrdenesCliente.HideSelection = false;
            this.listOrdenesCliente.Location = new System.Drawing.Point(13, 172);
            this.listOrdenesCliente.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenesCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenesCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenesCliente.MultiSelect = false;
            this.listOrdenesCliente.Name = "listOrdenesCliente";
            this.listOrdenesCliente.OwnerDraw = true;
            this.listOrdenesCliente.Size = new System.Drawing.Size(200, 459);
            this.listOrdenesCliente.TabIndex = 1;
            this.listOrdenesCliente.UseCompatibleStateImageBehavior = false;
            this.listOrdenesCliente.View = System.Windows.Forms.View.Details;
            this.listOrdenesCliente.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listOrdenesCliente_ColumnWidthChanging);
            // 
            // ColumnOrden
            // 
            this.ColumnOrden.Text = "Orden";
            this.ColumnOrden.Width = 70;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.Text = "Fecha entrada";
            this.ColumnFecha.Width = 130;
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
            this.txtDireccion.Location = new System.Drawing.Point(399, 84);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(171, 50);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // listItemsPedidos
            // 
            this.listItemsPedidos.AutoSizeTable = false;
            this.listItemsPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listItemsPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listItemsPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnServicio,
            this.columnTipoPrenda,
            this.columnItem,
            this.columnEstado});
            this.listItemsPedidos.Depth = 0;
            this.listItemsPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listItemsPedidos.FullRowSelect = true;
            this.listItemsPedidos.HideSelection = false;
            this.listItemsPedidos.Location = new System.Drawing.Point(219, 249);
            this.listItemsPedidos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listItemsPedidos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listItemsPedidos.MouseState = MaterialSkin.MouseState.OUT;
            this.listItemsPedidos.MultiSelect = false;
            this.listItemsPedidos.Name = "listItemsPedidos";
            this.listItemsPedidos.OwnerDraw = true;
            this.listItemsPedidos.Size = new System.Drawing.Size(435, 138);
            this.listItemsPedidos.TabIndex = 6;
            this.listItemsPedidos.UseCompatibleStateImageBehavior = false;
            this.listItemsPedidos.View = System.Windows.Forms.View.Details;
            this.listItemsPedidos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listItemsPedidos_ColumnWidthChanging);
            // 
            // ColumnServicio
            // 
            this.ColumnServicio.Text = "Servicio";
            this.ColumnServicio.Width = 120;
            // 
            // columnTipoPrenda
            // 
            this.columnTipoPrenda.Text = "Prenda";
            this.columnTipoPrenda.Width = 135;
            // 
            // columnItem
            // 
            this.columnItem.Text = "Item";
            this.columnItem.Width = 70;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 110;
            // 
            // btnVerItems
            // 
            this.btnVerItems.AutoSize = false;
            this.btnVerItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVerItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerItems.Depth = 0;
            this.btnVerItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerItems.HighEmphasis = true;
            this.btnVerItems.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnVerItems.Location = new System.Drawing.Point(327, 172);
            this.btnVerItems.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerItems.Name = "btnVerItems";
            this.btnVerItems.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerItems.Size = new System.Drawing.Size(114, 51);
            this.btnVerItems.TabIndex = 7;
            this.btnVerItems.Text = "Detalles orden";
            this.btnVerItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerItems.UseAccentColor = false;
            this.btnVerItems.UseVisualStyleBackColor = false;
            this.btnVerItems.Click += new System.EventHandler(this.btnVerItems_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.txtNombreApellidoEmpleadoAnterior);
            this.materialCard1.Controls.Add(this.txtIdEmpleadoAnterior);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.txtNombreApellidoRazonSocialAnterior);
            this.materialCard1.Controls.Add(this.txtServicioTipoPrendaAnterior);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txtDireccionAnterior);
            this.materialCard1.Controls.Add(this.txtTelefonoAnterior);
            this.materialCard1.Controls.Add(this.txtEstado);
            this.materialCard1.Controls.Add(this.txtCuitClienteAnterior);
            this.materialCard1.Controls.Add(this.txtOrdenItemAnterior);
            this.materialCard1.Controls.Add(this.txtNroOrdenAnterior);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(668, 108);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(685, 250);
            this.materialCard1.TabIndex = 8;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(5, 6);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(133, 19);
            this.materialLabel9.TabIndex = 27;
            this.materialLabel9.Text = "Datos de la orden: ";
            // 
            // txtNombreApellidoEmpleadoAnterior
            // 
            this.txtNombreApellidoEmpleadoAnterior.AnimateReadOnly = false;
            this.txtNombreApellidoEmpleadoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombreApellidoEmpleadoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreApellidoEmpleadoAnterior.Depth = 0;
            this.txtNombreApellidoEmpleadoAnterior.Enabled = false;
            this.txtNombreApellidoEmpleadoAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreApellidoEmpleadoAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreApellidoEmpleadoAnterior.Hint = "Nombre y Apellido";
            this.txtNombreApellidoEmpleadoAnterior.LeadingIcon = null;
            this.txtNombreApellidoEmpleadoAnterior.Location = new System.Drawing.Point(71, 111);
            this.txtNombreApellidoEmpleadoAnterior.MaxLength = 50;
            this.txtNombreApellidoEmpleadoAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreApellidoEmpleadoAnterior.Multiline = false;
            this.txtNombreApellidoEmpleadoAnterior.Name = "txtNombreApellidoEmpleadoAnterior";
            this.txtNombreApellidoEmpleadoAnterior.Size = new System.Drawing.Size(347, 50);
            this.txtNombreApellidoEmpleadoAnterior.TabIndex = 29;
            this.txtNombreApellidoEmpleadoAnterior.Text = "";
            this.txtNombreApellidoEmpleadoAnterior.TrailingIcon = null;
            // 
            // txtIdEmpleadoAnterior
            // 
            this.txtIdEmpleadoAnterior.AnimateReadOnly = false;
            this.txtIdEmpleadoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtIdEmpleadoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEmpleadoAnterior.Depth = 0;
            this.txtIdEmpleadoAnterior.Enabled = false;
            this.txtIdEmpleadoAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEmpleadoAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdEmpleadoAnterior.Hint = "ID";
            this.txtIdEmpleadoAnterior.LeadingIcon = null;
            this.txtIdEmpleadoAnterior.Location = new System.Drawing.Point(6, 111);
            this.txtIdEmpleadoAnterior.MaxLength = 50;
            this.txtIdEmpleadoAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdEmpleadoAnterior.Multiline = false;
            this.txtIdEmpleadoAnterior.Name = "txtIdEmpleadoAnterior";
            this.txtIdEmpleadoAnterior.Size = new System.Drawing.Size(59, 50);
            this.txtIdEmpleadoAnterior.TabIndex = 28;
            this.txtIdEmpleadoAnterior.Text = "";
            this.txtIdEmpleadoAnterior.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 87);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(150, 19);
            this.materialLabel8.TabIndex = 27;
            this.materialLabel8.Text = "Datos del empleado: ";
            // 
            // txtNombreApellidoRazonSocialAnterior
            // 
            this.txtNombreApellidoRazonSocialAnterior.AnimateReadOnly = false;
            this.txtNombreApellidoRazonSocialAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombreApellidoRazonSocialAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreApellidoRazonSocialAnterior.Depth = 0;
            this.txtNombreApellidoRazonSocialAnterior.Enabled = false;
            this.txtNombreApellidoRazonSocialAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreApellidoRazonSocialAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreApellidoRazonSocialAnterior.Hint = "Nombre y Apellido / Razón Social";
            this.txtNombreApellidoRazonSocialAnterior.LeadingIcon = null;
            this.txtNombreApellidoRazonSocialAnterior.Location = new System.Drawing.Point(145, 188);
            this.txtNombreApellidoRazonSocialAnterior.MaxLength = 50;
            this.txtNombreApellidoRazonSocialAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreApellidoRazonSocialAnterior.Multiline = false;
            this.txtNombreApellidoRazonSocialAnterior.Name = "txtNombreApellidoRazonSocialAnterior";
            this.txtNombreApellidoRazonSocialAnterior.Size = new System.Drawing.Size(203, 50);
            this.txtNombreApellidoRazonSocialAnterior.TabIndex = 22;
            this.txtNombreApellidoRazonSocialAnterior.Text = "";
            this.txtNombreApellidoRazonSocialAnterior.TrailingIcon = null;
            // 
            // txtServicioTipoPrendaAnterior
            // 
            this.txtServicioTipoPrendaAnterior.AnimateReadOnly = false;
            this.txtServicioTipoPrendaAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtServicioTipoPrendaAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicioTipoPrendaAnterior.Depth = 0;
            this.txtServicioTipoPrendaAnterior.Enabled = false;
            this.txtServicioTipoPrendaAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServicioTipoPrendaAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtServicioTipoPrendaAnterior.Hint = "Servicio - Tipo de Prenda";
            this.txtServicioTipoPrendaAnterior.LeadingIcon = null;
            this.txtServicioTipoPrendaAnterior.Location = new System.Drawing.Point(80, 28);
            this.txtServicioTipoPrendaAnterior.MaxLength = 50;
            this.txtServicioTipoPrendaAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServicioTipoPrendaAnterior.Multiline = false;
            this.txtServicioTipoPrendaAnterior.Name = "txtServicioTipoPrendaAnterior";
            this.txtServicioTipoPrendaAnterior.Size = new System.Drawing.Size(268, 50);
            this.txtServicioTipoPrendaAnterior.TabIndex = 14;
            this.txtServicioTipoPrendaAnterior.Text = "";
            this.txtServicioTipoPrendaAnterior.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 164);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Datos del cliente: ";
            // 
            // txtDireccionAnterior
            // 
            this.txtDireccionAnterior.AnimateReadOnly = false;
            this.txtDireccionAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtDireccionAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionAnterior.Depth = 0;
            this.txtDireccionAnterior.Enabled = false;
            this.txtDireccionAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccionAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDireccionAnterior.Hint = "Direccion";
            this.txtDireccionAnterior.LeadingIcon = null;
            this.txtDireccionAnterior.Location = new System.Drawing.Point(530, 188);
            this.txtDireccionAnterior.MaxLength = 50;
            this.txtDireccionAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccionAnterior.Multiline = false;
            this.txtDireccionAnterior.Name = "txtDireccionAnterior";
            this.txtDireccionAnterior.Size = new System.Drawing.Size(144, 50);
            this.txtDireccionAnterior.TabIndex = 11;
            this.txtDireccionAnterior.Text = "";
            this.txtDireccionAnterior.TrailingIcon = null;
            // 
            // txtTelefonoAnterior
            // 
            this.txtTelefonoAnterior.AnimateReadOnly = false;
            this.txtTelefonoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTelefonoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoAnterior.Depth = 0;
            this.txtTelefonoAnterior.Enabled = false;
            this.txtTelefonoAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefonoAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTelefonoAnterior.Hint = "Telefono";
            this.txtTelefonoAnterior.LeadingIcon = null;
            this.txtTelefonoAnterior.Location = new System.Drawing.Point(354, 188);
            this.txtTelefonoAnterior.MaxLength = 50;
            this.txtTelefonoAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefonoAnterior.Multiline = false;
            this.txtTelefonoAnterior.Name = "txtTelefonoAnterior";
            this.txtTelefonoAnterior.Size = new System.Drawing.Size(170, 50);
            this.txtTelefonoAnterior.TabIndex = 10;
            this.txtTelefonoAnterior.Text = "";
            this.txtTelefonoAnterior.TrailingIcon = null;
            // 
            // txtEstado
            // 
            this.txtEstado.AnimateReadOnly = false;
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEstado.Hint = "Estado";
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(450, 28);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(179, 50);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // txtCuitClienteAnterior
            // 
            this.txtCuitClienteAnterior.AnimateReadOnly = false;
            this.txtCuitClienteAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCuitClienteAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuitClienteAnterior.Depth = 0;
            this.txtCuitClienteAnterior.Enabled = false;
            this.txtCuitClienteAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuitClienteAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCuitClienteAnterior.Hint = "Cuit";
            this.txtCuitClienteAnterior.LeadingIcon = null;
            this.txtCuitClienteAnterior.Location = new System.Drawing.Point(5, 188);
            this.txtCuitClienteAnterior.MaxLength = 50;
            this.txtCuitClienteAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuitClienteAnterior.Multiline = false;
            this.txtCuitClienteAnterior.Name = "txtCuitClienteAnterior";
            this.txtCuitClienteAnterior.Size = new System.Drawing.Size(132, 50);
            this.txtCuitClienteAnterior.TabIndex = 5;
            this.txtCuitClienteAnterior.Text = "";
            this.txtCuitClienteAnterior.TrailingIcon = null;
            // 
            // txtOrdenItemAnterior
            // 
            this.txtOrdenItemAnterior.AnimateReadOnly = false;
            this.txtOrdenItemAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtOrdenItemAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrdenItemAnterior.Depth = 0;
            this.txtOrdenItemAnterior.Enabled = false;
            this.txtOrdenItemAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrdenItemAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOrdenItemAnterior.Hint = "Nro Item";
            this.txtOrdenItemAnterior.LeadingIcon = null;
            this.txtOrdenItemAnterior.Location = new System.Drawing.Point(354, 28);
            this.txtOrdenItemAnterior.MaxLength = 50;
            this.txtOrdenItemAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOrdenItemAnterior.Multiline = false;
            this.txtOrdenItemAnterior.Name = "txtOrdenItemAnterior";
            this.txtOrdenItemAnterior.Size = new System.Drawing.Size(90, 50);
            this.txtOrdenItemAnterior.TabIndex = 4;
            this.txtOrdenItemAnterior.Text = "";
            this.txtOrdenItemAnterior.TrailingIcon = null;
            // 
            // txtNroOrdenAnterior
            // 
            this.txtNroOrdenAnterior.AnimateReadOnly = false;
            this.txtNroOrdenAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNroOrdenAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroOrdenAnterior.Depth = 0;
            this.txtNroOrdenAnterior.Enabled = false;
            this.txtNroOrdenAnterior.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroOrdenAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNroOrdenAnterior.Hint = "Orden";
            this.txtNroOrdenAnterior.LeadingIcon = null;
            this.txtNroOrdenAnterior.Location = new System.Drawing.Point(5, 28);
            this.txtNroOrdenAnterior.MaxLength = 50;
            this.txtNroOrdenAnterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroOrdenAnterior.Multiline = false;
            this.txtNroOrdenAnterior.Name = "txtNroOrdenAnterior";
            this.txtNroOrdenAnterior.Size = new System.Drawing.Size(69, 50);
            this.txtNroOrdenAnterior.TabIndex = 1;
            this.txtNroOrdenAnterior.Text = "";
            this.txtNroOrdenAnterior.TrailingIcon = null;
            // 
            // lblPedidoAnterior
            // 
            this.lblPedidoAnterior.AutoSize = true;
            this.lblPedidoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblPedidoAnterior.Depth = 0;
            this.lblPedidoAnterior.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPedidoAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPedidoAnterior.Location = new System.Drawing.Point(668, 84);
            this.lblPedidoAnterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPedidoAnterior.Name = "lblPedidoAnterior";
            this.lblPedidoAnterior.Size = new System.Drawing.Size(98, 19);
            this.lblPedidoAnterior.TabIndex = 0;
            this.lblPedidoAnterior.Text = "Item anterior: ";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txtNombreApellidoEmpleadoSiguiente);
            this.materialCard2.Controls.Add(this.txtIDEmpleadoSiguiente);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.txtNombreApellidoRazonSocialSiguiente);
            this.materialCard2.Controls.Add(this.txtServicioTipoPrendaSiguiente);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.txtDireccionSiguiente);
            this.materialCard2.Controls.Add(this.txtEstadoSiguiente);
            this.materialCard2.Controls.Add(this.txtTelefonoSiguiente);
            this.materialCard2.Controls.Add(this.txtOrdenItemSiguiente);
            this.materialCard2.Controls.Add(this.txtCuitClienteSiguiente);
            this.materialCard2.Controls.Add(this.txtNroOrdenSiguiente);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(668, 391);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(684, 240);
            this.materialCard2.TabIndex = 9;
            // 
            // txtNombreApellidoEmpleadoSiguiente
            // 
            this.txtNombreApellidoEmpleadoSiguiente.AnimateReadOnly = false;
            this.txtNombreApellidoEmpleadoSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombreApellidoEmpleadoSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreApellidoEmpleadoSiguiente.Depth = 0;
            this.txtNombreApellidoEmpleadoSiguiente.Enabled = false;
            this.txtNombreApellidoEmpleadoSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreApellidoEmpleadoSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreApellidoEmpleadoSiguiente.Hint = "Nombre y Apellido";
            this.txtNombreApellidoEmpleadoSiguiente.LeadingIcon = null;
            this.txtNombreApellidoEmpleadoSiguiente.Location = new System.Drawing.Point(70, 106);
            this.txtNombreApellidoEmpleadoSiguiente.MaxLength = 50;
            this.txtNombreApellidoEmpleadoSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreApellidoEmpleadoSiguiente.Multiline = false;
            this.txtNombreApellidoEmpleadoSiguiente.Name = "txtNombreApellidoEmpleadoSiguiente";
            this.txtNombreApellidoEmpleadoSiguiente.Size = new System.Drawing.Size(347, 50);
            this.txtNombreApellidoEmpleadoSiguiente.TabIndex = 26;
            this.txtNombreApellidoEmpleadoSiguiente.Text = "";
            this.txtNombreApellidoEmpleadoSiguiente.TrailingIcon = null;
            // 
            // txtIDEmpleadoSiguiente
            // 
            this.txtIDEmpleadoSiguiente.AnimateReadOnly = false;
            this.txtIDEmpleadoSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtIDEmpleadoSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDEmpleadoSiguiente.Depth = 0;
            this.txtIDEmpleadoSiguiente.Enabled = false;
            this.txtIDEmpleadoSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDEmpleadoSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIDEmpleadoSiguiente.Hint = "ID";
            this.txtIDEmpleadoSiguiente.LeadingIcon = null;
            this.txtIDEmpleadoSiguiente.Location = new System.Drawing.Point(5, 106);
            this.txtIDEmpleadoSiguiente.MaxLength = 50;
            this.txtIDEmpleadoSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIDEmpleadoSiguiente.Multiline = false;
            this.txtIDEmpleadoSiguiente.Name = "txtIDEmpleadoSiguiente";
            this.txtIDEmpleadoSiguiente.Size = new System.Drawing.Size(59, 50);
            this.txtIDEmpleadoSiguiente.TabIndex = 24;
            this.txtIDEmpleadoSiguiente.Text = "";
            this.txtIDEmpleadoSiguiente.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(4, 84);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(150, 19);
            this.materialLabel7.TabIndex = 23;
            this.materialLabel7.Text = "Datos del empleado: ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(5, 6);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(133, 19);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "Datos de la orden: ";
            // 
            // txtNombreApellidoRazonSocialSiguiente
            // 
            this.txtNombreApellidoRazonSocialSiguiente.AnimateReadOnly = false;
            this.txtNombreApellidoRazonSocialSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombreApellidoRazonSocialSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreApellidoRazonSocialSiguiente.Depth = 0;
            this.txtNombreApellidoRazonSocialSiguiente.Enabled = false;
            this.txtNombreApellidoRazonSocialSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreApellidoRazonSocialSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreApellidoRazonSocialSiguiente.Hint = "Nombre y Apellido / Razón Social";
            this.txtNombreApellidoRazonSocialSiguiente.LeadingIcon = null;
            this.txtNombreApellidoRazonSocialSiguiente.Location = new System.Drawing.Point(144, 181);
            this.txtNombreApellidoRazonSocialSiguiente.MaxLength = 50;
            this.txtNombreApellidoRazonSocialSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreApellidoRazonSocialSiguiente.Multiline = false;
            this.txtNombreApellidoRazonSocialSiguiente.Name = "txtNombreApellidoRazonSocialSiguiente";
            this.txtNombreApellidoRazonSocialSiguiente.Size = new System.Drawing.Size(203, 50);
            this.txtNombreApellidoRazonSocialSiguiente.TabIndex = 21;
            this.txtNombreApellidoRazonSocialSiguiente.Text = "";
            this.txtNombreApellidoRazonSocialSiguiente.TrailingIcon = null;
            // 
            // txtServicioTipoPrendaSiguiente
            // 
            this.txtServicioTipoPrendaSiguiente.AnimateReadOnly = false;
            this.txtServicioTipoPrendaSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtServicioTipoPrendaSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicioTipoPrendaSiguiente.Depth = 0;
            this.txtServicioTipoPrendaSiguiente.Enabled = false;
            this.txtServicioTipoPrendaSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServicioTipoPrendaSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtServicioTipoPrendaSiguiente.Hint = "Servicio - Tipo de Prenda";
            this.txtServicioTipoPrendaSiguiente.LeadingIcon = null;
            this.txtServicioTipoPrendaSiguiente.Location = new System.Drawing.Point(79, 28);
            this.txtServicioTipoPrendaSiguiente.MaxLength = 50;
            this.txtServicioTipoPrendaSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServicioTipoPrendaSiguiente.Multiline = false;
            this.txtServicioTipoPrendaSiguiente.Name = "txtServicioTipoPrendaSiguiente";
            this.txtServicioTipoPrendaSiguiente.Size = new System.Drawing.Size(268, 50);
            this.txtServicioTipoPrendaSiguiente.TabIndex = 15;
            this.txtServicioTipoPrendaSiguiente.Text = "";
            this.txtServicioTipoPrendaSiguiente.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 159);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Datos del cliente: ";
            // 
            // txtDireccionSiguiente
            // 
            this.txtDireccionSiguiente.AnimateReadOnly = false;
            this.txtDireccionSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtDireccionSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionSiguiente.Depth = 0;
            this.txtDireccionSiguiente.Enabled = false;
            this.txtDireccionSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccionSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDireccionSiguiente.Hint = "Direccion";
            this.txtDireccionSiguiente.LeadingIcon = null;
            this.txtDireccionSiguiente.Location = new System.Drawing.Point(529, 181);
            this.txtDireccionSiguiente.MaxLength = 50;
            this.txtDireccionSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccionSiguiente.Multiline = false;
            this.txtDireccionSiguiente.Name = "txtDireccionSiguiente";
            this.txtDireccionSiguiente.Size = new System.Drawing.Size(144, 50);
            this.txtDireccionSiguiente.TabIndex = 19;
            this.txtDireccionSiguiente.Text = "";
            this.txtDireccionSiguiente.TrailingIcon = null;
            // 
            // txtEstadoSiguiente
            // 
            this.txtEstadoSiguiente.AnimateReadOnly = false;
            this.txtEstadoSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtEstadoSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoSiguiente.Depth = 0;
            this.txtEstadoSiguiente.Enabled = false;
            this.txtEstadoSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstadoSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEstadoSiguiente.Hint = "Estado";
            this.txtEstadoSiguiente.LeadingIcon = null;
            this.txtEstadoSiguiente.Location = new System.Drawing.Point(449, 28);
            this.txtEstadoSiguiente.MaxLength = 50;
            this.txtEstadoSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstadoSiguiente.Multiline = false;
            this.txtEstadoSiguiente.Name = "txtEstadoSiguiente";
            this.txtEstadoSiguiente.Size = new System.Drawing.Size(179, 50);
            this.txtEstadoSiguiente.TabIndex = 4;
            this.txtEstadoSiguiente.Text = "";
            this.txtEstadoSiguiente.TrailingIcon = null;
            // 
            // txtTelefonoSiguiente
            // 
            this.txtTelefonoSiguiente.AnimateReadOnly = false;
            this.txtTelefonoSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTelefonoSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoSiguiente.Depth = 0;
            this.txtTelefonoSiguiente.Enabled = false;
            this.txtTelefonoSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefonoSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTelefonoSiguiente.Hint = "Teléfono";
            this.txtTelefonoSiguiente.LeadingIcon = null;
            this.txtTelefonoSiguiente.Location = new System.Drawing.Point(353, 182);
            this.txtTelefonoSiguiente.MaxLength = 50;
            this.txtTelefonoSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefonoSiguiente.Multiline = false;
            this.txtTelefonoSiguiente.Name = "txtTelefonoSiguiente";
            this.txtTelefonoSiguiente.Size = new System.Drawing.Size(170, 50);
            this.txtTelefonoSiguiente.TabIndex = 18;
            this.txtTelefonoSiguiente.Text = "";
            this.txtTelefonoSiguiente.TrailingIcon = null;
            // 
            // txtOrdenItemSiguiente
            // 
            this.txtOrdenItemSiguiente.AnimateReadOnly = false;
            this.txtOrdenItemSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtOrdenItemSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrdenItemSiguiente.Depth = 0;
            this.txtOrdenItemSiguiente.Enabled = false;
            this.txtOrdenItemSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrdenItemSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOrdenItemSiguiente.Hint = "Nro Item";
            this.txtOrdenItemSiguiente.LeadingIcon = null;
            this.txtOrdenItemSiguiente.Location = new System.Drawing.Point(353, 28);
            this.txtOrdenItemSiguiente.MaxLength = 50;
            this.txtOrdenItemSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOrdenItemSiguiente.Multiline = false;
            this.txtOrdenItemSiguiente.Name = "txtOrdenItemSiguiente";
            this.txtOrdenItemSiguiente.Size = new System.Drawing.Size(90, 50);
            this.txtOrdenItemSiguiente.TabIndex = 3;
            this.txtOrdenItemSiguiente.Text = "";
            this.txtOrdenItemSiguiente.TrailingIcon = null;
            // 
            // txtCuitClienteSiguiente
            // 
            this.txtCuitClienteSiguiente.AnimateReadOnly = false;
            this.txtCuitClienteSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCuitClienteSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuitClienteSiguiente.Depth = 0;
            this.txtCuitClienteSiguiente.Enabled = false;
            this.txtCuitClienteSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuitClienteSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCuitClienteSiguiente.Hint = "Cuit";
            this.txtCuitClienteSiguiente.LeadingIcon = null;
            this.txtCuitClienteSiguiente.Location = new System.Drawing.Point(5, 181);
            this.txtCuitClienteSiguiente.MaxLength = 50;
            this.txtCuitClienteSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuitClienteSiguiente.Multiline = false;
            this.txtCuitClienteSiguiente.Name = "txtCuitClienteSiguiente";
            this.txtCuitClienteSiguiente.Size = new System.Drawing.Size(132, 50);
            this.txtCuitClienteSiguiente.TabIndex = 14;
            this.txtCuitClienteSiguiente.Text = "";
            this.txtCuitClienteSiguiente.TrailingIcon = null;
            // 
            // txtNroOrdenSiguiente
            // 
            this.txtNroOrdenSiguiente.AnimateReadOnly = false;
            this.txtNroOrdenSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNroOrdenSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroOrdenSiguiente.Depth = 0;
            this.txtNroOrdenSiguiente.Enabled = false;
            this.txtNroOrdenSiguiente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroOrdenSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNroOrdenSiguiente.Hint = "Orden";
            this.txtNroOrdenSiguiente.LeadingIcon = null;
            this.txtNroOrdenSiguiente.Location = new System.Drawing.Point(5, 29);
            this.txtNroOrdenSiguiente.MaxLength = 50;
            this.txtNroOrdenSiguiente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroOrdenSiguiente.Multiline = false;
            this.txtNroOrdenSiguiente.Name = "txtNroOrdenSiguiente";
            this.txtNroOrdenSiguiente.Size = new System.Drawing.Size(68, 50);
            this.txtNroOrdenSiguiente.TabIndex = 0;
            this.txtNroOrdenSiguiente.Text = "";
            this.txtNroOrdenSiguiente.TrailingIcon = null;
            // 
            // lblItemPosterior
            // 
            this.lblItemPosterior.AutoSize = true;
            this.lblItemPosterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblItemPosterior.Depth = 0;
            this.lblItemPosterior.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblItemPosterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemPosterior.Location = new System.Drawing.Point(668, 368);
            this.lblItemPosterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemPosterior.Name = "lblItemPosterior";
            this.lblItemPosterior.Size = new System.Drawing.Size(104, 19);
            this.lblItemPosterior.TabIndex = 0;
            this.lblItemPosterior.Text = "Item siguiente:";
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.AnimateReadOnly = false;
            this.txtNroOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNroOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroOrden.Depth = 0;
            this.txtNroOrden.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNroOrden.Hint = "Nro Orden";
            this.txtNroOrden.LeadingIcon = null;
            this.txtNroOrden.Location = new System.Drawing.Point(219, 172);
            this.txtNroOrden.MaxLength = 50;
            this.txtNroOrden.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroOrden.Multiline = false;
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.Size = new System.Drawing.Size(101, 50);
            this.txtNroOrden.TabIndex = 10;
            this.txtNroOrden.Text = "";
            this.txtNroOrden.TrailingIcon = null;
            // 
            // btnTrazarPedidos
            // 
            this.btnTrazarPedidos.AutoSize = false;
            this.btnTrazarPedidos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrazarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTrazarPedidos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrazarPedidos.Depth = 0;
            this.btnTrazarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTrazarPedidos.HighEmphasis = true;
            this.btnTrazarPedidos.Icon = global::UI.Desktop.Properties.Resources.navigation_find_location_icon_220679;
            this.btnTrazarPedidos.Location = new System.Drawing.Point(538, 640);
            this.btnTrazarPedidos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrazarPedidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrazarPedidos.Name = "btnTrazarPedidos";
            this.btnTrazarPedidos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTrazarPedidos.Size = new System.Drawing.Size(114, 51);
            this.btnTrazarPedidos.TabIndex = 12;
            this.btnTrazarPedidos.Text = "Trazar item";
            this.btnTrazarPedidos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrazarPedidos.UseAccentColor = false;
            this.btnTrazarPedidos.UseVisualStyleBackColor = false;
            this.btnTrazarPedidos.Click += new System.EventHandler(this.btnTrazarPedidos_Click);
            // 
            // listMaquinasItems
            // 
            this.listMaquinasItems.AutoSizeTable = false;
            this.listMaquinasItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMaquinasItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMaquinasItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaquina,
            this.columnFechaHora});
            this.listMaquinasItems.Depth = 0;
            this.listMaquinasItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listMaquinasItems.FullRowSelect = true;
            this.listMaquinasItems.HideSelection = false;
            this.listMaquinasItems.Location = new System.Drawing.Point(217, 467);
            this.listMaquinasItems.MinimumSize = new System.Drawing.Size(200, 100);
            this.listMaquinasItems.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMaquinasItems.MouseState = MaterialSkin.MouseState.OUT;
            this.listMaquinasItems.MultiSelect = false;
            this.listMaquinasItems.Name = "listMaquinasItems";
            this.listMaquinasItems.OwnerDraw = true;
            this.listMaquinasItems.Size = new System.Drawing.Size(435, 164);
            this.listMaquinasItems.TabIndex = 13;
            this.listMaquinasItems.UseCompatibleStateImageBehavior = false;
            this.listMaquinasItems.View = System.Windows.Forms.View.Details;
            this.listMaquinasItems.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listMaquinasItems_ColumnWidthChanging);
            // 
            // columnMaquina
            // 
            this.columnMaquina.Text = "Maquina";
            this.columnMaquina.Width = 173;
            // 
            // columnFechaHora
            // 
            this.columnFechaHora.Text = "Fecha y hora inicio";
            this.columnFechaHora.Width = 262;
            // 
            // btnVerServiciosRealizados
            // 
            this.btnVerServiciosRealizados.AutoSize = false;
            this.btnVerServiciosRealizados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerServiciosRealizados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVerServiciosRealizados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerServiciosRealizados.Depth = 0;
            this.btnVerServiciosRealizados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerServiciosRealizados.HighEmphasis = true;
            this.btnVerServiciosRealizados.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnVerServiciosRealizados.Location = new System.Drawing.Point(540, 396);
            this.btnVerServiciosRealizados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerServiciosRealizados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerServiciosRealizados.Name = "btnVerServiciosRealizados";
            this.btnVerServiciosRealizados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerServiciosRealizados.Size = new System.Drawing.Size(114, 51);
            this.btnVerServiciosRealizados.TabIndex = 14;
            this.btnVerServiciosRealizados.Text = "detalles item";
            this.btnVerServiciosRealizados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerServiciosRealizados.UseAccentColor = false;
            this.btnVerServiciosRealizados.UseVisualStyleBackColor = false;
            this.btnVerServiciosRealizados.Click += new System.EventHandler(this.btnVerServiciosRealizados_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(219, 436);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(153, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Máquinas utilizadas: ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(219, 225);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(130, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Items de la orden: ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(13, 150);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(138, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Ordenes del cliente:";
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
            this.btnCerrar.Location = new System.Drawing.Point(1265, 640);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.txtNombreApellidoRazonSocial.Hint = "Nombre y Apellido/ Razón Social";
            this.txtNombreApellidoRazonSocial.LeadingIcon = null;
            this.txtNombreApellidoRazonSocial.Location = new System.Drawing.Point(171, 84);
            this.txtNombreApellidoRazonSocial.MaxLength = 50;
            this.txtNombreApellidoRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreApellidoRazonSocial.Multiline = false;
            this.txtNombreApellidoRazonSocial.Name = "txtNombreApellidoRazonSocial";
            this.txtNombreApellidoRazonSocial.Size = new System.Drawing.Size(222, 50);
            this.txtNombreApellidoRazonSocial.TabIndex = 19;
            this.txtNombreApellidoRazonSocial.Text = "";
            this.txtNombreApellidoRazonSocial.TrailingIcon = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(575, 97);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ObjetosPerdidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 722);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreApellidoRazonSocial);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnVerServiciosRealizados);
            this.Controls.Add(this.listMaquinasItems);
            this.Controls.Add(this.lblItemPosterior);
            this.Controls.Add(this.btnTrazarPedidos);
            this.Controls.Add(this.txtNroOrden);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblPedidoAnterior);
            this.Controls.Add(this.btnVerItems);
            this.Controls.Add(this.listItemsPedidos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.listOrdenesCliente);
            this.Controls.Add(this.txtCuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObjetosPerdidosForm";
            this.Sizable = false;
            this.Text = "Objetos Perdidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtCuit;
        private MaterialSkin.Controls.MaterialListView listOrdenesCliente;
        private System.Windows.Forms.ColumnHeader ColumnOrden;
        private System.Windows.Forms.ColumnHeader ColumnFecha;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialListView listItemsPedidos;
        private System.Windows.Forms.ColumnHeader ColumnServicio;
        private System.Windows.Forms.ColumnHeader columnTipoPrenda;
        private System.Windows.Forms.ColumnHeader columnItem;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private MaterialSkin.Controls.MaterialButton btnVerItems;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblPedidoAnterior;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblItemPosterior;
        private MaterialSkin.Controls.MaterialTextBox txtNroOrden;
        private MaterialSkin.Controls.MaterialButton btnTrazarPedidos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtDireccionAnterior;
        private MaterialSkin.Controls.MaterialTextBox txtTelefonoAnterior;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private MaterialSkin.Controls.MaterialTextBox txtCuitClienteAnterior;
        private MaterialSkin.Controls.MaterialTextBox txtOrdenItemAnterior;
        private MaterialSkin.Controls.MaterialTextBox txtNroOrdenAnterior;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtDireccionSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtEstadoSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtTelefonoSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtOrdenItemSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtCuitClienteSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtNroOrdenSiguiente;
        private MaterialSkin.Controls.MaterialListView listMaquinasItems;
        private System.Windows.Forms.ColumnHeader columnMaquina;
        private System.Windows.Forms.ColumnHeader columnFechaHora;
        private MaterialSkin.Controls.MaterialButton btnVerServiciosRealizados;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreApellidoRazonSocial;
        private MaterialSkin.Controls.MaterialTextBox txtServicioTipoPrendaAnterior;
        private MaterialSkin.Controls.MaterialTextBox txtServicioTipoPrendaSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtNombreApellidoRazonSocialAnterior;
        private MaterialSkin.Controls.MaterialTextBox txtNombreApellidoRazonSocialSiguiente;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtNombreApellidoEmpleadoAnterior;
        private MaterialSkin.Controls.MaterialTextBox txtIdEmpleadoAnterior;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox txtNombreApellidoEmpleadoSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtIDEmpleadoSiguiente;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
    }
}