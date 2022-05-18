
namespace UI.Desktop
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNuevoCliente = new MaterialSkin.Controls.MaterialButton();
            this.mnuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.mnuTabOrdenes = new System.Windows.Forms.TabPage();
            this.btnRetirarOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoServicioTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevaOrden = new MaterialSkin.Controls.MaterialButton();
            this.listOrdenes = new MaterialSkin.Controls.MaterialListView();
            this.columnNroOrden = new System.Windows.Forms.ColumnHeader();
            this.columnIdCliente = new System.Windows.Forms.ColumnHeader();
            this.columnIdEmpleado = new System.Windows.Forms.ColumnHeader();
            this.columnIdFactura = new System.Windows.Forms.ColumnHeader();
            this.columnPrioridad = new System.Windows.Forms.ColumnHeader();
            this.columnFechaEntrada = new System.Windows.Forms.ColumnHeader();
            this.columnTiempoEntregaEstimado = new System.Windows.Forms.ColumnHeader();
            this.columnTiempoEntregaReal = new System.Windows.Forms.ColumnHeader();
            this.columnFechaSalida = new System.Windows.Forms.ColumnHeader();
            this.columnEstado = new System.Windows.Forms.ColumnHeader();
            this.btnNuevoEmpleado = new MaterialSkin.Controls.MaterialButton();
            this.mnuTabClientes = new System.Windows.Forms.TabPage();
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEditarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            this.listClientes = new MaterialSkin.Controls.MaterialListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnCuit = new System.Windows.Forms.ColumnHeader();
            this.columnNombre = new System.Windows.Forms.ColumnHeader();
            this.columnApellido = new System.Windows.Forms.ColumnHeader();
            this.columnDireccion = new System.Windows.Forms.ColumnHeader();
            this.columnRazonSocial = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.columnTel = new System.Windows.Forms.ColumnHeader();
            this.mnuTabInventario = new System.Windows.Forms.TabPage();
            this.tabControlInventario = new MaterialSkin.Controls.MaterialTabControl();
            this.TabStock = new System.Windows.Forms.TabPage();
            this.listStock = new MaterialSkin.Controls.MaterialListView();
            this.columnInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnExistencia = new System.Windows.Forms.ColumnHeader();
            this.TabProveedor = new System.Windows.Forms.TabPage();
            this.listProveedores = new MaterialSkin.Controls.MaterialListView();
            this.columnIDProv = new System.Windows.Forms.ColumnHeader();
            this.columnCuitProv = new System.Windows.Forms.ColumnHeader();
            this.columnRazonSocialProv = new System.Windows.Forms.ColumnHeader();
            this.columnTelProv = new System.Windows.Forms.ColumnHeader();
            this.columnEmailProv = new System.Windows.Forms.ColumnHeader();
            this.columnDireccionProv = new System.Windows.Forms.ColumnHeader();
            this.btnEditarProv = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarProv = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarProv = new MaterialSkin.Controls.MaterialButton();
            this.TabInsumo = new System.Windows.Forms.TabPage();
            this.listInsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnIdInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnDescInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnStockInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnUnidadMedida = new System.Windows.Forms.ColumnHeader();
            this.btnEditarInsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarInsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarInsumo = new MaterialSkin.Controls.MaterialButton();
            this.TabMovimientos = new System.Windows.Forms.TabPage();
            this.btnActualizarIngresos = new MaterialSkin.Controls.MaterialButton();
            this.lblFiltrarFecha = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFiltrarFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnEditarIngreso = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarIngreso = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoIngreso = new MaterialSkin.Controls.MaterialButton();
            this.listIngresos = new MaterialSkin.Controls.MaterialListView();
            this.columnIdProvIngreso = new System.Windows.Forms.ColumnHeader();
            this.columnProvIngreso = new System.Windows.Forms.ColumnHeader();
            this.columnIdInsumoIngreso = new System.Windows.Forms.ColumnHeader();
            this.columnInsumoIngreso = new System.Windows.Forms.ColumnHeader();
            this.columnFechaIngreso = new System.Windows.Forms.ColumnHeader();
            this.columnCantIngreso = new System.Windows.Forms.ColumnHeader();
            this.tabSelectorInventario = new MaterialSkin.Controls.MaterialTabSelector();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.epUser = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            this.btnOrdenesCliente = new MaterialSkin.Controls.MaterialButton();
            this.mnuPrincipal.SuspendLayout();
            this.mnuTabOrdenes.SuspendLayout();
            this.mnuTabClientes.SuspendLayout();
            this.mnuTabInventario.SuspendLayout();
            this.tabControlInventario.SuspendLayout();
            this.TabStock.SuspendLayout();
            this.TabProveedor.SuspendLayout();
            this.TabInsumo.SuspendLayout();
            this.TabMovimientos.SuspendLayout();
            this.epUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNuevoCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevoCliente.HighEmphasis = true;
            this.btnNuevoCliente.Icon = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(574, 367);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoCliente.Size = new System.Drawing.Size(131, 36);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoCliente.UseAccentColor = false;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Controls.Add(this.mnuTabOrdenes);
            this.mnuPrincipal.Controls.Add(this.mnuTabClientes);
            this.mnuPrincipal.Controls.Add(this.mnuTabInventario);
            this.mnuPrincipal.Depth = 0;
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mnuPrincipal.ImageList = this.imageList1;
            this.mnuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.mnuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mnuPrincipal.Multiline = true;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.SelectedIndex = 0;
            this.mnuPrincipal.Size = new System.Drawing.Size(1380, 722);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Selected += new System.Windows.Forms.TabControlEventHandler(this.mnuPrincipal_Selected);
            // 
            // mnuTabOrdenes
            // 
            this.mnuTabOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mnuTabOrdenes.Controls.Add(this.btnRetirarOrden);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoTipoPrenda);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoServicioTipoPrenda);
            this.mnuTabOrdenes.Controls.Add(this.materialTextBox1);
            this.mnuTabOrdenes.Controls.Add(this.materialLabel1);
            this.mnuTabOrdenes.Controls.Add(this.btnEliminarOrden);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevaOrden);
            this.mnuTabOrdenes.Controls.Add(this.listOrdenes);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoEmpleado);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoCliente);
            this.mnuTabOrdenes.ImageKey = "addthelist_añadir_3477.png";
            this.mnuTabOrdenes.Location = new System.Drawing.Point(4, 39);
            this.mnuTabOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabOrdenes.Name = "mnuTabOrdenes";
            this.mnuTabOrdenes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabOrdenes.Size = new System.Drawing.Size(1372, 679);
            this.mnuTabOrdenes.TabIndex = 0;
            this.mnuTabOrdenes.Text = "Ordenes";
            // 
            // btnRetirarOrden
            // 
            this.btnRetirarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRetirarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRetirarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRetirarOrden.Depth = 0;
            this.btnRetirarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRetirarOrden.HighEmphasis = true;
            this.btnRetirarOrden.Icon = null;
            this.btnRetirarOrden.Location = new System.Drawing.Point(284, 9);
            this.btnRetirarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRetirarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetirarOrden.Name = "btnRetirarOrden";
            this.btnRetirarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRetirarOrden.Size = new System.Drawing.Size(132, 36);
            this.btnRetirarOrden.TabIndex = 9;
            this.btnRetirarOrden.Text = "Retirar Orden";
            this.btnRetirarOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRetirarOrden.UseAccentColor = false;
            this.btnRetirarOrden.UseVisualStyleBackColor = false;
            // 
            // btnNuevoTipoPrenda
            // 
            this.btnNuevoTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNuevoTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoTipoPrenda.Depth = 0;
            this.btnNuevoTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevoTipoPrenda.HighEmphasis = true;
            this.btnNuevoTipoPrenda.Icon = null;
            this.btnNuevoTipoPrenda.Location = new System.Drawing.Point(62, 366);
            this.btnNuevoTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoTipoPrenda.Name = "btnNuevoTipoPrenda";
            this.btnNuevoTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoTipoPrenda.Size = new System.Drawing.Size(163, 36);
            this.btnNuevoTipoPrenda.TabIndex = 8;
            this.btnNuevoTipoPrenda.Text = "Nuevo TipoPrenda";
            this.btnNuevoTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoTipoPrenda.UseAccentColor = false;
            this.btnNuevoTipoPrenda.UseVisualStyleBackColor = false;
            this.btnNuevoTipoPrenda.Click += new System.EventHandler(this.btnNuevoTipoPrenda_Click);
            // 
            // btnNuevoServicioTipoPrenda
            // 
            this.btnNuevoServicioTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoServicioTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNuevoServicioTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoServicioTipoPrenda.Depth = 0;
            this.btnNuevoServicioTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevoServicioTipoPrenda.HighEmphasis = true;
            this.btnNuevoServicioTipoPrenda.Icon = null;
            this.btnNuevoServicioTipoPrenda.Location = new System.Drawing.Point(339, 367);
            this.btnNuevoServicioTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoServicioTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoServicioTipoPrenda.Name = "btnNuevoServicioTipoPrenda";
            this.btnNuevoServicioTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoServicioTipoPrenda.Size = new System.Drawing.Size(227, 36);
            this.btnNuevoServicioTipoPrenda.TabIndex = 7;
            this.btnNuevoServicioTipoPrenda.Text = "Nuevo ServicioTipoPrenda";
            this.btnNuevoServicioTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoServicioTipoPrenda.UseAccentColor = false;
            this.btnNuevoServicioTipoPrenda.UseVisualStyleBackColor = false;
            this.btnNuevoServicioTipoPrenda.Click += new System.EventHandler(this.btnNuevoServicioTipoPrenda_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(927, 2);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(252, 50);
            this.materialTextBox1.TabIndex = 6;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(867, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Buscar:";
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarOrden.Depth = 0;
            this.btnEliminarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarOrden.HighEmphasis = true;
            this.btnEliminarOrden.Icon = null;
            this.btnEliminarOrden.Location = new System.Drawing.Point(136, 9);
            this.btnEliminarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarOrden.Size = new System.Drawing.Size(140, 36);
            this.btnEliminarOrden.TabIndex = 4;
            this.btnEliminarOrden.Text = "Eliminar Orden";
            this.btnEliminarOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarOrden.UseAccentColor = false;
            this.btnEliminarOrden.UseVisualStyleBackColor = false;
            this.btnEliminarOrden.Click += new System.EventHandler(this.btnEliminarOrden_Click);
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNuevaOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevaOrden.Depth = 0;
            this.btnNuevaOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevaOrden.HighEmphasis = true;
            this.btnNuevaOrden.Icon = null;
            this.btnNuevaOrden.Location = new System.Drawing.Point(7, 9);
            this.btnNuevaOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevaOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevaOrden.Size = new System.Drawing.Size(121, 36);
            this.btnNuevaOrden.TabIndex = 3;
            this.btnNuevaOrden.Text = "Nueva Orden";
            this.btnNuevaOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevaOrden.UseAccentColor = false;
            this.btnNuevaOrden.UseVisualStyleBackColor = false;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // listOrdenes
            // 
            this.listOrdenes.AutoSizeTable = false;
            this.listOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNroOrden,
            this.columnIdCliente,
            this.columnIdEmpleado,
            this.columnIdFactura,
            this.columnPrioridad,
            this.columnFechaEntrada,
            this.columnTiempoEntregaEstimado,
            this.columnTiempoEntregaReal,
            this.columnFechaSalida,
            this.columnEstado});
            this.listOrdenes.Depth = 0;
            this.listOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenes.FullRowSelect = true;
            this.listOrdenes.HideSelection = false;
            this.listOrdenes.Location = new System.Drawing.Point(6, 59);
            this.listOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOrdenes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenes.MultiSelect = false;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.OwnerDraw = true;
            this.listOrdenes.Size = new System.Drawing.Size(1209, 299);
            this.listOrdenes.TabIndex = 2;
            this.listOrdenes.UseCompatibleStateImageBehavior = false;
            this.listOrdenes.View = System.Windows.Forms.View.Details;
            // 
            // columnNroOrden
            // 
            this.columnNroOrden.Text = "Nro";
            this.columnNroOrden.Width = 50;
            // 
            // columnIdCliente
            // 
            this.columnIdCliente.Text = "Cliente";
            this.columnIdCliente.Width = 80;
            // 
            // columnIdEmpleado
            // 
            this.columnIdEmpleado.Text = "Empleado";
            this.columnIdEmpleado.Width = 100;
            // 
            // columnIdFactura
            // 
            this.columnIdFactura.Text = "Id Factura";
            this.columnIdFactura.Width = 100;
            // 
            // columnPrioridad
            // 
            this.columnPrioridad.Text = "Prioridad";
            this.columnPrioridad.Width = 100;
            // 
            // columnFechaEntrada
            // 
            this.columnFechaEntrada.Text = "Fecha Ingreso";
            this.columnFechaEntrada.Width = 150;
            // 
            // columnTiempoEntregaEstimado
            // 
            this.columnTiempoEntregaEstimado.Text = "Tiempo Entrega Est.";
            this.columnTiempoEntregaEstimado.Width = 200;
            // 
            // columnTiempoEntregaReal
            // 
            this.columnTiempoEntregaReal.Text = "Tiempo Entrega Real";
            this.columnTiempoEntregaReal.Width = 200;
            // 
            // columnFechaSalida
            // 
            this.columnFechaSalida.DisplayIndex = 9;
            this.columnFechaSalida.Text = "Fecha de Salida";
            this.columnFechaSalida.Width = 150;
            // 
            // columnEstado
            // 
            this.columnEstado.DisplayIndex = 8;
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 80;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNuevoEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoEmpleado.Depth = 0;
            this.btnNuevoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevoEmpleado.HighEmphasis = true;
            this.btnNuevoEmpleado.Icon = null;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(713, 367);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(150, 36);
            this.btnNuevoEmpleado.TabIndex = 1;
            this.btnNuevoEmpleado.Text = "Nuevo Empleado";
            this.btnNuevoEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoEmpleado.UseAccentColor = false;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // mnuTabClientes
            // 
            this.mnuTabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mnuTabClientes.Controls.Add(this.btnOrdenesCliente);
            this.mnuTabClientes.Controls.Add(this.txtBuscarCliente);
            this.mnuTabClientes.Controls.Add(this.btnEditarCliente);
            this.mnuTabClientes.Controls.Add(this.btnEliminarCliente);
            this.mnuTabClientes.Controls.Add(this.btnAgregarCliente);
            this.mnuTabClientes.Controls.Add(this.listClientes);
            this.mnuTabClientes.ImageKey = "adduser_añadir_3553.png";
            this.mnuTabClientes.Location = new System.Drawing.Point(4, 39);
            this.mnuTabClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabClientes.Name = "mnuTabClientes";
            this.mnuTabClientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabClientes.Size = new System.Drawing.Size(1372, 679);
            this.mnuTabClientes.TabIndex = 1;
            this.mnuTabClientes.Text = "Clientes";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.AnimateReadOnly = false;
            this.txtBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.Hint = "Buscar cliente...";
            this.txtBuscarCliente.LeadingIcon = null;
            this.txtBuscarCliente.Location = new System.Drawing.Point(1020, 53);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.MaxLength = 50;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarCliente.Multiline = false;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(221, 50);
            this.txtBuscarCliente.TabIndex = 4;
            this.txtBuscarCliente.Text = "";
            this.txtBuscarCliente.TrailingIcon = null;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarCliente.Depth = 0;
            this.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarCliente.HighEmphasis = true;
            this.btnEditarCliente.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarCliente.Location = new System.Drawing.Point(26, 112);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarCliente.Size = new System.Drawing.Size(99, 36);
            this.btnEditarCliente.TabIndex = 3;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarCliente.UseAccentColor = false;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarCliente.Depth = 0;
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarCliente.HighEmphasis = true;
            this.btnEliminarCliente.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarCliente.Location = new System.Drawing.Point(26, 172);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarCliente.Size = new System.Drawing.Size(116, 36);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarCliente.UseAccentColor = false;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarCliente.Depth = 0;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarCliente.HighEmphasis = true;
            this.btnAgregarCliente.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnAgregarCliente.Location = new System.Drawing.Point(26, 53);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarCliente.Size = new System.Drawing.Size(116, 36);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarCliente.UseAccentColor = false;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // listClientes
            // 
            this.listClientes.AutoSizeTable = false;
            this.listClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnCuit,
            this.columnNombre,
            this.columnApellido,
            this.columnDireccion,
            this.columnRazonSocial,
            this.columnEmail,
            this.columnTel});
            this.listClientes.Depth = 0;
            this.listClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listClientes.FullRowSelect = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(226, 53);
            this.listClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listClientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listClientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listClientes.MultiSelect = false;
            this.listClientes.Name = "listClientes";
            this.listClientes.OwnerDraw = true;
            this.listClientes.Size = new System.Drawing.Size(775, 540);
            this.listClientes.TabIndex = 0;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            this.listClientes.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listClientes_ColumnWidthChanging);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 50;
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
            // columnDireccion
            // 
            this.columnDireccion.Text = "Direccion";
            this.columnDireccion.Width = 100;
            // 
            // columnRazonSocial
            // 
            this.columnRazonSocial.Text = "Razon Social";
            this.columnRazonSocial.Width = 125;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 100;
            // 
            // columnTel
            // 
            this.columnTel.Text = "Telefono";
            this.columnTel.Width = 100;
            // 
            // mnuTabInventario
            // 
            this.mnuTabInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mnuTabInventario.Controls.Add(this.tabControlInventario);
            this.mnuTabInventario.Controls.Add(this.tabSelectorInventario);
            this.mnuTabInventario.ImageKey = "sales_sale_supermarket_stock_market_icon_153849.png";
            this.mnuTabInventario.Location = new System.Drawing.Point(4, 39);
            this.mnuTabInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabInventario.Name = "mnuTabInventario";
            this.mnuTabInventario.Size = new System.Drawing.Size(1372, 679);
            this.mnuTabInventario.TabIndex = 2;
            this.mnuTabInventario.Text = "Inventario";
            // 
            // tabControlInventario
            // 
            this.tabControlInventario.Controls.Add(this.TabStock);
            this.tabControlInventario.Controls.Add(this.TabProveedor);
            this.tabControlInventario.Controls.Add(this.TabInsumo);
            this.tabControlInventario.Controls.Add(this.TabMovimientos);
            this.tabControlInventario.Depth = 0;
            this.tabControlInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlInventario.Location = new System.Drawing.Point(0, 47);
            this.tabControlInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlInventario.Multiline = true;
            this.tabControlInventario.Name = "tabControlInventario";
            this.tabControlInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlInventario.SelectedIndex = 0;
            this.tabControlInventario.Size = new System.Drawing.Size(1372, 632);
            this.tabControlInventario.TabIndex = 1;
            // 
            // TabStock
            // 
            this.TabStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabStock.Controls.Add(this.listStock);
            this.TabStock.Location = new System.Drawing.Point(4, 24);
            this.TabStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabStock.Name = "TabStock";
            this.TabStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabStock.Size = new System.Drawing.Size(1364, 604);
            this.TabStock.TabIndex = 0;
            this.TabStock.Text = "Stock";
            // 
            // listStock
            // 
            this.listStock.AutoSizeTable = false;
            this.listStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnInsumo,
            this.columnExistencia});
            this.listStock.Depth = 0;
            this.listStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listStock.FullRowSelect = true;
            this.listStock.HideSelection = false;
            this.listStock.Location = new System.Drawing.Point(414, 68);
            this.listStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listStock.MinimumSize = new System.Drawing.Size(200, 100);
            this.listStock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listStock.MouseState = MaterialSkin.MouseState.OUT;
            this.listStock.Name = "listStock";
            this.listStock.OwnerDraw = true;
            this.listStock.Size = new System.Drawing.Size(260, 404);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            this.listStock.View = System.Windows.Forms.View.Details;
            // 
            // columnInsumo
            // 
            this.columnInsumo.Text = "Descripción Insumo";
            this.columnInsumo.Width = 160;
            // 
            // columnExistencia
            // 
            this.columnExistencia.Text = "Existencia";
            this.columnExistencia.Width = 100;
            // 
            // TabProveedor
            // 
            this.TabProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabProveedor.Controls.Add(this.listProveedores);
            this.TabProveedor.Controls.Add(this.btnEditarProv);
            this.TabProveedor.Controls.Add(this.btnEliminarProv);
            this.TabProveedor.Controls.Add(this.btnAgregarProv);
            this.TabProveedor.Location = new System.Drawing.Point(4, 24);
            this.TabProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProveedor.Name = "TabProveedor";
            this.TabProveedor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabProveedor.Size = new System.Drawing.Size(1364, 604);
            this.TabProveedor.TabIndex = 1;
            this.TabProveedor.Text = "Proveedor";
            // 
            // listProveedores
            // 
            this.listProveedores.AutoSizeTable = false;
            this.listProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDProv,
            this.columnCuitProv,
            this.columnRazonSocialProv,
            this.columnTelProv,
            this.columnEmailProv,
            this.columnDireccionProv});
            this.listProveedores.Depth = 0;
            this.listProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listProveedores.FullRowSelect = true;
            this.listProveedores.HideSelection = false;
            this.listProveedores.Location = new System.Drawing.Point(193, 51);
            this.listProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listProveedores.MinimumSize = new System.Drawing.Size(200, 100);
            this.listProveedores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listProveedores.MouseState = MaterialSkin.MouseState.OUT;
            this.listProveedores.Name = "listProveedores";
            this.listProveedores.OwnerDraw = true;
            this.listProveedores.Size = new System.Drawing.Size(679, 407);
            this.listProveedores.TabIndex = 7;
            this.listProveedores.UseCompatibleStateImageBehavior = false;
            this.listProveedores.View = System.Windows.Forms.View.Details;
            this.listProveedores.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listProveedores_ColumnWidthChanging);
            // 
            // columnIDProv
            // 
            this.columnIDProv.Text = "ID";
            // 
            // columnCuitProv
            // 
            this.columnCuitProv.Text = "Cuit";
            this.columnCuitProv.Width = 120;
            // 
            // columnRazonSocialProv
            // 
            this.columnRazonSocialProv.Text = "Razon Social";
            this.columnRazonSocialProv.Width = 120;
            // 
            // columnTelProv
            // 
            this.columnTelProv.Text = "Telefono";
            this.columnTelProv.Width = 120;
            // 
            // columnEmailProv
            // 
            this.columnEmailProv.Text = "Email";
            this.columnEmailProv.Width = 140;
            // 
            // columnDireccionProv
            // 
            this.columnDireccionProv.Text = "Direccion";
            this.columnDireccionProv.Width = 120;
            // 
            // btnEditarProv
            // 
            this.btnEditarProv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditarProv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarProv.Depth = 0;
            this.btnEditarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarProv.HighEmphasis = true;
            this.btnEditarProv.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarProv.Location = new System.Drawing.Point(21, 110);
            this.btnEditarProv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarProv.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarProv.Name = "btnEditarProv";
            this.btnEditarProv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarProv.Size = new System.Drawing.Size(99, 36);
            this.btnEditarProv.TabIndex = 6;
            this.btnEditarProv.Text = "Editar";
            this.btnEditarProv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarProv.UseAccentColor = false;
            this.btnEditarProv.UseVisualStyleBackColor = false;
            this.btnEditarProv.Click += new System.EventHandler(this.btnEditarProv_Click);
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarProv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarProv.Depth = 0;
            this.btnEliminarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarProv.HighEmphasis = true;
            this.btnEliminarProv.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarProv.Location = new System.Drawing.Point(21, 170);
            this.btnEliminarProv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarProv.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarProv.Size = new System.Drawing.Size(116, 36);
            this.btnEliminarProv.TabIndex = 5;
            this.btnEliminarProv.Text = "Eliminar";
            this.btnEliminarProv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarProv.UseAccentColor = false;
            this.btnEliminarProv.UseVisualStyleBackColor = false;
            this.btnEliminarProv.Click += new System.EventHandler(this.btnEliminarProv_Click);
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarProv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarProv.Depth = 0;
            this.btnAgregarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarProv.HighEmphasis = true;
            this.btnAgregarProv.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnAgregarProv.Location = new System.Drawing.Point(21, 51);
            this.btnAgregarProv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarProv.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarProv.Size = new System.Drawing.Size(116, 36);
            this.btnAgregarProv.TabIndex = 4;
            this.btnAgregarProv.Text = "Agregar";
            this.btnAgregarProv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarProv.UseAccentColor = false;
            this.btnAgregarProv.UseVisualStyleBackColor = false;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // TabInsumo
            // 
            this.TabInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabInsumo.Controls.Add(this.listInsumos);
            this.TabInsumo.Controls.Add(this.btnEditarInsumo);
            this.TabInsumo.Controls.Add(this.btnEliminarInsumo);
            this.TabInsumo.Controls.Add(this.btnAgregarInsumo);
            this.TabInsumo.Location = new System.Drawing.Point(4, 24);
            this.TabInsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabInsumo.Name = "TabInsumo";
            this.TabInsumo.Size = new System.Drawing.Size(1364, 604);
            this.TabInsumo.TabIndex = 2;
            this.TabInsumo.Text = "Insumo";
            // 
            // listInsumos
            // 
            this.listInsumos.AutoSizeTable = false;
            this.listInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdInsumo,
            this.columnDescInsumo,
            this.columnStockInsumo,
            this.columnUnidadMedida});
            this.listInsumos.Depth = 0;
            this.listInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listInsumos.FullRowSelect = true;
            this.listInsumos.HideSelection = false;
            this.listInsumos.Location = new System.Drawing.Point(208, 28);
            this.listInsumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listInsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listInsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listInsumos.Name = "listInsumos";
            this.listInsumos.OwnerDraw = true;
            this.listInsumos.Size = new System.Drawing.Size(559, 446);
            this.listInsumos.TabIndex = 10;
            this.listInsumos.UseCompatibleStateImageBehavior = false;
            this.listInsumos.View = System.Windows.Forms.View.Details;
            this.listInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listInsumos_ColumnWidthChanging);
            // 
            // columnIdInsumo
            // 
            this.columnIdInsumo.Text = "ID";
            // 
            // columnDescInsumo
            // 
            this.columnDescInsumo.Text = "Descripción";
            this.columnDescInsumo.Width = 200;
            // 
            // columnStockInsumo
            // 
            this.columnStockInsumo.Text = "Stock";
            this.columnStockInsumo.Width = 100;
            // 
            // columnUnidadMedida
            // 
            this.columnUnidadMedida.Text = "Unidad de medida";
            this.columnUnidadMedida.Width = 200;
            // 
            // btnEditarInsumo
            // 
            this.btnEditarInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditarInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarInsumo.Depth = 0;
            this.btnEditarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarInsumo.HighEmphasis = true;
            this.btnEditarInsumo.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarInsumo.Location = new System.Drawing.Point(30, 86);
            this.btnEditarInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarInsumo.Name = "btnEditarInsumo";
            this.btnEditarInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarInsumo.Size = new System.Drawing.Size(99, 36);
            this.btnEditarInsumo.TabIndex = 9;
            this.btnEditarInsumo.Text = "Editar";
            this.btnEditarInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarInsumo.UseAccentColor = false;
            this.btnEditarInsumo.UseVisualStyleBackColor = false;
            this.btnEditarInsumo.Click += new System.EventHandler(this.btnEditarInsumo_Click);
            // 
            // btnEliminarInsumo
            // 
            this.btnEliminarInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarInsumo.Depth = 0;
            this.btnEliminarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarInsumo.HighEmphasis = true;
            this.btnEliminarInsumo.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarInsumo.Location = new System.Drawing.Point(30, 146);
            this.btnEliminarInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarInsumo.Name = "btnEliminarInsumo";
            this.btnEliminarInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarInsumo.Size = new System.Drawing.Size(116, 36);
            this.btnEliminarInsumo.TabIndex = 8;
            this.btnEliminarInsumo.Text = "Eliminar";
            this.btnEliminarInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarInsumo.UseAccentColor = false;
            this.btnEliminarInsumo.UseVisualStyleBackColor = false;
            this.btnEliminarInsumo.Click += new System.EventHandler(this.btnEliminarInsumo_Click);
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarInsumo.Depth = 0;
            this.btnAgregarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarInsumo.HighEmphasis = true;
            this.btnAgregarInsumo.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(30, 28);
            this.btnAgregarInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarInsumo.Size = new System.Drawing.Size(116, 36);
            this.btnAgregarInsumo.TabIndex = 7;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarInsumo.UseAccentColor = false;
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // TabMovimientos
            // 
            this.TabMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabMovimientos.Controls.Add(this.btnActualizarIngresos);
            this.TabMovimientos.Controls.Add(this.lblFiltrarFecha);
            this.TabMovimientos.Controls.Add(this.dtpFiltrarFechaIngreso);
            this.TabMovimientos.Controls.Add(this.btnEditarIngreso);
            this.TabMovimientos.Controls.Add(this.btnEliminarIngreso);
            this.TabMovimientos.Controls.Add(this.btnNuevoIngreso);
            this.TabMovimientos.Controls.Add(this.listIngresos);
            this.TabMovimientos.Location = new System.Drawing.Point(4, 24);
            this.TabMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabMovimientos.Name = "TabMovimientos";
            this.TabMovimientos.Size = new System.Drawing.Size(1364, 604);
            this.TabMovimientos.TabIndex = 3;
            this.TabMovimientos.Text = "Movimientos";
            // 
            // btnActualizarIngresos
            // 
            this.btnActualizarIngresos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnActualizarIngresos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarIngresos.Depth = 0;
            this.btnActualizarIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActualizarIngresos.HighEmphasis = true;
            this.btnActualizarIngresos.Icon = null;
            this.btnActualizarIngresos.Location = new System.Drawing.Point(1006, 434);
            this.btnActualizarIngresos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarIngresos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarIngresos.Name = "btnActualizarIngresos";
            this.btnActualizarIngresos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarIngresos.Size = new System.Drawing.Size(109, 36);
            this.btnActualizarIngresos.TabIndex = 15;
            this.btnActualizarIngresos.Text = "Actualizar";
            this.btnActualizarIngresos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarIngresos.UseAccentColor = false;
            this.btnActualizarIngresos.UseVisualStyleBackColor = false;
            this.btnActualizarIngresos.Click += new System.EventHandler(this.btnActualizarIngresos_Click);
            // 
            // lblFiltrarFecha
            // 
            this.lblFiltrarFecha.AutoSize = true;
            this.lblFiltrarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFiltrarFecha.Depth = 0;
            this.lblFiltrarFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFiltrarFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFiltrarFecha.Location = new System.Drawing.Point(284, 34);
            this.lblFiltrarFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFiltrarFecha.Name = "lblFiltrarFecha";
            this.lblFiltrarFecha.Size = new System.Drawing.Size(117, 19);
            this.lblFiltrarFecha.TabIndex = 14;
            this.lblFiltrarFecha.Text = "Filtrar por fecha:";
            // 
            // dtpFiltrarFechaIngreso
            // 
            this.dtpFiltrarFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFiltrarFechaIngreso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFiltrarFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFiltrarFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltrarFechaIngreso.Location = new System.Drawing.Point(414, 29);
            this.dtpFiltrarFechaIngreso.Name = "dtpFiltrarFechaIngreso";
            this.dtpFiltrarFechaIngreso.Size = new System.Drawing.Size(200, 24);
            this.dtpFiltrarFechaIngreso.TabIndex = 13;
            this.dtpFiltrarFechaIngreso.CloseUp += new System.EventHandler(this.dtpFiltrarFechaIngreso_CloseUp);
            // 
            // btnEditarIngreso
            // 
            this.btnEditarIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditarIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarIngreso.Depth = 0;
            this.btnEditarIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarIngreso.HighEmphasis = true;
            this.btnEditarIngreso.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarIngreso.Location = new System.Drawing.Point(24, 135);
            this.btnEditarIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarIngreso.Name = "btnEditarIngreso";
            this.btnEditarIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarIngreso.Size = new System.Drawing.Size(99, 36);
            this.btnEditarIngreso.TabIndex = 12;
            this.btnEditarIngreso.Text = "Editar";
            this.btnEditarIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarIngreso.UseAccentColor = false;
            this.btnEditarIngreso.UseVisualStyleBackColor = false;
            this.btnEditarIngreso.Click += new System.EventHandler(this.btnEditarIngreso_Click);
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarIngreso.Depth = 0;
            this.btnEliminarIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarIngreso.HighEmphasis = true;
            this.btnEliminarIngreso.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(24, 195);
            this.btnEliminarIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarIngreso.Size = new System.Drawing.Size(116, 36);
            this.btnEliminarIngreso.TabIndex = 11;
            this.btnEliminarIngreso.Text = "Eliminar";
            this.btnEliminarIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarIngreso.UseAccentColor = false;
            this.btnEliminarIngreso.UseVisualStyleBackColor = false;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNuevoIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoIngreso.Depth = 0;
            this.btnNuevoIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevoIngreso.HighEmphasis = true;
            this.btnNuevoIngreso.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnNuevoIngreso.Location = new System.Drawing.Point(24, 76);
            this.btnNuevoIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoIngreso.Size = new System.Drawing.Size(163, 36);
            this.btnNuevoIngreso.TabIndex = 10;
            this.btnNuevoIngreso.Text = "nuevo ingreso";
            this.btnNuevoIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoIngreso.UseAccentColor = false;
            this.btnNuevoIngreso.UseVisualStyleBackColor = false;
            this.btnNuevoIngreso.Click += new System.EventHandler(this.btnNuevoIngreso_Click);
            // 
            // listIngresos
            // 
            this.listIngresos.AutoSizeTable = false;
            this.listIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listIngresos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdProvIngreso,
            this.columnProvIngreso,
            this.columnIdInsumoIngreso,
            this.columnInsumoIngreso,
            this.columnFechaIngreso,
            this.columnCantIngreso});
            this.listIngresos.Depth = 0;
            this.listIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listIngresos.FullRowSelect = true;
            this.listIngresos.HideSelection = false;
            this.listIngresos.Location = new System.Drawing.Point(225, 76);
            this.listIngresos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listIngresos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listIngresos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listIngresos.MouseState = MaterialSkin.MouseState.OUT;
            this.listIngresos.Name = "listIngresos";
            this.listIngresos.OwnerDraw = true;
            this.listIngresos.Size = new System.Drawing.Size(890, 341);
            this.listIngresos.TabIndex = 0;
            this.listIngresos.UseCompatibleStateImageBehavior = false;
            this.listIngresos.View = System.Windows.Forms.View.Details;
            this.listIngresos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listIngresos_ColumnWidthChanging);
            // 
            // columnIdProvIngreso
            // 
            this.columnIdProvIngreso.Text = "ID Proveedor";
            this.columnIdProvIngreso.Width = 110;
            // 
            // columnProvIngreso
            // 
            this.columnProvIngreso.Text = "Proveedor";
            this.columnProvIngreso.Width = 200;
            // 
            // columnIdInsumoIngreso
            // 
            this.columnIdInsumoIngreso.Text = "ID Insumo";
            this.columnIdInsumoIngreso.Width = 100;
            // 
            // columnInsumoIngreso
            // 
            this.columnInsumoIngreso.Text = "Insumo";
            this.columnInsumoIngreso.Width = 150;
            // 
            // columnFechaIngreso
            // 
            this.columnFechaIngreso.Text = "Fecha Ingreso";
            this.columnFechaIngreso.Width = 180;
            // 
            // columnCantIngreso
            // 
            this.columnCantIngreso.Text = "Cantidad";
            this.columnCantIngreso.Width = 150;
            // 
            // tabSelectorInventario
            // 
            this.tabSelectorInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabSelectorInventario.BaseTabControl = this.tabControlInventario;
            this.tabSelectorInventario.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorInventario.Depth = 0;
            this.tabSelectorInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelectorInventario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabSelectorInventario.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSelectorInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorInventario.Name = "tabSelectorInventario";
            this.tabSelectorInventario.Size = new System.Drawing.Size(1372, 47);
            this.tabSelectorInventario.TabIndex = 0;
            this.tabSelectorInventario.Text = "TabSelectorInventario";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "adduser_añadir_3553.png");
            this.imageList1.Images.SetKeyName(1, "addthelist_añadir_3477.png");
            this.imageList1.Images.SetKeyName(2, "sales_sale_supermarket_stock_market_icon_153849.png");
            // 
            // epUser
            // 
            this.epUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.epUser.CancelButtonText = "";
            this.epUser.Collapse = true;
            this.epUser.Controls.Add(this.pictureBox1);
            this.epUser.Controls.Add(this.btnCerrarSesion);
            this.epUser.Depth = 0;
            this.epUser.Description = "";
            this.epUser.ExpandHeight = 207;
            this.epUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.epUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.epUser.Location = new System.Drawing.Point(1155, 28);
            this.epUser.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.epUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.epUser.Name = "epUser";
            this.epUser.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.epUser.ShowValidationButtons = false;
            this.epUser.Size = new System.Drawing.Size(192, 48);
            this.epUser.TabIndex = 9;
            this.epUser.ValidationButtonText = "";
            this.epUser.Leave += new System.EventHandler(this.epUser_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pictureBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::UI.Desktop.Properties.Resources.round_account_button_with_user_inside_icon_icons_com_72596;
            this.pictureBox1.Location = new System.Drawing.Point(103, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrarSesion.HighEmphasis = true;
            this.btnCerrarSesion.Icon = global::UI.Desktop.Properties.Resources.off_log_icon_214125;
            this.btnCerrarSesion.Location = new System.Drawing.Point(17, 81);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesion.Size = new System.Drawing.Size(159, 36);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesion.UseAccentColor = false;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnOrdenesCliente
            // 
            this.btnOrdenesCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrdenesCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOrdenesCliente.Depth = 0;
            this.btnOrdenesCliente.HighEmphasis = true;
            this.btnOrdenesCliente.Icon = null;
            this.btnOrdenesCliente.Location = new System.Drawing.Point(1020, 131);
            this.btnOrdenesCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenesCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOrdenesCliente.Name = "btnOrdenesCliente";
            this.btnOrdenesCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOrdenesCliente.Size = new System.Drawing.Size(158, 36);
            this.btnOrdenesCliente.TabIndex = 5;
            this.btnOrdenesCliente.Text = "Ver Ordenes";
            this.btnOrdenesCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOrdenesCliente.UseAccentColor = false;
            this.btnOrdenesCliente.UseVisualStyleBackColor = true;
            this.btnOrdenesCliente.Click += new System.EventHandler(this.btnOrdenesCliente_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.epUser);
            this.Controls.Add(this.mnuPrincipal);
            this.DrawerAutoHide = false;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mnuPrincipal;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = " Lavanderia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuTabOrdenes.ResumeLayout(false);
            this.mnuTabOrdenes.PerformLayout();
            this.mnuTabClientes.ResumeLayout(false);
            this.mnuTabClientes.PerformLayout();
            this.mnuTabInventario.ResumeLayout(false);
            this.tabControlInventario.ResumeLayout(false);
            this.TabStock.ResumeLayout(false);
            this.TabProveedor.ResumeLayout(false);
            this.TabProveedor.PerformLayout();
            this.TabInsumo.ResumeLayout(false);
            this.TabInsumo.PerformLayout();
            this.TabMovimientos.ResumeLayout(false);
            this.TabMovimientos.PerformLayout();
            this.epUser.ResumeLayout(false);
            this.epUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnNuevoCliente;
        private MaterialSkin.Controls.MaterialTabControl mnuPrincipal;
        private System.Windows.Forms.TabPage mnuTabOrdenes;
        private System.Windows.Forms.TabPage mnuTabClientes;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnNuevoEmpleado;
        private MaterialSkin.Controls.MaterialListView listClientes;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnCuit;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnApellido;
        private System.Windows.Forms.ColumnHeader columnDireccion;
        private System.Windows.Forms.ColumnHeader columnRazonSocial;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnTel;
        private System.Windows.Forms.TabPage mnuTabInventario;
        private MaterialSkin.Controls.MaterialButton btnEditarCliente;
        private MaterialSkin.Controls.MaterialButton btnEliminarCliente;
        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarCliente;
        private MaterialSkin.Controls.MaterialTabControl tabControlInventario;
        private System.Windows.Forms.TabPage TabStock;
        private System.Windows.Forms.TabPage TabProveedor;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorInventario;
        private System.Windows.Forms.TabPage TabInsumo;
        private MaterialSkin.Controls.MaterialListView listProveedores;
        private System.Windows.Forms.ColumnHeader columnIDProv;
        private System.Windows.Forms.ColumnHeader columnCuitProv;
        private System.Windows.Forms.ColumnHeader columnRazonSocialProv;
        private System.Windows.Forms.ColumnHeader columnTelProv;
        private System.Windows.Forms.ColumnHeader columnEmailProv;
        private System.Windows.Forms.ColumnHeader columnDireccionProv;
        private MaterialSkin.Controls.MaterialButton btnEditarProv;
        private MaterialSkin.Controls.MaterialButton btnEliminarProv;
        private MaterialSkin.Controls.MaterialButton btnAgregarProv;
        private MaterialSkin.Controls.MaterialListView listInsumos;
        private System.Windows.Forms.ColumnHeader columnIdInsumo;
        private System.Windows.Forms.ColumnHeader columnDescInsumo;
        private System.Windows.Forms.ColumnHeader columnStockInsumo;
        private MaterialSkin.Controls.MaterialButton btnEditarInsumo;
        private MaterialSkin.Controls.MaterialButton btnEliminarInsumo;
        private MaterialSkin.Controls.MaterialButton btnAgregarInsumo;
        private MaterialSkin.Controls.MaterialListView listStock;
        private System.Windows.Forms.ColumnHeader columnInsumo;
        private System.Windows.Forms.ColumnHeader columnExistencia;
        private System.Windows.Forms.TabPage TabMovimientos;
        private MaterialSkin.Controls.MaterialButton btnEditarIngreso;
        private MaterialSkin.Controls.MaterialButton btnEliminarIngreso;
        private MaterialSkin.Controls.MaterialButton btnNuevoIngreso;
        private MaterialSkin.Controls.MaterialListView listIngresos;
        private System.Windows.Forms.ColumnHeader columnIdProvIngreso;
        private System.Windows.Forms.ColumnHeader columnProvIngreso;
        private System.Windows.Forms.ColumnHeader columnIdInsumoIngreso;
        private System.Windows.Forms.ColumnHeader columnInsumoIngreso;
        private System.Windows.Forms.ColumnHeader columnFechaIngreso;
        private System.Windows.Forms.ColumnHeader columnCantIngreso;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialListView listOrdenes;
        private System.Windows.Forms.ColumnHeader columnNroOrden;
        private System.Windows.Forms.ColumnHeader columnIdCliente;
        private System.Windows.Forms.ColumnHeader columnIdEmpleado;
        private System.Windows.Forms.ColumnHeader columnIdFactura;
        private System.Windows.Forms.ColumnHeader columnPrioridad;
        private System.Windows.Forms.ColumnHeader columnFechaEntrada;
        private System.Windows.Forms.ColumnHeader columnTiempoEntregaEstimado;
        private System.Windows.Forms.ColumnHeader columnTiempoEntregaReal;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private MaterialSkin.Controls.MaterialButton btnEliminarOrden;
        private MaterialSkin.Controls.MaterialButton btnNuevaOrden;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton btnNuevoServicioTipoPrenda;
        private MaterialSkin.Controls.MaterialButton btnNuevoTipoPrenda;
        private System.Windows.Forms.ColumnHeader columnFechaSalida;
        private MaterialSkin.Controls.MaterialButton btnRetirarOrden;
        private MaterialSkin.Controls.MaterialExpansionPanel epUser;
        private System.Windows.Forms.ColumnHeader columnUnidadMedida;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpFiltrarFechaIngreso;
        private MaterialSkin.Controls.MaterialButton btnActualizarIngresos;
        private MaterialSkin.Controls.MaterialButton btnOrdenesCliente;
    }
}

