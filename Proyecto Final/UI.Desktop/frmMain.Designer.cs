
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
            this.mnuTabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mnuPrincipal.SuspendLayout();
            this.mnuTabOrdenes.SuspendLayout();
            this.mnuTabClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.HighEmphasis = true;
            this.btnNuevoCliente.Icon = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(750, 9);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoCliente.Size = new System.Drawing.Size(131, 36);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoCliente.UseAccentColor = false;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Controls.Add(this.mnuTabOrdenes);
            this.mnuPrincipal.Controls.Add(this.mnuTabClientes);
            this.mnuPrincipal.Controls.Add(this.mnuTabPage3);
            this.mnuPrincipal.Depth = 0;
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnuPrincipal.ImageList = this.imageList1;
            this.mnuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.mnuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mnuPrincipal.Multiline = true;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.SelectedIndex = 0;
            this.mnuPrincipal.Size = new System.Drawing.Size(1380, 721);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.SelectedIndexChanged += new System.EventHandler(this.mnuPrincipal_SelectedIndexChanged);
            // 
            // mnuTabOrdenes
            // 
            this.mnuTabOrdenes.BackColor = System.Drawing.Color.White;
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoEmpleado);
            this.mnuTabOrdenes.Controls.Add(this.btnNuevoCliente);
            this.mnuTabOrdenes.ImageKey = "addthelist_añadir_3477.png";
            this.mnuTabOrdenes.Location = new System.Drawing.Point(4, 39);
            this.mnuTabOrdenes.Name = "mnuTabOrdenes";
            this.mnuTabOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.mnuTabOrdenes.Size = new System.Drawing.Size(1372, 678);
            this.mnuTabOrdenes.TabIndex = 0;
            this.mnuTabOrdenes.Text = "Ordenes";
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoEmpleado.Depth = 0;
            this.btnNuevoEmpleado.HighEmphasis = true;
            this.btnNuevoEmpleado.Icon = null;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(750, 57);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(150, 36);
            this.btnNuevoEmpleado.TabIndex = 1;
            this.btnNuevoEmpleado.Text = "Nuevo Empleado";
            this.btnNuevoEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoEmpleado.UseAccentColor = false;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // mnuTabClientes
            // 
            this.mnuTabClientes.Controls.Add(this.txtBuscarCliente);
            this.mnuTabClientes.Controls.Add(this.btnEditarCliente);
            this.mnuTabClientes.Controls.Add(this.btnEliminarCliente);
            this.mnuTabClientes.Controls.Add(this.btnAgregarCliente);
            this.mnuTabClientes.Controls.Add(this.listClientes);
            this.mnuTabClientes.ImageKey = "adduser_añadir_3553.png";
            this.mnuTabClientes.Location = new System.Drawing.Point(4, 39);
            this.mnuTabClientes.Name = "mnuTabClientes";
            this.mnuTabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.mnuTabClientes.Size = new System.Drawing.Size(1372, 678);
            this.mnuTabClientes.TabIndex = 1;
            this.mnuTabClientes.Text = "Clientes";
            this.mnuTabClientes.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.AnimateReadOnly = false;
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarCliente.Hint = "Buscar cliente...";
            this.txtBuscarCliente.LeadingIcon = null;
            this.txtBuscarCliente.Location = new System.Drawing.Point(1020, 53);
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
            this.btnEditarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarCliente.Depth = 0;
            this.btnEditarCliente.HighEmphasis = true;
            this.btnEditarCliente.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarCliente.Location = new System.Drawing.Point(18, 112);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarCliente.Size = new System.Drawing.Size(99, 36);
            this.btnEditarCliente.TabIndex = 3;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarCliente.UseAccentColor = false;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarCliente.Depth = 0;
            this.btnEliminarCliente.HighEmphasis = true;
            this.btnEliminarCliente.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarCliente.Location = new System.Drawing.Point(18, 172);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarCliente.Size = new System.Drawing.Size(116, 36);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarCliente.UseAccentColor = false;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarCliente.Depth = 0;
            this.btnAgregarCliente.HighEmphasis = true;
            this.btnAgregarCliente.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnAgregarCliente.Location = new System.Drawing.Point(18, 53);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarCliente.Size = new System.Drawing.Size(116, 36);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarCliente.UseAccentColor = false;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // listClientes
            // 
            this.listClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listClientes.AutoSizeTable = false;
            this.listClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.listClientes.FullRowSelect = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(225, 53);
            this.listClientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listClientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listClientes.MultiSelect = false;
            this.listClientes.Name = "listClientes";
            this.listClientes.OwnerDraw = true;
            this.listClientes.Size = new System.Drawing.Size(747, 581);
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
            // mnuTabPage3
            // 
            this.mnuTabPage3.Location = new System.Drawing.Point(4, 39);
            this.mnuTabPage3.Name = "mnuTabPage3";
            this.mnuTabPage3.Size = new System.Drawing.Size(1372, 678);
            this.mnuTabPage3.TabIndex = 2;
            this.mnuTabPage3.Text = "tabPage1";
            this.mnuTabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "adduser_añadir_3553.png");
            this.imageList1.Images.SetKeyName(1, "addthelist_añadir_3477.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.mnuPrincipal);
            this.DoubleBuffered = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mnuPrincipal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = " Lavanderia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuTabOrdenes.ResumeLayout(false);
            this.mnuTabOrdenes.PerformLayout();
            this.mnuTabClientes.ResumeLayout(false);
            this.mnuTabClientes.PerformLayout();
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
        private System.Windows.Forms.TabPage mnuTabPage3;
        private MaterialSkin.Controls.MaterialButton btnEditarCliente;
        private MaterialSkin.Controls.MaterialButton btnEliminarCliente;
        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarCliente;
    }
}

