
namespace UI.Desktop
{
    partial class Proveedores
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
            this.listProveedores = new MaterialSkin.Controls.MaterialListView();
            this.columnId = new System.Windows.Forms.ColumnHeader();
            this.columnCuit = new System.Windows.Forms.ColumnHeader();
            this.columnRazonSocial = new System.Windows.Forms.ColumnHeader();
            this.columnTelefono = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.columnDireccion = new System.Windows.Forms.ColumnHeader();
            this.btnEditarProveedor = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarProveedor = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarProveedor = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblCantidadIngresos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.listIngresosInsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnFechaIngreso = new System.Windows.Forms.ColumnHeader();
            this.columnCantidad = new System.Windows.Forms.ColumnHeader();
            this.btnEditarIngreso = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarIngreso = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoIngreso = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProveedores
            // 
            this.listProveedores.AutoSizeTable = false;
            this.listProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnCuit,
            this.columnRazonSocial,
            this.columnTelefono,
            this.columnEmail,
            this.columnDireccion});
            this.listProveedores.Depth = 0;
            this.listProveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listProveedores.FullRowSelect = true;
            this.listProveedores.HideSelection = false;
            this.listProveedores.Location = new System.Drawing.Point(12, 145);
            this.listProveedores.MinimumSize = new System.Drawing.Size(200, 100);
            this.listProveedores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listProveedores.MouseState = MaterialSkin.MouseState.OUT;
            this.listProveedores.MultiSelect = false;
            this.listProveedores.Name = "listProveedores";
            this.listProveedores.OwnerDraw = true;
            this.listProveedores.Size = new System.Drawing.Size(766, 494);
            this.listProveedores.TabIndex = 0;
            this.listProveedores.UseCompatibleStateImageBehavior = false;
            this.listProveedores.View = System.Windows.Forms.View.Details;
            this.listProveedores.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listProveedores_ColumnWidthChanging);
            this.listProveedores.SelectedIndexChanged += new System.EventHandler(this.listProveedores_SelectedIndexChanged);
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 50;
            // 
            // columnCuit
            // 
            this.columnCuit.Text = "Cuit";
            this.columnCuit.Width = 110;
            // 
            // columnRazonSocial
            // 
            this.columnRazonSocial.Text = "Razón Social";
            this.columnRazonSocial.Width = 170;
            // 
            // columnTelefono
            // 
            this.columnTelefono.Text = "Teléfono";
            this.columnTelefono.Width = 120;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 170;
            // 
            // columnDireccion
            // 
            this.columnDireccion.Text = "Dirección";
            this.columnDireccion.Width = 150;
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.AutoSize = false;
            this.btnEditarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarProveedor.Depth = 0;
            this.btnEditarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarProveedor.HighEmphasis = true;
            this.btnEditarProveedor.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarProveedor.Location = new System.Drawing.Point(135, 85);
            this.btnEditarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarProveedor.Size = new System.Drawing.Size(114, 51);
            this.btnEditarProveedor.TabIndex = 9;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarProveedor.UseAccentColor = false;
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.AutoSize = false;
            this.btnEliminarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarProveedor.Depth = 0;
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarProveedor.HighEmphasis = true;
            this.btnEliminarProveedor.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(257, 85);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarProveedor.Size = new System.Drawing.Size(114, 51);
            this.btnEliminarProveedor.TabIndex = 8;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarProveedor.UseAccentColor = false;
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.AutoSize = false;
            this.btnAgregarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarProveedor.Depth = 0;
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarProveedor.HighEmphasis = true;
            this.btnAgregarProveedor.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(13, 85);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarProveedor.Size = new System.Drawing.Size(114, 51);
            this.btnAgregarProveedor.TabIndex = 7;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarProveedor.UseAccentColor = false;
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscar.Hint = "Ingrese Cuit/Razón Social del Proveedor...";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(73, 645);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(705, 50);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.Text = "";
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.btnDetalles.Location = new System.Drawing.Point(784, 145);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(114, 51);
            this.btnDetalles.TabIndex = 11;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblCantidadIngresos);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(784, 200);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(416, 92);
            this.materialCard1.TabIndex = 12;
            // 
            // lblCantidadIngresos
            // 
            this.lblCantidadIngresos.AutoSize = true;
            this.lblCantidadIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCantidadIngresos.Depth = 0;
            this.lblCantidadIngresos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCantidadIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidadIngresos.Location = new System.Drawing.Point(178, 41);
            this.lblCantidadIngresos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadIngresos.Name = "lblCantidadIngresos";
            this.lblCantidadIngresos.Size = new System.Drawing.Size(5, 19);
            this.lblCantidadIngresos.TabIndex = 2;
            this.lblCantidadIngresos.Text = "-";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 42);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(154, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Cantidad de ingresos:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 11);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Estadísticas:";
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
            this.btnCerrar.Location = new System.Drawing.Point(1244, 659);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // listIngresosInsumos
            // 
            this.listIngresosInsumos.AutoSizeTable = false;
            this.listIngresosInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listIngresosInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listIngresosInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnInsumo,
            this.columnFechaIngreso,
            this.columnCantidad});
            this.listIngresosInsumos.Depth = 0;
            this.listIngresosInsumos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listIngresosInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listIngresosInsumos.FullRowSelect = true;
            this.listIngresosInsumos.HideSelection = false;
            this.listIngresosInsumos.Location = new System.Drawing.Point(784, 328);
            this.listIngresosInsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listIngresosInsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listIngresosInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listIngresosInsumos.MultiSelect = false;
            this.listIngresosInsumos.Name = "listIngresosInsumos";
            this.listIngresosInsumos.OwnerDraw = true;
            this.listIngresosInsumos.Size = new System.Drawing.Size(416, 311);
            this.listIngresosInsumos.TabIndex = 14;
            this.listIngresosInsumos.UseCompatibleStateImageBehavior = false;
            this.listIngresosInsumos.View = System.Windows.Forms.View.Details;
            this.listIngresosInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listIngresosInsumos_ColumnWidthChanging);
            // 
            // columnInsumo
            // 
            this.columnInsumo.Text = "Insumo";
            this.columnInsumo.Width = 153;
            // 
            // columnFechaIngreso
            // 
            this.columnFechaIngreso.Text = "Fecha Ingreso";
            this.columnFechaIngreso.Width = 164;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.Width = 99;
            // 
            // btnEditarIngreso
            // 
            this.btnEditarIngreso.AutoSize = false;
            this.btnEditarIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarIngreso.Depth = 0;
            this.btnEditarIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarIngreso.HighEmphasis = true;
            this.btnEditarIngreso.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarIngreso.Location = new System.Drawing.Point(1207, 391);
            this.btnEditarIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarIngreso.Name = "btnEditarIngreso";
            this.btnEditarIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarIngreso.Size = new System.Drawing.Size(114, 51);
            this.btnEditarIngreso.TabIndex = 17;
            this.btnEditarIngreso.Text = "Editar";
            this.btnEditarIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarIngreso.UseAccentColor = false;
            this.btnEditarIngreso.UseVisualStyleBackColor = false;
            this.btnEditarIngreso.Click += new System.EventHandler(this.btnEditarIngreso_Click);
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
            this.btnEliminarIngreso.Location = new System.Drawing.Point(1207, 454);
            this.btnEliminarIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarIngreso.Size = new System.Drawing.Size(114, 51);
            this.btnEliminarIngreso.TabIndex = 16;
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
            this.btnNuevoIngreso.Location = new System.Drawing.Point(1207, 328);
            this.btnNuevoIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoIngreso.Size = new System.Drawing.Size(114, 51);
            this.btnNuevoIngreso.TabIndex = 15;
            this.btnNuevoIngreso.Text = "nuevo ingreso";
            this.btnNuevoIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoIngreso.UseAccentColor = false;
            this.btnNuevoIngreso.UseVisualStyleBackColor = false;
            this.btnNuevoIngreso.Click += new System.EventHandler(this.btnNuevoIngreso_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(784, 306);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Ingreso de insumos";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(13, 661);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Buscar:";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnEditarIngreso);
            this.Controls.Add(this.btnEliminarIngreso);
            this.Controls.Add(this.btnNuevoIngreso);
            this.Controls.Add(this.listIngresosInsumos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.listProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Proveedores";
            this.Sizable = false;
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listProveedores;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnCuit;
        private MaterialSkin.Controls.MaterialButton btnEditarProveedor;
        private MaterialSkin.Controls.MaterialButton btnEliminarProveedor;
        private MaterialSkin.Controls.MaterialButton btnAgregarProveedor;
        private System.Windows.Forms.ColumnHeader columnRazonSocial;
        private System.Windows.Forms.ColumnHeader columnTelefono;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnDireccion;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialListView listIngresosInsumos;
        private MaterialSkin.Controls.MaterialLabel lblCantidadIngresos;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ColumnHeader columnInsumo;
        private System.Windows.Forms.ColumnHeader columnFechaIngreso;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private MaterialSkin.Controls.MaterialButton btnEditarIngreso;
        private MaterialSkin.Controls.MaterialButton btnEliminarIngreso;
        private MaterialSkin.Controls.MaterialButton btnNuevoIngreso;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}