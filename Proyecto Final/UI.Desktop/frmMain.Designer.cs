
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
            this.listClientes = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
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
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Controls.Add(this.mnuTabOrdenes);
            this.mnuPrincipal.Controls.Add(this.mnuTabClientes);
            this.mnuPrincipal.Depth = 0;
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnuPrincipal.ImageList = this.imageList1;
            this.mnuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.mnuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mnuPrincipal.Multiline = true;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.SelectedIndex = 0;
            this.mnuPrincipal.Size = new System.Drawing.Size(1355, 721);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Selected += new System.Windows.Forms.TabControlEventHandler(this.mnuPrincipal_Selected);
            // 
            // mnuTabOrdenes
            // 
            this.mnuTabOrdenes.BackColor = System.Drawing.Color.White;
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
            this.mnuTabOrdenes.Name = "mnuTabOrdenes";
            this.mnuTabOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.mnuTabOrdenes.Size = new System.Drawing.Size(1347, 678);
            this.mnuTabOrdenes.TabIndex = 0;
            this.mnuTabOrdenes.Text = "Ordenes";
            // 
            // btnNuevoTipoPrenda
            // 
            this.btnNuevoTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoTipoPrenda.Depth = 0;
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
            this.btnNuevoTipoPrenda.UseVisualStyleBackColor = true;
            this.btnNuevoTipoPrenda.Click += new System.EventHandler(this.btnNuevoTipoPrenda_Click);
            // 
            // btnNuevoServicioTipoPrenda
            // 
            this.btnNuevoServicioTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoServicioTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoServicioTipoPrenda.Depth = 0;
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
            this.btnNuevoServicioTipoPrenda.UseVisualStyleBackColor = true;
            this.btnNuevoServicioTipoPrenda.Click += new System.EventHandler(this.btnNuevoServicioTipoPrenda_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(927, 3);
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
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnEliminarOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarOrden.Depth = 0;
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
            this.btnEliminarOrden.UseVisualStyleBackColor = true;
            this.btnEliminarOrden.Click += new System.EventHandler(this.btnEliminarOrden_Click);
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaOrden.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevaOrden.Depth = 0;
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
            this.btnNuevaOrden.UseVisualStyleBackColor = true;
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
            this.listOrdenes.FullRowSelect = true;
            this.listOrdenes.HideSelection = false;
            this.listOrdenes.Location = new System.Drawing.Point(6, 59);
            this.listOrdenes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.OwnerDraw = true;
            this.listOrdenes.Size = new System.Drawing.Size(1231, 299);
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
            this.btnNuevoEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoEmpleado.Depth = 0;
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
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // mnuTabClientes
            // 
            this.mnuTabClientes.Controls.Add(this.listClientes);
            this.mnuTabClientes.ImageKey = "adduser_añadir_3553.png";
            this.mnuTabClientes.Location = new System.Drawing.Point(4, 39);
            this.mnuTabClientes.Name = "mnuTabClientes";
            this.mnuTabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.mnuTabClientes.Size = new System.Drawing.Size(1331, 678);
            this.mnuTabClientes.TabIndex = 1;
            this.mnuTabClientes.Text = "Clientes";
            this.mnuTabClientes.UseVisualStyleBackColor = true;
            // 
            // listClientes
            // 
            this.listClientes.AutoSizeTable = false;
            this.listClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listClientes.Depth = 0;
            this.listClientes.FullRowSelect = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(3, 3);
            this.listClientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listClientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listClientes.Name = "listClientes";
            this.listClientes.OwnerDraw = true;
            this.listClientes.Size = new System.Drawing.Size(785, 607);
            this.listClientes.TabIndex = 0;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cuit";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellido";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Direccion";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Razon Social";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Telefono";
            this.columnHeader8.Width = 100;
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
            this.ClientSize = new System.Drawing.Size(1361, 788);
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
    }
}

