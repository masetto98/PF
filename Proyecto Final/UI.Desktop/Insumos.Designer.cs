
namespace UI.Desktop
{
    partial class Insumos
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
            this.listInsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnIDInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnDesc = new System.Windows.Forms.ColumnHeader();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.listConsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnServicio = new System.Windows.Forms.ColumnHeader();
            this.columntp = new System.Windows.Forms.ColumnHeader();
            this.columnCant = new System.Windows.Forms.ColumnHeader();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarIns = new MaterialSkin.Controls.MaterialButton();
            this.btnEditarIns = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarIns = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarInsumos = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblCantidadInsumoIngresada = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblInsumosUtilizados = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listInsumos
            // 
            this.listInsumos.AutoSizeTable = false;
            this.listInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDInsumo,
            this.columnDesc});
            this.listInsumos.Depth = 0;
            this.listInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listInsumos.FullRowSelect = true;
            this.listInsumos.HideSelection = false;
            this.listInsumos.Location = new System.Drawing.Point(12, 139);
            this.listInsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listInsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listInsumos.Name = "listInsumos";
            this.listInsumos.OwnerDraw = true;
            this.listInsumos.Size = new System.Drawing.Size(372, 471);
            this.listInsumos.TabIndex = 0;
            this.listInsumos.UseCompatibleStateImageBehavior = false;
            this.listInsumos.View = System.Windows.Forms.View.Details;
            this.listInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listInsumos_ColumnWidthChanging);
            // 
            // columnIDInsumo
            // 
            this.columnIDInsumo.Text = "ID";
            this.columnIDInsumo.Width = 100;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "Descripción";
            this.columnDesc.Width = 272;
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
            this.btnDetalles.Location = new System.Drawing.Point(394, 139);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(114, 51);
            this.btnDetalles.TabIndex = 1;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // listConsumos
            // 
            this.listConsumos.AutoSizeTable = false;
            this.listConsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listConsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listConsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnServicio,
            this.columntp,
            this.columnCant});
            this.listConsumos.Depth = 0;
            this.listConsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listConsumos.FullRowSelect = true;
            this.listConsumos.HideSelection = false;
            this.listConsumos.Location = new System.Drawing.Point(394, 396);
            this.listConsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listConsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listConsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listConsumos.Name = "listConsumos";
            this.listConsumos.OwnerDraw = true;
            this.listConsumos.Size = new System.Drawing.Size(452, 214);
            this.listConsumos.TabIndex = 2;
            this.listConsumos.UseCompatibleStateImageBehavior = false;
            this.listConsumos.View = System.Windows.Forms.View.Details;
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 150;
            // 
            // columntp
            // 
            this.columntp.Text = "Tipo Prenda";
            this.columntp.Width = 150;
            // 
            // columnCant
            // 
            this.columnCant.Text = "Cantidad";
            this.columnCant.Width = 150;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(394, 363);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Consumos:";
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
            this.btnCerrar.Location = new System.Drawing.Point(769, 619);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregarIns
            // 
            this.btnAgregarIns.AutoSize = false;
            this.btnAgregarIns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarIns.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarIns.Depth = 0;
            this.btnAgregarIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarIns.HighEmphasis = true;
            this.btnAgregarIns.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregarIns.Location = new System.Drawing.Point(13, 90);
            this.btnAgregarIns.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarIns.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarIns.Name = "btnAgregarIns";
            this.btnAgregarIns.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarIns.Size = new System.Drawing.Size(114, 40);
            this.btnAgregarIns.TabIndex = 7;
            this.btnAgregarIns.Text = "Agregar";
            this.btnAgregarIns.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarIns.UseAccentColor = false;
            this.btnAgregarIns.UseVisualStyleBackColor = false;
            this.btnAgregarIns.Click += new System.EventHandler(this.btnAgregarIns_Click);
            // 
            // btnEditarIns
            // 
            this.btnEditarIns.AutoSize = false;
            this.btnEditarIns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarIns.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarIns.Depth = 0;
            this.btnEditarIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarIns.HighEmphasis = true;
            this.btnEditarIns.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarIns.Location = new System.Drawing.Point(142, 90);
            this.btnEditarIns.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarIns.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarIns.Name = "btnEditarIns";
            this.btnEditarIns.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarIns.Size = new System.Drawing.Size(114, 40);
            this.btnEditarIns.TabIndex = 8;
            this.btnEditarIns.Text = "Editar";
            this.btnEditarIns.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarIns.UseAccentColor = false;
            this.btnEditarIns.UseVisualStyleBackColor = false;
            this.btnEditarIns.Click += new System.EventHandler(this.btnEditarIns_Click);
            // 
            // btnEliminarIns
            // 
            this.btnEliminarIns.AutoSize = false;
            this.btnEliminarIns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarIns.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarIns.Depth = 0;
            this.btnEliminarIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarIns.HighEmphasis = true;
            this.btnEliminarIns.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarIns.Location = new System.Drawing.Point(270, 90);
            this.btnEliminarIns.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarIns.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarIns.Name = "btnEliminarIns";
            this.btnEliminarIns.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarIns.Size = new System.Drawing.Size(114, 40);
            this.btnEliminarIns.TabIndex = 9;
            this.btnEliminarIns.Text = "Eliminar";
            this.btnEliminarIns.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarIns.UseAccentColor = false;
            this.btnEliminarIns.UseVisualStyleBackColor = false;
            this.btnEliminarIns.Click += new System.EventHandler(this.btnEliminarIns_Click);
            // 
            // txtBuscarInsumos
            // 
            this.txtBuscarInsumos.AnimateReadOnly = false;
            this.txtBuscarInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscarInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarInsumos.Depth = 0;
            this.txtBuscarInsumos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscarInsumos.Hint = "Buscar ....";
            this.txtBuscarInsumos.LeadingIcon = null;
            this.txtBuscarInsumos.Location = new System.Drawing.Point(12, 616);
            this.txtBuscarInsumos.MaxLength = 50;
            this.txtBuscarInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarInsumos.Multiline = false;
            this.txtBuscarInsumos.Name = "txtBuscarInsumos";
            this.txtBuscarInsumos.Size = new System.Drawing.Size(372, 50);
            this.txtBuscarInsumos.TabIndex = 10;
            this.txtBuscarInsumos.Text = "";
            this.txtBuscarInsumos.TrailingIcon = null;
            this.txtBuscarInsumos.TextChanged += new System.EventHandler(this.txtBuscarInsumos_TextChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblCantidadInsumoIngresada);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.lblInsumosUtilizados);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(394, 230);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(448, 119);
            this.materialCard1.TabIndex = 11;
            // 
            // lblCantidadInsumoIngresada
            // 
            this.lblCantidadInsumoIngresada.AutoSize = true;
            this.lblCantidadInsumoIngresada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCantidadInsumoIngresada.Depth = 0;
            this.lblCantidadInsumoIngresada.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCantidadInsumoIngresada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidadInsumoIngresada.Location = new System.Drawing.Point(166, 63);
            this.lblCantidadInsumoIngresada.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadInsumoIngresada.Name = "lblCantidadInsumoIngresada";
            this.lblCantidadInsumoIngresada.Size = new System.Drawing.Size(5, 19);
            this.lblCantidadInsumoIngresada.TabIndex = 4;
            this.lblCantidadInsumoIngresada.Text = "-";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(17, 63);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(143, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Cantidad ingresada:";
            // 
            // lblInsumosUtilizados
            // 
            this.lblInsumosUtilizados.AutoSize = true;
            this.lblInsumosUtilizados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblInsumosUtilizados.Depth = 0;
            this.lblInsumosUtilizados.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInsumosUtilizados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInsumosUtilizados.Location = new System.Drawing.Point(166, 40);
            this.lblInsumosUtilizados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInsumosUtilizados.Name = "lblInsumosUtilizados";
            this.lblInsumosUtilizados.Size = new System.Drawing.Size(5, 19);
            this.lblInsumosUtilizados.TabIndex = 2;
            this.lblInsumosUtilizados.Text = "-";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 40);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(134, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Cantidad utilizada:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Estadisticas:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(394, 201);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(94, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Fecha desde:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(494, 200);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(124, 23);
            this.dtpFechaInicio.TabIndex = 13;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(681, 197);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(124, 23);
            this.dtpFechaHasta.TabIndex = 14;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(624, 202);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Hasta:";
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 674);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtBuscarInsumos);
            this.Controls.Add(this.btnEliminarIns);
            this.Controls.Add(this.btnEditarIns);
            this.Controls.Add(this.btnAgregarIns);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listConsumos);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.listInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Insumos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listInsumos;
        private System.Windows.Forms.ColumnHeader columnIDInsumo;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
        private MaterialSkin.Controls.MaterialListView listConsumos;
        private System.Windows.Forms.ColumnHeader columnServicio;
        private System.Windows.Forms.ColumnHeader columntp;
        private System.Windows.Forms.ColumnHeader columnCant;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialButton btnAgregarIns;
        private MaterialSkin.Controls.MaterialButton btnEditarIns;
        private MaterialSkin.Controls.MaterialButton btnEliminarIns;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarInsumos;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblCantidadInsumoIngresada;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblInsumosUtilizados;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}