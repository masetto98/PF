
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
            this.cmbBuscarOrden = new MaterialSkin.Controls.MaterialComboBox();
            this.btnVerDetalles = new MaterialSkin.Controls.MaterialButton();
            this.btnEditarOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnRetirarOrden = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarOrdenes = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarOrden = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevaOrden = new MaterialSkin.Controls.MaterialButton();
            this.listOrdenes = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnCliente = new System.Windows.Forms.ColumnHeader();
            this.columnPrioridad = new System.Windows.Forms.ColumnHeader();
            this.columnFechaEntrada = new System.Windows.Forms.ColumnHeader();
            this.columnFechaSalida = new System.Windows.Forms.ColumnHeader();
            this.columnEstado = new System.Windows.Forms.ColumnHeader();
            this.mnuTabClientes = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.btnSaldarDeuda = new MaterialSkin.Controls.MaterialButton();
            this.lblCuentaCorriente = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregarPago = new MaterialSkin.Controls.MaterialButton();
            this.btnVerPagos = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.listPagosOrden = new MaterialSkin.Controls.MaterialListView();
            this.columnFechaPago = new System.Windows.Forms.ColumnHeader();
            this.columnValorPago = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPago = new System.Windows.Forms.ColumnHeader();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.listOrdenesCliente = new MaterialSkin.Controls.MaterialListView();
            this.columnNroOrden = new System.Windows.Forms.ColumnHeader();
            this.columnFecha = new System.Windows.Forms.ColumnHeader();
            this.columnValor = new System.Windows.Forms.ColumnHeader();
            this.columnDeuda = new System.Windows.Forms.ColumnHeader();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBuscarCliente = new MaterialSkin.Controls.MaterialComboBox();
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
            this.columnRazonSocial = new System.Windows.Forms.ColumnHeader();
            this.mnuTabInventario = new System.Windows.Forms.TabPage();
            this.tabControlInventario = new MaterialSkin.Controls.MaterialTabControl();
            this.TabStock = new System.Windows.Forms.TabPage();
            this.cmbInsumos = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarInsumos = new MaterialSkin.Controls.MaterialTextBox();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.dtpFiltroFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarIngresoInsumo = new MaterialSkin.Controls.MaterialButton();
            this.listIngresosInsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnProveedor = new System.Windows.Forms.ColumnHeader();
            this.columnFechaInput = new System.Windows.Forms.ColumnHeader();
            this.columnCantidad = new System.Windows.Forms.ColumnHeader();
            this.columnUniMed = new System.Windows.Forms.ColumnHeader();
            this.btnIngresoInsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.listInsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnIDIns = new System.Windows.Forms.ColumnHeader();
            this.columnDescripcionIns = new System.Windows.Forms.ColumnHeader();
            this.columnStock = new System.Windows.Forms.ColumnHeader();
            this.columnUniMedida = new System.Windows.Forms.ColumnHeader();
            this.btnEditarInsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarInsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarInsumo = new MaterialSkin.Controls.MaterialButton();
            this.TabMovimientos = new System.Windows.Forms.TabPage();
            this.btnActualizarIngresos = new MaterialSkin.Controls.MaterialButton();
            this.lblFiltrarFecha = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFiltrarFechaIngreso = new System.Windows.Forms.DateTimePicker();
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
            this.txtBuscarTrabajosPendientes = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbTrabajosPendientes = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
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
            this.btnGastos = new MaterialSkin.Controls.MaterialButton();
            this.btnCaja = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.btnAtributos = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnObjetosPerdidos = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnReporteEmpleados = new MaterialSkin.Controls.MaterialButton();
            this.btnMovimientos = new MaterialSkin.Controls.MaterialButton();
            this.btnReporteGastos = new MaterialSkin.Controls.MaterialButton();
            this.btnDeudas = new MaterialSkin.Controls.MaterialButton();
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
            this.chkCambioColor = new MaterialSkin.Controls.MaterialSwitch();
            this.btnEditarPerfil = new MaterialSkin.Controls.MaterialButton();
            this.imgUserLogin = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            this.mnuPrincipal.SuspendLayout();
            this.mnuTabOrdenes.SuspendLayout();
            this.mnuTabClientes.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.mnuTabInventario.SuspendLayout();
            this.tabControlInventario.SuspendLayout();
            this.TabStock.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.imgUserLogin)).BeginInit();
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
            this.mnuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mnuPrincipal.ImageList = this.imageList1;
            this.mnuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.mnuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mnuPrincipal.Multiline = true;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.SelectedIndex = 0;
            this.mnuPrincipal.Size = new System.Drawing.Size(1361, 722);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.SelectedIndexChanged += new System.EventHandler(this.mnuPrincipal_SelectedIndexChanged);
            // 
            // mnuTabOrdenes
            // 
            this.mnuTabOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mnuTabOrdenes.Controls.Add(this.cmbBuscarOrden);
            this.mnuTabOrdenes.Controls.Add(this.btnVerDetalles);
            this.mnuTabOrdenes.Controls.Add(this.btnEditarOrden);
            this.mnuTabOrdenes.Controls.Add(this.btnRetirarOrden);
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
            this.mnuTabOrdenes.Size = new System.Drawing.Size(1353, 679);
            this.mnuTabOrdenes.TabIndex = 0;
            this.mnuTabOrdenes.Text = "Ordenes";
            // 
            // cmbBuscarOrden
            // 
            this.cmbBuscarOrden.AutoResize = false;
            this.cmbBuscarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbBuscarOrden.Depth = 0;
            this.cmbBuscarOrden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBuscarOrden.DropDownHeight = 174;
            this.cmbBuscarOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarOrden.DropDownWidth = 121;
            this.cmbBuscarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBuscarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBuscarOrden.FormattingEnabled = true;
            this.cmbBuscarOrden.Hint = "Filtro";
            this.cmbBuscarOrden.IntegralHeight = false;
            this.cmbBuscarOrden.ItemHeight = 43;
            this.cmbBuscarOrden.Location = new System.Drawing.Point(87, 550);
            this.cmbBuscarOrden.MaxDropDownItems = 4;
            this.cmbBuscarOrden.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBuscarOrden.Name = "cmbBuscarOrden";
            this.cmbBuscarOrden.Size = new System.Drawing.Size(222, 49);
            this.cmbBuscarOrden.StartIndex = 0;
            this.cmbBuscarOrden.TabIndex = 12;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.AutoSize = false;
            this.btnVerDetalles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVerDetalles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerDetalles.Depth = 0;
            this.btnVerDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerDetalles.HighEmphasis = true;
            this.btnVerDetalles.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnVerDetalles.Location = new System.Drawing.Point(1164, 74);
            this.btnVerDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerDetalles.Size = new System.Drawing.Size(114, 55);
            this.btnVerDetalles.TabIndex = 11;
            this.btnVerDetalles.Text = "Detalles";
            this.btnVerDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerDetalles.UseAccentColor = false;
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnEditarOrden
            // 
            this.btnEditarOrden.AutoSize = false;
            this.btnEditarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarOrden.Depth = 0;
            this.btnEditarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarOrden.HighEmphasis = true;
            this.btnEditarOrden.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarOrden.Location = new System.Drawing.Point(149, 8);
            this.btnEditarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarOrden.Name = "btnEditarOrden";
            this.btnEditarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarOrden.Size = new System.Drawing.Size(114, 51);
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
            this.btnRetirarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRetirarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRetirarOrden.Depth = 0;
            this.btnRetirarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRetirarOrden.HighEmphasis = true;
            this.btnRetirarOrden.Icon = global::UI.Desktop.Properties.Resources.thefreeforty_withdraw_icon_icons_com_66307;
            this.btnRetirarOrden.Location = new System.Drawing.Point(1164, 141);
            this.btnRetirarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRetirarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetirarOrden.Name = "btnRetirarOrden";
            this.btnRetirarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRetirarOrden.Size = new System.Drawing.Size(114, 51);
            this.btnRetirarOrden.TabIndex = 9;
            this.btnRetirarOrden.Text = "Retirar Orden";
            this.btnRetirarOrden.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRetirarOrden.UseAccentColor = false;
            this.btnRetirarOrden.UseVisualStyleBackColor = false;
            this.btnRetirarOrden.Click += new System.EventHandler(this.btnRetirarOrden_Click);
            // 
            // txtBuscarOrdenes
            // 
            this.txtBuscarOrdenes.AnimateReadOnly = false;
            this.txtBuscarOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscarOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarOrdenes.Depth = 0;
            this.txtBuscarOrdenes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscarOrdenes.Hint = "Buscar ordenes...";
            this.txtBuscarOrdenes.LeadingIcon = null;
            this.txtBuscarOrdenes.Location = new System.Drawing.Point(315, 550);
            this.txtBuscarOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarOrdenes.MaxLength = 50;
            this.txtBuscarOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarOrdenes.Multiline = false;
            this.txtBuscarOrdenes.Name = "txtBuscarOrdenes";
            this.txtBuscarOrdenes.Size = new System.Drawing.Size(438, 50);
            this.txtBuscarOrdenes.TabIndex = 6;
            this.txtBuscarOrdenes.Text = "";
            this.txtBuscarOrdenes.TrailingIcon = null;
            this.txtBuscarOrdenes.TextChanged += new System.EventHandler(this.txtBuscarOrdenes_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 565);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Buscar:";
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.AutoSize = false;
            this.btnEliminarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarOrden.Depth = 0;
            this.btnEliminarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarOrden.HighEmphasis = true;
            this.btnEliminarOrden.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarOrden.Location = new System.Drawing.Point(271, 8);
            this.btnEliminarOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarOrden.Size = new System.Drawing.Size(114, 51);
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
            this.btnNuevaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNuevaOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevaOrden.Depth = 0;
            this.btnNuevaOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaOrden.HighEmphasis = true;
            this.btnNuevaOrden.Icon = global::UI.Desktop.Properties.Resources.addthelist_añadir_3477;
            this.btnNuevaOrden.Location = new System.Drawing.Point(27, 8);
            this.btnNuevaOrden.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevaOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevaOrden.Size = new System.Drawing.Size(114, 51);
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
            this.listOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnCliente,
            this.columnPrioridad,
            this.columnFechaEntrada,
            this.columnFechaSalida,
            this.columnEstado});
            this.listOrdenes.Depth = 0;
            this.listOrdenes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenes.FullRowSelect = true;
            this.listOrdenes.HideSelection = false;
            this.listOrdenes.Location = new System.Drawing.Point(27, 74);
            this.listOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOrdenes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenes.MultiSelect = false;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.OwnerDraw = true;
            this.listOrdenes.Size = new System.Drawing.Size(1118, 465);
            this.listOrdenes.TabIndex = 2;
            this.listOrdenes.UseCompatibleStateImageBehavior = false;
            this.listOrdenes.View = System.Windows.Forms.View.Details;
            this.listOrdenes.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listOrdenes_ColumnWidthChanging);
            this.listOrdenes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOrdenes_MouseDoubleClick);
            // 
            // columnNro
            // 
            this.columnNro.Text = "N° Orden";
            this.columnNro.Width = 90;
            // 
            // columnCliente
            // 
            this.columnCliente.Text = "Cliente(Nombre y Apellido/Razón Social)";
            this.columnCliente.Width = 345;
            // 
            // columnPrioridad
            // 
            this.columnPrioridad.Text = "Prioridad";
            this.columnPrioridad.Width = 150;
            // 
            // columnFechaEntrada
            // 
            this.columnFechaEntrada.Text = "Fecha Ingreso";
            this.columnFechaEntrada.Width = 200;
            // 
            // columnFechaSalida
            // 
            this.columnFechaSalida.Text = "Fecha de Salida";
            this.columnFechaSalida.Width = 210;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 123;
            // 
            // mnuTabClientes
            // 
            this.mnuTabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mnuTabClientes.Controls.Add(this.materialCard7);
            this.mnuTabClientes.Controls.Add(this.btnAgregarPago);
            this.mnuTabClientes.Controls.Add(this.btnVerPagos);
            this.mnuTabClientes.Controls.Add(this.materialLabel11);
            this.mnuTabClientes.Controls.Add(this.listPagosOrden);
            this.mnuTabClientes.Controls.Add(this.materialLabel10);
            this.mnuTabClientes.Controls.Add(this.listOrdenesCliente);
            this.mnuTabClientes.Controls.Add(this.materialLabel9);
            this.mnuTabClientes.Controls.Add(this.cmbBuscarCliente);
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
            this.mnuTabClientes.Size = new System.Drawing.Size(1353, 679);
            this.mnuTabClientes.TabIndex = 1;
            this.mnuTabClientes.Text = "Clientes";
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.btnSaldarDeuda);
            this.materialCard7.Controls.Add(this.lblCuentaCorriente);
            this.materialCard7.Controls.Add(this.materialLabel12);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(844, 16);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(403, 72);
            this.materialCard7.TabIndex = 14;
            // 
            // btnSaldarDeuda
            // 
            this.btnSaldarDeuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaldarDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSaldarDeuda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaldarDeuda.Depth = 0;
            this.btnSaldarDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaldarDeuda.HighEmphasis = true;
            this.btnSaldarDeuda.Icon = null;
            this.btnSaldarDeuda.Location = new System.Drawing.Point(263, 18);
            this.btnSaldarDeuda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaldarDeuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaldarDeuda.Name = "btnSaldarDeuda";
            this.btnSaldarDeuda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaldarDeuda.Size = new System.Drawing.Size(127, 36);
            this.btnSaldarDeuda.TabIndex = 3;
            this.btnSaldarDeuda.Text = "Saldar deuda";
            this.btnSaldarDeuda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaldarDeuda.UseAccentColor = false;
            this.btnSaldarDeuda.UseVisualStyleBackColor = false;
            this.btnSaldarDeuda.Click += new System.EventHandler(this.btnSaldarDeuda_Click);
            // 
            // lblCuentaCorriente
            // 
            this.lblCuentaCorriente.AutoSize = true;
            this.lblCuentaCorriente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCuentaCorriente.Depth = 0;
            this.lblCuentaCorriente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCuentaCorriente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCuentaCorriente.Location = new System.Drawing.Point(143, 28);
            this.lblCuentaCorriente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCuentaCorriente.Name = "lblCuentaCorriente";
            this.lblCuentaCorriente.Size = new System.Drawing.Size(5, 19);
            this.lblCuentaCorriente.TabIndex = 2;
            this.lblCuentaCorriente.Text = "-";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(17, 28);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(120, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Cuenta corriente:";
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.AutoSize = false;
            this.btnAgregarPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarPago.Depth = 0;
            this.btnAgregarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarPago.HighEmphasis = true;
            this.btnAgregarPago.Icon = global::UI.Desktop.Properties.Resources.pay_payment_bill_dollar_cash_icon_143281;
            this.btnAgregarPago.Location = new System.Drawing.Point(1133, 214);
            this.btnAgregarPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarPago.Size = new System.Drawing.Size(114, 51);
            this.btnAgregarPago.TabIndex = 13;
            this.btnAgregarPago.Text = "Agregar Pago";
            this.btnAgregarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarPago.UseAccentColor = false;
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // btnVerPagos
            // 
            this.btnVerPagos.AutoSize = false;
            this.btnVerPagos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVerPagos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerPagos.Depth = 0;
            this.btnVerPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerPagos.HighEmphasis = true;
            this.btnVerPagos.Icon = global::UI.Desktop.Properties.Resources.payment_tax_invoice_document_calculator_icon_188684__1_;
            this.btnVerPagos.Location = new System.Drawing.Point(1133, 151);
            this.btnVerPagos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerPagos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerPagos.Name = "btnVerPagos";
            this.btnVerPagos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerPagos.Size = new System.Drawing.Size(114, 51);
            this.btnVerPagos.TabIndex = 12;
            this.btnVerPagos.Text = "Ver pagos";
            this.btnVerPagos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerPagos.UseAccentColor = false;
            this.btnVerPagos.UseVisualStyleBackColor = false;
            this.btnVerPagos.Click += new System.EventHandler(this.btnVerPagos_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(678, 357);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(132, 19);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "Pagos de la orden:";
            // 
            // listPagosOrden
            // 
            this.listPagosOrden.AutoSizeTable = false;
            this.listPagosOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPagosOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPagosOrden.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFechaPago,
            this.columnValorPago,
            this.columnTipoPago});
            this.listPagosOrden.Depth = 0;
            this.listPagosOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPagosOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listPagosOrden.FullRowSelect = true;
            this.listPagosOrden.HideSelection = false;
            this.listPagosOrden.Location = new System.Drawing.Point(678, 379);
            this.listPagosOrden.MinimumSize = new System.Drawing.Size(200, 100);
            this.listPagosOrden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listPagosOrden.MouseState = MaterialSkin.MouseState.OUT;
            this.listPagosOrden.MultiSelect = false;
            this.listPagosOrden.Name = "listPagosOrden";
            this.listPagosOrden.OwnerDraw = true;
            this.listPagosOrden.Size = new System.Drawing.Size(451, 198);
            this.listPagosOrden.TabIndex = 10;
            this.listPagosOrden.UseCompatibleStateImageBehavior = false;
            this.listPagosOrden.View = System.Windows.Forms.View.Details;
            this.listPagosOrden.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listPagosOrden_ColumnWidthChanging);
            // 
            // columnFechaPago
            // 
            this.columnFechaPago.Text = "Fecha";
            this.columnFechaPago.Width = 199;
            // 
            // columnValorPago
            // 
            this.columnValorPago.Text = "Valor";
            this.columnValorPago.Width = 100;
            // 
            // columnTipoPago
            // 
            this.columnTipoPago.Text = "Tipo de pago";
            this.columnTipoPago.Width = 152;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(678, 128);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(138, 19);
            this.materialLabel10.TabIndex = 9;
            this.materialLabel10.Text = "Ordenes del cliente:";
            // 
            // listOrdenesCliente
            // 
            this.listOrdenesCliente.AutoSizeTable = false;
            this.listOrdenesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenesCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenesCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNroOrden,
            this.columnFecha,
            this.columnValor,
            this.columnDeuda});
            this.listOrdenesCliente.Depth = 0;
            this.listOrdenesCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listOrdenesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenesCliente.FullRowSelect = true;
            this.listOrdenesCliente.HideSelection = false;
            this.listOrdenesCliente.Location = new System.Drawing.Point(678, 150);
            this.listOrdenesCliente.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenesCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenesCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenesCliente.MultiSelect = false;
            this.listOrdenesCliente.Name = "listOrdenesCliente";
            this.listOrdenesCliente.OwnerDraw = true;
            this.listOrdenesCliente.Size = new System.Drawing.Size(450, 192);
            this.listOrdenesCliente.TabIndex = 8;
            this.listOrdenesCliente.UseCompatibleStateImageBehavior = false;
            this.listOrdenesCliente.View = System.Windows.Forms.View.Details;
            this.listOrdenesCliente.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listOrdenesCliente_ColumnWidthChanging);
            // 
            // columnNroOrden
            // 
            this.columnNroOrden.Text = "N° Orden";
            this.columnNroOrden.Width = 100;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "FechaEntrada";
            this.columnFecha.Width = 156;
            // 
            // columnValor
            // 
            this.columnValor.Text = "Importe";
            this.columnValor.Width = 95;
            // 
            // columnDeuda
            // 
            this.columnDeuda.Text = "Deuda";
            this.columnDeuda.Width = 99;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(26, 601);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(54, 19);
            this.materialLabel9.TabIndex = 7;
            this.materialLabel9.Text = "Buscar:";
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.AutoResize = false;
            this.cmbBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbBuscarCliente.Depth = 0;
            this.cmbBuscarCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBuscarCliente.DropDownHeight = 174;
            this.cmbBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCliente.DropDownWidth = 121;
            this.cmbBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Hint = "Filtro";
            this.cmbBuscarCliente.IntegralHeight = false;
            this.cmbBuscarCliente.ItemHeight = 43;
            this.cmbBuscarCliente.Location = new System.Drawing.Point(86, 585);
            this.cmbBuscarCliente.MaxDropDownItems = 4;
            this.cmbBuscarCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(217, 49);
            this.cmbBuscarCliente.StartIndex = 0;
            this.cmbBuscarCliente.TabIndex = 6;
            // 
            // btnOrdenesCliente
            // 
            this.btnOrdenesCliente.AutoSize = false;
            this.btnOrdenesCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrdenesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnOrdenesCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOrdenesCliente.Depth = 0;
            this.btnOrdenesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrdenesCliente.HighEmphasis = true;
            this.btnOrdenesCliente.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnOrdenesCliente.Location = new System.Drawing.Point(678, 71);
            this.btnOrdenesCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenesCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOrdenesCliente.Name = "btnOrdenesCliente";
            this.btnOrdenesCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOrdenesCliente.Size = new System.Drawing.Size(111, 51);
            this.btnOrdenesCliente.TabIndex = 5;
            this.btnOrdenesCliente.Text = "Detalles";
            this.btnOrdenesCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOrdenesCliente.UseAccentColor = false;
            this.btnOrdenesCliente.UseVisualStyleBackColor = false;
            this.btnOrdenesCliente.Click += new System.EventHandler(this.btnOrdenesCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.AnimateReadOnly = false;
            this.txtBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscarCliente.Hint = "Buscar cliente...";
            this.txtBuscarCliente.LeadingIcon = null;
            this.txtBuscarCliente.Location = new System.Drawing.Point(309, 585);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.MaxLength = 50;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarCliente.Multiline = false;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(362, 50);
            this.txtBuscarCliente.TabIndex = 4;
            this.txtBuscarCliente.Text = "";
            this.txtBuscarCliente.TrailingIcon = null;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.AutoSize = false;
            this.btnEditarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarCliente.Depth = 0;
            this.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarCliente.HighEmphasis = true;
            this.btnEditarCliente.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarCliente.Location = new System.Drawing.Point(145, 12);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarCliente.Size = new System.Drawing.Size(114, 51);
            this.btnEditarCliente.TabIndex = 3;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarCliente.UseAccentColor = false;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.AutoSize = false;
            this.btnEliminarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarCliente.Depth = 0;
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarCliente.HighEmphasis = true;
            this.btnEliminarCliente.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarCliente.Location = new System.Drawing.Point(267, 13);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarCliente.Size = new System.Drawing.Size(111, 51);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarCliente.UseAccentColor = false;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
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
            this.btnAgregarCliente.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnAgregarCliente.Location = new System.Drawing.Point(26, 12);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarCliente.Size = new System.Drawing.Size(111, 51);
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
            this.listClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnCuit,
            this.columnNombre,
            this.columnApellido,
            this.columnRazonSocial});
            this.listClientes.Depth = 0;
            this.listClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listClientes.FullRowSelect = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(26, 71);
            this.listClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listClientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listClientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listClientes.MultiSelect = false;
            this.listClientes.Name = "listClientes";
            this.listClientes.OwnerDraw = true;
            this.listClientes.Size = new System.Drawing.Size(645, 506);
            this.listClientes.TabIndex = 0;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            this.listClientes.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listClientes_ColumnWidthChanging);
            this.listClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listClientes_MouseDoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 50;
            // 
            // columnCuit
            // 
            this.columnCuit.Text = "Cuit";
            this.columnCuit.Width = 140;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 150;
            // 
            // columnApellido
            // 
            this.columnApellido.Text = "Apellido";
            this.columnApellido.Width = 150;
            // 
            // columnRazonSocial
            // 
            this.columnRazonSocial.Text = "Razón Social";
            this.columnRazonSocial.Width = 155;
            // 
            // mnuTabInventario
            // 
            this.mnuTabInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mnuTabInventario.Controls.Add(this.tabControlInventario);
            this.mnuTabInventario.Controls.Add(this.tabSelectorInventario);
            this.mnuTabInventario.ImageKey = "sales_sale_supermarket_stock_market_icon_153849.png";
            this.mnuTabInventario.Location = new System.Drawing.Point(4, 39);
            this.mnuTabInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuTabInventario.Name = "mnuTabInventario";
            this.mnuTabInventario.Size = new System.Drawing.Size(1353, 679);
            this.mnuTabInventario.TabIndex = 2;
            this.mnuTabInventario.Text = "Inventario";
            // 
            // tabControlInventario
            // 
            this.tabControlInventario.Controls.Add(this.TabStock);
            this.tabControlInventario.Controls.Add(this.TabMovimientos);
            this.tabControlInventario.Depth = 0;
            this.tabControlInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControlInventario.Location = new System.Drawing.Point(0, 47);
            this.tabControlInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlInventario.Multiline = true;
            this.tabControlInventario.Name = "tabControlInventario";
            this.tabControlInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlInventario.SelectedIndex = 0;
            this.tabControlInventario.Size = new System.Drawing.Size(1353, 632);
            this.tabControlInventario.TabIndex = 1;
            this.tabControlInventario.SelectedIndexChanged += new System.EventHandler(this.tabControlInventario_SelectedIndexChanged);
            // 
            // TabStock
            // 
            this.TabStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TabStock.Controls.Add(this.cmbInsumos);
            this.TabStock.Controls.Add(this.materialLabel14);
            this.TabStock.Controls.Add(this.txtBuscarInsumos);
            this.TabStock.Controls.Add(this.btnReset);
            this.TabStock.Controls.Add(this.dtpFiltroFechaIngreso);
            this.TabStock.Controls.Add(this.materialLabel8);
            this.TabStock.Controls.Add(this.materialLabel7);
            this.TabStock.Controls.Add(this.btnEliminarIngresoInsumo);
            this.TabStock.Controls.Add(this.listIngresosInsumos);
            this.TabStock.Controls.Add(this.btnIngresoInsumo);
            this.TabStock.Controls.Add(this.btnDetalles);
            this.TabStock.Controls.Add(this.listInsumos);
            this.TabStock.Controls.Add(this.btnEditarInsumo);
            this.TabStock.Controls.Add(this.btnEliminarInsumo);
            this.TabStock.Controls.Add(this.btnAgregarInsumo);
            this.TabStock.Location = new System.Drawing.Point(4, 24);
            this.TabStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabStock.Name = "TabStock";
            this.TabStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabStock.Size = new System.Drawing.Size(1345, 604);
            this.TabStock.TabIndex = 0;
            this.TabStock.Text = "Stock";
            // 
            // cmbInsumos
            // 
            this.cmbInsumos.AutoResize = false;
            this.cmbInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbInsumos.Depth = 0;
            this.cmbInsumos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbInsumos.DropDownHeight = 174;
            this.cmbInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsumos.DropDownWidth = 121;
            this.cmbInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbInsumos.FormattingEnabled = true;
            this.cmbInsumos.Hint = "Filtro";
            this.cmbInsumos.IntegralHeight = false;
            this.cmbInsumos.ItemHeight = 43;
            this.cmbInsumos.Location = new System.Drawing.Point(76, 509);
            this.cmbInsumos.MaxDropDownItems = 4;
            this.cmbInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbInsumos.Name = "cmbInsumos";
            this.cmbInsumos.Size = new System.Drawing.Size(178, 49);
            this.cmbInsumos.StartIndex = 0;
            this.cmbInsumos.TabIndex = 27;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(16, 527);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(54, 19);
            this.materialLabel14.TabIndex = 26;
            this.materialLabel14.Text = "Buscar:";
            // 
            // txtBuscarInsumos
            // 
            this.txtBuscarInsumos.AnimateReadOnly = false;
            this.txtBuscarInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscarInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarInsumos.Depth = 0;
            this.txtBuscarInsumos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscarInsumos.Hint = "Buscar insumo...";
            this.txtBuscarInsumos.LeadingIcon = null;
            this.txtBuscarInsumos.Location = new System.Drawing.Point(262, 510);
            this.txtBuscarInsumos.MaxLength = 50;
            this.txtBuscarInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarInsumos.Multiline = false;
            this.txtBuscarInsumos.Name = "txtBuscarInsumos";
            this.txtBuscarInsumos.Size = new System.Drawing.Size(296, 50);
            this.txtBuscarInsumos.TabIndex = 25;
            this.txtBuscarInsumos.Text = "";
            this.txtBuscarInsumos.TrailingIcon = null;
            this.txtBuscarInsumos.TextChanged += new System.EventHandler(this.txtBuscarInsumos_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.HighEmphasis = true;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(1101, 130);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReset.Size = new System.Drawing.Size(65, 36);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "reset";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReset.UseAccentColor = false;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpFiltroFechaIngreso
            // 
            this.dtpFiltroFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpFiltroFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFiltroFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFiltroFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaIngreso.Location = new System.Drawing.Point(965, 141);
            this.dtpFiltroFechaIngreso.Name = "dtpFiltroFechaIngreso";
            this.dtpFiltroFechaIngreso.Size = new System.Drawing.Size(118, 23);
            this.dtpFiltroFechaIngreso.TabIndex = 23;
            this.dtpFiltroFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFiltroFechaIngreso_ValueChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(865, 145);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(94, 19);
            this.materialLabel8.TabIndex = 22;
            this.materialLabel8.Text = "Fecha desde:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(564, 147);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(179, 19);
            this.materialLabel7.TabIndex = 21;
            this.materialLabel7.Text = "Movimientos del insumo:";
            // 
            // btnEliminarIngresoInsumo
            // 
            this.btnEliminarIngresoInsumo.AutoSize = false;
            this.btnEliminarIngresoInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarIngresoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarIngresoInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarIngresoInsumo.Depth = 0;
            this.btnEliminarIngresoInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarIngresoInsumo.HighEmphasis = true;
            this.btnEliminarIngresoInsumo.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarIngresoInsumo.Location = new System.Drawing.Point(1173, 232);
            this.btnEliminarIngresoInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarIngresoInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarIngresoInsumo.Name = "btnEliminarIngresoInsumo";
            this.btnEliminarIngresoInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarIngresoInsumo.Size = new System.Drawing.Size(115, 51);
            this.btnEliminarIngresoInsumo.TabIndex = 18;
            this.btnEliminarIngresoInsumo.Text = "Eliminar";
            this.btnEliminarIngresoInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarIngresoInsumo.UseAccentColor = false;
            this.btnEliminarIngresoInsumo.UseVisualStyleBackColor = false;
            this.btnEliminarIngresoInsumo.Click += new System.EventHandler(this.btnEliminarIngresoInsumo_Click);
            // 
            // listIngresosInsumos
            // 
            this.listIngresosInsumos.AutoSizeTable = false;
            this.listIngresosInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listIngresosInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listIngresosInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProveedor,
            this.columnFechaInput,
            this.columnCantidad,
            this.columnUniMed});
            this.listIngresosInsumos.Depth = 0;
            this.listIngresosInsumos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listIngresosInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listIngresosInsumos.FullRowSelect = true;
            this.listIngresosInsumos.HideSelection = false;
            this.listIngresosInsumos.Location = new System.Drawing.Point(564, 169);
            this.listIngresosInsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listIngresosInsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listIngresosInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listIngresosInsumos.MultiSelect = false;
            this.listIngresosInsumos.Name = "listIngresosInsumos";
            this.listIngresosInsumos.OwnerDraw = true;
            this.listIngresosInsumos.Size = new System.Drawing.Size(602, 337);
            this.listIngresosInsumos.TabIndex = 16;
            this.listIngresosInsumos.UseCompatibleStateImageBehavior = false;
            this.listIngresosInsumos.View = System.Windows.Forms.View.Details;
            this.listIngresosInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listIngresosInsumos_ColumnWidthChanging);
            // 
            // columnProveedor
            // 
            this.columnProveedor.Text = "Proveedor";
            this.columnProveedor.Width = 200;
            // 
            // columnFechaInput
            // 
            this.columnFechaInput.Text = "Fecha Ingreso";
            this.columnFechaInput.Width = 205;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.Width = 95;
            // 
            // columnUniMed
            // 
            this.columnUniMed.Text = "Unidad";
            this.columnUniMed.Width = 102;
            // 
            // btnIngresoInsumo
            // 
            this.btnIngresoInsumo.AutoSize = false;
            this.btnIngresoInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIngresoInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresoInsumo.Depth = 0;
            this.btnIngresoInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresoInsumo.HighEmphasis = true;
            this.btnIngresoInsumo.Icon = global::UI.Desktop.Properties.Resources.product_delivery_icon_152013;
            this.btnIngresoInsumo.Location = new System.Drawing.Point(1174, 169);
            this.btnIngresoInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresoInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresoInsumo.Name = "btnIngresoInsumo";
            this.btnIngresoInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresoInsumo.Size = new System.Drawing.Size(115, 51);
            this.btnIngresoInsumo.TabIndex = 17;
            this.btnIngresoInsumo.Text = "nuevo ingreso";
            this.btnIngresoInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresoInsumo.UseAccentColor = false;
            this.btnIngresoInsumo.UseVisualStyleBackColor = false;
            this.btnIngresoInsumo.Click += new System.EventHandler(this.btnIngresoInsumo_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.AutoSize = false;
            this.btnDetalles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDetalles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetalles.Depth = 0;
            this.btnDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetalles.HighEmphasis = true;
            this.btnDetalles.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnDetalles.Location = new System.Drawing.Point(564, 71);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(115, 51);
            this.btnDetalles.TabIndex = 15;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // listInsumos
            // 
            this.listInsumos.AutoSizeTable = false;
            this.listInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDIns,
            this.columnDescripcionIns,
            this.columnStock,
            this.columnUniMedida});
            this.listInsumos.Depth = 0;
            this.listInsumos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listInsumos.FullRowSelect = true;
            this.listInsumos.HideSelection = false;
            this.listInsumos.Location = new System.Drawing.Point(16, 71);
            this.listInsumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listInsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listInsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listInsumos.MultiSelect = false;
            this.listInsumos.Name = "listInsumos";
            this.listInsumos.OwnerDraw = true;
            this.listInsumos.Size = new System.Drawing.Size(542, 435);
            this.listInsumos.TabIndex = 14;
            this.listInsumos.UseCompatibleStateImageBehavior = false;
            this.listInsumos.View = System.Windows.Forms.View.Details;
            this.listInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listInsumos_ColumnWidthChanging_1);
            // 
            // columnIDIns
            // 
            this.columnIDIns.Text = "ID";
            this.columnIDIns.Width = 81;
            // 
            // columnDescripcionIns
            // 
            this.columnDescripcionIns.Text = "Descripción";
            this.columnDescripcionIns.Width = 251;
            // 
            // columnStock
            // 
            this.columnStock.Text = "Stock";
            this.columnStock.Width = 100;
            // 
            // columnUniMedida
            // 
            this.columnUniMedida.Text = "Unidad";
            this.columnUniMedida.Width = 110;
            // 
            // btnEditarInsumo
            // 
            this.btnEditarInsumo.AutoSize = false;
            this.btnEditarInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarInsumo.Depth = 0;
            this.btnEditarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarInsumo.HighEmphasis = true;
            this.btnEditarInsumo.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarInsumo.Location = new System.Drawing.Point(140, 8);
            this.btnEditarInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarInsumo.Name = "btnEditarInsumo";
            this.btnEditarInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarInsumo.Size = new System.Drawing.Size(114, 51);
            this.btnEditarInsumo.TabIndex = 13;
            this.btnEditarInsumo.Text = "Editar";
            this.btnEditarInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarInsumo.UseAccentColor = false;
            this.btnEditarInsumo.UseVisualStyleBackColor = false;
            this.btnEditarInsumo.Click += new System.EventHandler(this.btnEditarInsumo_Click);
            // 
            // btnEliminarInsumo
            // 
            this.btnEliminarInsumo.AutoSize = false;
            this.btnEliminarInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarInsumo.Depth = 0;
            this.btnEliminarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarInsumo.HighEmphasis = true;
            this.btnEliminarInsumo.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarInsumo.Location = new System.Drawing.Point(262, 8);
            this.btnEliminarInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarInsumo.Name = "btnEliminarInsumo";
            this.btnEliminarInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarInsumo.Size = new System.Drawing.Size(114, 51);
            this.btnEliminarInsumo.TabIndex = 12;
            this.btnEliminarInsumo.Text = "Eliminar";
            this.btnEliminarInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarInsumo.UseAccentColor = false;
            this.btnEliminarInsumo.UseVisualStyleBackColor = false;
            this.btnEliminarInsumo.Click += new System.EventHandler(this.btnEliminarInsumo_Click);
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.AutoSize = false;
            this.btnAgregarInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarInsumo.Depth = 0;
            this.btnAgregarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarInsumo.HighEmphasis = true;
            this.btnAgregarInsumo.Icon = global::UI.Desktop.Properties.Resources.productapplication_producto_3010;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(16, 8);
            this.btnAgregarInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarInsumo.Size = new System.Drawing.Size(116, 51);
            this.btnAgregarInsumo.TabIndex = 11;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarInsumo.UseAccentColor = false;
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // TabMovimientos
            // 
            this.TabMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TabMovimientos.Controls.Add(this.btnActualizarIngresos);
            this.TabMovimientos.Controls.Add(this.lblFiltrarFecha);
            this.TabMovimientos.Controls.Add(this.dtpFiltrarFechaIngreso);
            this.TabMovimientos.Controls.Add(this.btnEliminarIngreso);
            this.TabMovimientos.Controls.Add(this.btnNuevoIngreso);
            this.TabMovimientos.Controls.Add(this.listIngresos);
            this.TabMovimientos.Location = new System.Drawing.Point(4, 24);
            this.TabMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabMovimientos.Name = "TabMovimientos";
            this.TabMovimientos.Size = new System.Drawing.Size(1345, 604);
            this.TabMovimientos.TabIndex = 3;
            this.TabMovimientos.Text = "Movimientos";
            // 
            // btnActualizarIngresos
            // 
            this.btnActualizarIngresos.AutoSize = false;
            this.btnActualizarIngresos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnActualizarIngresos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarIngresos.Depth = 0;
            this.btnActualizarIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnActualizarIngresos.HighEmphasis = true;
            this.btnActualizarIngresos.Icon = null;
            this.btnActualizarIngresos.Location = new System.Drawing.Point(1017, 16);
            this.btnActualizarIngresos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarIngresos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarIngresos.Name = "btnActualizarIngresos";
            this.btnActualizarIngresos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarIngresos.Size = new System.Drawing.Size(114, 51);
            this.btnActualizarIngresos.TabIndex = 15;
            this.btnActualizarIngresos.Text = "Reset";
            this.btnActualizarIngresos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarIngresos.UseAccentColor = false;
            this.btnActualizarIngresos.UseVisualStyleBackColor = false;
            this.btnActualizarIngresos.Click += new System.EventHandler(this.btnActualizarIngresos_Click);
            // 
            // lblFiltrarFecha
            // 
            this.lblFiltrarFecha.AutoSize = true;
            this.lblFiltrarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblFiltrarFecha.Depth = 0;
            this.lblFiltrarFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFiltrarFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFiltrarFecha.Location = new System.Drawing.Point(780, 37);
            this.lblFiltrarFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFiltrarFecha.Name = "lblFiltrarFecha";
            this.lblFiltrarFecha.Size = new System.Drawing.Size(94, 19);
            this.lblFiltrarFecha.TabIndex = 14;
            this.lblFiltrarFecha.Text = "Fecha desde:";
            // 
            // dtpFiltrarFechaIngreso
            // 
            this.dtpFiltrarFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpFiltrarFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFiltrarFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFiltrarFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltrarFechaIngreso.Location = new System.Drawing.Point(880, 33);
            this.dtpFiltrarFechaIngreso.Name = "dtpFiltrarFechaIngreso";
            this.dtpFiltrarFechaIngreso.Size = new System.Drawing.Size(130, 23);
            this.dtpFiltrarFechaIngreso.TabIndex = 13;
            this.dtpFiltrarFechaIngreso.CloseUp += new System.EventHandler(this.dtpFiltrarFechaIngreso_CloseUp);
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.AutoSize = false;
            this.btnEliminarIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarIngreso.Depth = 0;
            this.btnEliminarIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarIngreso.HighEmphasis = true;
            this.btnEliminarIngreso.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(267, 16);
            this.btnEliminarIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarIngreso.Size = new System.Drawing.Size(114, 51);
            this.btnEliminarIngreso.TabIndex = 11;
            this.btnEliminarIngreso.Text = "Eliminar";
            this.btnEliminarIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarIngreso.UseAccentColor = false;
            this.btnEliminarIngreso.UseVisualStyleBackColor = false;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.AutoSize = false;
            this.btnNuevoIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNuevoIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoIngreso.Depth = 0;
            this.btnNuevoIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevoIngreso.HighEmphasis = true;
            this.btnNuevoIngreso.Icon = global::UI.Desktop.Properties.Resources.product_delivery_icon_152013;
            this.btnNuevoIngreso.Location = new System.Drawing.Point(136, 16);
            this.btnNuevoIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoIngreso.Size = new System.Drawing.Size(114, 51);
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
            this.listIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.listIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listIngresos.FullRowSelect = true;
            this.listIngresos.HideSelection = false;
            this.listIngresos.Location = new System.Drawing.Point(136, 75);
            this.listIngresos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listIngresos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listIngresos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listIngresos.MouseState = MaterialSkin.MouseState.OUT;
            this.listIngresos.MultiSelect = false;
            this.listIngresos.Name = "listIngresos";
            this.listIngresos.OwnerDraw = true;
            this.listIngresos.Size = new System.Drawing.Size(995, 434);
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
            this.columnProvIngreso.Width = 235;
            // 
            // columnIdInsumoIngreso
            // 
            this.columnIdInsumoIngreso.Text = "ID Insumo";
            this.columnIdInsumoIngreso.Width = 100;
            // 
            // columnInsumoIngreso
            // 
            this.columnInsumoIngreso.Text = "Insumo";
            this.columnInsumoIngreso.Width = 210;
            // 
            // columnFechaIngreso
            // 
            this.columnFechaIngreso.Text = "Fecha Ingreso";
            this.columnFechaIngreso.Width = 190;
            // 
            // columnCantIngreso
            // 
            this.columnCantIngreso.Text = "Cantidad";
            this.columnCantIngreso.Width = 145;
            // 
            // tabSelectorInventario
            // 
            this.tabSelectorInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabSelectorInventario.BaseTabControl = this.tabControlInventario;
            this.tabSelectorInventario.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorInventario.Depth = 0;
            this.tabSelectorInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelectorInventario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabSelectorInventario.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSelectorInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorInventario.Name = "tabSelectorInventario";
            this.tabSelectorInventario.Size = new System.Drawing.Size(1353, 47);
            this.tabSelectorInventario.TabIndex = 0;
            this.tabSelectorInventario.Text = "TabSelectorInventario";
            // 
            // tabPlanificacion
            // 
            this.tabPlanificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPlanificacion.Controls.Add(this.tabControlPlanificacion);
            this.tabPlanificacion.Controls.Add(this.tabSelectorPlanificacion);
            this.tabPlanificacion.ImageKey = "20business-planning_102092.png";
            this.tabPlanificacion.Location = new System.Drawing.Point(4, 39);
            this.tabPlanificacion.Name = "tabPlanificacion";
            this.tabPlanificacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanificacion.Size = new System.Drawing.Size(1353, 679);
            this.tabPlanificacion.TabIndex = 3;
            this.tabPlanificacion.Text = "Planificación";
            // 
            // tabControlPlanificacion
            // 
            this.tabControlPlanificacion.Controls.Add(this.tabPendientes);
            this.tabControlPlanificacion.Controls.Add(this.tabEnProceso);
            this.tabControlPlanificacion.Depth = 0;
            this.tabControlPlanificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.tabPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPendientes.Controls.Add(this.txtBuscarTrabajosPendientes);
            this.tabPendientes.Controls.Add(this.cmbTrabajosPendientes);
            this.tabPendientes.Controls.Add(this.materialLabel13);
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
            // txtBuscarTrabajosPendientes
            // 
            this.txtBuscarTrabajosPendientes.AnimateReadOnly = false;
            this.txtBuscarTrabajosPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscarTrabajosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarTrabajosPendientes.Depth = 0;
            this.txtBuscarTrabajosPendientes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarTrabajosPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscarTrabajosPendientes.Hint = "Buscar trabajo pendiente ....";
            this.txtBuscarTrabajosPendientes.LeadingIcon = null;
            this.txtBuscarTrabajosPendientes.Location = new System.Drawing.Point(288, 537);
            this.txtBuscarTrabajosPendientes.MaxLength = 50;
            this.txtBuscarTrabajosPendientes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarTrabajosPendientes.Multiline = false;
            this.txtBuscarTrabajosPendientes.Name = "txtBuscarTrabajosPendientes";
            this.txtBuscarTrabajosPendientes.Size = new System.Drawing.Size(509, 50);
            this.txtBuscarTrabajosPendientes.TabIndex = 9;
            this.txtBuscarTrabajosPendientes.Text = "";
            this.txtBuscarTrabajosPendientes.TrailingIcon = null;
            this.txtBuscarTrabajosPendientes.TextChanged += new System.EventHandler(this.txtBuscarTrabajosPendientes_TextChanged);
            // 
            // cmbTrabajosPendientes
            // 
            this.cmbTrabajosPendientes.AutoResize = false;
            this.cmbTrabajosPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbTrabajosPendientes.Depth = 0;
            this.cmbTrabajosPendientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTrabajosPendientes.DropDownHeight = 174;
            this.cmbTrabajosPendientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrabajosPendientes.DropDownWidth = 121;
            this.cmbTrabajosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTrabajosPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTrabajosPendientes.FormattingEnabled = true;
            this.cmbTrabajosPendientes.Hint = "Filtro";
            this.cmbTrabajosPendientes.IntegralHeight = false;
            this.cmbTrabajosPendientes.ItemHeight = 43;
            this.cmbTrabajosPendientes.Location = new System.Drawing.Point(66, 537);
            this.cmbTrabajosPendientes.MaxDropDownItems = 4;
            this.cmbTrabajosPendientes.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTrabajosPendientes.Name = "cmbTrabajosPendientes";
            this.cmbTrabajosPendientes.Size = new System.Drawing.Size(216, 49);
            this.cmbTrabajosPendientes.StartIndex = 0;
            this.cmbTrabajosPendientes.TabIndex = 8;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(6, 553);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(54, 19);
            this.materialLabel13.TabIndex = 7;
            this.materialLabel13.Text = "Buscar:";
            // 
            // btnFinalizarTrabajo
            // 
            this.btnFinalizarTrabajo.AutoSize = false;
            this.btnFinalizarTrabajo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizarTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFinalizarTrabajo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalizarTrabajo.Depth = 0;
            this.btnFinalizarTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFinalizarTrabajo.HighEmphasis = true;
            this.btnFinalizarTrabajo.Icon = global::UI.Desktop.Properties.Resources.squareinsideacircle_120602;
            this.btnFinalizarTrabajo.Location = new System.Drawing.Point(804, 72);
            this.btnFinalizarTrabajo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizarTrabajo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizarTrabajo.Name = "btnFinalizarTrabajo";
            this.btnFinalizarTrabajo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalizarTrabajo.Size = new System.Drawing.Size(134, 51);
            this.btnFinalizarTrabajo.TabIndex = 6;
            this.btnFinalizarTrabajo.Text = "Finalizar Trabajo";
            this.btnFinalizarTrabajo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalizarTrabajo.UseAccentColor = false;
            this.btnFinalizarTrabajo.UseVisualStyleBackColor = false;
            this.btnFinalizarTrabajo.Click += new System.EventHandler(this.btnFinalizarTrabajo_Click_1);
            // 
            // btnIniciarServicio
            // 
            this.btnIniciarServicio.AutoSize = false;
            this.btnIniciarServicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIniciarServicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciarServicio.Depth = 0;
            this.btnIniciarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIniciarServicio.HighEmphasis = true;
            this.btnIniciarServicio.Icon = global::UI.Desktop.Properties.Resources.playbutton_120627;
            this.btnIniciarServicio.Location = new System.Drawing.Point(804, 9);
            this.btnIniciarServicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciarServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarServicio.Name = "btnIniciarServicio";
            this.btnIniciarServicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciarServicio.Size = new System.Drawing.Size(134, 51);
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
            this.listMaquinasItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMaquinasItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMaquinasItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaquina3,
            this.columnInicio1,
            this.columnFin});
            this.listMaquinasItem.Depth = 0;
            this.listMaquinasItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMaquinasItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listMaquinasItem.FullRowSelect = true;
            this.listMaquinasItem.HideSelection = false;
            this.listMaquinasItem.Location = new System.Drawing.Point(804, 228);
            this.listMaquinasItem.MinimumSize = new System.Drawing.Size(200, 100);
            this.listMaquinasItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMaquinasItem.MouseState = MaterialSkin.MouseState.OUT;
            this.listMaquinasItem.MultiSelect = false;
            this.listMaquinasItem.Name = "listMaquinasItem";
            this.listMaquinasItem.OwnerDraw = true;
            this.listMaquinasItem.Size = new System.Drawing.Size(446, 303);
            this.listMaquinasItem.TabIndex = 4;
            this.listMaquinasItem.UseCompatibleStateImageBehavior = false;
            this.listMaquinasItem.View = System.Windows.Forms.View.Details;
            this.listMaquinasItem.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listMaquinasItem_ColumnWidthChanging);
            // 
            // columnMaquina3
            // 
            this.columnMaquina3.Text = "Maquina";
            this.columnMaquina3.Width = 106;
            // 
            // columnInicio1
            // 
            this.columnInicio1.Text = "Inicio";
            this.columnInicio1.Width = 170;
            // 
            // columnFin
            // 
            this.columnFin.Text = "Fin";
            this.columnFin.Width = 170;
            // 
            // btnMostrarServicios
            // 
            this.btnMostrarServicios.AutoSize = false;
            this.btnMostrarServicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrarServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMostrarServicios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMostrarServicios.Depth = 0;
            this.btnMostrarServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMostrarServicios.HighEmphasis = true;
            this.btnMostrarServicios.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnMostrarServicios.Location = new System.Drawing.Point(804, 168);
            this.btnMostrarServicios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMostrarServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrarServicios.Name = "btnMostrarServicios";
            this.btnMostrarServicios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMostrarServicios.Size = new System.Drawing.Size(134, 51);
            this.btnMostrarServicios.TabIndex = 3;
            this.btnMostrarServicios.Text = "Servicios detallados";
            this.btnMostrarServicios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMostrarServicios.UseAccentColor = false;
            this.btnMostrarServicios.UseVisualStyleBackColor = false;
            this.btnMostrarServicios.Click += new System.EventHandler(this.btnMostrarServicios_Click);
            // 
            // listEstadoMaquinas
            // 
            this.listEstadoMaquinas.AutoSizeTable = false;
            this.listEstadoMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listEstadoMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEstadoMaquinas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaquina2,
            this.columnEstadoMaquina});
            this.listEstadoMaquinas.Depth = 0;
            this.listEstadoMaquinas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listEstadoMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listEstadoMaquinas.FullRowSelect = true;
            this.listEstadoMaquinas.HideSelection = false;
            this.listEstadoMaquinas.Location = new System.Drawing.Point(1050, 23);
            this.listEstadoMaquinas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listEstadoMaquinas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEstadoMaquinas.MouseState = MaterialSkin.MouseState.OUT;
            this.listEstadoMaquinas.MultiSelect = false;
            this.listEstadoMaquinas.Name = "listEstadoMaquinas";
            this.listEstadoMaquinas.OwnerDraw = true;
            this.listEstadoMaquinas.Size = new System.Drawing.Size(200, 169);
            this.listEstadoMaquinas.TabIndex = 2;
            this.listEstadoMaquinas.UseCompatibleStateImageBehavior = false;
            this.listEstadoMaquinas.View = System.Windows.Forms.View.Details;
            this.listEstadoMaquinas.Visible = false;
            this.listEstadoMaquinas.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listEstadoMaquinas_ColumnWidthChanging);
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
            this.listTrabajosPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.listTrabajosPendientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listTrabajosPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listTrabajosPendientes.FullRowSelect = true;
            this.listTrabajosPendientes.HideSelection = false;
            this.listTrabajosPendientes.Location = new System.Drawing.Point(6, 7);
            this.listTrabajosPendientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listTrabajosPendientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listTrabajosPendientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listTrabajosPendientes.MultiSelect = false;
            this.listTrabajosPendientes.Name = "listTrabajosPendientes";
            this.listTrabajosPendientes.OwnerDraw = true;
            this.listTrabajosPendientes.Size = new System.Drawing.Size(791, 524);
            this.listTrabajosPendientes.TabIndex = 0;
            this.listTrabajosPendientes.UseCompatibleStateImageBehavior = false;
            this.listTrabajosPendientes.View = System.Windows.Forms.View.Details;
            this.listTrabajosPendientes.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listTrabajosPendientes_ColumnWidthChanging);
            // 
            // columnOrden
            // 
            this.columnOrden.Text = "Orden";
            this.columnOrden.Width = 70;
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 150;
            // 
            // columnTipoPrenda
            // 
            this.columnTipoPrenda.Text = "Tipo de Prenda";
            this.columnTipoPrenda.Width = 145;
            // 
            // columnOrdenItem
            // 
            this.columnOrdenItem.Text = "Item";
            // 
            // columnState
            // 
            this.columnState.Text = "Estado";
            this.columnState.Width = 120;
            // 
            // columnPriority
            // 
            this.columnPriority.Text = "Prioridad";
            this.columnPriority.Width = 100;
            // 
            // columnTiempoRestante
            // 
            this.columnTiempoRestante.Text = "Tiempo Restante";
            this.columnTiempoRestante.Width = 146;
            // 
            // tabEnProceso
            // 
            this.tabEnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabEnProceso.Controls.Add(this.btnTerminarServicio);
            this.tabEnProceso.Controls.Add(this.listTrabajosEnProceso);
            this.tabEnProceso.Location = new System.Drawing.Point(4, 24);
            this.tabEnProceso.Name = "tabEnProceso";
            this.tabEnProceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnProceso.Size = new System.Drawing.Size(1364, 604);
            this.tabEnProceso.TabIndex = 1;
            this.tabEnProceso.Text = "Trabajos en Proceso";
            // 
            // btnTerminarServicio
            // 
            this.btnTerminarServicio.AutoSize = false;
            this.btnTerminarServicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTerminarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTerminarServicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTerminarServicio.Depth = 0;
            this.btnTerminarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTerminarServicio.HighEmphasis = true;
            this.btnTerminarServicio.Icon = global::UI.Desktop.Properties.Resources._3706883_control_music_pause_stop_stop_music_108702;
            this.btnTerminarServicio.Location = new System.Drawing.Point(1065, 16);
            this.btnTerminarServicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTerminarServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTerminarServicio.Name = "btnTerminarServicio";
            this.btnTerminarServicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTerminarServicio.Size = new System.Drawing.Size(108, 51);
            this.btnTerminarServicio.TabIndex = 1;
            this.btnTerminarServicio.Text = "Detener Servicio";
            this.btnTerminarServicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTerminarServicio.UseAccentColor = false;
            this.btnTerminarServicio.UseVisualStyleBackColor = false;
            this.btnTerminarServicio.Click += new System.EventHandler(this.btnTerminarServicio_Click);
            // 
            // listTrabajosEnProceso
            // 
            this.listTrabajosEnProceso.AutoSizeTable = false;
            this.listTrabajosEnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.listTrabajosEnProceso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listTrabajosEnProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listTrabajosEnProceso.FullRowSelect = true;
            this.listTrabajosEnProceso.HideSelection = false;
            this.listTrabajosEnProceso.Location = new System.Drawing.Point(19, 16);
            this.listTrabajosEnProceso.MinimumSize = new System.Drawing.Size(200, 100);
            this.listTrabajosEnProceso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listTrabajosEnProceso.MouseState = MaterialSkin.MouseState.OUT;
            this.listTrabajosEnProceso.MultiSelect = false;
            this.listTrabajosEnProceso.Name = "listTrabajosEnProceso";
            this.listTrabajosEnProceso.OwnerDraw = true;
            this.listTrabajosEnProceso.Size = new System.Drawing.Size(1010, 570);
            this.listTrabajosEnProceso.TabIndex = 0;
            this.listTrabajosEnProceso.UseCompatibleStateImageBehavior = false;
            this.listTrabajosEnProceso.View = System.Windows.Forms.View.Details;
            this.listTrabajosEnProceso.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listTrabajosEnProceso_ColumnWidthChanging);
            // 
            // columnMaquina
            // 
            this.columnMaquina.Text = "Máquina";
            this.columnMaquina.Width = 120;
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
            this.columnTipoPrenda2.Width = 170;
            // 
            // columnOrdenItem2
            // 
            this.columnOrdenItem2.Text = "Orden Item";
            this.columnOrdenItem2.Width = 120;
            // 
            // columnInicio
            // 
            this.columnInicio.Text = "Hora de inicio";
            this.columnInicio.Width = 220;
            // 
            // columnState2
            // 
            this.columnState2.Text = "Estado";
            this.columnState2.Width = 130;
            // 
            // tabSelectorPlanificacion
            // 
            this.tabSelectorPlanificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabSelectorPlanificacion.BaseTabControl = this.tabControlPlanificacion;
            this.tabSelectorPlanificacion.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorPlanificacion.Depth = 0;
            this.tabSelectorPlanificacion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorPlanificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabSelectorPlanificacion.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorPlanificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSelectorPlanificacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorPlanificacion.Name = "tabSelectorPlanificacion";
            this.tabSelectorPlanificacion.Size = new System.Drawing.Size(1394, 47);
            this.tabSelectorPlanificacion.TabIndex = 0;
            this.tabSelectorPlanificacion.Text = "tabSelectorPlanificacion";
            // 
            // tabUtilidades
            // 
            this.tabUtilidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabUtilidades.Controls.Add(this.materialCard5);
            this.tabUtilidades.Controls.Add(this.materialCard4);
            this.tabUtilidades.Controls.Add(this.materialCard3);
            this.tabUtilidades.Controls.Add(this.materialCard2);
            this.tabUtilidades.Controls.Add(this.materialCard1);
            this.tabUtilidades.ImageKey = "tools_icon-icons.com_69843.png";
            this.tabUtilidades.Location = new System.Drawing.Point(4, 39);
            this.tabUtilidades.Name = "tabUtilidades";
            this.tabUtilidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtilidades.Size = new System.Drawing.Size(1353, 679);
            this.tabUtilidades.TabIndex = 4;
            this.tabUtilidades.Text = "Utilidades";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btnGastos);
            this.materialCard5.Controls.Add(this.btnCaja);
            this.materialCard5.Controls.Add(this.materialLabel6);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(17, 375);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(276, 268);
            this.materialCard5.TabIndex = 5;
            // 
            // btnGastos
            // 
            this.btnGastos.AutoSize = false;
            this.btnGastos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnGastos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGastos.Depth = 0;
            this.btnGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGastos.HighEmphasis = true;
            this.btnGastos.Icon = global::UI.Desktop.Properties.Resources._3615751_banknote_cash_cheque_money_order_payment_voucher_107903;
            this.btnGastos.Location = new System.Drawing.Point(39, 91);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGastos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGastos.Size = new System.Drawing.Size(195, 36);
            this.btnGastos.TabIndex = 2;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGastos.UseAccentColor = false;
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.AutoSize = false;
            this.btnCaja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCaja.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCaja.Depth = 0;
            this.btnCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCaja.HighEmphasis = true;
            this.btnCaja.Icon = global::UI.Desktop.Properties.Resources._3925411_cashbox_cashier_shop_icon_111535;
            this.btnCaja.Location = new System.Drawing.Point(40, 43);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCaja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCaja.Size = new System.Drawing.Size(195, 36);
            this.btnCaja.TabIndex = 1;
            this.btnCaja.Text = "Caja";
            this.btnCaja.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCaja.UseAccentColor = false;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 18);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Finanzas";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.btnAtributos);
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Controls.Add(this.btnObjetosPerdidos);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(309, 214);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(279, 146);
            this.materialCard4.TabIndex = 4;
            // 
            // btnAtributos
            // 
            this.btnAtributos.AutoSize = false;
            this.btnAtributos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtributos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAtributos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAtributos.Depth = 0;
            this.btnAtributos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAtributos.HighEmphasis = true;
            this.btnAtributos.Icon = global::UI.Desktop.Properties.Resources.effective_employees_users_team_group_icon_152042;
            this.btnAtributos.Location = new System.Drawing.Point(43, 87);
            this.btnAtributos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtributos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtributos.Name = "btnAtributos";
            this.btnAtributos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAtributos.Size = new System.Drawing.Size(196, 36);
            this.btnAtributos.TabIndex = 5;
            this.btnAtributos.Text = "Atributos del negocio";
            this.btnAtributos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAtributos.UseAccentColor = false;
            this.btnAtributos.UseVisualStyleBackColor = false;
            this.btnAtributos.Click += new System.EventHandler(this.btnAtributos_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(17, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Utilidades";
            // 
            // btnObjetosPerdidos
            // 
            this.btnObjetosPerdidos.AutoSize = false;
            this.btnObjetosPerdidos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObjetosPerdidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnObjetosPerdidos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnObjetosPerdidos.Depth = 0;
            this.btnObjetosPerdidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnObjetosPerdidos.HighEmphasis = true;
            this.btnObjetosPerdidos.Icon = global::UI.Desktop.Properties.Resources.search_find_look_zoom_in_icon_icons_com_59897;
            this.btnObjetosPerdidos.Location = new System.Drawing.Point(43, 39);
            this.btnObjetosPerdidos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnObjetosPerdidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnObjetosPerdidos.Name = "btnObjetosPerdidos";
            this.btnObjetosPerdidos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnObjetosPerdidos.Size = new System.Drawing.Size(196, 36);
            this.btnObjetosPerdidos.TabIndex = 0;
            this.btnObjetosPerdidos.Text = "Objetos Perdidos";
            this.btnObjetosPerdidos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnObjetosPerdidos.UseAccentColor = false;
            this.btnObjetosPerdidos.UseVisualStyleBackColor = false;
            this.btnObjetosPerdidos.Click += new System.EventHandler(this.btnObjetosPerdidos_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnReporteEmpleados);
            this.materialCard3.Controls.Add(this.btnMovimientos);
            this.materialCard3.Controls.Add(this.btnReporteGastos);
            this.materialCard3.Controls.Add(this.btnDeudas);
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(603, 20);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(279, 340);
            this.materialCard3.TabIndex = 3;
            // 
            // btnReporteEmpleados
            // 
            this.btnReporteEmpleados.AutoSize = false;
            this.btnReporteEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReporteEmpleados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporteEmpleados.Depth = 0;
            this.btnReporteEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporteEmpleados.HighEmphasis = true;
            this.btnReporteEmpleados.Icon = global::UI.Desktop.Properties.Resources.report_document_finance_business_analysis_analytics_chart_icon_188615;
            this.btnReporteEmpleados.Location = new System.Drawing.Point(41, 177);
            this.btnReporteEmpleados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReporteEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporteEmpleados.Name = "btnReporteEmpleados";
            this.btnReporteEmpleados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReporteEmpleados.Size = new System.Drawing.Size(196, 36);
            this.btnReporteEmpleados.TabIndex = 5;
            this.btnReporteEmpleados.Text = "Empleados";
            this.btnReporteEmpleados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReporteEmpleados.UseAccentColor = false;
            this.btnReporteEmpleados.UseVisualStyleBackColor = false;
            this.btnReporteEmpleados.Click += new System.EventHandler(this.btnReporteEmpleados_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.AutoSize = false;
            this.btnMovimientos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMovimientos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMovimientos.Depth = 0;
            this.btnMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMovimientos.HighEmphasis = true;
            this.btnMovimientos.Icon = global::UI.Desktop.Properties.Resources.report_document_finance_business_analysis_analytics_chart_icon_188615;
            this.btnMovimientos.Location = new System.Drawing.Point(41, 129);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMovimientos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMovimientos.Size = new System.Drawing.Size(196, 36);
            this.btnMovimientos.TabIndex = 3;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMovimientos.UseAccentColor = false;
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnReporteGastos
            // 
            this.btnReporteGastos.AutoSize = false;
            this.btnReporteGastos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReporteGastos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporteGastos.Depth = 0;
            this.btnReporteGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporteGastos.HighEmphasis = true;
            this.btnReporteGastos.Icon = global::UI.Desktop.Properties.Resources.report_document_finance_business_analysis_analytics_chart_icon_188615;
            this.btnReporteGastos.Location = new System.Drawing.Point(41, 81);
            this.btnReporteGastos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReporteGastos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporteGastos.Name = "btnReporteGastos";
            this.btnReporteGastos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReporteGastos.Size = new System.Drawing.Size(196, 36);
            this.btnReporteGastos.TabIndex = 2;
            this.btnReporteGastos.Text = "Gastos";
            this.btnReporteGastos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReporteGastos.UseAccentColor = false;
            this.btnReporteGastos.UseVisualStyleBackColor = false;
            this.btnReporteGastos.Click += new System.EventHandler(this.btnReporteGastos_Click);
            // 
            // btnDeudas
            // 
            this.btnDeudas.AutoSize = false;
            this.btnDeudas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeudas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeudas.Depth = 0;
            this.btnDeudas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeudas.HighEmphasis = true;
            this.btnDeudas.Icon = global::UI.Desktop.Properties.Resources.report_document_finance_business_analysis_analytics_chart_icon_188615;
            this.btnDeudas.Location = new System.Drawing.Point(41, 35);
            this.btnDeudas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeudas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeudas.Name = "btnDeudas";
            this.btnDeudas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeudas.Size = new System.Drawing.Size(196, 36);
            this.btnDeudas.TabIndex = 1;
            this.btnDeudas.Text = "Deudas";
            this.btnDeudas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeudas.UseAccentColor = false;
            this.btnDeudas.UseVisualStyleBackColor = false;
            this.btnDeudas.Click += new System.EventHandler(this.btnDeudas_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(149, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Informes del negocio";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.btnInsumos);
            this.materialCard2.Controls.Add(this.btnProveedores);
            this.materialCard2.Controls.Add(this.btnClientes);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(18, 10);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(164, 19);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "Administración externa";
            // 
            // btnInsumos
            // 
            this.btnInsumos.AutoSize = false;
            this.btnInsumos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnInsumos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsumos.Depth = 0;
            this.btnInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInsumos.HighEmphasis = true;
            this.btnInsumos.Icon = global::UI.Desktop.Properties.Resources.productapplication_producto_3010;
            this.btnInsumos.Location = new System.Drawing.Point(43, 81);
            this.btnInsumos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsumos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsumos.Size = new System.Drawing.Size(196, 36);
            this.btnInsumos.TabIndex = 2;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsumos.UseAccentColor = false;
            this.btnInsumos.UseVisualStyleBackColor = false;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSize = false;
            this.btnProveedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnProveedores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProveedores.Depth = 0;
            this.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProveedores.HighEmphasis = true;
            this.btnProveedores.Icon = global::UI.Desktop.Properties.Resources.product_delivery_icon_152013;
            this.btnProveedores.Location = new System.Drawing.Point(43, 35);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProveedores.Size = new System.Drawing.Size(196, 36);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProveedores.UseAccentColor = false;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = false;
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClientes.Depth = 0;
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClientes.HighEmphasis = true;
            this.btnClientes.Icon = global::UI.Desktop.Properties.Resources.customer_service_icon_194124;
            this.btnClientes.Location = new System.Drawing.Point(43, 127);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClientes.Size = new System.Drawing.Size(196, 36);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClientes.UseAccentColor = false;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnUsuarios);
            this.materialCard1.Controls.Add(this.btnMaquinas);
            this.materialCard1.Controls.Add(this.btnEmpleados);
            this.materialCard1.Controls.Add(this.btnServicioTipoPrenda);
            this.materialCard1.Controls.Add(this.btnTipoPrenda);
            this.materialCard1.Controls.Add(this.btnServicio);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(276, 340);
            this.materialCard1.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = false;
            this.btnUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUsuarios.Depth = 0;
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUsuarios.HighEmphasis = true;
            this.btnUsuarios.Icon = global::UI.Desktop.Properties.Resources.effective_employees_users_team_group_icon_152042;
            this.btnUsuarios.Location = new System.Drawing.Point(39, 271);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUsuarios.Size = new System.Drawing.Size(196, 36);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsuarios.UseAccentColor = false;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMaquinas
            // 
            this.btnMaquinas.AutoSize = false;
            this.btnMaquinas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMaquinas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMaquinas.Depth = 0;
            this.btnMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaquinas.HighEmphasis = true;
            this.btnMaquinas.Icon = global::UI.Desktop.Properties.Resources.washing_machine_washer_cloth_cloths_laundry_appliances_icon_icons_com_53502;
            this.btnMaquinas.Location = new System.Drawing.Point(40, 175);
            this.btnMaquinas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMaquinas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaquinas.Name = "btnMaquinas";
            this.btnMaquinas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMaquinas.Size = new System.Drawing.Size(195, 36);
            this.btnMaquinas.TabIndex = 4;
            this.btnMaquinas.Text = "Maquinas";
            this.btnMaquinas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMaquinas.UseAccentColor = false;
            this.btnMaquinas.UseVisualStyleBackColor = false;
            this.btnMaquinas.Click += new System.EventHandler(this.btnMaquinas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSize = false;
            this.btnEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEmpleados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEmpleados.Depth = 0;
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmpleados.HighEmphasis = true;
            this.btnEmpleados.Icon = global::UI.Desktop.Properties.Resources.worker_form_document_icon_208910;
            this.btnEmpleados.Location = new System.Drawing.Point(40, 223);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEmpleados.Size = new System.Drawing.Size(195, 36);
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
            this.btnServicioTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnServicioTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnServicioTipoPrenda.Depth = 0;
            this.btnServicioTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnServicioTipoPrenda.HighEmphasis = true;
            this.btnServicioTipoPrenda.Icon = null;
            this.btnServicioTipoPrenda.Location = new System.Drawing.Point(40, 127);
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
            this.btnTipoPrenda.AutoSize = false;
            this.btnTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTipoPrenda.Depth = 0;
            this.btnTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTipoPrenda.HighEmphasis = true;
            this.btnTipoPrenda.Icon = global::UI.Desktop.Properties.Resources.tshirt_120689;
            this.btnTipoPrenda.Location = new System.Drawing.Point(40, 81);
            this.btnTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoPrenda.Name = "btnTipoPrenda";
            this.btnTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTipoPrenda.Size = new System.Drawing.Size(195, 36);
            this.btnTipoPrenda.TabIndex = 2;
            this.btnTipoPrenda.Text = "Tipos de prenda";
            this.btnTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTipoPrenda.UseAccentColor = false;
            this.btnTipoPrenda.UseVisualStyleBackColor = false;
            this.btnTipoPrenda.Click += new System.EventHandler(this.btnTipoPrenda_Click);
            // 
            // btnServicio
            // 
            this.btnServicio.AutoSize = false;
            this.btnServicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnServicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnServicio.Depth = 0;
            this.btnServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnServicio.HighEmphasis = true;
            this.btnServicio.Icon = global::UI.Desktop.Properties.Resources.electric_appliances_waching_machine_laundry_icon_124437;
            this.btnServicio.Location = new System.Drawing.Point(40, 35);
            this.btnServicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnServicio.Size = new System.Drawing.Size(195, 36);
            this.btnServicio.TabIndex = 1;
            this.btnServicio.Text = "Servicios";
            this.btnServicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnServicio.UseAccentColor = false;
            this.btnServicio.UseVisualStyleBackColor = false;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(143, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Administrar negocio";
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
            this.imageList1.Images.SetKeyName(4, "tools_icon-icons.com_69843.png");
            // 
            // epUser
            // 
            this.epUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.epUser.CancelButtonText = "";
            this.epUser.Collapse = true;
            this.epUser.Controls.Add(this.chkCambioColor);
            this.epUser.Controls.Add(this.btnEditarPerfil);
            this.epUser.Controls.Add(this.imgUserLogin);
            this.epUser.Controls.Add(this.btnCerrarSesion);
            this.epUser.Depth = 0;
            this.epUser.Description = "";
            this.epUser.ExpandHeight = 207;
            this.epUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.epUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // chkCambioColor
            // 
            this.chkCambioColor.AutoSize = true;
            this.chkCambioColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkCambioColor.Depth = 0;
            this.chkCambioColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkCambioColor.Location = new System.Drawing.Point(16, 102);
            this.chkCambioColor.Margin = new System.Windows.Forms.Padding(0);
            this.chkCambioColor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCambioColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCambioColor.Name = "chkCambioColor";
            this.chkCambioColor.Ripple = true;
            this.chkCambioColor.Size = new System.Drawing.Size(151, 37);
            this.chkCambioColor.TabIndex = 11;
            this.chkCambioColor.Text = "Modo oscuro";
            this.chkCambioColor.UseVisualStyleBackColor = false;
            this.chkCambioColor.CheckedChanged += new System.EventHandler(this.chkCambioColor_CheckedChanged);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarPerfil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarPerfil.Depth = 0;
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarPerfil.HighEmphasis = true;
            this.btnEditarPerfil.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarPerfil.Location = new System.Drawing.Point(16, 60);
            this.btnEditarPerfil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarPerfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarPerfil.Size = new System.Drawing.Size(164, 36);
            this.btnEditarPerfil.TabIndex = 10;
            this.btnEditarPerfil.Text = "Editar Usuario";
            this.btnEditarPerfil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarPerfil.UseAccentColor = false;
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // imgUserLogin
            // 
            this.imgUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imgUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgUserLogin.Image = global::UI.Desktop.Properties.Resources.round_account_button_with_user_inside_icon_icons_com_72596;
            this.imgUserLogin.Location = new System.Drawing.Point(103, 8);
            this.imgUserLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgUserLogin.Name = "imgUserLogin";
            this.imgUserLogin.Size = new System.Drawing.Size(32, 32);
            this.imgUserLogin.TabIndex = 9;
            this.imgUserLogin.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.HighEmphasis = true;
            this.btnCerrarSesion.Icon = global::UI.Desktop.Properties.Resources.off_log_icon_214125;
            this.btnCerrarSesion.Location = new System.Drawing.Point(16, 149);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1367, 788);
            this.Controls.Add(this.epUser);
            this.Controls.Add(this.mnuPrincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mnuPrincipal;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.mnuTabInventario.ResumeLayout(false);
            this.tabControlInventario.ResumeLayout(false);
            this.TabStock.ResumeLayout(false);
            this.TabStock.PerformLayout();
            this.TabMovimientos.ResumeLayout(false);
            this.TabMovimientos.PerformLayout();
            this.tabPlanificacion.ResumeLayout(false);
            this.tabControlPlanificacion.ResumeLayout(false);
            this.tabPendientes.ResumeLayout(false);
            this.tabPendientes.PerformLayout();
            this.tabEnProceso.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgUserLogin)).EndInit();
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
        private System.Windows.Forms.ColumnHeader columnRazonSocial;
        private System.Windows.Forms.TabPage mnuTabInventario;
        private MaterialSkin.Controls.MaterialButton btnEditarCliente;
        private MaterialSkin.Controls.MaterialButton btnEliminarCliente;
        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarCliente;
        private MaterialSkin.Controls.MaterialTabControl tabControlInventario;
        private System.Windows.Forms.TabPage TabStock;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorInventario;
        private System.Windows.Forms.TabPage TabMovimientos;
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
        private System.Windows.Forms.ColumnHeader columnCliente;
        private System.Windows.Forms.ColumnHeader columnPrioridad;
        private System.Windows.Forms.ColumnHeader columnFechaEntrada;
        private MaterialSkin.Controls.MaterialButton btnEliminarOrden;
        private MaterialSkin.Controls.MaterialButton btnNuevaOrden;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarOrdenes;
        private System.Windows.Forms.ColumnHeader columnFechaSalida;
        private MaterialSkin.Controls.MaterialButton btnRetirarOrden;
        private MaterialSkin.Controls.MaterialExpansionPanel epUser;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
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
        private MaterialSkin.Controls.MaterialButton btnEditarPerfil;
        private System.Windows.Forms.PictureBox imgUserLogin;
        private MaterialSkin.Controls.MaterialListView listIngresosInsumos;
        private System.Windows.Forms.ColumnHeader columnProveedor;
        private System.Windows.Forms.ColumnHeader columnFechaInput;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
        private MaterialSkin.Controls.MaterialListView listInsumos;
        private System.Windows.Forms.ColumnHeader columnIDIns;
        private System.Windows.Forms.ColumnHeader columnDescripcionIns;
        private System.Windows.Forms.ColumnHeader columnStock;
        private System.Windows.Forms.ColumnHeader columnUniMedida;
        private MaterialSkin.Controls.MaterialButton btnEditarInsumo;
        private MaterialSkin.Controls.MaterialButton btnEliminarInsumo;
        private MaterialSkin.Controls.MaterialButton btnAgregarInsumo;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialButton btnEliminarIngresoInsumo;
        private MaterialSkin.Controls.MaterialButton btnIngresoInsumo;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ColumnHeader columnUniMed;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private MaterialSkin.Controls.MaterialButton btnVerDetalles;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox cmbBuscarCliente;
        private MaterialSkin.Controls.MaterialButton btnAgregarPago;
        private MaterialSkin.Controls.MaterialButton btnVerPagos;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialListView listPagosOrden;
        private System.Windows.Forms.ColumnHeader columnFechaPago;
        private System.Windows.Forms.ColumnHeader columnValorPago;
        private System.Windows.Forms.ColumnHeader columnTipoPago;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialListView listOrdenesCliente;
        private System.Windows.Forms.ColumnHeader columnNroOrden;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnValor;
        private System.Windows.Forms.ColumnHeader columnDeuda;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel lblCuentaCorriente;
        private MaterialSkin.Controls.MaterialComboBox cmbBuscarOrden;
        private MaterialSkin.Controls.MaterialSwitch chkCambioColor;
        private MaterialSkin.Controls.MaterialButton btnCaja;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarTrabajosPendientes;
        private MaterialSkin.Controls.MaterialComboBox cmbTrabajosPendientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialComboBox cmbInsumos;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarInsumos;
        private MaterialSkin.Controls.MaterialButton btnGastos;
        private MaterialSkin.Controls.MaterialButton btnDeudas;
        private MaterialSkin.Controls.MaterialButton btnReporteGastos;
        private MaterialSkin.Controls.MaterialButton btnMovimientos;
        private MaterialSkin.Controls.MaterialButton btnReporteEmpleados;
        private MaterialSkin.Controls.MaterialButton btnAtributos;
        private MaterialSkin.Controls.MaterialButton btnSaldarDeuda;
    }
}

