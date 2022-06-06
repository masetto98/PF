
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
            this.mnuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.mnuTabOrdenes = new System.Windows.Forms.TabPage();
            this.btnEditarOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnRetirarOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoServicioTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarOrdenes = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevaOrden = new MaterialSkin.Controls.MaterialButton();
            this.listOrdenes = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnIdCliente = new System.Windows.Forms.ColumnHeader();
            this.columnIdEmpleado = new System.Windows.Forms.ColumnHeader();
            this.columnIdFactura = new System.Windows.Forms.ColumnHeader();
            this.columnPrioridad = new System.Windows.Forms.ColumnHeader();
            this.columnFechaEntrada = new System.Windows.Forms.ColumnHeader();
            this.columnFechaSalida = new System.Windows.Forms.ColumnHeader();
            this.columnEstado = new System.Windows.Forms.ColumnHeader();
            this.mnuTabClientes = new System.Windows.Forms.TabPage();
            this.btnOrdenesCliente = new MaterialSkin.Controls.MaterialButton();
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
            this.tabPlanificacion = new System.Windows.Forms.TabPage();
            this.tabControlPlanificacion = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPendientes = new System.Windows.Forms.TabPage();
            this.btnFinalizarTrabajo = new MaterialSkin.Controls.MaterialButton();
            this.btnIniciarServicio = new MaterialSkin.Controls.MaterialButton();
            this.listMaquinasItem = new MaterialSkin.Controls.MaterialListView();
            this.columnMaquina3 = new System.Windows.Forms.ColumnHeader();
            this.columnInicio1 = new System.Windows.Forms.ColumnHeader();
            this.columnFin = new System.Windows.Forms.ColumnHeader();
            this.btnMostrarServicios = new MaterialSkin.Controls.MaterialButton();
            this.listEstadoMaquinas = new MaterialSkin.Controls.MaterialListView();
            this.columnMaquina2 = new System.Windows.Forms.ColumnHeader();
            this.columnEstadoMaquina = new System.Windows.Forms.ColumnHeader();
            this.listTrabajosPendientes = new MaterialSkin.Controls.MaterialListView();
            this.columnOrden = new System.Windows.Forms.ColumnHeader();
            this.columnServicio = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPrenda = new System.Windows.Forms.ColumnHeader();
            this.columnOrdenItem = new System.Windows.Forms.ColumnHeader();
            this.columnState = new System.Windows.Forms.ColumnHeader();
            this.columnPriority = new System.Windows.Forms.ColumnHeader();
            this.columnTiempoRestante = new System.Windows.Forms.ColumnHeader();
            this.tabEnProceso = new System.Windows.Forms.TabPage();
            this.btnTerminarServicio = new MaterialSkin.Controls.MaterialButton();
            this.listTrabajosEnProceso = new MaterialSkin.Controls.MaterialListView();
            this.columnMaquina = new System.Windows.Forms.ColumnHeader();
            this.columnNroOrden2 = new System.Windows.Forms.ColumnHeader();
            this.columnServicio2 = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPrenda2 = new System.Windows.Forms.ColumnHeader();
            this.columnOrdenItem2 = new System.Windows.Forms.ColumnHeader();
            this.columnInicio = new System.Windows.Forms.ColumnHeader();
            this.columnState2 = new System.Windows.Forms.ColumnHeader();
            this.tabSelectorPlanificacion = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabUtilidades = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnObjetosPerdidos = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnInsumos = new MaterialSkin.Controls.MaterialButton();
            this.btnProveedores = new MaterialSkin.Controls.MaterialButton();
            this.btnClientes = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnUsuarios = new MaterialSkin.Controls.MaterialButton();
            this.btnMaquinas = new MaterialSkin.Controls.MaterialButton();
            this.btnEmpleados = new MaterialSkin.Controls.MaterialButton();
            this.btnServicioTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.btnTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.btnServicio = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
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
            this.mnuPrincipal.SuspendLayout();
            this.mnuTabOrdenes.SuspendLayout();
            this.mnuTabClientes.SuspendLayout();
            this.mnuTabInventario.SuspendLayout();
            this.tabControlInventario.SuspendLayout();
            this.TabStock.SuspendLayout();
            this.TabProveedor.SuspendLayout();
            this.TabInsumo.SuspendLayout();
            this.TabMovimientos.SuspendLayout();
            this.tabPlanificacion.SuspendLayout();
            this.tabControlPlanificacion.SuspendLayout();
            this.tabPendientes.SuspendLayout();
            this.tabEnProceso.SuspendLayout();
            this.tabUtilidades.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.epUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Controls.Add(this.mnuTabOrdenes);
            this.mnuPrincipal.Controls.Add(this.mnuTabClientes);
            this.mnuPrincipal.Controls.Add(this.mnuTabInventario);
            this.mnuPrincipal.Controls.Add(this.tabPlanificacion);
            this.mnuPrincipal.Controls.Add(this.tabUtilidades);
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
            this.mnuPrincipal.SelectedIndexChanged += new System.EventHandler(this.mnuPrincipal_SelectedIndexChanged);
            // 
            // mnuTabOrdenes
            // 
            this.mnuTabOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mnuTabOrdenes.Controls.Add(this.btnEditarOrden);
            this.mnuTabOrdenes.Controls.Add(this.btnRetirarOrden);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoTipoPrenda);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoServicioTipoPrenda);
            this.mnuTabOrdenes.Controls.Add(this.txtBuscarOrdenes);
            this.mnuTabOrdenes.Controls.Add(this.materialLabel1);
            this.mnuTabOrdenes.Controls.Add(this.btnEliminarOrden);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevaOrden);
            this.mnuTabOrdenes.Controls.Add(this.listOrdenes);
            this.mnuTabOrdenes.ImageKey = "addthelist_añadir_3477.png";
            this.mnuTabOrdenes.Location = new System.Drawing.Point(4, 39);
            this.mnuTabOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabOrdenes.Name = "mnuTabOrdenes";
            this.mnuTabOrdenes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabOrdenes.Size = new System.Drawing.Size(1372, 679);
            this.mnuTabOrdenes.TabIndex = 0;
            this.mnuTabOrdenes.Text = "Ordenes";
            // 
            // btnEliminarEmpleado
            // 
            
            
            // btnEditarOrden
            // 
            this.btnEditarOrden.AutoSize = false;
            this.btnEditarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarOrden.Depth = 0;
            this.btnEditarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditarOrden.HighEmphasis = true;
            this.btnEditarOrden.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarOrden.Location = new System.Drawing.Point(52, 130);
            this.btnEditarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarOrden.Name = "btnEditarOrden";
            this.btnEditarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarOrden.Size = new System.Drawing.Size(99, 36);
            this.btnEditarOrden.TabIndex = 10;
            this.btnEditarOrden.Text = "Editar";
            this.btnEditarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarOrden.UseAccentColor = false;
            this.btnEditarOrden.UseVisualStyleBackColor = false;
            this.btnEditarOrden.Click += new System.EventHandler(this.btnEditarOrden_Click);
            // 
            // btnRetirarOrden
            // 
            this.btnRetirarOrden.AutoSize = false;
            this.btnRetirarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRetirarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRetirarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRetirarOrden.Depth = 0;
            this.btnRetirarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRetirarOrden.HighEmphasis = true;
            this.btnRetirarOrden.Icon = global::UI.Desktop.Properties.Resources.thefreeforty_withdraw_icon_icons_com_66307;
            this.btnRetirarOrden.Location = new System.Drawing.Point(52, 251);
            this.btnRetirarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRetirarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetirarOrden.Name = "btnRetirarOrden";
            this.btnRetirarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRetirarOrden.Size = new System.Drawing.Size(160, 36);
            this.btnRetirarOrden.TabIndex = 9;
            this.btnRetirarOrden.Text = "Retirar Orden";
            this.btnRetirarOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRetirarOrden.UseAccentColor = false;
            this.btnRetirarOrden.UseVisualStyleBackColor = false;
            this.btnRetirarOrden.Click += new System.EventHandler(this.btnRetirarOrden_Click);
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
            this.btnNuevoTipoPrenda.Location = new System.Drawing.Point(390, 506);
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
            //this.btnNuevoTipoPrenda.Click += new System.EventHandler(this.btnNuevoTipoPrenda_Click);
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
            this.btnNuevoServicioTipoPrenda.Location = new System.Drawing.Point(58, 508);
            this.btnNuevoServicioTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoServicioTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoServicioTipoPrenda.Name = "btnNuevoServicioTipoPrenda";
            this.btnNuevoServicioTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoServicioTipoPrenda.Size = new System.Drawing.Size(104, 36);
            this.btnNuevoServicioTipoPrenda.TabIndex = 7;
            this.btnNuevoServicioTipoPrenda.Text = "Nuevo S-TP";
            this.btnNuevoServicioTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoServicioTipoPrenda.UseAccentColor = false;
            this.btnNuevoServicioTipoPrenda.UseVisualStyleBackColor = false;
            //this.btnNuevoServicioTipoPrenda.Click += new System.EventHandler(this.btnNuevoServicioTipoPrenda_Click);
            // 
            // txtBuscarOrdenes
            // 
            this.txtBuscarOrdenes.AnimateReadOnly = false;
            this.txtBuscarOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBuscarOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarOrdenes.Depth = 0;
            this.txtBuscarOrdenes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscarOrdenes.Hint = "Buscar ordenes...";
            this.txtBuscarOrdenes.LeadingIcon = null;
            this.txtBuscarOrdenes.Location = new System.Drawing.Point(335, 6);
            this.txtBuscarOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarOrdenes.MaxLength = 50;
            this.txtBuscarOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarOrdenes.Multiline = false;
            this.txtBuscarOrdenes.Name = "txtBuscarOrdenes";
            this.txtBuscarOrdenes.Size = new System.Drawing.Size(233, 50);
            this.txtBuscarOrdenes.TabIndex = 6;
            this.txtBuscarOrdenes.Text = "";
            this.txtBuscarOrdenes.TrailingIcon = null;
            this.txtBuscarOrdenes.TextChanged += new System.EventHandler(this.txtBuscarOrdenes_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(275, 37);
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
            this.btnEliminarOrden.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarOrden.Location = new System.Drawing.Point(52, 187);
            this.btnEliminarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarOrden.Size = new System.Drawing.Size(116, 36);
            this.btnEliminarOrden.TabIndex = 4;
            this.btnEliminarOrden.Text = "Eliminar";
            this.btnEliminarOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarOrden.UseAccentColor = false;
            this.btnEliminarOrden.UseVisualStyleBackColor = false;
            this.btnEliminarOrden.Click += new System.EventHandler(this.btnEliminarOrden_Click);
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.AutoSize = false;
            this.btnNuevaOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNuevaOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevaOrden.Depth = 0;
            this.btnNuevaOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevaOrden.HighEmphasis = true;
            this.btnNuevaOrden.Icon = global::UI.Desktop.Properties.Resources.addthelist_añadir_3477;
            this.btnNuevaOrden.Location = new System.Drawing.Point(52, 69);
            this.btnNuevaOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevaOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevaOrden.Size = new System.Drawing.Size(149, 36);
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
            this.columnNro,
            this.columnIdCliente,
            this.columnIdEmpleado,
            this.columnIdFactura,
            this.columnPrioridad,
            this.columnFechaEntrada,
            this.columnFechaSalida,
            this.columnEstado});
            this.listOrdenes.Depth = 0;
            this.listOrdenes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenes.FullRowSelect = true;
            this.listOrdenes.HideSelection = false;
            this.listOrdenes.Location = new System.Drawing.Point(275, 69);
            this.listOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOrdenes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenes.MultiSelect = false;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.OwnerDraw = true;
            this.listOrdenes.Size = new System.Drawing.Size(850, 372);
            this.listOrdenes.TabIndex = 2;
            this.listOrdenes.UseCompatibleStateImageBehavior = false;
            this.listOrdenes.View = System.Windows.Forms.View.Details;
            this.listOrdenes.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listOrdenes_ColumnWidthChanging);
            // 
            // columnNro
            // 
            this.columnNro.Text = "Nro";
            this.columnNro.Width = 70;
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
            // columnFechaSalida
            // 
            this.columnFechaSalida.Text = "Fecha de Salida";
            this.columnFechaSalida.Width = 150;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 100;
            // 
            
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
            // btnOrdenesCliente
            // 
            this.btnOrdenesCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrdenesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOrdenesCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOrdenesCliente.Depth = 0;
            this.btnOrdenesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrdenesCliente.HighEmphasis = true;
            this.btnOrdenesCliente.Icon = null;
            this.btnOrdenesCliente.Location = new System.Drawing.Point(1020, 129);
            this.btnOrdenesCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenesCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOrdenesCliente.Name = "btnOrdenesCliente";
            this.btnOrdenesCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOrdenesCliente.Size = new System.Drawing.Size(117, 36);
            this.btnOrdenesCliente.TabIndex = 5;
            this.btnOrdenesCliente.Text = "Ver Ordenes";
            this.btnOrdenesCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOrdenesCliente.UseAccentColor = false;
            this.btnOrdenesCliente.UseVisualStyleBackColor = false;
            this.btnOrdenesCliente.Click += new System.EventHandler(this.btnOrdenesCliente_Click);
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
            this.tabControlInventario.SelectedIndexChanged += new System.EventHandler(this.tabControlInventario_SelectedIndexChanged);
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
            this.listStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listStock.FullRowSelect = true;
            this.listStock.HideSelection = false;
            this.listStock.Location = new System.Drawing.Point(85, 31);
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
            this.listProveedores.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.listInsumos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.btnAgregarInsumo.Icon = global::UI.Desktop.Properties.Resources.productapplication_producto_3010;
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
            this.btnNuevoIngreso.Icon = global::UI.Desktop.Properties.Resources.product_delivery_icon_152013;
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
            this.listIngresos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.columnIdProvIngreso.Width = 115;
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
            this.columnFechaIngreso.Width = 210;
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
            // tabPlanificacion
            // 
            this.tabPlanificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPlanificacion.Controls.Add(this.tabControlPlanificacion);
            this.tabPlanificacion.Controls.Add(this.tabSelectorPlanificacion);
            this.tabPlanificacion.ImageKey = "20business-planning_102092.png";
            this.tabPlanificacion.Location = new System.Drawing.Point(4, 39);
            this.tabPlanificacion.Name = "tabPlanificacion";
            this.tabPlanificacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanificacion.Size = new System.Drawing.Size(1372, 679);
            this.tabPlanificacion.TabIndex = 3;
            this.tabPlanificacion.Text = "Planificación";
            // 
            // tabControlPlanificacion
            // 
            this.tabControlPlanificacion.Controls.Add(this.tabPendientes);
            this.tabControlPlanificacion.Controls.Add(this.tabEnProceso);
            this.tabControlPlanificacion.Depth = 0;
            this.tabControlPlanificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPlanificacion.ItemSize = new System.Drawing.Size(48, 20);
            this.tabControlPlanificacion.Location = new System.Drawing.Point(0, 47);
            this.tabControlPlanificacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlPlanificacion.Multiline = true;
            this.tabControlPlanificacion.Name = "tabControlPlanificacion";
            this.tabControlPlanificacion.SelectedIndex = 0;
            this.tabControlPlanificacion.Size = new System.Drawing.Size(1372, 632);
            this.tabControlPlanificacion.TabIndex = 1;
            // 
            // tabPendientes
            // 
            this.tabPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPendientes.Controls.Add(this.btnFinalizarTrabajo);
            this.tabPendientes.Controls.Add(this.btnIniciarServicio);
            this.tabPendientes.Controls.Add(this.listMaquinasItem);
            this.tabPendientes.Controls.Add(this.btnMostrarServicios);
            this.tabPendientes.Controls.Add(this.listEstadoMaquinas);
            this.tabPendientes.Controls.Add(this.listTrabajosPendientes);
            this.tabPendientes.Location = new System.Drawing.Point(4, 24);
            this.tabPendientes.Name = "tabPendientes";
            this.tabPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendientes.Size = new System.Drawing.Size(1364, 604);
            this.tabPendientes.TabIndex = 0;
            this.tabPendientes.Text = "Trabajos Pendientes";
            // 
            // btnFinalizarTrabajo
            // 
            this.btnFinalizarTrabajo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizarTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFinalizarTrabajo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalizarTrabajo.Depth = 0;
            this.btnFinalizarTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFinalizarTrabajo.HighEmphasis = true;
            this.btnFinalizarTrabajo.Icon = null;
            this.btnFinalizarTrabajo.Location = new System.Drawing.Point(981, 53);
            this.btnFinalizarTrabajo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizarTrabajo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizarTrabajo.Name = "btnFinalizarTrabajo";
            this.btnFinalizarTrabajo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalizarTrabajo.Size = new System.Drawing.Size(163, 36);
            this.btnFinalizarTrabajo.TabIndex = 6;
            this.btnFinalizarTrabajo.Text = "Finalizar Trabajo";
            this.btnFinalizarTrabajo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalizarTrabajo.UseAccentColor = false;
            this.btnFinalizarTrabajo.UseVisualStyleBackColor = false;
            this.btnFinalizarTrabajo.Click += new System.EventHandler(this.btnFinalizarTrabajo_Click_1);
            // 
            // btnIniciarServicio
            // 
            this.btnIniciarServicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIniciarServicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciarServicio.Depth = 0;
            this.btnIniciarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIniciarServicio.HighEmphasis = true;
            this.btnIniciarServicio.Icon = null;
            this.btnIniciarServicio.Location = new System.Drawing.Point(981, 7);
            this.btnIniciarServicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciarServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarServicio.Name = "btnIniciarServicio";
            this.btnIniciarServicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciarServicio.Size = new System.Drawing.Size(141, 36);
            this.btnIniciarServicio.TabIndex = 5;
            this.btnIniciarServicio.Text = "Iniciar Servicio";
            this.btnIniciarServicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciarServicio.UseAccentColor = false;
            this.btnIniciarServicio.UseVisualStyleBackColor = false;
            this.btnIniciarServicio.Click += new System.EventHandler(this.btnIniciarServicio_Click);
            // 
            // listMaquinasItem
            // 
            this.listMaquinasItem.AutoSizeTable = false;
            this.listMaquinasItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listMaquinasItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMaquinasItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaquina3,
            this.columnInicio1,
            this.columnFin});
            this.listMaquinasItem.Depth = 0;
            this.listMaquinasItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMaquinasItem.FullRowSelect = true;
            this.listMaquinasItem.HideSelection = false;
            this.listMaquinasItem.Location = new System.Drawing.Point(980, 223);
            this.listMaquinasItem.MinimumSize = new System.Drawing.Size(200, 100);
            this.listMaquinasItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMaquinasItem.MouseState = MaterialSkin.MouseState.OUT;
            this.listMaquinasItem.Name = "listMaquinasItem";
            this.listMaquinasItem.OwnerDraw = true;
            this.listMaquinasItem.Size = new System.Drawing.Size(294, 355);
            this.listMaquinasItem.TabIndex = 4;
            this.listMaquinasItem.UseCompatibleStateImageBehavior = false;
            this.listMaquinasItem.View = System.Windows.Forms.View.Details;
            // 
            // columnMaquina3
            // 
            this.columnMaquina3.Text = "Maquina";
            this.columnMaquina3.Width = 100;
            // 
            // columnInicio1
            // 
            this.columnInicio1.Text = "Inicio";
            this.columnInicio1.Width = 100;
            // 
            // columnFin
            // 
            this.columnFin.Text = "Fin";
            this.columnFin.Width = 100;
            // 
            // btnMostrarServicios
            // 
            this.btnMostrarServicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrarServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMostrarServicios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMostrarServicios.Depth = 0;
            this.btnMostrarServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMostrarServicios.HighEmphasis = true;
            this.btnMostrarServicios.Icon = null;
            this.btnMostrarServicios.Location = new System.Drawing.Point(981, 178);
            this.btnMostrarServicios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMostrarServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrarServicios.Name = "btnMostrarServicios";
            this.btnMostrarServicios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMostrarServicios.Size = new System.Drawing.Size(216, 36);
            this.btnMostrarServicios.TabIndex = 3;
            this.btnMostrarServicios.Text = "Ver servicios realizados";
            this.btnMostrarServicios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMostrarServicios.UseAccentColor = false;
            this.btnMostrarServicios.UseVisualStyleBackColor = false;
            this.btnMostrarServicios.Click += new System.EventHandler(this.btnMostrarServicios_Click);
            // 
            // listEstadoMaquinas
            // 
            this.listEstadoMaquinas.AutoSizeTable = false;
            this.listEstadoMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listEstadoMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEstadoMaquinas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaquina2,
            this.columnEstadoMaquina});
            this.listEstadoMaquinas.Depth = 0;
            this.listEstadoMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listEstadoMaquinas.FullRowSelect = true;
            this.listEstadoMaquinas.HideSelection = false;
            this.listEstadoMaquinas.Location = new System.Drawing.Point(6, 6);
            this.listEstadoMaquinas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listEstadoMaquinas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEstadoMaquinas.MouseState = MaterialSkin.MouseState.OUT;
            this.listEstadoMaquinas.Name = "listEstadoMaquinas";
            this.listEstadoMaquinas.OwnerDraw = true;
            this.listEstadoMaquinas.Size = new System.Drawing.Size(200, 572);
            this.listEstadoMaquinas.TabIndex = 2;
            this.listEstadoMaquinas.UseCompatibleStateImageBehavior = false;
            this.listEstadoMaquinas.View = System.Windows.Forms.View.Details;
            // 
            // columnMaquina2
            // 
            this.columnMaquina2.Text = "Maquina";
            this.columnMaquina2.Width = 100;
            // 
            // columnEstadoMaquina
            // 
            this.columnEstadoMaquina.Text = "Estado";
            this.columnEstadoMaquina.Width = 100;
            // 
            // listTrabajosPendientes
            // 
            this.listTrabajosPendientes.AutoSizeTable = false;
            this.listTrabajosPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listTrabajosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTrabajosPendientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrden,
            this.columnServicio,
            this.columnTipoPrenda,
            this.columnOrdenItem,
            this.columnState,
            this.columnPriority,
            this.columnTiempoRestante});
            this.listTrabajosPendientes.Depth = 0;
            this.listTrabajosPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listTrabajosPendientes.FullRowSelect = true;
            this.listTrabajosPendientes.HideSelection = false;
            this.listTrabajosPendientes.Location = new System.Drawing.Point(212, 6);
            this.listTrabajosPendientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listTrabajosPendientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listTrabajosPendientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listTrabajosPendientes.Name = "listTrabajosPendientes";
            this.listTrabajosPendientes.OwnerDraw = true;
            this.listTrabajosPendientes.Size = new System.Drawing.Size(762, 572);
            this.listTrabajosPendientes.TabIndex = 0;
            this.listTrabajosPendientes.UseCompatibleStateImageBehavior = false;
            this.listTrabajosPendientes.View = System.Windows.Forms.View.Details;
            // 
            // columnOrden
            // 
            this.columnOrden.Text = "Orden";
            this.columnOrden.Width = 70;
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 130;
            // 
            // columnTipoPrenda
            // 
            this.columnTipoPrenda.Text = "Tipo de Prenda";
            this.columnTipoPrenda.Width = 150;
            // 
            // columnOrdenItem
            // 
            this.columnOrdenItem.Text = "Item";
            // 
            // columnState
            // 
            this.columnState.Text = "Estado";
            this.columnState.Width = 100;
            // 
            // columnPriority
            // 
            this.columnPriority.Text = "Prioridad";
            this.columnPriority.Width = 100;
            // 
            // columnTiempoRestante
            // 
            this.columnTiempoRestante.Text = "Tiempo Restante";
            this.columnTiempoRestante.Width = 150;
            // 
            // tabEnProceso
            // 
            this.tabEnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabEnProceso.Controls.Add(this.btnTerminarServicio);
            this.tabEnProceso.Controls.Add(this.listTrabajosEnProceso);
            this.tabEnProceso.Location = new System.Drawing.Point(4, 24);
            this.tabEnProceso.Name = "tabEnProceso";
            this.tabEnProceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnProceso.Size = new System.Drawing.Size(1358, 597);
            this.tabEnProceso.TabIndex = 1;
            this.tabEnProceso.Text = "Trabajos en Proceso";
            // 
            // btnTerminarServicio
            // 
            this.btnTerminarServicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTerminarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTerminarServicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTerminarServicio.Depth = 0;
            this.btnTerminarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTerminarServicio.HighEmphasis = true;
            this.btnTerminarServicio.Icon = null;
            this.btnTerminarServicio.Location = new System.Drawing.Point(963, 6);
            this.btnTerminarServicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTerminarServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTerminarServicio.Name = "btnTerminarServicio";
            this.btnTerminarServicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTerminarServicio.Size = new System.Drawing.Size(162, 36);
            this.btnTerminarServicio.TabIndex = 1;
            this.btnTerminarServicio.Text = "Terminar Servicio";
            this.btnTerminarServicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTerminarServicio.UseAccentColor = false;
            this.btnTerminarServicio.UseVisualStyleBackColor = false;
            this.btnTerminarServicio.Click += new System.EventHandler(this.btnTerminarServicio_Click);
            // 
            // listTrabajosEnProceso
            // 
            this.listTrabajosEnProceso.AutoSizeTable = false;
            this.listTrabajosEnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listTrabajosEnProceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTrabajosEnProceso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaquina,
            this.columnNroOrden2,
            this.columnServicio2,
            this.columnTipoPrenda2,
            this.columnOrdenItem2,
            this.columnInicio,
            this.columnState2});
            this.listTrabajosEnProceso.Depth = 0;
            this.listTrabajosEnProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listTrabajosEnProceso.FullRowSelect = true;
            this.listTrabajosEnProceso.HideSelection = false;
            this.listTrabajosEnProceso.Location = new System.Drawing.Point(6, 6);
            this.listTrabajosEnProceso.MinimumSize = new System.Drawing.Size(200, 100);
            this.listTrabajosEnProceso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listTrabajosEnProceso.MouseState = MaterialSkin.MouseState.OUT;
            this.listTrabajosEnProceso.Name = "listTrabajosEnProceso";
            this.listTrabajosEnProceso.OwnerDraw = true;
            this.listTrabajosEnProceso.Size = new System.Drawing.Size(950, 576);
            this.listTrabajosEnProceso.TabIndex = 0;
            this.listTrabajosEnProceso.UseCompatibleStateImageBehavior = false;
            this.listTrabajosEnProceso.View = System.Windows.Forms.View.Details;
            // 
            // columnMaquina
            // 
            this.columnMaquina.Text = "Maquina";
            this.columnMaquina.Width = 100;
            // 
            // columnNroOrden2
            // 
            this.columnNroOrden2.Text = "Nro Orden";
            this.columnNroOrden2.Width = 100;
            // 
            // columnServicio2
            // 
            this.columnServicio2.Text = "Servicio";
            this.columnServicio2.Width = 150;
            // 
            // columnTipoPrenda2
            // 
            this.columnTipoPrenda2.Text = "Tipo de Prenda";
            this.columnTipoPrenda2.Width = 150;
            // 
            // columnOrdenItem2
            // 
            this.columnOrdenItem2.Text = "Orden Item";
            this.columnOrdenItem2.Width = 120;
            // 
            // columnInicio
            // 
            this.columnInicio.Text = "Hora de inicio";
            this.columnInicio.Width = 200;
            // 
            // columnState2
            // 
            this.columnState2.Text = "Estado";
            this.columnState2.Width = 130;
            // 
            // tabSelectorPlanificacion
            // 
            this.tabSelectorPlanificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabSelectorPlanificacion.BaseTabControl = this.tabControlPlanificacion;
            this.tabSelectorPlanificacion.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorPlanificacion.Depth = 0;
            this.tabSelectorPlanificacion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorPlanificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabSelectorPlanificacion.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorPlanificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSelectorPlanificacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorPlanificacion.Name = "tabSelectorPlanificacion";
            this.tabSelectorPlanificacion.Size = new System.Drawing.Size(1372, 47);
            this.tabSelectorPlanificacion.TabIndex = 0;
            this.tabSelectorPlanificacion.Text = "tabSelectorPlanificacion";
            // 
            // tabUtilidades
            // 
            this.tabUtilidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabUtilidades.Controls.Add(this.materialCard5);
            this.tabUtilidades.Controls.Add(this.materialCard4);
            this.tabUtilidades.Controls.Add(this.materialCard3);
            this.tabUtilidades.Controls.Add(this.materialCard2);
            this.tabUtilidades.Controls.Add(this.materialCard1);
            this.tabUtilidades.Location = new System.Drawing.Point(4, 39);
            this.tabUtilidades.Name = "tabUtilidades";
            this.tabUtilidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtilidades.Size = new System.Drawing.Size(1372, 679);
            this.tabUtilidades.TabIndex = 4;
            this.tabUtilidades.Text = "Utilidades";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard5.Controls.Add(this.materialLabel6);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Location = new System.Drawing.Point(17, 357);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(276, 284);
            this.materialCard5.TabIndex = 5;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 18);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Finanzas";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Controls.Add(this.btnObjetosPerdidos);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Location = new System.Drawing.Point(309, 220);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(279, 121);
            this.materialCard4.TabIndex = 4;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(18, 18);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Utilidades";
            // 
            // btnObjetosPerdidos
            // 
            this.btnObjetosPerdidos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObjetosPerdidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnObjetosPerdidos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnObjetosPerdidos.Depth = 0;
            this.btnObjetosPerdidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnObjetosPerdidos.HighEmphasis = true;
            this.btnObjetosPerdidos.Icon = null;
            this.btnObjetosPerdidos.Location = new System.Drawing.Point(18, 43);
            this.btnObjetosPerdidos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnObjetosPerdidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnObjetosPerdidos.Name = "btnObjetosPerdidos";
            this.btnObjetosPerdidos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnObjetosPerdidos.Size = new System.Drawing.Size(159, 36);
            this.btnObjetosPerdidos.TabIndex = 0;
            this.btnObjetosPerdidos.Text = "Objetos Perdidos";
            this.btnObjetosPerdidos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnObjetosPerdidos.UseAccentColor = false;
            this.btnObjetosPerdidos.UseVisualStyleBackColor = false;
            this.btnObjetosPerdidos.Click += new System.EventHandler(this.btnObjetosPerdidos_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Location = new System.Drawing.Point(603, 20);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(279, 321);
            this.materialCard3.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(149, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Informes del negocio";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.btnInsumos);
            this.materialCard2.Controls.Add(this.btnProveedores);
            this.materialCard2.Controls.Add(this.btnClientes);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Location = new System.Drawing.Point(309, 20);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(279, 178);
            this.materialCard2.TabIndex = 2;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel5.Location = new System.Drawing.Point(18, 10);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 19);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "materialLabel5";
            // 
            // btnInsumos
            // 
            this.btnInsumos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnInsumos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsumos.Depth = 0;
            this.btnInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsumos.HighEmphasis = true;
            this.btnInsumos.Icon = null;
            this.btnInsumos.Location = new System.Drawing.Point(18, 131);
            this.btnInsumos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsumos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsumos.Size = new System.Drawing.Size(86, 36);
            this.btnInsumos.TabIndex = 2;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsumos.UseAccentColor = false;
            this.btnInsumos.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnProveedores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProveedores.Depth = 0;
            this.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProveedores.HighEmphasis = true;
            this.btnProveedores.Icon = null;
            this.btnProveedores.Location = new System.Drawing.Point(18, 83);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProveedores.Size = new System.Drawing.Size(123, 36);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProveedores.UseAccentColor = false;
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClientes.Depth = 0;
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClientes.HighEmphasis = true;
            this.btnClientes.Icon = null;
            this.btnClientes.Location = new System.Drawing.Point(18, 35);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClientes.Size = new System.Drawing.Size(88, 36);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClientes.UseAccentColor = false;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard1.Controls.Add(this.btnUsuarios);
            this.materialCard1.Controls.Add(this.btnMaquinas);
            this.materialCard1.Controls.Add(this.btnEmpleados);
            this.materialCard1.Controls.Add(this.btnServicioTipoPrenda);
            this.materialCard1.Controls.Add(this.btnTipoPrenda);
            this.materialCard1.Controls.Add(this.btnServicio);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(276, 321);
            this.materialCard1.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUsuarios.Depth = 0;
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUsuarios.HighEmphasis = true;
            this.btnUsuarios.Icon = null;
            this.btnUsuarios.Location = new System.Drawing.Point(17, 270);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUsuarios.Size = new System.Drawing.Size(91, 36);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsuarios.UseAccentColor = false;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnMaquinas
            // 
            this.btnMaquinas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMaquinas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMaquinas.Depth = 0;
            this.btnMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMaquinas.HighEmphasis = true;
            this.btnMaquinas.Icon = null;
            this.btnMaquinas.Location = new System.Drawing.Point(18, 175);
            this.btnMaquinas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMaquinas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaquinas.Name = "btnMaquinas";
            this.btnMaquinas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMaquinas.Size = new System.Drawing.Size(97, 36);
            this.btnMaquinas.TabIndex = 4;
            this.btnMaquinas.Text = "Maquinas";
            this.btnMaquinas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMaquinas.UseAccentColor = false;
            this.btnMaquinas.UseVisualStyleBackColor = false;
            this.btnMaquinas.Click += new System.EventHandler(this.btnMaquinas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEmpleados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEmpleados.Depth = 0;
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEmpleados.HighEmphasis = true;
            this.btnEmpleados.Icon = null;
            this.btnEmpleados.Location = new System.Drawing.Point(18, 223);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEmpleados.Size = new System.Drawing.Size(107, 36);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEmpleados.UseAccentColor = false;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnServicioTipoPrenda
            // 
            this.btnServicioTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServicioTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnServicioTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnServicioTipoPrenda.Depth = 0;
            this.btnServicioTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnServicioTipoPrenda.HighEmphasis = true;
            this.btnServicioTipoPrenda.Icon = null;
            this.btnServicioTipoPrenda.Location = new System.Drawing.Point(18, 127);
            this.btnServicioTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServicioTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServicioTipoPrenda.Name = "btnServicioTipoPrenda";
            this.btnServicioTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnServicioTipoPrenda.Size = new System.Drawing.Size(195, 36);
            this.btnServicioTipoPrenda.TabIndex = 3;
            this.btnServicioTipoPrenda.Text = "Servicios - TipoPrenda";
            this.btnServicioTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnServicioTipoPrenda.UseAccentColor = false;
            this.btnServicioTipoPrenda.UseVisualStyleBackColor = false;
            this.btnServicioTipoPrenda.Click += new System.EventHandler(this.btnServicioTipoPrenda_Click);
            // 
            // btnTipoPrenda
            // 
            this.btnTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTipoPrenda.Depth = 0;
            this.btnTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTipoPrenda.HighEmphasis = true;
            this.btnTipoPrenda.Icon = null;
            this.btnTipoPrenda.Location = new System.Drawing.Point(18, 81);
            this.btnTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoPrenda.Name = "btnTipoPrenda";
            this.btnTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTipoPrenda.Size = new System.Drawing.Size(145, 36);
            this.btnTipoPrenda.TabIndex = 2;
            this.btnTipoPrenda.Text = "Tipos de prenda";
            this.btnTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTipoPrenda.UseAccentColor = false;
            this.btnTipoPrenda.UseVisualStyleBackColor = false;
            // 
            // btnServicio
            // 
            this.btnServicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnServicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnServicio.Depth = 0;
            this.btnServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnServicio.HighEmphasis = true;
            this.btnServicio.Icon = null;
            this.btnServicio.Location = new System.Drawing.Point(18, 35);
            this.btnServicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnServicio.Size = new System.Drawing.Size(94, 36);
            this.btnServicio.TabIndex = 1;
            this.btnServicio.Text = "Servicios";
            this.btnServicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnServicio.UseAccentColor = false;
            this.btnServicio.UseVisualStyleBackColor = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Administrar negocio:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "adduser_añadir_3553.png");
            this.imageList1.Images.SetKeyName(1, "addthelist_añadir_3477.png");
            this.imageList1.Images.SetKeyName(2, "sales_sale_supermarket_stock_market_icon_153849.png");
            this.imageList1.Images.SetKeyName(3, "20business-planning_102092.png");
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.epUser);
            this.Controls.Add(this.mnuPrincipal);
            this.DrawerAutoHide = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mnuPrincipal;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.tabPlanificacion.ResumeLayout(false);
            this.tabControlPlanificacion.ResumeLayout(false);
            this.tabPendientes.ResumeLayout(false);
            this.tabPendientes.PerformLayout();
            this.tabEnProceso.ResumeLayout(false);
            this.tabEnProceso.PerformLayout();
            this.tabUtilidades.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.epUser.ResumeLayout(false);
            this.epUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl mnuPrincipal;
        private System.Windows.Forms.TabPage mnuTabOrdenes;
        private System.Windows.Forms.TabPage mnuTabClientes;
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.ColumnHeader columnNro;
        private System.Windows.Forms.ColumnHeader columnIdCliente;
        private System.Windows.Forms.ColumnHeader columnIdEmpleado;
        private System.Windows.Forms.ColumnHeader columnIdFactura;
        private System.Windows.Forms.ColumnHeader columnPrioridad;
        private System.Windows.Forms.ColumnHeader columnFechaEntrada;
        private MaterialSkin.Controls.MaterialButton btnEliminarOrden;
        private MaterialSkin.Controls.MaterialButton btnNuevaOrden;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarOrdenes;
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
        private MaterialSkin.Controls.MaterialButton btnEditarOrden;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private System.Windows.Forms.TabPage tabPlanificacion;
        private MaterialSkin.Controls.MaterialTabControl tabControlPlanificacion;
        private System.Windows.Forms.TabPage tabPendientes;
        private System.Windows.Forms.TabPage tabEnProceso;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorPlanificacion;
        private System.Windows.Forms.TabPage tabUtilidades;
        private MaterialSkin.Controls.MaterialListView listTrabajosPendientes;
        private System.Windows.Forms.ColumnHeader columnOrden;
        private System.Windows.Forms.ColumnHeader columnServicio;
        private System.Windows.Forms.ColumnHeader columnTipoPrenda;
        private System.Windows.Forms.ColumnHeader columnOrdenItem;
        private System.Windows.Forms.ColumnHeader columnState;
        private System.Windows.Forms.ColumnHeader columnPriority;
        private MaterialSkin.Controls.MaterialButton btnOrdenesCliente;
        private System.Windows.Forms.ColumnHeader columnTiempoRestante;
        private MaterialSkin.Controls.MaterialListView listTrabajosEnProceso;
        private System.Windows.Forms.ColumnHeader columnMaquina;
        private System.Windows.Forms.ColumnHeader columnNroOrden2;
        private System.Windows.Forms.ColumnHeader columnServicio2;
        private System.Windows.Forms.ColumnHeader columnTipoPrenda2;
        private System.Windows.Forms.ColumnHeader columnOrdenItem2;
        private MaterialSkin.Controls.MaterialListView listEstadoMaquinas;
        private System.Windows.Forms.ColumnHeader columnMaquina2;
        private System.Windows.Forms.ColumnHeader columnEstadoMaquina;
        private System.Windows.Forms.ColumnHeader columnInicio;
        private MaterialSkin.Controls.MaterialButton btnMostrarServicios;
        private MaterialSkin.Controls.MaterialListView listMaquinasItem;
        private System.Windows.Forms.ColumnHeader columnMaquina3;
        private System.Windows.Forms.ColumnHeader columnInicio1;
        private System.Windows.Forms.ColumnHeader columnFin;
        private MaterialSkin.Controls.MaterialButton btnIniciarServicio;
        private MaterialSkin.Controls.MaterialButton btnFinalizarTrabajo;
        private MaterialSkin.Controls.MaterialButton btnTerminarServicio;
        private System.Windows.Forms.ColumnHeader columnState2;
        private MaterialSkin.Controls.MaterialButton btnObjetosPerdidos;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnMaquinas;
        private MaterialSkin.Controls.MaterialButton btnServicioTipoPrenda;
        private MaterialSkin.Controls.MaterialButton btnTipoPrenda;
        private MaterialSkin.Controls.MaterialButton btnServicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnInsumos;
        private MaterialSkin.Controls.MaterialButton btnProveedores;
        private MaterialSkin.Controls.MaterialButton btnClientes;
        private MaterialSkin.Controls.MaterialButton btnUsuarios;
        private MaterialSkin.Controls.MaterialButton btnEmpleados;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

